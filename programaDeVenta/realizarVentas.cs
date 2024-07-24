using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programaDeVenta
{
	public partial class realizarVentas : Form
	{
		private List<VentaDetalle> detallesVenta;
		private int selectedRowIndex = -1; // Para almacenar el índice de la fila seleccionada
		private int usuarioID;
		public realizarVentas(int usuarioID)
		{
			InitializeComponent();
			this.usuarioID = usuarioID;
			detallesVenta = new List<VentaDetalle>();
			CargarClientes();
			CargarProductos();
		}

		public class VentaDetalle
		{
			public int ProductoID { get; set; }
			public string NombreProducto { get; set; }
			public int Cantidad { get; set; }
			public decimal PrecioUnitario { get; set; }
			public decimal SubTotal { get; set; }
		}

		private void CargarClientes()
		{
			string connectionString = "Data Source=PREDATOR\\MSSQLSERVER2014;Initial Catalog=programaVenta;Integrated Security=True;";
			string query = "SELECT ClienteID, Nombre FROM Clientes";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);

				cbClientes.DataSource = dataTable;
				cbClientes.DisplayMember = "Nombre";
				cbClientes.ValueMember = "ClienteID";
			}
		}

		private void CargarProductos()
		{
			string connectionString = "Data Source=PREDATOR\\MSSQLSERVER2014;Initial Catalog=programaVenta;Integrated Security=True;";
			string query = "SELECT ProductoID, Nombre, Precio FROM Productos WHERE Estatus = 'Activo'";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);

				cbProductos.DataSource = dataTable;
				cbProductos.DisplayMember = "Nombre";
				cbProductos.ValueMember = "ProductoID";
			}
		}

		private void btnAgregarProducto_Click(object sender, EventArgs e)
		{
			if (cbProductos.SelectedValue != null && int.TryParse(nupCantidad.Text, out int cantidad))
			{
				if (cantidad <= 0)
				{
					MessageBox.Show("Ingrese una cantidad válida .");
					return;
				}

				DataRowView selectedRow = (DataRowView)cbProductos.SelectedItem;
				int productoID = (int)selectedRow["ProductoID"];
				string nombre = (string)selectedRow["Nombre"];
				decimal precioUnitario = (decimal)selectedRow["Precio"];

				// Verificar si el producto ya está en la lista
				if (detallesVenta.Any(d => d.ProductoID == productoID))
				{
					MessageBox.Show("Este producto ya está agregado.");
					return;
				}

				if (VerificarStockDisponible(productoID, cantidad))
				{
					decimal subTotal = precioUnitario * cantidad;

					VentaDetalle detalle = new VentaDetalle
					{
						ProductoID = productoID,
						NombreProducto = nombre,
						Cantidad = cantidad,
						PrecioUnitario = precioUnitario,
						SubTotal = subTotal
					};

					detallesVenta.Add(detalle);
					dgvDetallesVenta.DataSource = null;
					dgvDetallesVenta.DataSource = detallesVenta;
					CalcularTotal();
					// Bloquear el ComboBox de clientes al agregar un producto
					cbClientes.Enabled = false;
				}
				else
				{
					MessageBox.Show("No hay suficiente stock para este producto.");
				}
			}
			else
			{
				MessageBox.Show("Por favor, seleccione un producto y una cantidad válida.");
			}
		}

		private bool VerificarStockDisponible(int productoID, int cantidadRequerida)
		{
			string connectionString = "Data Source=PREDATOR\\MSSQLSERVER2014;Initial Catalog=programaVenta;Integrated Security=True;";
			string query = "SELECT Stock FROM Productos WHERE ProductoID = @ProductoID";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@ProductoID", productoID);

				connection.Open();
				int stockDisponible = (int)command.ExecuteScalar();

				return stockDisponible >= cantidadRequerida;
			}
		}

		private void CalcularTotal()
		{
			decimal total = detallesVenta.Sum(d => d.SubTotal);
			lbTotal.Text = $"{total:C}";
		}
		private void btnRegistrarVenta_Click(object sender, EventArgs e)
		{
			if (cbClientes.SelectedValue != null && detallesVenta.Count > 0)
			{
				int clienteID = (int)cbClientes.SelectedValue;
				DateTime fechaVenta = DateTime.Now;
				decimal total = detallesVenta.Sum(d => d.SubTotal);

				string connectionString = "Data Source=PREDATOR\\MSSQLSERVER2014;Initial Catalog=programaVenta;Integrated Security=True;";
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();
					SqlTransaction transaction = connection.BeginTransaction();

					try
					{
						string queryVenta = "INSERT INTO Ventas (ClienteID, UsuarioID, FechaVenta, Total) OUTPUT INSERTED.VentaID VALUES (@ClienteID, @UsuarioID, @FechaVenta, @Total)";
						int ventaID;
						using (SqlCommand command = new SqlCommand(queryVenta, connection, transaction))
						{
							command.Parameters.AddWithValue("@ClienteID", clienteID);
							command.Parameters.AddWithValue("@UsuarioID", usuarioID);
							command.Parameters.AddWithValue("@FechaVenta", fechaVenta);
							command.Parameters.AddWithValue("@Total", total);

							ventaID = (int)command.ExecuteScalar();
						}

						foreach (var detalle in detallesVenta)
						{
							string queryDetalle = "INSERT INTO DetalleVentas (VentaID, ProductoID, Cantidad, PrecioUnitario, SubTotal) VALUES (@VentaID, @ProductoID, @Cantidad, @PrecioUnitario, @SubTotal)";
							using (SqlCommand command = new SqlCommand(queryDetalle, connection, transaction))
							{
								command.Parameters.AddWithValue("@VentaID", ventaID);
								command.Parameters.AddWithValue("@ProductoID", detalle.ProductoID);
								command.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
								command.Parameters.AddWithValue("@PrecioUnitario", detalle.PrecioUnitario);
								command.Parameters.AddWithValue("@SubTotal", detalle.SubTotal);

								command.ExecuteNonQuery();
							}
						}

						transaction.Commit();
						MessageBox.Show("Venta registrada correctamente.");
						LimpiarCampos();
						// Desbloquear el ComboBox de clientes después de registrar la venta
						cbClientes.Enabled = true;
					}
					catch (Exception ex)
					{
						transaction.Rollback();
						MessageBox.Show("Error al registrar la venta: " + ex.Message);
						// En caso de error, también desbloquear el ComboBox de clientes
						cbClientes.Enabled = true;
					}
				}
			}
			else
			{
				MessageBox.Show("Por favor, seleccione un cliente y agregue productos a la venta.");
			}
		}

		private void LimpiarCampos()
		{
			cbClientes.SelectedIndex = -1;
			cbProductos.SelectedIndex = -1;
			nupCantidad.Value = 0;
			lbTotal.Text = "";
			detallesVenta.Clear();
			dgvDetallesVenta.DataSource = null;
		}

		private void dgvDetallesVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				// Remover el detalle de la lista
				detallesVenta.RemoveAt(e.RowIndex);
				// Actualizar el DataGridView
				dgvDetallesVenta.DataSource = null;
				dgvDetallesVenta.DataSource = detallesVenta;
				// Recalcular el total
				CalcularTotal();
			}
		}

		private void dgvDetallesVenta_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvDetallesVenta.Rows[e.RowIndex];
				cbProductos.SelectedValue = row.Cells["ProductoID"].Value;
				nupCantidad.Value = Convert.ToInt32(row.Cells["Cantidad"].Value);
				selectedRowIndex = e.RowIndex;
			}
		}

		private void btnModificarProducto_Click(object sender, EventArgs e)
		{
			if (selectedRowIndex >= 0 && cbProductos.SelectedValue != null && int.TryParse(nupCantidad.Text, out int cantidad))
			{
				if (cantidad <= 0)
				{
					MessageBox.Show("Ingrese una cantidad válida.");
					return;
				}

				DataRowView selectedRow = (DataRowView)cbProductos.SelectedItem;
				int productoID = (int)selectedRow["ProductoID"];
				string nombre = (string)selectedRow["Nombre"];
				decimal precioUnitario = (decimal)selectedRow["Precio"];

				// Verificar si el nuevo producto ya está en la lista excepto la fila seleccionada
				if (detallesVenta.Any(d => d.ProductoID == productoID && detallesVenta.IndexOf(d) != selectedRowIndex))
				{
					MessageBox.Show("Este producto ya está agregado en otra línea.");
					return;
				}

				if (VerificarStockDisponible(productoID, cantidad))
				{
					decimal subTotal = precioUnitario * cantidad;

					VentaDetalle detalle = new VentaDetalle
					{
						ProductoID = productoID,
						NombreProducto = nombre,
						Cantidad = cantidad,
						PrecioUnitario = precioUnitario,
						SubTotal = subTotal
					};

					detallesVenta[selectedRowIndex] = detalle;
					dgvDetallesVenta.DataSource = null;
					dgvDetallesVenta.DataSource = detallesVenta;
					CalcularTotal();
				}
				else
				{
					MessageBox.Show("No hay suficiente stock para este producto.");
				}
			}
			else
			{
				MessageBox.Show("Primero seleccione el producto de la lista que desea modificar y una cantidad válida.");
			}
		}
	}
}

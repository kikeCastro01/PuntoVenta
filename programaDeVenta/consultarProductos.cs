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
	public partial class consultarProductos : Form
	{
		int productoId; // Variable para almacenar el ID del producto seleccionado
		public consultarProductos()
		{
			InitializeComponent();
			CargarDatos();
		}

		public void CargarDatos()
		{
			string connectionString = "Data Source=PREDATOR\\MSSQLSERVER2014;Initial Catalog=programaVenta;Integrated Security=True;";
			string query = "SELECT * FROM Productos";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);
					dgvProductos.DataSource = dataTable;

					// Cambiar el color de las filas según el estatus
					foreach (DataGridViewRow row in dgvProductos.Rows)
					{
						if (row.Cells["Estatus"].Value != null && row.Cells["Estatus"].Value.ToString() == "Inactivo")
						{
							row.DefaultCellStyle.BackColor = Color.LightGray;
						}
						else
						{
							row.DefaultCellStyle.BackColor = Color.White;
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
		}
		private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvProductos.Rows[e.RowIndex];

				// Validar que las celdas no estén vacías
				if (row.Cells["ProductoID"].Value != DBNull.Value &&
					row.Cells["Nombre"].Value != DBNull.Value &&
					row.Cells["Descripción"].Value != DBNull.Value &&
					row.Cells["Precio"].Value != DBNull.Value &&
					row.Cells["Stock"].Value != DBNull.Value)
				{
					productoId = Convert.ToInt32(row.Cells["ProductoID"].Value); // Almacenar el ID del producto seleccionado
					tbNombre.Text = row.Cells["Nombre"].Value.ToString();
					tbDescripcion.Text = row.Cells["Descripción"].Value.ToString();
					tbPrecio.Text = row.Cells["Precio"].Value.ToString();
					nupStock.Value = Convert.ToInt32(row.Cells["Stock"].Value);
				}
				else
				{
					MessageBox.Show("Fila vacía seleccionada. Por favor, seleccione una fila con datos válidos.");
				}
			}
		}
		private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvProductos.Rows[e.RowIndex];

				// Validar que las celdas no estén vacías
				if (row.Cells["ProductoID"].Value != DBNull.Value)
				{
					int productIdToToggle = Convert.ToInt32(row.Cells["ProductoID"].Value); // Obtener el ID del producto a cambiar estatus

					DialogResult result = MessageBox.Show("¿Está seguro de que desea cambiar el estatus de este producto?", "Confirmar cambio de estatus", MessageBoxButtons.YesNo);
					if (result == DialogResult.Yes)
					{
						CambiarEstatusProducto(productIdToToggle);
					}
				}
				else
				{
					MessageBox.Show("Fila vacía seleccionada. Por favor, seleccione una fila con datos válidos.");
				}
			}
		}

		private void LimpiarCampos()
		{
			tbNombre.Text = "";
			tbDescripcion.Text = "";
			tbPrecio.Text = "";
			nupStock.Value = 0;
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			string nombre = tbNombre.Text;
			string descripcion = tbDescripcion.Text;
			decimal precio = decimal.Parse(tbPrecio.Text);
			int stock = Convert.ToInt32(nupStock.Value);

			if (string.IsNullOrWhiteSpace(tbNombre.Text) ||
				string.IsNullOrWhiteSpace(tbDescripcion.Text) ||
				string.IsNullOrWhiteSpace(tbPrecio.Text) ||
				string.IsNullOrWhiteSpace(nupStock.Text))
			{
				MessageBox.Show("Por favor, llene todos los campos.");
				return;
			}

			string connectionString = "Data Source=PREDATOR\\MSSQLSERVER2014;Initial Catalog=programaVenta;Integrated Security=True;";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "UPDATE Productos SET Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, Stock = @Stock WHERE ProductoID = @Id";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Id", productoId); // Usar el ID del producto almacenado
					command.Parameters.AddWithValue("@Nombre", nombre);
					command.Parameters.AddWithValue("@Descripcion", descripcion);
					command.Parameters.AddWithValue("@Precio", precio);
					command.Parameters.AddWithValue("@Stock", stock);

					connection.Open();
					int result = command.ExecuteNonQuery();

					if (result < 0)
						MessageBox.Show("Error al modificar el producto.");
					else
					{
						MessageBox.Show("Producto modificado correctamente.");
						CargarDatos(); // Recargar datos para reflejar cambios
						LimpiarCampos(); // Limpiar los campos después de modificar
					}
				}
			}
		}

		private void CambiarEstatusProducto(int productId)
		{
			string connectionString = "Data Source=PREDATOR\\MSSQLSERVER2014;Initial Catalog=programaVenta;Integrated Security=True;";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string storedProcedure = "sp_CambiarEstatusProducto";
				using (SqlCommand command = new SqlCommand(storedProcedure, connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@ProductoID", productId);

					connection.Open();
					int result = command.ExecuteNonQuery();

					if (result < 0)
						MessageBox.Show("Error al cambiar el estatus del producto.");
					else
					{
						MessageBox.Show("Estatus del producto cambiado correctamente.");
						CargarDatos(); // Recargar datos para reflejar cambios
						LimpiarCampos(); // Limpiar los campos después de modificar
					}
				}
			}
		}
	}
}

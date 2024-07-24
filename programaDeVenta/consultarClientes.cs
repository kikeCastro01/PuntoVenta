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
	public partial class consultarClientes : Form
	{
		int ClienteId; // Variable para almacenar el ID del producto seleccionado
		public consultarClientes()
		{
			InitializeComponent();
			CargarDatos();
		}

		public void CargarDatos()
		{
			string connectionString = "Data Source=PREDATOR\\MSSQLSERVER2014;Initial Catalog=programaVenta;Integrated Security=True;";
			string query = "SELECT * FROM Clientes";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);
					dgvClientes.DataSource = dataTable;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
		}

		private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

				// Validar que las celdas no estén vacías
				if (row.Cells["ClienteID"].Value != DBNull.Value &&
					row.Cells["Nombre"].Value != DBNull.Value &&
					row.Cells["Dirección"].Value != DBNull.Value &&
					row.Cells["Teléfono"].Value != DBNull.Value)

				{
					ClienteId = Convert.ToInt32(row.Cells["ClienteID"].Value); // Almacenar el ID del producto seleccionado
					tbNombre.Text = row.Cells["Nombre"].Value.ToString();
					tbDireccion.Text = row.Cells["Dirección"].Value.ToString();
					tbTelefono.Text = row.Cells["Teléfono"].Value.ToString();
					tbCorreo.Text = row.Cells["Correo"].Value.ToString();
				}
				else
				{
					MessageBox.Show("Fila vacía seleccionada. Por favor, seleccione una fila con datos válidos.");
				}

			}
		}

		private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

				// Validar que las celdas no estén vacías
				if (row.Cells["ClienteID"].Value != DBNull.Value)
				{
					int productIdToDelete = Convert.ToInt32(row.Cells["ClienteID"].Value); // Obtener el ID del producto a eliminar

					DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo);
					if (result == DialogResult.Yes)
					{
						EliminarProducto(productIdToDelete);
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
			tbDireccion.Text = "";
			tbTelefono.Text = "";
			tbCorreo.Text = "";
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{

			string nombre = tbNombre.Text;
			string Direccion = tbDireccion.Text;
			string Telefono = tbTelefono.Text;
			string Correo = tbCorreo.Text;

			if (string.IsNullOrWhiteSpace(tbNombre.Text) ||
				string.IsNullOrWhiteSpace(tbDireccion.Text) ||
				string.IsNullOrWhiteSpace(tbTelefono.Text) ||
				string.IsNullOrWhiteSpace(tbCorreo.Text))
			{
				MessageBox.Show("Por favor, llene todos los campos.");
				return;
			}
			string connectionString = "Data Source=PREDATOR\\MSSQLSERVER2014;Initial Catalog=programaVenta;Integrated Security=True;";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "UPDATE Clientes SET Nombre = @Nombre, Dirección = @Direccion, Teléfono = @Telefono, Correo = @Correo WHERE ClienteID = @Id";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Id", ClienteId); // Usar el ID del producto almacenado
					command.Parameters.AddWithValue("@Nombre", nombre);
					command.Parameters.AddWithValue("@Direccion", Direccion);
					command.Parameters.AddWithValue("@Telefono", Telefono);
					command.Parameters.AddWithValue("@Correo", Correo);

					connection.Open();
					int result = command.ExecuteNonQuery();

					if (result < 0)
						MessageBox.Show("Error al modificar la información del cliente.");
					else
					{
						MessageBox.Show("Información del cliente modificada correctamente.");
						CargarDatos(); // Recargar datos para reflejar cambios
						LimpiarCampos(); // Limpiar los campos después de modificar
					}
				}
			}
		}

		private void EliminarProducto(int productId)
		{
			string connectionString = "Data Source=PREDATOR\\MSSQLSERVER2014;Initial Catalog=programaVenta;Integrated Security=True;";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "DELETE FROM Clientes WHERE ClienteID = @Id";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Id", productId);

					connection.Open();
					int result = command.ExecuteNonQuery();

					if (result < 0)
						MessageBox.Show("Error al eliminar el cliente.");
					else
					{
						MessageBox.Show("Cliente eliminado correctamente.");
						CargarDatos(); // Recargar datos para reflejar cambios
						LimpiarCampos(); // Limpiar los campos después de modificar
					}
				}
			}
		}
	}
}




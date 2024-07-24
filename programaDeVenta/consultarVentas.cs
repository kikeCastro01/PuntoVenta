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
	public partial class consultarVentas : Form
	{
		public consultarVentas()
		{
			InitializeComponent();
			CargarVentas();
		}

		private void CargarVentas()
		{
			string connectionString = "Data Source=PREDATOR\\MSSQLSERVER2014;Initial Catalog=programaVenta;Integrated Security=True;";
			string query = @"SELECT v.VentaID, v.ClienteID, c.Nombre AS NombreCliente, v.FechaVenta, v.Total
                             FROM Ventas v
                             INNER JOIN Clientes c ON v.ClienteID = c.ClienteID";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);

				dgvVentas.DataSource = dataTable;
			}
		}

		private void CargarDetalleVenta(int ventaID)
		{
			string connectionString = "Data Source=PREDATOR\\MSSQLSERVER2014;Initial Catalog=programaVenta;Integrated Security=True;";
			string query = "SELECT d.VentaID, d.ProductoID, p.Nombre, d.Cantidad, d.PrecioUnitario, d.SubTotal FROM DetalleVentas d INNER JOIN Productos p ON d.ProductoID = p.ProductoID WHERE d.VentaID = @VentaID";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
				adapter.SelectCommand.Parameters.AddWithValue("@VentaID", ventaID);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);

				dgvDetalleVentas.DataSource = dataTable;
			}
		}
		private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvVentas.Rows[e.RowIndex];

				// Validar que las celdas no estén vacías
				if (row.Cells["VentaID"].Value != DBNull.Value)
				{
					int ventaID = (int)row.Cells["VentaID"].Value;
					CargarDetalleVenta(ventaID);
				}
				else
				{
					MessageBox.Show("Fila vacía seleccionada. Por favor, seleccione una fila con datos válidos.");
				}
			}
		}
	}
}

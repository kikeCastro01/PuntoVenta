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
	public partial class reporteVentas : Form
	{
		public reporteVentas()
		{
			InitializeComponent();
			CargarDatos();
		}

		private void CargarDatos()
		{
			string connectionString = "Data Source=PREDATOR\\MSSQLSERVER2014;Initial Catalog=programaVenta;Integrated Security=True;";
			string query = "SELECT * FROM reporteVentas";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);
					dgvReporte.DataSource = dataTable;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
		}
	}
}

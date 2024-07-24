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
	public partial class agregarProductos : Form
	{
		public agregarProductos()
		{
			InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			string nombre = tbNombre.Text;
			string descripcion = tbDescripcion.Text;
			decimal precio = decimal.Parse(tbPrecio.Text);
			int stock = Convert.ToInt32(nupStock.Text);


			// Validar que todos los campos estén llenos
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
				string query = "INSERT INTO Productos (Nombre, Descripcion, Precio, Stock) " +
			   "VALUES (@Nombre, @Descripcion, @Precio, @Stock)";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Nombre", nombre);
					command.Parameters.AddWithValue("@Descripcion", descripcion);
					command.Parameters.AddWithValue("@Precio", precio);
					command.Parameters.AddWithValue("@Stock", stock);

					connection.Open();
					int result = command.ExecuteNonQuery();

					// Verificar si la inserción fue exitosa
					if (result < 0)
						MessageBox.Show("Error al agregar el producto.");
					else
						MessageBox.Show("Producto agregado correctamente.");
				}
			}
		}

		private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Permitir solo números, un punto decimal, y la tecla de retroceso
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			// Permitir solo un punto decimal
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}
	}
}

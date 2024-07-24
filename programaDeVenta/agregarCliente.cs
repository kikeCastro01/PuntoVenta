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
	public partial class agregarCliente : Form
	{
		public agregarCliente()
		{
			InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			string nombre = tbNombre.Text;
			string direccion = tbDireccion.Text;
			string telefono = tbTelefono.Text;
			string correo = tbCorreo.Text;


			// Validar que todos los campos estén llenos
			if (string.IsNullOrWhiteSpace(nombre) ||
				string.IsNullOrWhiteSpace(direccion) ||
				string.IsNullOrWhiteSpace(telefono) ||
				string.IsNullOrWhiteSpace(correo))
			{
				MessageBox.Show("Por favor, llene todos los campos.");
				return;
			}

			string connectionString = "Data Source=PREDATOR\\MSSQLSERVER2014;Initial Catalog=programaVenta;Integrated Security=True;";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "INSERT INTO Clientes (Nombre, Dirección, Teléfono, Correo) " +
			   "VALUES (@Nombre, @Dirección, @Teléfono, @Correo)";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Nombre", nombre);
					command.Parameters.AddWithValue("@Dirección", direccion);
					command.Parameters.AddWithValue("@Teléfono", telefono);
					command.Parameters.AddWithValue("@Correo", correo);

					connection.Open();
					int result = command.ExecuteNonQuery();

					// Verificar si la inserción fue exitosa
					if (result < 0)
						MessageBox.Show("Error al agregar el cliente.");
					else
						MessageBox.Show("Cliente agregado correctamente.");
				}
			}
		}

		private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Permitir solo números, un punto decimal, y la tecla de retroceso
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}

		}
	}
}

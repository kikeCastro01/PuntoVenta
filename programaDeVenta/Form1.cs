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
	public partial class Form1 : Form
	{
		public int UsuarioID { get; private set; }

		string connectionString = "Data Source=PREDATOR\\MSSQLSERVER2014;Initial Catalog=programaVenta;Integrated Security=True;";
		public Form1()
		{
			InitializeComponent();
			tbPassword.UseSystemPasswordChar = true;
		}

		private void lbRegistrarUsuario_Click(object sender, EventArgs e)
		{
			registrarUsuario formRegistrarse = new registrarUsuario();
			formRegistrarse.ShowDialog();
		}

		private void checkBoxContraseña_CheckedChanged(object sender, EventArgs e)
		{
			tbPassword.UseSystemPasswordChar = !checkBoxContraseña.Checked;
		}

		private void btnIngresar_Click(object sender, EventArgs e)
		{
			string usuario = tbUsuario.Text;
			string contraseña = tbPassword.Text;

			// Validar que se hayan ingresado usuario y contraseña
			if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
			{
				MessageBox.Show("Por favor ingrese usuario y contraseña.");
				return;
			}

			// Verificar las credenciales en la base de datos
			if (VerificarCredenciales(usuario, contraseña))
			{
				// Cambiar el estatus del usuario a 'Activo' y actualizar la fecha y hora de acceso
				ActualizarEstatusUsuario(usuario, "Activo", DateTime.Now.Date, DateTime.Now.TimeOfDay);
				LimpiarCampos();
				MessageBox.Show("Inicio de sesión exitoso.");

				// Abrir el formulario principal
				menuNegocio menuForm = new menuNegocio(UsuarioID); // Ajusta el constructor de menuNegocio según sea necesario
				menuForm.FormClosed += (s, args) =>
				{
					ActualizarEstatusUsuario(usuario, "Inactivo", null, null);
					this.Show();
				};
				this.Hide();
				menuForm.Show();
			}
			else
			{
				MessageBox.Show("Usuario o contraseña incorrectos.");
			}
		}

		private bool VerificarCredenciales(string usuario, string contraseña)
		{
			bool credencialesValidas = false;

			// Consulta SQL para verificar las credenciales
			string query = "SELECT Id, Contraseña FROM Usuarios WHERE Usuario = @Usuario";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Usuario", usuario);

					connection.Open();
					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							string contraseñaAlmacenada = reader["Contraseña"].ToString();
							int usuarioId = Convert.ToInt32(reader["Id"]);

							if (BCrypt.Net.BCrypt.Verify(contraseña, contraseñaAlmacenada))
							{
								credencialesValidas = true;
								UsuarioID = usuarioId;
							}
						}
					}
				}
			}

			return credencialesValidas;
		}

		private void ActualizarEstatusUsuario(string usuario, string nuevoEstatus, DateTime? fechaAcceso, TimeSpan? horaAcceso)
		{
			string query;
			if (fechaAcceso.HasValue && horaAcceso.HasValue)
			{
				query = "UPDATE Usuarios SET Estatus = @Estatus, FechaAcceso = @FechaAcceso, HoraAcceso = @HoraAcceso WHERE Usuario = @Usuario";
			}
			else
			{
				query = "UPDATE Usuarios SET Estatus = @Estatus WHERE Usuario = @Usuario";
			}

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Estatus", nuevoEstatus);
					command.Parameters.AddWithValue("@Usuario", usuario);

					if (fechaAcceso.HasValue && horaAcceso.HasValue)
					{
						command.Parameters.AddWithValue("@FechaAcceso", fechaAcceso.Value);
						command.Parameters.AddWithValue("@HoraAcceso", horaAcceso.Value);
					}

					connection.Open();
					command.ExecuteNonQuery();
				}
			}
		}

		private void LimpiarCampos()
		{
			tbUsuario.Text = "";
			tbPassword.Text = "";
		}
	}
}

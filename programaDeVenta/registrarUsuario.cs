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
	public partial class registrarUsuario : Form
	{
		public registrarUsuario()
		{
			InitializeComponent();
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			string usuario = tbUsuario.Text;
			string nombre = tbNombreCompleto.Text;
			string correo = tbCorreo.Text;
			string contraseña = tbPassword.Text;
			DateTime fechaAcceso = DateTime.Now.Date;
			TimeSpan horaAcceso = DateTime.Now.TimeOfDay;

			// Validar que todos los campos estén llenos
			if (string.IsNullOrWhiteSpace(usuario) ||
				string.IsNullOrWhiteSpace(nombre) ||
				string.IsNullOrWhiteSpace(correo) ||
				string.IsNullOrWhiteSpace(contraseña))
			{
				MessageBox.Show("Por favor, llene todos los campos.");
				return;
			}

			// Validar longitud de los campos
			if (usuario.Length > 12)
			{
				MessageBox.Show("El campo 'Usuario' no debe exceder los 12 caracteres.");
				return;
			}
			if (contraseña.Length > 12)
			{
				MessageBox.Show("El campo 'Contraseña' no debe exceder los 12 caracteres.");
				return;
			}
			if (nombre.Length > 50)
			{
				MessageBox.Show("El campo 'Nombre' no debe exceder los 50 caracteres.");
				return;
			}
			if (correo.Length > 50)
			{
				MessageBox.Show("El campo 'Correo' no debe exceder los 50 caracteres.");
				return;
			}

			// Encriptar la contraseña
			string contraseñaEncriptada = BCrypt.Net.BCrypt.HashPassword(contraseña);

			string connectionString = "Data Source=PREDATOR\\MSSQLSERVER2014;Initial Catalog=programaVenta;Integrated Security=True;";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "INSERT INTO Usuarios (Usuario, Contraseña, Nombre, Correo, FechaAcceso, HoraAcceso) " +
			   "VALUES (@Usuario, @Contraseña, @Nombre, @Correo, @FechaAcceso, @HoraAcceso)";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Usuario", usuario);
					command.Parameters.AddWithValue("@Contraseña", contraseñaEncriptada);
					command.Parameters.AddWithValue("@Nombre", nombre);
					command.Parameters.AddWithValue("@Correo", correo);
					command.Parameters.AddWithValue("@FechaAcceso", fechaAcceso);
					command.Parameters.AddWithValue("@HoraAcceso", horaAcceso);

					connection.Open();
					int result = command.ExecuteNonQuery();

					// Verificar si la inserción fue exitosa
					if (result < 0)
						MessageBox.Show("Error al registrar el usuario.");
					else
						MessageBox.Show("El usuario se ha registrado exitosamente.");
				}
			}
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

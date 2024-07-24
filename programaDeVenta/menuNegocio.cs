using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programaDeVenta
{
	public partial class menuNegocio : Form
	{
		private int usuarioID;
		public menuNegocio(int usuarioID)
		{
			InitializeComponent();
			this.usuarioID = usuarioID;
			MostrarFormEnPanel(new agregarProductos());
		}

		private void btnAgregarProductos_Click(object sender, EventArgs e)
		{
			MostrarFormEnPanel(new agregarProductos());
		}

		private void btnConsultarProductos_Click(object sender, EventArgs e)
		{
			MostrarFormEnPanel(new consultarProductos());
		}

		private void btnAgregarClientes_Click(object sender, EventArgs e)
		{
			MostrarFormEnPanel(new agregarCliente());
		}

		private void btnConsultarClientes_Click(object sender, EventArgs e)
		{
			MostrarFormEnPanel(new consultarClientes());
		}

		private void btnRealizarVentas_Click(object sender, EventArgs e)
		{
			MostrarFormEnPanel(new realizarVentas(usuarioID));
		}

		private void btnConsultarVentas_Click(object sender, EventArgs e)
		{
			MostrarFormEnPanel(new consultarVentas());
		}

		private void btnReporte_Click(object sender, EventArgs e)
		{
			MostrarFormEnPanel(new reporteVentas());
		}

		private void MostrarFormEnPanel(Form form)
		{
			// Limpiar el panel
			panelInicio.Controls.Clear();

			// Configurar el formulario secundario para que no sea de nivel superior
			form.TopLevel = false;

			// Quitar los bordes del formulario secundario
			form.FormBorderStyle = FormBorderStyle.None;

			// Hacer que el formulario secundario llene el panel
			form.Dock = DockStyle.Fill;

			// Agregar el formulario secundario al panel
			panelInicio.Controls.Add(form);

			// Mostrar el formulario secundario
			form.Show();
		}

		private void btnCerrarSesion_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

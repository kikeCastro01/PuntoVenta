namespace programaDeVenta
{
	partial class consultarClientes
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnModificar = new System.Windows.Forms.Button();
			this.dgvClientes = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.tbDireccion = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tbCorreo = new System.Windows.Forms.TextBox();
			this.tbNombre = new System.Windows.Forms.TextBox();
			this.tbTelefono = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// btnModificar
			// 
			this.btnModificar.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnModificar.Location = new System.Drawing.Point(330, 496);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(85, 41);
			this.btnModificar.TabIndex = 62;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// dgvClientes
			// 
			this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
			this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClientes.Location = new System.Drawing.Point(12, 79);
			this.dgvClientes.Name = "dgvClientes";
			this.dgvClientes.Size = new System.Drawing.Size(753, 229);
			this.dgvClientes.TabIndex = 61;
			this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
			this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Gill Sans MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(182, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(425, 67);
			this.label6.TabIndex = 52;
			this.label6.Text = "Consultar Cliente";
			// 
			// tbDireccion
			// 
			this.tbDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDireccion.Location = new System.Drawing.Point(294, 371);
			this.tbDireccion.Name = "tbDireccion";
			this.tbDireccion.Size = new System.Drawing.Size(295, 27);
			this.tbDireccion.TabIndex = 67;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(179, 329);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 25);
			this.label7.TabIndex = 66;
			this.label7.Text = "Nombre";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(179, 416);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(97, 25);
			this.label8.TabIndex = 65;
			this.label8.Text = "Telefono";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(179, 373);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(109, 25);
			this.label9.TabIndex = 63;
			this.label9.Text = "Direccion";
			// 
			// tbCorreo
			// 
			this.tbCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCorreo.Location = new System.Drawing.Point(266, 453);
			this.tbCorreo.Name = "tbCorreo";
			this.tbCorreo.Size = new System.Drawing.Size(197, 27);
			this.tbCorreo.TabIndex = 69;
			// 
			// tbNombre
			// 
			this.tbNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNombre.Location = new System.Drawing.Point(280, 327);
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.Size = new System.Drawing.Size(197, 27);
			this.tbNombre.TabIndex = 70;
			// 
			// tbTelefono
			// 
			this.tbTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTelefono.Location = new System.Drawing.Point(282, 416);
			this.tbTelefono.Name = "tbTelefono";
			this.tbTelefono.Size = new System.Drawing.Size(100, 27);
			this.tbTelefono.TabIndex = 68;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(179, 453);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(81, 25);
			this.label10.TabIndex = 64;
			this.label10.Text = "Correo";
			// 
			// consultarClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(777, 558);
			this.Controls.Add(this.tbDireccion);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.tbCorreo);
			this.Controls.Add(this.tbNombre);
			this.Controls.Add(this.tbTelefono);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.dgvClientes);
			this.Controls.Add(this.label6);
			this.Name = "consultarClientes";
			this.Text = "consultarClientes";
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.DataGridView dgvClientes;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbDireccion;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbCorreo;
		private System.Windows.Forms.TextBox tbNombre;
		private System.Windows.Forms.TextBox tbTelefono;
		private System.Windows.Forms.Label label10;
	}
}
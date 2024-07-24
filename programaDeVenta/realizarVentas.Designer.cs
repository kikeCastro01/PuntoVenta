namespace programaDeVenta
{
	partial class realizarVentas
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
			this.label6 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.nupCantidad = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.cbClientes = new System.Windows.Forms.ComboBox();
			this.cbProductos = new System.Windows.Forms.ComboBox();
			this.dgvDetallesVenta = new System.Windows.Forms.DataGridView();
			this.btnAgregarProducto = new System.Windows.Forms.Button();
			this.lbTotal = new System.Windows.Forms.Label();
			this.btnRegistrarVenta = new System.Windows.Forms.Button();
			this.btnModificarProducto = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetallesVenta)).BeginInit();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Gill Sans MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(199, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(376, 67);
			this.label6.TabIndex = 53;
			this.label6.Text = "Realizar Ventas";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(561, 105);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(137, 32);
			this.label10.TabIndex = 55;
			this.label10.Text = "Cantidad";
			// 
			// nupCantidad
			// 
			this.nupCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nupCantidad.Location = new System.Drawing.Point(704, 108);
			this.nupCantidad.Name = "nupCantidad";
			this.nupCantidad.Size = new System.Drawing.Size(64, 29);
			this.nupCantidad.TabIndex = 59;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(271, 105);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(131, 32);
			this.label8.TabIndex = 56;
			this.label8.Text = "Producto";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(3, 103);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(105, 32);
			this.label9.TabIndex = 54;
			this.label9.Text = "Cliente";
			// 
			// cbClientes
			// 
			this.cbClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbClientes.FormattingEnabled = true;
			this.cbClientes.Location = new System.Drawing.Point(114, 105);
			this.cbClientes.Name = "cbClientes";
			this.cbClientes.Size = new System.Drawing.Size(151, 29);
			this.cbClientes.TabIndex = 60;
			// 
			// cbProductos
			// 
			this.cbProductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbProductos.FormattingEnabled = true;
			this.cbProductos.Location = new System.Drawing.Point(408, 106);
			this.cbProductos.Name = "cbProductos";
			this.cbProductos.Size = new System.Drawing.Size(147, 29);
			this.cbProductos.TabIndex = 60;
			// 
			// dgvDetallesVenta
			// 
			this.dgvDetallesVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDetallesVenta.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
			this.dgvDetallesVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetallesVenta.Location = new System.Drawing.Point(15, 201);
			this.dgvDetallesVenta.Name = "dgvDetallesVenta";
			this.dgvDetallesVenta.Size = new System.Drawing.Size(753, 229);
			this.dgvDetallesVenta.TabIndex = 62;
			this.dgvDetallesVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetallesVenta_CellClick);
			this.dgvDetallesVenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetallesVenta_CellDoubleClick);
			// 
			// btnAgregarProducto
			// 
			this.btnAgregarProducto.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarProducto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnAgregarProducto.Location = new System.Drawing.Point(12, 154);
			this.btnAgregarProducto.Name = "btnAgregarProducto";
			this.btnAgregarProducto.Size = new System.Drawing.Size(142, 41);
			this.btnAgregarProducto.TabIndex = 63;
			this.btnAgregarProducto.Text = "Agregar Producto";
			this.btnAgregarProducto.UseVisualStyleBackColor = true;
			this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
			// 
			// lbTotal
			// 
			this.lbTotal.AutoSize = true;
			this.lbTotal.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotal.Location = new System.Drawing.Point(399, 445);
			this.lbTotal.Name = "lbTotal";
			this.lbTotal.Size = new System.Drawing.Size(0, 32);
			this.lbTotal.TabIndex = 55;
			// 
			// btnRegistrarVenta
			// 
			this.btnRegistrarVenta.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrarVenta.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnRegistrarVenta.Location = new System.Drawing.Point(325, 505);
			this.btnRegistrarVenta.Name = "btnRegistrarVenta";
			this.btnRegistrarVenta.Size = new System.Drawing.Size(142, 41);
			this.btnRegistrarVenta.TabIndex = 63;
			this.btnRegistrarVenta.Text = "Registrar Venta";
			this.btnRegistrarVenta.UseVisualStyleBackColor = true;
			this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
			// 
			// btnModificarProducto
			// 
			this.btnModificarProducto.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificarProducto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnModificarProducto.Location = new System.Drawing.Point(160, 154);
			this.btnModificarProducto.Name = "btnModificarProducto";
			this.btnModificarProducto.Size = new System.Drawing.Size(145, 41);
			this.btnModificarProducto.TabIndex = 63;
			this.btnModificarProducto.Text = "Modificar Producto";
			this.btnModificarProducto.UseVisualStyleBackColor = true;
			this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(319, 445);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 32);
			this.label1.TabIndex = 55;
			this.label1.Text = "Total:";
			// 
			// realizarVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(777, 558);
			this.Controls.Add(this.btnRegistrarVenta);
			this.Controls.Add(this.btnModificarProducto);
			this.Controls.Add(this.btnAgregarProducto);
			this.Controls.Add(this.dgvDetallesVenta);
			this.Controls.Add(this.cbProductos);
			this.Controls.Add(this.cbClientes);
			this.Controls.Add(this.nupCantidad);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbTotal);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label6);
			this.Name = "realizarVentas";
			this.Text = "realizarVentas";
			((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetallesVenta)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown nupCantidad;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cbClientes;
		private System.Windows.Forms.ComboBox cbProductos;
		private System.Windows.Forms.DataGridView dgvDetallesVenta;
		private System.Windows.Forms.Button btnAgregarProducto;
		private System.Windows.Forms.Label lbTotal;
		private System.Windows.Forms.Button btnRegistrarVenta;
		private System.Windows.Forms.Button btnModificarProducto;
		private System.Windows.Forms.Label label1;
	}
}
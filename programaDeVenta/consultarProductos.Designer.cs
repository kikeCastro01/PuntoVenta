namespace programaDeVenta
{
	partial class consultarProductos
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
			this.nupStock = new System.Windows.Forms.NumericUpDown();
			this.tbDescripcion = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tbNombre = new System.Windows.Forms.TextBox();
			this.tbPrecio = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.btnModificar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nupStock)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// nupStock
			// 
			this.nupStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nupStock.Location = new System.Drawing.Point(255, 479);
			this.nupStock.Name = "nupStock";
			this.nupStock.Size = new System.Drawing.Size(64, 26);
			this.nupStock.TabIndex = 49;
			// 
			// tbDescripcion
			// 
			this.tbDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDescripcion.Location = new System.Drawing.Point(312, 394);
			this.tbDescripcion.Multiline = true;
			this.tbDescripcion.Name = "tbDescripcion";
			this.tbDescripcion.Size = new System.Drawing.Size(295, 37);
			this.tbDescripcion.TabIndex = 46;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(174, 351);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 25);
			this.label7.TabIndex = 45;
			this.label7.Text = "Nombre";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(174, 438);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(75, 25);
			this.label8.TabIndex = 44;
			this.label8.Text = "Precio";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(174, 394);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(132, 25);
			this.label9.TabIndex = 42;
			this.label9.Text = "Descripcion";
			// 
			// tbNombre
			// 
			this.tbNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNombre.Location = new System.Drawing.Point(275, 351);
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.Size = new System.Drawing.Size(100, 27);
			this.tbNombre.TabIndex = 48;
			// 
			// tbPrecio
			// 
			this.tbPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPrecio.Location = new System.Drawing.Point(255, 438);
			this.tbPrecio.Name = "tbPrecio";
			this.tbPrecio.Size = new System.Drawing.Size(100, 27);
			this.tbPrecio.TabIndex = 47;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(174, 477);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 25);
			this.label10.TabIndex = 43;
			this.label10.Text = "Stock";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Gill Sans MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(157, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(493, 67);
			this.label6.TabIndex = 41;
			this.label6.Text = "Consultar Productos";
			// 
			// dgvProductos
			// 
			this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductos.Location = new System.Drawing.Point(12, 82);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.Size = new System.Drawing.Size(753, 250);
			this.dgvProductos.TabIndex = 50;
			this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
			this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
			// 
			// btnModificar
			// 
			this.btnModificar.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnModificar.Location = new System.Drawing.Point(333, 519);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(85, 36);
			this.btnModificar.TabIndex = 51;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// consultarProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(777, 558);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.dgvProductos);
			this.Controls.Add(this.nupStock);
			this.Controls.Add(this.tbDescripcion);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.tbNombre);
			this.Controls.Add(this.tbPrecio);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label6);
			this.Name = "consultarProductos";
			this.Text = "consultarProductos";
			((System.ComponentModel.ISupportInitialize)(this.nupStock)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nupStock;
		private System.Windows.Forms.TextBox tbDescripcion;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbNombre;
		private System.Windows.Forms.TextBox tbPrecio;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dgvProductos;
		private System.Windows.Forms.Button btnModificar;
	}
}
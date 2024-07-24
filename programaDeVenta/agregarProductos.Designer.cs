namespace programaDeVenta
{
	partial class agregarProductos
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
			this.btnAgregar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nupStock)).BeginInit();
			this.SuspendLayout();
			// 
			// nupStock
			// 
			this.nupStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nupStock.Location = new System.Drawing.Point(241, 342);
			this.nupStock.Name = "nupStock";
			this.nupStock.Size = new System.Drawing.Size(64, 29);
			this.nupStock.TabIndex = 40;
			// 
			// tbDescripcion
			// 
			this.tbDescripcion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDescripcion.Location = new System.Drawing.Point(323, 228);
			this.tbDescripcion.Name = "tbDescripcion";
			this.tbDescripcion.Size = new System.Drawing.Size(411, 31);
			this.tbDescripcion.TabIndex = 37;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(149, 171);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(120, 32);
			this.label7.TabIndex = 36;
			this.label7.Text = "Nombre";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(149, 282);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(95, 32);
			this.label8.TabIndex = 35;
			this.label8.Text = "Precio";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(149, 228);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(168, 32);
			this.label9.TabIndex = 33;
			this.label9.Text = "Descripcion";
			// 
			// tbNombre
			// 
			this.tbNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNombre.Location = new System.Drawing.Point(275, 171);
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.Size = new System.Drawing.Size(227, 31);
			this.tbNombre.TabIndex = 39;
			// 
			// tbPrecio
			// 
			this.tbPrecio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPrecio.Location = new System.Drawing.Point(250, 292);
			this.tbPrecio.Name = "tbPrecio";
			this.tbPrecio.Size = new System.Drawing.Size(129, 31);
			this.tbPrecio.TabIndex = 38;
			this.tbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecio_KeyPress);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(149, 339);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(86, 32);
			this.label10.TabIndex = 34;
			this.label10.Text = "Stock";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Gill Sans MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(172, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(456, 67);
			this.label6.TabIndex = 32;
			this.label6.Text = "Agregar Productos";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnAgregar.Location = new System.Drawing.Point(358, 406);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(88, 42);
			this.btnAgregar.TabIndex = 41;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// agregarProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(777, 558);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.nupStock);
			this.Controls.Add(this.tbDescripcion);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.tbNombre);
			this.Controls.Add(this.tbPrecio);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label6);
			this.Name = "agregarProductos";
			this.Text = "agregarProductos";
			((System.ComponentModel.ISupportInitialize)(this.nupStock)).EndInit();
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
		private System.Windows.Forms.Button btnAgregar;
	}
}
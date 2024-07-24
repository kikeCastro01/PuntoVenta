namespace programaDeVenta
{
	partial class consultarVentas
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
			this.dgvVentas = new System.Windows.Forms.DataGridView();
			this.dgvDetalleVentas = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Gill Sans MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(178, -2);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(416, 67);
			this.label6.TabIndex = 53;
			this.label6.Text = "Consultar Ventas";
			// 
			// dgvVentas
			// 
			this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvVentas.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
			this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVentas.Location = new System.Drawing.Point(15, 19);
			this.dgvVentas.Name = "dgvVentas";
			this.dgvVentas.Size = new System.Drawing.Size(440, 178);
			this.dgvVentas.TabIndex = 63;
			this.dgvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellClick);
			// 
			// dgvDetalleVentas
			// 
			this.dgvDetalleVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDetalleVentas.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
			this.dgvDetalleVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetalleVentas.Location = new System.Drawing.Point(16, 19);
			this.dgvDetalleVentas.Name = "dgvDetalleVentas";
			this.dgvDetalleVentas.Size = new System.Drawing.Size(719, 245);
			this.dgvDetalleVentas.TabIndex = 64;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvVentas);
			this.groupBox1.Location = new System.Drawing.Point(158, 68);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(470, 208);
			this.groupBox1.TabIndex = 65;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ventas";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvDetalleVentas);
			this.groupBox2.Location = new System.Drawing.Point(12, 282);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(753, 274);
			this.groupBox2.TabIndex = 66;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Detalle de Venta";
			// 
			// consultarVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(777, 558);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label6);
			this.Name = "consultarVentas";
			this.Text = "consultarVentas";
			((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dgvVentas;
		private System.Windows.Forms.DataGridView dgvDetalleVentas;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}
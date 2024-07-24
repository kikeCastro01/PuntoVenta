namespace programaDeVenta
{
	partial class reporteVentas
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
			this.dgvReporte = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Gill Sans MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(174, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(444, 67);
			this.label6.TabIndex = 43;
			this.label6.Text = "Reporte de Ventas";
			// 
			// dgvReporte
			// 
			this.dgvReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvReporte.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
			this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvReporte.Location = new System.Drawing.Point(12, 120);
			this.dgvReporte.Name = "dgvReporte";
			this.dgvReporte.Size = new System.Drawing.Size(753, 229);
			this.dgvReporte.TabIndex = 65;
			// 
			// reporteVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(777, 558);
			this.Controls.Add(this.dgvReporte);
			this.Controls.Add(this.label6);
			this.Name = "reporteVentas";
			this.Text = "reporteVentas";
			((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dgvReporte;
	}
}
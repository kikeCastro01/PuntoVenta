namespace programaDeVenta
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbUsuario = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.checkBoxContraseña = new System.Windows.Forms.CheckBox();
			this.lbRegistrarUsuario = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(63, 315);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Usuario";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(68, 11);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(261, 261);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(63, 355);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Contraseña";
			// 
			// tbUsuario
			// 
			this.tbUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbUsuario.Location = new System.Drawing.Point(156, 315);
			this.tbUsuario.Name = "tbUsuario";
			this.tbUsuario.Size = new System.Drawing.Size(163, 31);
			this.tbUsuario.TabIndex = 10;
			// 
			// tbPassword
			// 
			this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPassword.Location = new System.Drawing.Point(199, 355);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(142, 31);
			this.tbPassword.TabIndex = 10;
			// 
			// btnIngresar
			// 
			this.btnIngresar.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngresar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnIngresar.Location = new System.Drawing.Point(157, 429);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(92, 36);
			this.btnIngresar.TabIndex = 11;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = true;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// checkBoxContraseña
			// 
			this.checkBoxContraseña.AutoSize = true;
			this.checkBoxContraseña.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxContraseña.Location = new System.Drawing.Point(68, 391);
			this.checkBoxContraseña.Margin = new System.Windows.Forms.Padding(2);
			this.checkBoxContraseña.Name = "checkBoxContraseña";
			this.checkBoxContraseña.Size = new System.Drawing.Size(148, 23);
			this.checkBoxContraseña.TabIndex = 12;
			this.checkBoxContraseña.Text = "Mostrar contraseña";
			this.checkBoxContraseña.UseVisualStyleBackColor = true;
			this.checkBoxContraseña.CheckedChanged += new System.EventHandler(this.checkBoxContraseña_CheckedChanged);
			// 
			// lbRegistrarUsuario
			// 
			this.lbRegistrarUsuario.AutoSize = true;
			this.lbRegistrarUsuario.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbRegistrarUsuario.ForeColor = System.Drawing.Color.SlateBlue;
			this.lbRegistrarUsuario.Location = new System.Drawing.Point(153, 479);
			this.lbRegistrarUsuario.Name = "lbRegistrarUsuario";
			this.lbRegistrarUsuario.Size = new System.Drawing.Size(111, 21);
			this.lbRegistrarUsuario.TabIndex = 13;
			this.lbRegistrarUsuario.Text = "Registrarse";
			this.lbRegistrarUsuario.Click += new System.EventHandler(this.lbRegistrarUsuario_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(398, 535);
			this.Controls.Add(this.lbRegistrarUsuario);
			this.Controls.Add(this.checkBoxContraseña);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbUsuario);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbUsuario;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.CheckBox checkBoxContraseña;
		private System.Windows.Forms.Label lbRegistrarUsuario;
	}
}


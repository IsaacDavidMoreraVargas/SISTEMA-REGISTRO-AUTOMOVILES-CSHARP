/*
 * Created by SharpDevelop.
 * User: Alcatraz
 * Date: 27/7/2018
 * Time: 07:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Final
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonACarro;
		private System.Windows.Forms.Button buttonAMoto;
		private System.Windows.Forms.Button buttonMostrarListas;
		private System.Windows.Forms.Button buttonSalir;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonACarro = new System.Windows.Forms.Button();
			this.buttonAMoto = new System.Windows.Forms.Button();
			this.buttonMostrarListas = new System.Windows.Forms.Button();
			this.buttonSalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonACarro
			// 
			this.buttonACarro.Location = new System.Drawing.Point(12, 44);
			this.buttonACarro.Name = "buttonACarro";
			this.buttonACarro.Size = new System.Drawing.Size(149, 46);
			this.buttonACarro.TabIndex = 2;
			this.buttonACarro.Text = "Añadir Carro";
			this.buttonACarro.UseVisualStyleBackColor = true;
			this.buttonACarro.Click += new System.EventHandler(this.ButtonACarroClick);
			// 
			// buttonAMoto
			// 
			this.buttonAMoto.Location = new System.Drawing.Point(195, 44);
			this.buttonAMoto.Name = "buttonAMoto";
			this.buttonAMoto.Size = new System.Drawing.Size(149, 46);
			this.buttonAMoto.TabIndex = 3;
			this.buttonAMoto.Text = "Añadir Moto";
			this.buttonAMoto.UseVisualStyleBackColor = true;
			this.buttonAMoto.Click += new System.EventHandler(this.ButtonAMotoClick);
			// 
			// buttonMostrarListas
			// 
			this.buttonMostrarListas.Location = new System.Drawing.Point(100, 137);
			this.buttonMostrarListas.Name = "buttonMostrarListas";
			this.buttonMostrarListas.Size = new System.Drawing.Size(149, 46);
			this.buttonMostrarListas.TabIndex = 5;
			this.buttonMostrarListas.Text = "Mostrar Listas";
			this.buttonMostrarListas.UseVisualStyleBackColor = true;
			this.buttonMostrarListas.Click += new System.EventHandler(this.ButtonMostrarListasClick);
			// 
			// buttonSalir
			// 
			this.buttonSalir.Location = new System.Drawing.Point(100, 210);
			this.buttonSalir.Name = "buttonSalir";
			this.buttonSalir.Size = new System.Drawing.Size(149, 46);
			this.buttonSalir.TabIndex = 6;
			this.buttonSalir.Text = "Salir";
			this.buttonSalir.UseVisualStyleBackColor = true;
			this.buttonSalir.Click += new System.EventHandler(this.ButtonSalirClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 282);
			this.Controls.Add(this.buttonSalir);
			this.Controls.Add(this.buttonMostrarListas);
			this.Controls.Add(this.buttonAMoto);
			this.Controls.Add(this.buttonACarro);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Final";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
	}
}

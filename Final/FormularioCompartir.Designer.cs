/*
 * Created by SharpDevelop.
 * User: Alcatraz
 * Date: 27/7/2018
 * Time: 07:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Final
{
	partial class FormularioCompartir
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.Button Regresar;
		public System.Windows.Forms.Label label6;
		public System.Windows.Forms.Label label7;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label label3;
		
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
			this.Regresar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Regresar
			// 
			this.Regresar.Location = new System.Drawing.Point(81, 503);
			this.Regresar.Name = "Regresar";
			this.Regresar.Size = new System.Drawing.Size(133, 76);
			this.Regresar.TabIndex = 8;
			this.Regresar.Text = "Regresar";
			this.Regresar.UseVisualStyleBackColor = true;
			this.Regresar.Click += new System.EventHandler(this.RegresarClick);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(414, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(116, 23);
			this.label6.TabIndex = 23;
			this.label6.Text = "Nombre Dueño";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(414, 81);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(116, 23);
			this.label7.TabIndex = 25;
			this.label7.Text = "Telefono Dueño";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(124, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 26;
			this.label4.Text = "Marca";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(124, 81);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 23);
			this.label5.TabIndex = 27;
			this.label5.Text = "Color";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(124, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 28;
			this.label3.Text = "Placa";
			// 
			// FormularioCompartir
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(703, 604);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Regresar);
			this.Location = new System.Drawing.Point(124, 81);
			this.Name = "FormularioCompartir";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormularioCompartir";
			this.Load += new System.EventHandler(this.FormularioCompartirLoad);
			this.ResumeLayout(false);

		}
	}
}

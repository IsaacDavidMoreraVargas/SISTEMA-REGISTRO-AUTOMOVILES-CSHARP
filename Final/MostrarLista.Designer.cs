/*
 * Created by SharpDevelop.
 * User: Alcatraz
 * Date: 27/7/2018
 * Time: 08:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Final
{
	partial class MostrarLista
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.DataGridView dataGridM;
		public System.Windows.Forms.Button buttonMListaCarro;
		private System.Windows.Forms.Button buttonMListaMoto;
		private System.Windows.Forms.TextBox textBoxPorPlaca;
		private System.Windows.Forms.Button buttonBuscarPlaca;
		private System.Windows.Forms.Button Regresar;
		
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
			this.dataGridM = new System.Windows.Forms.DataGridView();
			this.buttonMListaCarro = new System.Windows.Forms.Button();
			this.buttonMListaMoto = new System.Windows.Forms.Button();
			this.textBoxPorPlaca = new System.Windows.Forms.TextBox();
			this.buttonBuscarPlaca = new System.Windows.Forms.Button();
			this.Regresar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridM)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridM
			// 
			this.dataGridM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridM.Location = new System.Drawing.Point(205, 33);
			this.dataGridM.Name = "dataGridM";
			this.dataGridM.RowTemplate.Height = 24;
			this.dataGridM.ShowCellErrors = false;
			this.dataGridM.Size = new System.Drawing.Size(663, 408);
			this.dataGridM.TabIndex = 8;
			this.dataGridM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridMCellContentClick);
			// 
			// buttonMListaCarro
			// 
			this.buttonMListaCarro.Location = new System.Drawing.Point(27, 33);
			this.buttonMListaCarro.Name = "buttonMListaCarro";
			this.buttonMListaCarro.Size = new System.Drawing.Size(133, 76);
			this.buttonMListaCarro.TabIndex = 9;
			this.buttonMListaCarro.Text = "Mostrar Lista Carros";
			this.buttonMListaCarro.UseVisualStyleBackColor = true;
			this.buttonMListaCarro.Click += new System.EventHandler(this.ButtonMListaCarroClick);
			// 
			// buttonMListaMoto
			// 
			this.buttonMListaMoto.Location = new System.Drawing.Point(27, 115);
			this.buttonMListaMoto.Name = "buttonMListaMoto";
			this.buttonMListaMoto.Size = new System.Drawing.Size(133, 76);
			this.buttonMListaMoto.TabIndex = 10;
			this.buttonMListaMoto.Text = "Mostrar Lista Motos";
			this.buttonMListaMoto.UseVisualStyleBackColor = true;
			this.buttonMListaMoto.Click += new System.EventHandler(this.ButtonMListaMotoClick);
			// 
			// textBoxPorPlaca
			// 
			this.textBoxPorPlaca.Location = new System.Drawing.Point(27, 225);
			this.textBoxPorPlaca.Name = "textBoxPorPlaca";
			this.textBoxPorPlaca.Size = new System.Drawing.Size(133, 22);
			this.textBoxPorPlaca.TabIndex = 11;
			this.textBoxPorPlaca.TextChanged += new System.EventHandler(this.TextBoxPorPlacaTextChanged);
			// 
			// buttonBuscarPlaca
			// 
			this.buttonBuscarPlaca.Location = new System.Drawing.Point(27, 262);
			this.buttonBuscarPlaca.Name = "buttonBuscarPlaca";
			this.buttonBuscarPlaca.Size = new System.Drawing.Size(133, 76);
			this.buttonBuscarPlaca.TabIndex = 12;
			this.buttonBuscarPlaca.Text = "Buscar por Placa";
			this.buttonBuscarPlaca.UseVisualStyleBackColor = true;
			this.buttonBuscarPlaca.Click += new System.EventHandler(this.ButtonBuscarPlacaClick);
			// 
			// Regresar
			// 
			this.Regresar.Location = new System.Drawing.Point(27, 365);
			this.Regresar.Name = "Regresar";
			this.Regresar.Size = new System.Drawing.Size(133, 76);
			this.Regresar.TabIndex = 13;
			this.Regresar.Text = "Regresar";
			this.Regresar.UseVisualStyleBackColor = true;
			this.Regresar.Click += new System.EventHandler(this.RegresarClick);
			// 
			// MostrarLista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(898, 468);
			this.Controls.Add(this.Regresar);
			this.Controls.Add(this.buttonBuscarPlaca);
			this.Controls.Add(this.textBoxPorPlaca);
			this.Controls.Add(this.buttonMListaMoto);
			this.Controls.Add(this.buttonMListaCarro);
			this.Controls.Add(this.dataGridM);
			this.Name = "MostrarLista";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MostrarLista";
			this.Load += new System.EventHandler(this.MostrarListaLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridM)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

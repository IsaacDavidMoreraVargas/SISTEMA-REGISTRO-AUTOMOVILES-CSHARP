/*
 * Created by SharpDevelop.
 * User: Alcatraz
 * Date: 27/7/2018
 * Time: 08:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Final
{
	partial class MenuCarro
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.DataGridView dataGridView1;
		public System.Windows.Forms.TextBox textNombreDue;
		public System.Windows.Forms.TextBox textTelefDue;
		public System.Windows.Forms.TextBox textMarca;
		public System.Windows.Forms.TextBox textColor;
		public System.Windows.Forms.TextBox textPlaca;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox textTipo;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox textCantPasaj;
		public System.Windows.Forms.Button buttonAgregar;
		
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textNombreDue = new System.Windows.Forms.TextBox();
			this.textTelefDue = new System.Windows.Forms.TextBox();
			this.textMarca = new System.Windows.Forms.TextBox();
			this.textColor = new System.Windows.Forms.TextBox();
			this.textPlaca = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textTipo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textCantPasaj = new System.Windows.Forms.TextBox();
			this.buttonAgregar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(276, 135);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(404, 457);
			this.dataGridView1.TabIndex = 29;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// textNombreDue
			// 
			this.textNombreDue.Location = new System.Drawing.Point(391, 47);
			this.textNombreDue.Name = "textNombreDue";
			this.textNombreDue.Size = new System.Drawing.Size(155, 22);
			this.textNombreDue.TabIndex = 30;
			this.textNombreDue.TextChanged += new System.EventHandler(this.TextNombreDueTextChanged);
			// 
			// textTelefDue
			// 
			this.textTelefDue.Location = new System.Drawing.Point(391, 107);
			this.textTelefDue.Name = "textTelefDue";
			this.textTelefDue.Size = new System.Drawing.Size(155, 22);
			this.textTelefDue.TabIndex = 31;
			this.textTelefDue.TextChanged += new System.EventHandler(this.TextTelefDueTextChanged);
			// 
			// textMarca
			// 
			this.textMarca.Location = new System.Drawing.Point(81, 47);
			this.textMarca.Name = "textMarca";
			this.textMarca.Size = new System.Drawing.Size(155, 22);
			this.textMarca.TabIndex = 32;
			this.textMarca.TextChanged += new System.EventHandler(this.TextMarcaTextChanged);
			// 
			// textColor
			// 
			this.textColor.Location = new System.Drawing.Point(81, 107);
			this.textColor.Name = "textColor";
			this.textColor.Size = new System.Drawing.Size(155, 22);
			this.textColor.TabIndex = 33;
			this.textColor.TextChanged += new System.EventHandler(this.TextColorTextChanged);
			// 
			// textPlaca
			// 
			this.textPlaca.Location = new System.Drawing.Point(81, 171);
			this.textPlaca.Name = "textPlaca";
			this.textPlaca.Size = new System.Drawing.Size(155, 22);
			this.textPlaca.TabIndex = 34;
			this.textPlaca.TextChanged += new System.EventHandler(this.TextPlacaTextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(81, 213);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 23);
			this.label1.TabIndex = 35;
			this.label1.Text = "1:Automatico 2:Manual";
			// 
			// textTipo
			// 
			this.textTipo.Location = new System.Drawing.Point(81, 249);
			this.textTipo.Name = "textTipo";
			this.textTipo.Size = new System.Drawing.Size(155, 22);
			this.textTipo.TabIndex = 36;
			this.textTipo.TextChanged += new System.EventHandler(this.TextTipoTextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(92, 296);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 23);
			this.label2.TabIndex = 37;
			this.label2.Text = "Cantidad Pasajeros";
			// 
			// textCantPasaj
			// 
			this.textCantPasaj.Location = new System.Drawing.Point(81, 335);
			this.textCantPasaj.Name = "textCantPasaj";
			this.textCantPasaj.Size = new System.Drawing.Size(155, 22);
			this.textCantPasaj.TabIndex = 38;
			this.textCantPasaj.TextChanged += new System.EventHandler(this.TextCantPasajTextChanged);
			// 
			// buttonAgregar
			// 
			this.buttonAgregar.Location = new System.Drawing.Point(81, 387);
			this.buttonAgregar.Name = "buttonAgregar";
			this.buttonAgregar.Size = new System.Drawing.Size(129, 89);
			this.buttonAgregar.TabIndex = 39;
			this.buttonAgregar.Text = "Agregar Carro";
			this.buttonAgregar.UseVisualStyleBackColor = true;
			this.buttonAgregar.Click += new System.EventHandler(this.ButtonAgregarClick);
			// 
			// MenuCarro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(703, 604);
			this.Controls.Add(this.buttonAgregar);
			this.Controls.Add(this.textCantPasaj);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textTipo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textPlaca);
			this.Controls.Add(this.textColor);
			this.Controls.Add(this.textMarca);
			this.Controls.Add(this.textTelefDue);
			this.Controls.Add(this.textNombreDue);
			this.Controls.Add(this.dataGridView1);
			this.Location = new System.Drawing.Point(81, 387);
			this.Name = "MenuCarro";
			this.Text = "MenuCarro";
			this.Load += new System.EventHandler(this.MenuCarroLoad);
			this.Controls.SetChildIndex(this.Regresar, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.label7, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.dataGridView1, 0);
			this.Controls.SetChildIndex(this.textNombreDue, 0);
			this.Controls.SetChildIndex(this.textTelefDue, 0);
			this.Controls.SetChildIndex(this.textMarca, 0);
			this.Controls.SetChildIndex(this.textColor, 0);
			this.Controls.SetChildIndex(this.textPlaca, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.textTipo, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.textCantPasaj, 0);
			this.Controls.SetChildIndex(this.buttonAgregar, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

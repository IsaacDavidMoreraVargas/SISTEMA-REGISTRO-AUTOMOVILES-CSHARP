
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final
{

	public partial class FormularioCompartir : Form
	{
		public FormularioCompartir()
		{
			InitializeComponent();
		}
        
		public void guardar()
		{
		
		}
		
		void FormularioCompartirLoad(object sender, EventArgs e)
		{
	
		}

		void RegresarClick(object sender, EventArgs e)
		{
	      this.Hide();
		  Form llamadoPrincipal = new MainForm();
		  llamadoPrincipal.Show();
		}
		void ButtonAgregarClick(object sender, EventArgs e)
		{

		}
	}
}

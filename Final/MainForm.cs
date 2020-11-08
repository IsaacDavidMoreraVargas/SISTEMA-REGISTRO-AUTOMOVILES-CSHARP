
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Final
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();

		}
		
		void ButtonACarroClick(object sender, EventArgs e)
		{
	        Form llamado = new MenuCarro();
			llamado.Show();
			this.Hide();  
		}
		void ButtonAMotoClick(object sender, EventArgs e)
		{
			Form llamado = new MenuMoto();
			llamado.Show();
			this.Hide();
		}
		void ButtonMostrarListasClick(object sender, EventArgs e)
		{
	        Form llamado = new MostrarLista();
			llamado.Show();
			this.Hide();
		}
		
		
		void ButtonSalirClick(object sender, EventArgs e)
		{
	        Application.Exit();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
	}
}

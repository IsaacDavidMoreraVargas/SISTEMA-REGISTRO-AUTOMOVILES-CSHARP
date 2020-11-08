using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Final
{

	public partial class MenuMoto : FormularioCompartir
	{

		string telefono,cilindraje;
		string placa,marca,color, nombre;
		bool confirmar =false;
		
		List<Moto> lista = new List<Moto>();
		
		public MenuMoto()
		{

			InitializeComponent();

		}
		void TextMarcaTextChanged(object sender, EventArgs e)
		{
	
		}
		void TextColorTextChanged(object sender, EventArgs e)
		{
	
		}
		void TextPlacaTextChanged(object sender, EventArgs e)
		{
	
		}
		void TextCilindrajeTextChanged(object sender, EventArgs e)
		{
	
		}
		void TextNombreDueTextChanged(object sender, EventArgs e)
		{
	
		}
		void TextTelefDueTextChanged(object sender, EventArgs e)
		{
	
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		void ButtonAgregarClick(object sender, EventArgs e)
		{
			guardarMoto();
		}
		
		public void guardarMoto()
		{
			string path="Datos.txt";
			bool permitirescritura=true;
			placa=textPlaca.Text;
		
	      if(!File.Exists(path))
		    {	

	        }else
	          {
	      	try{
		         using (StreamReader archivo = File.OpenText(path)) 
                    {
             
                      while (!archivo.EndOfStream)
                         {  
              	           string comprobar=archivo.ReadLine();
              	     
              	             if(comprobar==placa)
              	               {
                                  MessageBox.Show("Ya existe la placa: "+comprobar+" ,no se permitira anadir");
                                  permitirescritura=false;
                                  break;
              	               }
                         }
                    }
                  }catch(Exception e)
		   	      {
		   		    MessageBox.Show("Problema leyendo-"+e);
		   	      }		         
	          }
	      
		  if(permitirescritura==true)
		  {
		        int temp;
		   	    placa=textPlaca.Text;
	            marca=textMarca.Text;
	            color=textColor.Text;
	            nombre=textNombreDue.Text;
	            confirmar=true;
			
		   if(string.IsNullOrEmpty(textCilindraje.Text)||string.IsNullOrEmpty(textPlaca.Text)||string.IsNullOrEmpty(textMarca.Text)||string.IsNullOrEmpty(textColor.Text)||string.IsNullOrEmpty(textNombreDue.Text)||string.IsNullOrEmpty(textTelefDue.Text))
			 {
			 	MessageBox.Show("Falta escribir algun dato para guardar");
			 	confirmar=false;
			 }else
			 {
		   	   
		   	try{

	             temp=Convert.ToInt32(textCilindraje.Text);
	             cilindraje=textCilindraje.Text;

		   	   }catch(Exception e)
		   	      {
		   		    MessageBox.Show("No digito un numero para el Cilindraje");
		   	        confirmar=false;
		   	      }
	            
	          try{  
	              telefono=textTelefDue.Text;
	              temp=Convert.ToInt32(telefono);
	             }catch(Exception e)
		   	      {
		   		    MessageBox.Show("Digite un numero de telefono sin espacios o simbolos");
		   	        confirmar=false;
	              }
	            
	            
			 }
                  
			
		  if(confirmar==true)
		    {
		       Moto NuevaMoto = new Moto( placa, nombre, telefono,marca,color,cilindraje);    
		       lista.Add(NuevaMoto);
		       dataGridView1.DataSource=null;
		       dataGridView1.DataSource=lista;
		       
		       List<string> listaString= new List<string>(); 
		       listaString.Add(placa);
		       listaString.Add(nombre);
		       listaString.Add(telefono);
		       listaString.Add(marca);
		       listaString.Add(color);
		       listaString.Add(cilindraje);

		  try{
		       if(!File.Exists(path))
		       {
		         using (StreamWriter escritor = File.CreateText(path)) 
                   {
		         	
		         	escritor.WriteLine("Moto");
		         	
		          	 foreach(string temporal in listaString)
		          	  {
		          	 	escritor.WriteLine(temporal);
		       	      }

		            }
		         
		         MessageBox.Show("Moto añadida exitosamente");
		         
		       }else
		       {
		           using (StreamWriter escritor = File.AppendText(path)) 
                   {
		           	
		           	escritor.WriteLine("Moto");
		           	
		          	 foreach(string temporal in listaString)
		          	  {
		       		    escritor.WriteLine(temporal);
		       	      }
		          	 
		            }
		           
		           MessageBox.Show("Moto añadida exitosamente");
		       }
		       
              }catch(Exception e)
		   	      {
		   		    MessageBox.Show("Problema leyendo-"+e);
		   	      }         
		         	
		   }
		  
		  }//fin if boolean
		  
		}
		
	}
}

using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Final
{

	public partial class MenuCarro : FormularioCompartir
	{
		string cantidad,tipo,telefono;
		string placa,marca,color, nombre;
		bool confirmar =false;		
		List<Carro> lista = new List<Carro>();
		
		public MenuCarro()
		{

			InitializeComponent();

		}
		void MenuCarroLoad(object sender, EventArgs e)
		{
	
		}
		void TextTipoTextChanged(object sender, EventArgs e)
		{
	
		}
		void TextCantPasajTextChanged(object sender, EventArgs e)
		{
	
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
		void ButtonAgregarClick(object sender, EventArgs e)
		{
			guardarCarro();
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
		
		public void guardarCarro()
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
	          }
	      	
	      	}catch(Exception e)
		   	      {
		   		    MessageBox.Show("Problema leyendo-"+e);
		   	      }	
	      
		  if(permitirescritura==true)
		  {
		        int temp;
		        string temptipo="";
		   	    placa=textPlaca.Text;
	            marca=textMarca.Text;
	            color=textColor.Text;
	            nombre=textNombreDue.Text;
	            confirmar=true;
			
		   if(string.IsNullOrEmpty(textTipo.Text)||string.IsNullOrEmpty(textCantPasaj.Text)||string.IsNullOrEmpty(textPlaca.Text)||string.IsNullOrEmpty(textMarca.Text)||string.IsNullOrEmpty(textColor.Text)||string.IsNullOrEmpty(textNombreDue.Text)||string.IsNullOrEmpty(textTelefDue.Text))
			 {
			 	MessageBox.Show("Falta escribir algun dato para guardar");
			 	confirmar=false;
			 }else
			 {
		   	   
		   	try{
	             tipo=textTipo.Text;
	             temp=Convert.ToInt32(tipo);
	             
	               if(temp!=1&&temp!=2)
	                {
	                  MessageBox.Show("Digite 1 o 2 para el tipo de carro");
                      confirmar=false;	
                      
	                } else if(temp==1)
	                      {
	               	          temptipo="Automatico";
	               	          
	                      }else if(temp==2)
	                          {  
	                             temptipo="Manual";
	                             
	                          }

		   	   }catch(Exception e)
		   	      {
		   		    MessageBox.Show("No digito un numero para el tipo de carro");
		   	        confirmar=false;
		   	      }
		   	
		   	 try{
	             cantidad=textCantPasaj.Text;
	             temp=Convert.ToInt32(cantidad);
		   	    }catch(Exception e)
		   	      {
		   		    MessageBox.Show("No digito un numero para la cantidad");
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

		       Carro NuevoCarro = new Carro(placa, nombre, telefono,marca,color,temptipo,cantidad);    
		       lista.Add(NuevoCarro);
		       dataGridView1.DataSource=null;
		       dataGridView1.DataSource=lista;
		       
		       List<string> listaString= new List<string>();
		       listaString.Add(placa);
		       listaString.Add(nombre);
		       listaString.Add(telefono);
		       listaString.Add(marca);
		       listaString.Add(color);
		       listaString.Add(temptipo);
		       listaString.Add(cantidad);

        try{		       
		       if(!File.Exists(path))
		       {
		         using (StreamWriter escritor = File.CreateText(path)) 
                   {
		         	
		         	escritor.WriteLine("Auto");
		         	
		          	 foreach(string temporal in listaString)
		          	  {
		          	 	escritor.WriteLine(temporal);
		       	      }

		            }
		         
		         MessageBox.Show("Auto añadido exitosamente");  
		         
		       }else
		       {
		           using (StreamWriter escritor = File.AppendText(path)) 
                   {
		           	
		           	escritor.WriteLine("Auto");
		           	
		          	 foreach(string temporal in listaString)
		          	  {
		       		    escritor.WriteLine(temporal);
		       	      }
		          	 
		            }
		           
		           MessageBox.Show("Auto añadido exitosamente");  
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

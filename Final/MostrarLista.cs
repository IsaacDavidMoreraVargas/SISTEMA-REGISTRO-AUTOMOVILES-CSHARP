using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;

namespace Final
{

	public partial class MostrarLista : Form
	{
		
		public MostrarLista()
		{

			InitializeComponent();

		}
		void MostrarListaLoad(object sender, EventArgs e)
		{
	
		}
		void DataGridMCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		void ButtonMListaCarroClick(object sender, EventArgs e)
		{
	       BuscarPorCategoria("Auto");
		}
		void ButtonMListaMotoClick(object sender, EventArgs e)
		{
	        BuscarPorCategoria("Moto");
		}
		void TextBoxPorPlacaTextChanged(object sender, EventArgs e)
		{
	        
		}
		void ButtonBuscarPlacaClick(object sender, EventArgs e)
		{
	        string buscar=textBoxPorPlaca.Text;
			BuscarPorPlaca(buscar) ;
		}
		void RegresarClick(object sender, EventArgs e)
		{
		  this.Hide();
		  Form llamadoPrincipal = new MainForm();
		  llamadoPrincipal.Show();
	
		}		
	 
	 public void BuscarPorCategoria(string categoria)
	  {
		string placa;
		string nombre;
	    string telefono;
		string marca;
		string color;
		string tipo;
	    string cantidad;
	    string cilindraje;
	    bool carro=false;
	    bool moto=false;
	    
	    string path="Datos.txt";
  			
	    List<Carro> listaCarro = new List<Carro>();
        List<Moto> listaMoto = new List<Moto>();
        
        if(categoria=="Auto")
        {
        
            carro=true;
            
        }else if(categoria=="Moto")
        {
        
        	moto=true;
        }
		
    try{
        	
        if(carro==true)
        {
           using (StreamReader archivo = File.OpenText(path)) 
            {
             
              while (!archivo.EndOfStream)
                {  
              	  if(archivo.ReadLine()==categoria)
              	  { 	
                    placa=archivo.ReadLine();
		            nombre=archivo.ReadLine();
	                telefono=archivo.ReadLine();
		            marca=archivo.ReadLine();
		            color=archivo.ReadLine();
	                tipo=archivo.ReadLine();
	                cantidad=archivo.ReadLine();
	                Carro NuevoCarro = new Carro(placa, nombre, telefono,marca,color,tipo,cantidad);
	                listaCarro.Add(NuevoCarro);
	                dataGridM.DataSource=null;
		            dataGridM.DataSource=listaCarro; 
              	  }
             }
           }
           
        }else if(moto==true)
        {
           using (StreamReader archivoMoto = File.OpenText(path))
             {
              	 while (!archivoMoto.EndOfStream)
                 { 
              	  if(archivoMoto.ReadLine()==categoria)
              	  {
              	  	placa=archivoMoto.ReadLine();
		            nombre=archivoMoto.ReadLine();
	                telefono=archivoMoto.ReadLine();
		            marca=archivoMoto.ReadLine();
		            color=archivoMoto.ReadLine();
	                cilindraje=archivoMoto.ReadLine();
	                Moto NuevaMoto = new Moto(placa, nombre, telefono,marca,color,cilindraje);
	                listaMoto.Add(NuevaMoto);
	                dataGridM.DataSource=null;
		            dataGridM.DataSource=listaMoto;
              	  }
              	 }
              }
         }
        
         }catch(Exception e)
		   	      {
		   		    MessageBox.Show("Problema leyendo-"+e);
		   	      }     
        
	}
	 
	public void BuscarPorPlaca(string buscar)
	  {
	  	
		string placa;
		string nombre;
	    string telefono;
		string marca;
		string color;
		string tipo;
	    string cantidad;
	    string cilindraje;
	    Boolean encontrado=false;
	    
	    string path="Datos.txt";
		
		List<Carro> listaCarro = new List<Carro>();	
		List<Moto> listaMoto = new List<Moto>();
		
     try{
           using (StreamReader archivo = File.OpenText(path)) 
            {
               archivo.ReadLine();
               
                 while (!archivo.EndOfStream)
                  {
                 	
                 	try{
              	   	  if(buscar==archivo.ReadLine())
              	   	  {
              	   	   placa=buscar;
              	       nombre=archivo.ReadLine();
              	       telefono=archivo.ReadLine();
		               marca=archivo.ReadLine();
		               color=archivo.ReadLine();
		               tipo=archivo.ReadLine();
	                   cantidad=archivo.ReadLine();
	                   Carro NuevoCarro = new Carro(placa, nombre, telefono,marca,color,tipo,cantidad);  
		               listaCarro.Add(NuevoCarro);
		               dataGridM.DataSource=null;
		               dataGridM.DataSource=listaCarro;
		               encontrado=true;
	                   break;
	                   
              	   	  }
                 	}catch(Exception e)
                 	{
                 		Console.WriteLine();
                 	
                    }
              	   	  
                 	try{
              	   	   if(buscar==archivo.ReadLine())
              	   	     {
              	   	  	    placa=buscar;
              	   	   	    nombre=archivo.ReadLine();
              	       	    telefono=archivo.ReadLine();
		               	    marca=archivo.ReadLine();
		               	    color=archivo.ReadLine();
		               	    cilindraje=archivo.ReadLine();
	                  	    Moto NuevaMoto = new Moto(placa, nombre, telefono,marca,color,cilindraje);  
		              	    listaMoto.Add(NuevaMoto);
		              	    dataGridM.DataSource=null;
		              	    dataGridM.DataSource=listaMoto;
		             	    encontrado=true;
	                 	    break;
              	   	  	 }
                 	}catch(Exception e)
                 	{
                 	  Console.WriteLine();
                 	}
    
              	 }
              	   	  
              }
           
          }catch(Exception e)
		   	      {
		   		    MessageBox.Show("Problema leyendo-"+e);
		   	      }  
 
           
           if(encontrado==false)
              	 {
              	    MessageBox.Show("La placa no existe");
              	 }
	  } 
	

	}
}

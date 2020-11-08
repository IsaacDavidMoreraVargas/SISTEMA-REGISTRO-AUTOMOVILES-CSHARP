
using System;

namespace Final
{

	public class Moto
	{
		
		   private string placa;
		   private string nombre;
		   private string telefono;
		   private string marca;
		   private string color;
		   private string cilindraje;
		   
		public Moto(string plac, string nombr, string telefon, string marc, string colo,string cilindraj)
		{	
			placa=plac;
			nombre=nombr;
			telefono=telefon;
			marca= marc;
			color=colo;
			cilindraje=cilindraj;
		}
		
		
				
		public String Placa
		{
		    
			get{return this.placa;}
			set{this.placa=value;}
		}
		
		public String Nombre
		{
			get{return this.nombre;}
			set{ this.nombre=value;}
		
		}
		
		public String Telefono
		{
			
		   get{return this.telefono;}
		   set{ this.telefono=value;}
		
		}
		
		public String Marca
		{
			
		  get{return this.marca;}
		  set{ this.marca=value;}
		
		}
		
		public String Color
		{
		  get{return this.color;}
		  set{ this.color=value;}
		
		}

		
		public String Cilindraje
		{
		  get{return this.cilindraje;}
		  set{ this.cilindraje=value;}
		
		}
		
	
	}
}

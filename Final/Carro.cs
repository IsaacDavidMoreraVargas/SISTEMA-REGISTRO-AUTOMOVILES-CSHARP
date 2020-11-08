using System;

namespace Final
{

	public class Carro 
	{
		private string placa;
		private string nombre;
		private string telefono;
		private string marca;
		private string color;
		private string tipoauto;
		private string CantidadPasajero;
		
		public Carro(string plac, string nombr, string telefon, string marc, string colo,string tipoaut, string CantidadPasajer)
		{	
			placa=plac;
			nombre=nombr;
			telefono=telefon;
			marca= marc;
			color=colo;
			tipoauto=tipoaut;
		    CantidadPasajero=CantidadPasajer;
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
		
		public String Tipo
		{
		  get{return this.tipoauto;}
			set{ this.tipoauto=value;}
		
		}
		
		public String CantidadPasajeros
		{
		  get{return this.CantidadPasajero;}
		  set{ this.CantidadPasajero=value;}
		
		}
		
	}
}

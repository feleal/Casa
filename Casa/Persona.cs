using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa
{
    public   class Persona
    {
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected string Direccion { get; set;}
        protected string Telefono { get; set; } 

        public string nombre
        {
            get => Nombre; set=> Nombre= value;
        }

        public string apellido
        {
            get=> Apellido; set=> Apellido= value;  
        }
        public string direccion
        {
            get => Direccion; set=> Direccion= value;   
        }
        public string telefono
        {
            get => Telefono;set=> Telefono= value;
        }
        // constructor de la clase
        public Persona() 
        {
            pasatiempo();
            SerieTv();
        } 

        // constructor con parametros
        public  Persona(string nombre,string apellido, string direccion, string telefono)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion= direccion;
            this.Telefono = telefono;   
        }

        public  virtual void pasatiempo()
        {
            Console.WriteLine("Mi pasatiempo  como persona  es... Leer !!");
        }

        public virtual void SerieTv()
        {
            Console.WriteLine("Mi serie favorita es:...La casa de Papel !");
        }
        public virtual void ComidaFavorita()
        {
            Console.WriteLine("Mi Comida favorita es:...Empanadas !!!");
        }
        // hay que meterle mas cosas a las funciones algunas que retornene algun valor 
        // o que reciban algunos parametros... queda pendiente.. 
    }
}

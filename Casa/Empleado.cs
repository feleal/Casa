using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa
{
    public class Empleado :Persona
    {
        // los metodos heredados de la clase padre estan en ella
        // estos son los metodos de la clase emplado unicamente
        private string Cargo { get; set; }
        private string JornadaCompleta { get; set; }
        private string Capacitacion { get; set; }   
        private int Edad { get; set; }  
        private string ZonaTrabajo { get; set; }    

        public string cargo
        {
            get=>Cargo; set => Cargo = value;
        }
        public string jornadacompleta
        {
            get=>JornadaCompleta; set => JornadaCompleta = value;
        }
        public string capacitacion
        {
            get => Capacitacion; set => Capacitacion = value;
        }
        public int edad
        {
            get => Edad; set => Edad = value;
        }
        public string zonatrabajo
        {
            get => ZonaTrabajo; set => ZonaTrabajo = value;
        }

        public Empleado()
        {
            pasatiempo();
            SerieTv();
        }
        public Empleado(string cargo, string jornadacompleta,string capacitacion, int edad, string zonatrabajo)
        {
            this.Cargo = cargo;
            this.JornadaCompleta = jornadacompleta; 
            this.Capacitacion= capacitacion;
            this.Edad = edad;
            this.ZonaTrabajo= zonatrabajo;
        }

        public override void pasatiempo()
        {
            Console.WriteLine("Mi pasatiempo como empleado es... ! Jugar Futbol !! ");
        }
        public override void SerieTv()
        {
            Console.WriteLine("Mi serie de tv es:....La histora del Hombre !!");
        }
        public override void ComidaFavorita()
        {
            Console.WriteLine("mi Comida favortia es:---- Milanesas con pure");
        }
    }
}

namespace Casa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine();

            Persona per = new Persona();
            per.nombre = "Juan Manuel";
            per.apellido = "Maldonado";
            per.direccion = "Av Mitre 2510";
            per.telefono = "987544555";

            Console.WriteLine("**** Datos de la Persona ****");

            Console.WriteLine("El Nombre de la persona es  ..."+per.nombre);
            Console.WriteLine("El Apellido de la persona es .."+per.apellido);
            Console.WriteLine("La direccion es ..."+per.direccion);
            Console.WriteLine("El telefono de la persona es.."+per.telefono);
            per.pasatiempo();
            per.SerieTv();
            per.ComidaFavorita();

            Console.WriteLine("");
            Console.WriteLine("###########################################");

            Console.WriteLine("** Datos del Empleado ****");

            Empleado empleado= new Empleado();
            // heredados de la clase padre
            empleado.nombre = "Hernesto ";
            empleado.apellido = "De La Fuente";
            empleado.direccion = "Calle 02";
            empleado.telefono = " 1542666445";

            //propios de la clase empleados
            empleado.cargo = "Supervisor";
            empleado.jornadacompleta = "Si";
            empleado.capacitacion = "Si";
            empleado.edad = 49;
            empleado.zonatrabajo = "San Miguel de Tucuman";

            Console.WriteLine("el nombre del empleado es .." + empleado.nombre);
            Console.WriteLine("el apellido es ..." + empleado.apellido);
            Console.WriteLine("la direccion es " + empleado.direccion);
            Console.WriteLine("el telefono es .."+ empleado.telefono);
            Console.WriteLine("el cargo del empleado es "+empleado.cargo);
            Console.WriteLine("Jornada laboral completa: " + empleado.jornadacompleta);
            Console.WriteLine("Edad del empleado.." + empleado.edad);
            Console.WriteLine("Zona de trabajo.." + empleado.zonatrabajo);
            empleado.pasatiempo();
            empleado.SerieTv();
            empleado.ComidaFavorita();  
            Console.ReadKey();

        }
    }
}
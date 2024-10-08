using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCorrecto
{
    public abstract class EmpleadoBase : IEmpleado
    {
        public abstract double SueldoBase { get; }

        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }

        public string Puesto { get; set; }

        public abstract double CalcularSueldo();

        
        public void MostrarDetalle()
        {
            Console.WriteLine($"El puesto del empleado es: {Puesto}");
        
            Console.WriteLine($"El nombre del empleado es: {Nombre}");

            Console.WriteLine($"El sueldo base del empleado es: {SueldoBase}");
            Console.WriteLine("----------------------------------------------");

        }
    }
}

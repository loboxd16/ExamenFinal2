using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCorrecto
{
    public class Desarollador : EmpleadoBase
    {
        public override double SueldoBase => 3000;

        public override double CalcularSueldo()
        {
            return SueldoBase;
        }
    }
}

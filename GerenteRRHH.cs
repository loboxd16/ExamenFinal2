using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCorrecto
{
    public class GerenteRRHH : EmpleadoBase, ISueldoBonificable, IDescuentoImpuesto
    {
        public override double SueldoBase => 8000;

        public double CalcularBonificacion()
        {
            return SueldoBase+1000;
        }

        

        
        public double DescontarSueldo()
        {
            return SueldoBase * 0.10;
        }
        public override double CalcularSueldo()
        {
            return SueldoBase + CalcularBonificacion() - DescontarSueldo();
        }
    }
}

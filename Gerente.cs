using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCorrecto
{
    public class Gerente : EmpleadoBase, ISueldoBonificable, IDescuentoImpuesto
    {
        //=> Lambda: Funciones pequeñas
        public override double SueldoBase => 8000;

        public double CalcularBonificacion()
        {
            return SueldoBase+1000;
        }



        public double DescontarSueldo()
        {
            
            return SueldoBase*0.20;
        }

        public override double CalcularSueldo()
        {
            return SueldoBase + CalcularBonificacion() - DescontarSueldo();
        }


    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCorrecto
{
    public class ConsultorExterno : EmpleadoBase
    {
        public override double SueldoBase => 5000;

        public override double CalcularSueldo()
        {
            return SueldoBase + 1000;
        }
    }
}

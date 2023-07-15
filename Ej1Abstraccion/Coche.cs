using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1Abstraccion
{
    public class Coche : MedioTransporte
    {
        public override string Arrancar()
        {
            return "Enciendo el motor y salgo ";
        }

        public override string Detener()
        {
            return "Piso el freno ";  
        }
    }
}

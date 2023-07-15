using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1Abstraccion
{
    //Clase
    public abstract class MedioTransporte
    {
        public int AnioFabricacion { get; set; }    //Atributo
        public int Capacidad { get; set; }


        public abstract string Arrancar();   //Metodos 
        public abstract string Detener();

    }
}

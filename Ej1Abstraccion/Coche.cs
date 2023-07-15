using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1Abstraccion
{
    public class Coche : MedioTransporte
    {
        //Constructor por defecto (Todas las clases lo tienen pero no se ven )
        public Coche() 
        {
        }
        //Constructor con un parametro de tipo entero para definir el año de fabricacion 
        public Coche(int anioFabricacion) 
        {
        AnioFabricacion = anioFabricacion;
        }
        //Constructor con dos parametros de tipo entero para definir el año de fabricacion y capacidad
        public Coche(int anioFabricacion,int capacidad) 
        {
            AnioFabricacion = anioFabricacion;
            Capacidad = capacidad;
        }
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

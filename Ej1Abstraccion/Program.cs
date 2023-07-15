namespace Ej1Abstraccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicializamos con el constructor dentro de la clase choche 
            // donde recibe los dos parametros para el año de fabricacion y capacidad 
           Coche  coche = new Coche(1990,5);

            Avion avion = new Avion()
            {
                AnioFabricacion = 2005,
                Capacidad = 200
            };
            Barco barco = new Barco()
            {
                AnioFabricacion = 2000,
            Capacidad = 500
            };
            var arrancarCoche = coche.Arrancar();
            var detenerCoche = coche.Detener();

            var arrancarBarco = barco.Arrancar();
            var detenerBarco = barco.Detener();

            var arrancarAvion = avion.Arrancar();
            var detenerAvion = avion.Detener(); 


            Console.WriteLine($"El coche arranca :{arrancarCoche}");
            Console.WriteLine($"El coche se detiene:{detenerCoche}");

            Console.WriteLine($"El barco arranca:{arrancarBarco}");
            Console.WriteLine($"El barco se detiene:{detenerBarco}");

            Console.WriteLine($"El avion arranca:{arrancarAvion}");
            Console.WriteLine($"El avion se detiene:{detenerAvion}");
        }
    }
}
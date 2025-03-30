
namespace Ejercicio4_Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Automovil a1 = new Automovil("Volkswagen", "Nivus", new DateTime(2024, 12, 30),
                    new Duenio("Roberto", "Giordano", new DateTime(1976, 09, 05)));
                Automovil a2 = new Automovil("Porsche", "911", new DateTime(2015, 08, 30),
                    new Duenio("Leonardo", "Fernandez", new DateTime(1998, 10, 05)));

                Console.WriteLine(a1);
                // Console.WriteLine(a2);
            }
            catch (Exception e)
            {   
                Console.WriteLine(e.Message);
                Console.ReadKey();
                throw;
                
            }
            
        }
    }
}
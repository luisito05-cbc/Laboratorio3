namespace Ejercicio1_Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mesa m1 = new Mesa(60, 50, 2.8, new Material("Maromol", "Nigeria"), 30000);

            Console.WriteLine(m1);
            Console.ReadKey();
            
        }
    }
}

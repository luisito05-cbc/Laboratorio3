namespace Ejercicio1_Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mesa m1 = new Mesa(10.5, 5, 2.2, new Material("Madera", "Brasil"), 15000);

            Console.WriteLine(m1);


            Console.ReadKey();
        }
    }
}

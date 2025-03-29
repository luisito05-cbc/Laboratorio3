namespace Ejercicio2_Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Television television1 = new Television(new Marca("LG", "Corea del Sur"), "QNED 4K", Tamanio.Md, false, "Encendido", 60);
            Television television2 =new Television(new Marca("Sony", "Japon"), "Bravia 8", Tamanio.Xl, true, "Apagado", 100);

            Console.WriteLine(television1);
            Console.WriteLine(television2);
            Console.ReadKey();
        }
    }
}
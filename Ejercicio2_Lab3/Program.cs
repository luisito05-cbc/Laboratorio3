namespace Ejercicio2_Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Television television1 = new Television(new Marca("LG",new PaisOrigen("Corea del Sur","Cor")), "QNED 4K", Tamanio.Md, false, "Encendido", 60);
            Television television2 =new Television(new Marca("Sony",new PaisOrigen("Japon","Jap")), "Bravia 8", Tamanio.Xl, true, "Apagado", 100);

            Console.WriteLine("Ejercicio Television");
            Console.WriteLine(television1);
            Console.WriteLine(television2);
            Console.ReadKey();
        }
    }
}
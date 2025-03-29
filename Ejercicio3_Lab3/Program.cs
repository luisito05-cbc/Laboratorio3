
namespace  Ejercicio3_Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Pelicula pelicula1 = new Pelicula("Hereditary",Genero.Terror,new Director("Ari","Aster",new PaisDirector("Estados Unidos","EE.UU")),new DateTime(2018,08,30),new TimeSpan(2,27,0));
                Pelicula pelicula2 = new Pelicula("Se7en",Genero.Suspenso,new Director("David","Fincher",new PaisDirector("Estados Unidos","EE.UU")),new DateTime(1995,03,22),new TimeSpan(2,27,7));
                Pelicula pelicula3 = new Pelicula("El Pianista",Genero.Drama,new Director("Roman","Polanski",new PaisDirector("Rusia","Rus")),new DateTime(2002,10,24),new TimeSpan(2,30,0));
                Pelicula pelicula4 = new Pelicula("Supercool",Genero.Comedia,new Director("Greg","Mottola",new PaisDirector("Italia","Ita")),new DateTime(2007,02,04),new TimeSpan(1,53,0));
                Pelicula pelicula5 = new Pelicula("El Origen ",Genero.Thriller,new Director("Christopher","Nolan",new PaisDirector("Estados Unidos","EE.UU")),new DateTime(2010,02,04),new TimeSpan(2,28,0));

                // Console.WriteLine($"Baja de catalogo - {pelicula1.FechaBajaCatalogo()}");
                // Console.WriteLine(pelicula1.AptaPublico());

                
                // Console.WriteLine($"Baja de catalogo - {pelicula2.FechaBajaCatalogo()}");
                // Console.WriteLine(pelicula2.AptaPublico());
                //
                // Console.WriteLine($"Baja de catalogo - {pelicula3.FechaBajaCatalogo()}");
                // Console.WriteLine(pelicula3.AptaPublico());
                //
                Console.WriteLine($"Baja de catalogo - {pelicula4.FechaBajaCatalogo()}");
                Console.WriteLine(pelicula4.AptaPublico());
                //
                // Console.WriteLine($"Baja de catalogo - {pelicula5.FechaBajaCatalogo()}");
                // Console.WriteLine(pelicula5.AptaPublico());
                

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                throw;

            }

            Console.ReadKey();

            
        }
    }
}
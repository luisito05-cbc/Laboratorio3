namespace Ejercicio2_Lab3
{
    public class Pais
    {
        public int Id { get; set;}
        public static int UltimoID { get; set; } = 1;
        public string Nombre { get; set; }
        public int  Codigo { get; set; }


        public Pais()
        {
            Id = UltimoID;
            UltimoID++;
        }

        public Pais(string nombre, int codigo)
        {
            Id = UltimoID;
            UltimoID++;
            Nombre = nombre;
            Codigo = codigo;
        }
    }
}

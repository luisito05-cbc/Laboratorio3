namespace Ejercicio2_Lab3
{
    public class PaisOrigen
    {
        public int Id { get; set;}
        public static int UltimoID { get; set; } = 1;
        public string Nombre { get; set; }
        public string  Codigo { get; set; }


        public PaisOrigen()
        {
            Id = UltimoID;
            UltimoID++;
        }

        public PaisOrigen(string nombre, string codigo)
        {
            Id = UltimoID;
            UltimoID++;
            Nombre = nombre;
            Codigo = codigo;
        }
    }
}

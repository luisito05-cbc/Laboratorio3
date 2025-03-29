namespace Ejercicio3_Lab3;

public class PaisDirector
{
    public int Id { get; set; }
    public static int UltimoId { get; set; } = 1;
    public string Nombre { get; set; }
    public string Codigo { get; set; }

    public PaisDirector()
    {
        Id = UltimoId;
        UltimoId++;
    }

    public PaisDirector(string nombre, string codigo)
    {
        Id = UltimoId;
        UltimoId++;
        Nombre = nombre;
        Codigo = codigo;
    }
}
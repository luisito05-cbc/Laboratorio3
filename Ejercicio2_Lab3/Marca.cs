namespace Ejercicio2_Lab3;

public class Marca
{
    public int Id { get; set; }
    public static int UltimoId { get; set; } = 1;
    public string Nombre { get; set; }
    public string PaisOrigen { get; set; }


    public Marca()
    {
        Id = UltimoId;
        UltimoId++;
    }

    public Marca(string nombre, string paisOrigen)
    {
        Id = UltimoId;
        UltimoId++;
        Nombre = nombre;
        PaisOrigen = paisOrigen;
    }
}
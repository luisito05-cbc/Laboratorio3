using System.Runtime.InteropServices.JavaScript;

namespace Ejercicio3_Lab3;

public class Director
{
    public int Id { get; set; }
    public static int UltimoID { get; set; } = 1;
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public PaisDirector PaisDirector { get; set; }
    

    public Director()
    {
        Id = UltimoID;
        UltimoID++;
    }
    
    public Director(string nombre, string apellido, PaisDirector paisDirector)
    {
        Id = UltimoID;
        UltimoID++;
        Nombre = nombre;
        Apellido = apellido;
        PaisDirector = paisDirector;
        
    }
}
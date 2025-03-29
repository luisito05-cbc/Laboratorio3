namespace Ejercicio3_Lab3;

public class Pelicula
{
    public int Id { get; set; }
    public static int UltimoId { get; set; } = 1;
    public string Titulo { get; set; }
    public Genero Genero { get; set; }
    public Director Director { get; set; }
    public DateTime FechaLanzamiento { get; set; }
    public TimeSpan Duracion { get; set; }

    public Pelicula()
    {
        Id = UltimoId;
        UltimoId++;
    }

    public Pelicula(string titulo, Genero genero, Director director, DateTime fechaLanzamiento, TimeSpan duracion)
    {
        Id = UltimoId;
        UltimoId++;
        Titulo = titulo;
        Genero = genero;
        Director = director;
        FechaLanzamiento = fechaLanzamiento;
        Duracion = duracion;
        ValidarTitulo();

    }
    
    public DateTime FechaBajaCatalogo()
    {
        return FechaLanzamiento.AddMonths(3);
    }

    public string AptaPublico()
    {
        if (Genero == Genero.Terror || Genero == Genero.Thriller || Genero == Genero.Suspenso)
        {
            return $"La pelicula {Titulo} es Apta para mayores de 13 años";
        }
        return $"La pelicula {Titulo}, es Apta para TODO PUBLICO";
    }

    private void ValidarTitulo()
    {
        if (string.IsNullOrWhiteSpace(Titulo))
        {
            throw new ArgumentException("El titulo no puede estar vacio");
        }
    }
    
}
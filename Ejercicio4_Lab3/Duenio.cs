namespace Ejercicio4_Lab3;

public class Duenio
{
    public int Id { get; set; }
    public static int UltimoId { get; set; } = 1;
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }

    public Duenio()
    {
        Id = UltimoId;
        UltimoId++;
    }

    public Duenio(string nombre, string apellido, DateTime fechaNacimiento)
    {
        Id = UltimoId;
        UltimoId++;
        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = fechaNacimiento;
        Validaciones();
    }

    #region Validaciones
    
    
    private void Validaciones()
    {
        ValidarNombre();
        ValidarApellido();
    }

    private void ValidarNombre()
    {
        if (string.IsNullOrWhiteSpace(Nombre))
        {
            throw new ArgumentException("El Nombre no puede estar vacio");
        }

    }

    private void ValidarApellido()
    {
        if (string.IsNullOrWhiteSpace(Apellido))
        {
            throw new ArgumentException("El Nombre no puede estar vacio");
        }
    }

    
    
    
    #endregion
}
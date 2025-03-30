namespace Ejercicio4_Lab3;

public class Automovil
{
    public int Id { get; set; }
    public static int UltimoId { get; set; } = 1;
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public DateTime AnioFabricacion { get; set; }
    public Duenio Duenio { get; set; }

    public Automovil()
    {
        Id = UltimoId;
        UltimoId++;
    }

    public Automovil(string marca, string modelo, DateTime anioFabricacion, Duenio duenio)
    {
        Id = UltimoId;
        UltimoId++;
        Marca = marca;
        Modelo = modelo;
        AnioFabricacion = anioFabricacion;
        Duenio = duenio;
        ValidarMarca();
    }

    #region Validaciones
    
    
    private void ValidarMarca()
    {
        if (string.IsNullOrWhiteSpace(Marca))
        {
            throw new ArgumentException("La Marca no puede estar vacio");
        }

        if (Marca.Length == int.MaxValue && Marca.Length == int.MinValue)
        {
            throw new ArgumentException("La Marca no puede ser numerica");

        }
    }
    

    #endregion

    public override string ToString()
    {
        return $"\n Datos del Automovil {Id}\n Marca: {Marca}\n Modelo: {Modelo}\n Anio Fabricacion: {AnioFabricacion}\n\n Datos del Propietario {Duenio.Id}\n Nombre : {Duenio.Nombre}\n Apellido : {Duenio.Apellido}\n Fecha Nacimiento {Duenio.FechaNacimiento}";
    }
}
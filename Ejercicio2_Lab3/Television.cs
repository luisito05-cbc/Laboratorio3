namespace Ejercicio2_Lab3;

public class Television
{
    public int Id { get; set; }
    public static int UltimoId { get; set; } = 1;
    public  Marca Marca { get; set; }
    public string Modelo { get; set; }
    public Tamanio Tamanio { get; set; }
    public bool EsSmart { get; set; }
    public string Estado { get; set; }
    public int NivelVolumen { get; set; }
    
    public Television()
    {
        Id = UltimoId;
        UltimoId++;
        
    }

    public Television(Marca marca, string modelo, Tamanio tamanio, bool esSmart, string estado, int nivelVolumen)
    {
        Id = UltimoId;
        UltimoId++;
        Marca = marca;
        Modelo = modelo;
        Tamanio = tamanio;
        EsSmart = esSmart;
        Estado = estado;
        NivelVolumen = nivelVolumen;
    }

    public override string ToString()
    {
        return $"\n Informacion Televisor {Id} :\n Marca: {Marca.Id}- {Marca.PaisOrigen} - {Marca.Nombre}\n Modelo: {Modelo}\n Tamaño: {Tamanio}\n Es Smart: {EsSmart}\n Estado: {Estado}\n Nivel Volumen: {NivelVolumen}";
    }
}
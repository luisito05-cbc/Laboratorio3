using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Lab3
{
    public class Mesa
    {
        public int Id { get; set; }
        public static int UltimoId { get; set; } = 1;

        public double Largo { get; set; }
        public double Ancho { get; set; }
        public double Altura { get; set; }
        public Material Material { get; set; }
        public double Precio { get; set; }

        public Mesa()
        {
            Id = UltimoId;
            UltimoId++;
        }

        public Mesa(double largo, double ancho, double altura, Material material, double precio)
        {
            Id = UltimoId;
            UltimoId++;
            Largo = largo;
            Ancho = ancho;
            Altura = altura;
            Material = material;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"\n Datos de la mesa:\n Largo: {Largo} cm\n Ancho: {Ancho} cm\n Altura: {Altura} cm\n Material: {Material.Nombre}\n Pais Origen: {Material.PaisOrigen}\n Precio: ${Precio}  "; 
        }

    }
}

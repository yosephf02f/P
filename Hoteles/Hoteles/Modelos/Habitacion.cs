using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteles.Modelos
{
    public class Habitacion
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } // es desir que Tipo de habitasion
        public double Precio { get; set; }
        public int CategoriaId { get; set; } //servira para el diseno del formulario
        public Categoria Categoria { get; set; }


        //constructot basio
        public Habitacion()
        {
            Categoria = new Categoria(1, "Secilla");
            CategoriaId = Categoria.Id;
        }


        public Habitacion(int id, string descripcion, double precio, Categoria categoria)
        {
            Id = id;
            Descripcion = descripcion;
            Precio = precio;
            Categoria = categoria;
            CategoriaId = categoria.Id;

        }

    }
}
















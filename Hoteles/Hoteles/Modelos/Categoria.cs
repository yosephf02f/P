using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteles.Modelos
{
    public class Categoria // o tipo de habitacion
    {


        public int Id { get; set; }
        public string Descripcion { get; set; }


        public Categoria()
        {

        }

        public Categoria(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;

        }


    }
}


















using Hoteles.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteles.BL
{
    public class CategoriasBL
    {

        public BindingList<Categoria> ListaDeCategorias { get; set; }

        public CategoriasBL()
        {
            ListaDeCategorias = new BindingList<Categoria>();
            CrearDatosDePrueba();
        }

        private void CrearDatosDePrueba()
        {
            var categoria1 = new Categoria(1, "Habitaciones");
            var categoria2 = new Categoria(2, "Cervicio al cliente");

            ListaDeCategorias.Add(categoria1);
            ListaDeCategorias.Add(categoria2);


        } 


    }
}




















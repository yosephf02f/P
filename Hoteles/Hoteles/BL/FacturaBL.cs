using Hoteles.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteles.BL
{
    public class FacturaBL
    {
        public BindingList<Factura> ListaDeFacturas { get; set; }

        public FacturaBL()
        {
            ListaDeFacturas = new BindingList<Factura>();
        }
    }
}

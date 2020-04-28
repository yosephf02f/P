using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteles.Modelos
{
    public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public int  ClienteId { get; set; }//estas ban juntas 
        public Cliente Cliente { get; set; }//para podre crerar un conbobox

        public int Subtotal { get; set; }
        public int PropinaYotros { get; set; }
        public int Total { get; set; }

        public bool Activo { get; set; }// Nos dira si la factura esta bien

        public BindingList<FacturaDetalle> FacturaDetalle { get; set; }

        public Factura()
        {
            Fecha = DateTime.Now;
            Activo = true;
            FacturaDetalle = new BindingList<Modelos.FacturaDetalle>();
        }


    }

    public class FacturaDetalle
    {
        public int Id { get; set; }


        public int HabitacionId { get; set; }// para conboobox
        public Habitacion Habitacion { get; set; }

        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public int Total { get; set; }

        public FacturaDetalle()
        {
            Cantidad = 1;
            HabitacionId = 1;
        }

    }

}





















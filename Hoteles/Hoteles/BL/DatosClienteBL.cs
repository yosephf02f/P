using Hoteles.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteles.BL
{
    public class DatosClienteBL
    {
        public BindingList<DatosCliente> ListaDeDatosClientes { get; set; }

        public DatosClienteBL()
        {
            ListaDeDatosClientes = new BindingList<DatosCliente>();
            CrearDatosDePrueba();
        }

        private void CrearDatosDePrueba()
        {
            var datosCliente = new DatosCliente(1, "Nobre Del Cliente","Metodo de pago",1);

            ListaDeDatosClientes.Add(datosCliente);



        }




    }
}

















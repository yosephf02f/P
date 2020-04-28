using Hoteles.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteles.BL
{
    public class ClientesBL
    {
        public BindingList<Cliente> ListaDeClientes { get; set; }

        public ClientesBL()
        {
            ListaDeClientes = new BindingList<Cliente>();
            CrearDatosDePrueba();

        }

        private void CrearDatosDePrueba()
        {
            var datosCliente = new DatosCliente(1, "Nobre Del Cliente", "Metodo de pago",89951903);


            var cliente1 = new Cliente(1, "David Lopez", "Efectivo", datosCliente,98980033);
            var cliente2 = new Cliente(2, "Jose Montes", "Tarjeta", datosCliente,89175699);
            var cliente3 = new Cliente(3, "Yoseph Flores", "Efectivo", datosCliente,98478524);

            ListaDeClientes.Add(cliente1);
            ListaDeClientes.Add(cliente2);
            ListaDeClientes.Add(cliente3);

        }
    }
}
















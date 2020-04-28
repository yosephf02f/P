using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteles.Modelos
{
    public class Cliente
    {

        // se desea id nombre telefono y combobox  de si usa targeta o efectivo
        public int Id { get; set; }
        public string NombreDeCliente { get; set; }
        public string MetodoDePago { get; set; }
        public int Numero { get; set; }
        public int DatosClienteId { get; set; } // esta sirbe para diseno del formulario vid 9.2con30
        public DatosCliente DatosCliente { get; set; }

        //contructor basio
        public Cliente()
        {
            DatosCliente = new DatosCliente(1, " t", "mt", 9898);
            DatosClienteId = DatosCliente.Id;
        }

        public Cliente(int id, string nombredecliente, string metododepago, DatosCliente datoscliente, int numero)
        {
            Id = id;
            NombreDeCliente = nombredecliente;
            MetodoDePago = metododepago;
            DatosCliente = datoscliente;
            DatosClienteId = datoscliente.Id;
            Numero = numero;

        }

    }
}























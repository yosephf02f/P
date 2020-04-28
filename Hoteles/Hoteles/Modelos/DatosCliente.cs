using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteles.Modelos
{
    public class DatosCliente
    {
        public int Id { get; set; }
        public string NombreDeCliente { get; set; }
        public string MetodoDePago { get; set; }
        public int Numero { get; set; }


        //contructor basio
        public DatosCliente()
        {

        }

        public DatosCliente(int id, string nombredecliente, string metododepago, int numero)
        {
            Id = id;
            NombreDeCliente = nombredecliente;
            MetodoDePago = metododepago;
            Numero = numero;

        }

    }
}
















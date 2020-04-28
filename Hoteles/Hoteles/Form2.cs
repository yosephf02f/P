using Hoteles.BL;
using Hoteles.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoteles
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
       
        }
        public void cargarDatos(ClientesBL clientesBL, DatosClienteBL datosclienteBL)
        {

            listaDeClientesBindingSource.DataSource = clientesBL.ListaDeClientes;
            listaDeDatosClientesBindingSource.DataSource = datosclienteBL.ListaDeDatosClientes;


        }

    }
}





















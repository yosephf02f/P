using Hoteles.BL;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void cargarDatos(FacturaBL facturasBL, ClientesBL clientesBL, HabitacionesBL habitacionesBL)
        {
            listaDeFacturasBindingSource.DataSource = facturasBL.ListaDeFacturas;
            listaDeClientesBindingSource.DataSource = clientesBL.ListaDeClientes;
            listaDeHabitacionesBindingSource.DataSource = habitacionesBL.ListaDeHabitaciones;
        }

    }

}
























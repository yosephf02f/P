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
    public partial class Menu : Form
    {
        HabitacionesBL _habitacionesBL;
        CategoriasBL _categoriasBL;
        ClientesBL _clientesBL;
        DatosClienteBL _datosClienteBL;    




        public Menu()
        {
            InitializeComponent();
            _habitacionesBL = new HabitacionesBL();
            _categoriasBL = new CategoriasBL();
            _clientesBL = new ClientesBL();
            _datosClienteBL = new DatosClienteBL();

        }

        private void habitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formHabitaciones = new Form1();
            formHabitaciones.MdiParent = this;

            formHabitaciones.cargarDatos(_habitacionesBL, _categoriasBL);

            formHabitaciones.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new Form2();
            formClientes.MdiParent = this;
            formClientes.cargarDatos(_clientesBL, _datosClienteBL);

            formClientes.Show();

        }
    }
}


















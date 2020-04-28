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
        FacturaBL _facturaBL;



        public Menu()
        {
            InitializeComponent();
            _habitacionesBL = new HabitacionesBL();
            _categoriasBL = new CategoriasBL();
            _clientesBL = new ClientesBL();
            _datosClienteBL = new DatosClienteBL();
            _facturaBL = new FacturaBL();
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

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new Form3();
            formFactura.MdiParent = this;//para que el formulario quede conteido dentro del menu

            formFactura.cargarDatos(_facturaBL, _clientesBL, _habitacionesBL);

            formFactura.Show();

        }
    }
}


















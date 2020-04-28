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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        public void cargarDatos(HabitacionesBL habitacionesBL,CategoriasBL categoriasBL)
        {
            listaDeHabitacionesBindingSource.DataSource = habitacionesBL.ListaDeHabitaciones;
            listaDeCategoriasBindingSource.DataSource = categoriasBL.ListaDeCategorias;
        }

    }
}


















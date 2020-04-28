using Hoteles.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteles.BL
{
    public class HabitacionesBL
    {
        public BindingList<Habitacion> ListaDeHabitaciones { get; set; }
        public HabitacionesBL()
        {
            ListaDeHabitaciones = new BindingList<Habitacion>();
            CrearDatosDePrueba();
        }
        private void CrearDatosDePrueba()
        {

            var categoria1 = new Categoria(1, "Habitaciones");
            var categoria2 = new Categoria(2, "Cervicio al cliente");

            var habitacion1 = new Habitacion(1, "Habitacion Sencilla", 500, categoria1);
            var habitacion2 = new Habitacion(2, "Habitacion Doble", 800, categoria1);
            var habitacion3 = new Habitacion(3, "Cena Premium", 400, categoria2);

            ListaDeHabitaciones.Add(habitacion1);
            ListaDeHabitaciones.Add(habitacion2);
            ListaDeHabitaciones.Add(habitacion3);
        }

    }
}





















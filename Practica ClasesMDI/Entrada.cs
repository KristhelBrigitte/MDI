using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ClasesMDI
{
    abstract class Entrada //Se crea la clase abstracta
    {
        //Atributos
       private string evento; //No necesita private
       double precio;

        //Comentarios de tareas por hacer

        /// <summary>
        /// Constructor de la clase entrada, parametros ey=Nombre del evento, y monto= Precio de la entrada.
        /// </summary>
        /// <param name="ev"></param>
        /// <param name="monto"></param>

        public Entrada()
        {
            evento = "";
            precio = 0;
        }

        public Entrada(string ev,double monto)
        {
            evento = ev;
            precio = monto;
        }

        /// <summary>
        /// Actualiza el nombre del evento. Recibe como entrada el nuevo nombre.
        /// </summary>
        /// <param name="nuevoNombreEvento"></param>

        public void actualizarEvento(string nuevoNombreEvento)
        {
            evento = nuevoNombreEvento;
        }
        //Un metodo virtual se puede subescribir y modificar.

        public abstract int cantidadEntradas();

        public abstract string mensajeAlCliente();


    }
}

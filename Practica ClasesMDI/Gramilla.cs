using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ClasesMDI
{
    class Gramilla:Entrada
    {
        static int cantidad = 0;
        string amenidades= "";

   
        public Gramilla(string evento, double precio) : base(evento, precio)
        {
            cantidad += 1;
            amenidades = "Lentes Led";
        }
        

        public override int cantidadEntradas() //Override permite sobreescribir
        {
            return cantidad;
        }

        public override string mensajeAlCliente()
        {
            return "Excelente, compra exitosa!";
        }

        public void asignarOtraAmenidad(string amenidad)
        {
            amenidades = amenidad;
        }

    }
}

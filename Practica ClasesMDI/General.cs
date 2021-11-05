using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ClasesMDI
{
    class General:Entrada //Dos puntos para indicar que se hereda de la clase Entrada
    {
        static int cantidad = 0;

        //Constructor
        public General(string evento, double precio) : base(evento,precio) 
        {
            cantidad += 1;
        }

        //Base es para mandar a llamar al constructor de la clase base(En este caso)


        //Implementación de los metodos abstractos

        public override int cantidadEntradas() //Override permite sobreescribir
        {
            return cantidad;
        }

        public override string mensajeAlCliente()
        {
            return "Excelente, compra exitosa!";
        }



    }

}

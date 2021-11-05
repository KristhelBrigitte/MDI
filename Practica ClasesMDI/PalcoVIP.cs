using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ClasesMDI
{
    class PalcoVIP : Entrada
    {
        static int cantidad = 0;
        int id;
        int bebidas;

        public PalcoVIP(string evento, double precio, int canti) : base(evento, precio)
        {
            cantidad += 1;
            id = cantidad;
            bebidas = canti;
        }

        public override int cantidadEntradas() //Override permite sobreescribir
        {
            return cantidad;
        }

        public override string mensajeAlCliente()
        {
            return "Excelente,  compra exitosa!";
        }

        public void restarBebidas()
        {
            bebidas = bebidas - 1;
        }

        public bool quedanBebidas()
        {
            if (bebidas > 0)
                return true;
            else
                return false;
        }

    }
}

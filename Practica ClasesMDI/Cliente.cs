using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Practica_ClasesMDI
{
    class Cliente
    {
        string cedula;
        string nombre;
        string apellido;
        string apellido2;
        string correo;
        ArrayList ArrayEntradas;
   
        public Cliente()
        {
            cedula="";
            nombre = "";
            apellido = "";
            apellido2 = "";
            correo ="";
            ArrayEntradas = new ArrayList();
        }

        public Cliente(string ide, string nom,string ape1,string ape2, string corr)
        {
            cedula = ide;
            nombre = nom ;
            apellido = ape1;
            apellido2= ape2;
            correo = corr;
            ArrayEntradas = new ArrayList();
        }

        public int cantidadEntradas()
        {
            return ArrayEntradas.Count;
        }

        public void asignarEntrada(int cantidad,Entrada entrada)
        {
            for (int i=0;i< cantidad; i++)
            {
                ArrayEntradas.Add(entrada);
            }
        }

        public override string ToString()
        {
            return cedula + " "+nombre+ " " + apellido +" "+ apellido2 +" "+ correo ;
        }

        public string getCedula()
        {
            return cedula;

        }

        public string getNombre()
        {
            return nombre;
        }

        public string getApe1()
        {
            return apellido;
        }

        public string getApe2()
        {
            return apellido2;
        }

        public string getCorreo()
        {
            return correo;
        }

        
        public ListViewItem agregarClientesVista(Cliente cli)
        {
            ListViewItem lista = new ListViewItem(cli.getCedula());
            lista.SubItems.Add(cli.getNombre());
            lista.SubItems.Add(cli.getApe1());
            lista.SubItems.Add(cli.getCorreo());
            lista.SubItems.Add(cli.getApe2());
            return lista;
        }



    }

}

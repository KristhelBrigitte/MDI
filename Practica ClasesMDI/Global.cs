using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Practica_ClasesMDI
{
    class Global
    {
        private static ArrayList entGenerales;
        private static ArrayList entGramilla;
        private static ArrayList entVIP;
        private static ArrayList arrayClientes;
       

        public Global()
        {
            if (entGenerales == null && entGramilla == null && entVIP == null && arrayClientes == null)
            {
                entGenerales = new ArrayList();
                entGramilla = new ArrayList();
                entVIP = new ArrayList();
                arrayClientes = new ArrayList();
            }
        }

        public void agregarGen(General entrada)
        {
            entGenerales.Add(entrada);
        }

        /*
            public Gramilla getGramilla()
            {
                if (entGramilla.Count > 0)
                {
                    return entGramilla[0];  //Consultar
                }
                return null;
            }*/

        public Gramilla primerGR()
        {
            int cont = 0;
           foreach (Gramilla g in entGramilla){//entGramilla[0] Preguntar
                if (cont == 0)
                {
                    return g;
                }
            }
           return null;
        }

        public General primerGen()
        {
            int cont = 0;
            foreach (General gen in entGenerales)
            {
                if (cont == 0)
                {
                    return gen;
                }
            }
            return null;
        }
        public PalcoVIP primerVip()
        {
            int cont = 0;
            foreach (PalcoVIP vip in entVIP)
            {//entGramilla[0] Preguntar
                if (cont == 0)
                {
                    return vip;
                }
            }
            return null;
        }


        public void agregarGramilla(Gramilla entrada)
        {
            entGramilla.Add(entrada);
        }

        public void agregarVIP(PalcoVIP entrada)
        {
            entVIP.Add(entrada);
        }

        public void agregarCliente(Cliente cliente)
        {
            arrayClientes.Add(cliente);

        }

       
        public bool eliminarClientes(Cliente cli)
        {
            if (arrayClientes.Contains(cli))
            {
                arrayClientes.Remove(arrayClientes.IndexOf(cli, 1));
                return true;
            }
            return false;
        }

        public Cliente buscarCliente(string cedula)
        {
            foreach (Cliente cli in arrayClientes)
            {
                if (cli.getCedula() == cedula)
                {
                    return cli;
                }
            }
            return null;
        }

        public ArrayList getClientes()
        {
            return arrayClientes;
        }
        public ArrayList getGramilla()
        {
            return entGramilla;
        }
        public ArrayList getGeneral()
        {
            return entGenerales;
        }
        public ArrayList getPalcoVip()
        {
            return entVIP;
        }
        public int cantidadGram()
        {
            return entGramilla.Count;
        }
        public int cantidadGen()
        {
            return entGenerales.Count;
        }

        public int cantidadVip()
        {
            return entVIP.Count;
        }

        public void EliminarGen()
        {
            entGenerales.RemoveAt(0);
        }
        public void EliminarVip()
        {
            entVIP.RemoveAt(0);
        }
        public void EliminarGram()
        {
            entGramilla.RemoveAt(0);
        }



    }
}

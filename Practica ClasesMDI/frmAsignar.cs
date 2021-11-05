using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Practica_ClasesMDI
{
    public partial class FrmAsignar : Form
    {
        Cliente c = new Cliente();
        Global global = new Global();
      
        public FrmAsignar()
        {
            InitializeComponent();
        }

      /*
            int cantSeleccion=0;
            Button tipoEntrada = (Button) sender;
            Cliente cliente = global.buscarCliente(txtCedula.Text);
       
            if (VerificarSelecccion() == null)
            {
                MessageBox.Show("Error, debe seleccionar la cantidad de enrtadas");
            }
            else if (cliente != null)
            {
                int cant = cliente.cantidadEntradas();
                if (cant < 3 && (cant+cantSeleccion)<3)
                {
                    cliente.asignarEntrada(cantSeleccion,)
                }
                else
                {
                    MessageBox.Show("El cliente no puede tener más de 3 entradas!");
                }
            }
            else
            {
                MessageBox.Show("El cliente no está registrado");
            }    
       */

        public RadioButton VerificarSelecccion()
        {
            foreach(RadioButton RB in this.gbxCantidad.Controls)
            {
                if (RB.Checked == true)
                {
                    return RB;
                }

            }
            return null;
         
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            //ArrayList gramillas=global.getGramilla();
            int cant = 0;  
            if (VerificarSelecccion() == null)
            {
                MessageBox.Show("Error, debe seleccionar la cantidad de entradas");
            }
            else
            {
                int cantSeleccion = int.Parse(VerificarSelecccion().Text);
                Cliente cliente = global.buscarCliente(txtCedula.Text);
                if (cliente != null)
                {
                    cant = cliente.cantidadEntradas();
                    if (cant < 3 && (cant + cantSeleccion) < 4)
                    { 
                        cliente.asignarEntrada(cantSeleccion,global.primerGR());
                        for (int i = 0; i < cantSeleccion;i++)
                        {
                            global.EliminarGram();
                        }

                        Gramilla g = new Gramilla("",0);
                        MessageBox.Show(g.mensajeAlCliente());
                    }
                    else
                    {
                        MessageBox.Show("El cliente no puede tener más de 3 entradas!");
                    }
                }
            }
        }

        private void btnGramilla_Click(object sender, EventArgs e)
        {
            int cant = 0;
            if (VerificarSelecccion() == null)
            {
                MessageBox.Show("Error, debe seleccionar la cantidad de entradas");
            }
            else
            {
                int cantSeleccion = int.Parse(VerificarSelecccion().Text);
                Cliente cliente = global.buscarCliente(txtCedula.Text);
                if (cliente != null)
                {
                    cant = cliente.cantidadEntradas();
                    if (cant < 3 && (cant + cantSeleccion) < 4)
                    {
                        cliente.asignarEntrada(cantSeleccion, global.primerGen());
                        for (int i = 0; i < cantSeleccion; i++)
                        {
                            global.EliminarGen();
                        }

                        General gen = new General("", 0);
                        MessageBox.Show(gen.mensajeAlCliente());
                    }
                    else
                    {
                        MessageBox.Show("El cliente no puede tener más de 3 entradas!");
                    }
                }
            }
        }

        private void btnVip_Click(object sender, EventArgs e)
        {
            int cant = 0;
            if (VerificarSelecccion() == null)
            {
                MessageBox.Show("Error, debe seleccionar la cantidad de entradas");
            }
            else
            {
                int cantSeleccion = int.Parse(VerificarSelecccion().Text);
                Cliente cliente = global.buscarCliente(txtCedula.Text);
                if (cliente != null)
                {
                    cant = cliente.cantidadEntradas();
                    if (cant < 3 && (cant + cantSeleccion) < 4)
                    {
                        cliente.asignarEntrada(cantSeleccion, global.primerVip());
                        for (int i = 0; i < cantSeleccion; i++)
                        {
                            global.EliminarVip();
                        }
                        PalcoVIP vip = new PalcoVIP("", 0,0);
                        MessageBox.Show(vip.mensajeAlCliente());
                    }
                    else
                    {
                        MessageBox.Show("El cliente no puede tener más de 3 entradas!");
                    }
                }
            }
        }
    }
}

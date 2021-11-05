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
    public partial class FrmClientes : Form
    {
        Global global = new Global();
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if( txtCedulaCli.Text == "" || txtApellido1.Text == "" || txtApellido2.Text == "" || txtNombreCli.Text == "" || txtCorreo.Text == "")
            {
                MessageBox.Show("No se pueden dejar campos vacíos");
            }
            else
            {
                if (global.buscarCliente(txtCedulaCli.Text) == null)
                {
                    Cliente cliente = new Cliente(txtCedulaCli.Text, txtNombreCli.Text, txtApellido1.Text, txtApellido2.Text, txtCorreo.Text);
                    global.agregarCliente(cliente);
                    ArrayList arrayDeClientes = global.getClientes();
                    ListViewClientes.Items.Add(cliente.agregarClientesVista(cliente));
                 
                }
                else
                {
                    MessageBox.Show("El cliente ya se encuentra registrado!");
                }
            }
         
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ListViewClientes.SelectedItems.Count>0 )
            {
                foreach (ListViewItem list in ListViewClientes.SelectedItems)
                {
                    list.Remove();
                    Cliente cli = global.buscarCliente(txtCedulaCli.Text);
                    global.eliminarClientes(cli);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente para eliminarlo");
            }
        }

        public void verArrayClientes()
        {
            ListViewClientes.Items.Clear();
            ArrayList arrayCli; ;
            Global global=new Global();
            arrayCli =global.getClientes();
            foreach(Cliente c in arrayCli)
            {
                ListViewItem lista = new ListViewItem(c.getCedula());
                lista.SubItems.Add(c.getNombre());
                lista.SubItems.Add(c.getApe1());
                lista.SubItems.Add(c.getCorreo());
                lista.SubItems.Add(c.getApe2());
                ListViewClientes.Items.Add(lista);
            }
        }

        private void btnActual_Click(object sender, EventArgs e)
        {
            verArrayClientes();
        }
    }

}

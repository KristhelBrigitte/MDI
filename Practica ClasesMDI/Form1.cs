using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_ClasesMDI
{
    public partial class FrmPrincipal : Form
    {
        FrmEntradas crear;
        FrmClientes agregarC;
        FrmAsignar asignar;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            tstFecha.Text += DateTime.Today.ToLongDateString();
        }

        private void MnuCrearEntradas_Click(object sender, EventArgs e)
        {
            if (crear == null)
            {
                crear = new FrmEntradas();
                crear.MdiParent = this;
                crear.FormClosed += new FormClosedEventHandler(cerrarForm);
                crear.Show();
            }
            else
            {
                crear.Activate();
            }
        }

        private void cerrarForm(object sender, FormClosedEventArgs e)
        {
            crear = null;
        }

        private void insertarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (agregarC == null)
            {
                agregarC = new FrmClientes();
                agregarC.MdiParent = this;
                agregarC.FormClosed += new FormClosedEventHandler(cerrar);
                agregarC.Show();
            }
            else
            {
                agregarC.Activate();
            }
        }

        private void cerrar(object sender, FormClosedEventArgs e)
        {
            agregarC = null;
        }

        private void MnuAsignarEntradas_Click(object sender, EventArgs e)
        {
            if (asignar == null)
            {
                asignar= new FrmAsignar();
                asignar.MdiParent = this;
                asignar.FormClosed += new FormClosedEventHandler(cerrarAsignacion);
                asignar.Show();
            }
            else
            {
                asignar.Activate();
            }
        }

        private void cerrarAsignacion(object sender, FormClosedEventArgs e)
        {
            asignar = null;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

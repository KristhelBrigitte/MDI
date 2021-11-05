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
    public partial class FrmEntradas : Form
    {
        public FrmEntradas()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)

        {
            if(txtNombreEv.Text == " " || txtGeneral.Text == "" || txtGramilla.Text ==" " ||
            txtVIP.Text == "" || txtCostoGen.Text == "" || txtCostoGram.Text == "" ||
            txtCostoVIP.Text =="" || txtEvento.Text ==" " || txtAme.Text == "")
            {
                MessageBox.Show("Error:Es necesario llenar todos los campos");
            }
            else
            {
            string evento = txtEvento.Text;
            Global arrayGlobal = new Global();

            for(int i = 0; i < int.Parse(txtGeneral.Text); i++)
            {
                General entrada = new General(evento, double.Parse(txtCostoGen.Text));
                arrayGlobal.agregarGen(entrada);
            }


            for (int i = 0; i < int.Parse(txtCostoGram.Text); i++)
            {
                Gramilla entrada = new Gramilla(evento, double.Parse(txtCostoGram.Text));
                arrayGlobal.agregarGramilla(entrada);
            }

            for (int i = 0; i < int.Parse(txtGeneral.Text); i++)
            {
                PalcoVIP entrada = new PalcoVIP(evento, double.Parse(txtCostoGen.Text),int.Parse(txtAme.Text));
                arrayGlobal.agregarVIP(entrada);
            }
            }
           
            MessageBox.Show("Entradas registradas!");
            txtNombreEv.Text = " "; txtGeneral.Text = "";txtGramilla.Text = "";
            txtVIP.Text = ""; txtCostoGen.Text = "";txtCostoGram.Text = "";
            txtCostoVIP.Text = "";txtEvento.Text = " "; txtAme.Text = "";
        }

    }
}

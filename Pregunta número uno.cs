using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exámen_de_geografía
{
    public partial class Pnum1 : Form
    {
        string nombre_usuario;
        public Pnum1(string NIngresado)
        {
            InitializeComponent();
            nombre_usuario = NIngresado;
        }

        private void Pnum1_Load(object sender, EventArgs e)
        {
            S1F1.Enabled = false;
        }
       
        private void controlRespuestas()
        {
            if (R1F1.Checked || R2F1.Checked || R3F1.Checked || R4F1.Checked)
            {
                S1F1.Enabled=true;
                errorProvider2.SetError(S1F1, "");
            }
            else
            {
                errorProvider2.SetError(S1F1, "Debe de seleccionar una respuesta.");

                S1F1.Enabled = false;
                S1F1.Focus();
            }
        }

        private void R3F1_CheckedChanged (object sender, EventArgs e)
        {
            controlRespuestas();
        }

        private void R4F1_CheckedChanged(object sender, EventArgs e)
        {
            controlRespuestas();
        }

        private void R2F1_CheckedChanged(object sender, EventArgs e)
        {
            controlRespuestas();
        }

        private void R1F1_CheckedChanged(object sender, EventArgs e)
        {
            controlRespuestas();
        }

        private void S1F1_Click(object sender, EventArgs e)
        {
            Pnum2 Preguntanum2 = new Pnum2();
            Preguntanum2.ShowDialog();
            this.Hide();
        }
    }
}

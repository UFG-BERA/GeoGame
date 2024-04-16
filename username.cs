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
    public partial class username : Form
    {
        public username()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imgF1\imgF2.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void username_Load(object sender, EventArgs e)
        {
            Iboton.Enabled = false;
        }

        private void controlBotones()
        {
            if (NIngresado.Text.Trim() != string.Empty)
            {
                Iboton.Enabled = true;
                errorProvider1.SetError(NIngresado, "");
            }
            else
            {
                errorProvider1.SetError(NIngresado, "Debe introducir su nombre.");

                Iboton.Enabled = false;
                NIngresado.Focus();
            }

        }
        private void NIngresado_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void Iboton_Click(object sender, EventArgs e)
        {
            using (Pnum1 PregNum1 = new Pnum1(NIngresado.Text))
                PregNum1.ShowDialog();
        }
    }
}

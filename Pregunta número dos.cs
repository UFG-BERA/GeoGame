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
    public partial class Pnum2 : Form
    {
        public Pnum2()
        {
            InitializeComponent();
        }

        private void Pnum2_Load(object sender, EventArgs e)
        {

        }

        private void S2F2_Click(object sender, EventArgs e)
        {
            Preguntas preguntas = new Preguntas();
            preguntas.ShowDialog();
            this.Hide();
        }
    }
}

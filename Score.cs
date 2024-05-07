namespace GeoGame
{
    public partial class Score : Form
    {
        public Score(ScoreEntidad scoreEntidad)
        {
            InitializeComponent();
            lblUsername.Text = scoreEntidad.Username;
            llbScore.Text = scoreEntidad.Score.ToString();
            lblAciertos.Text = scoreEntidad.Aciertos.ToString();
            lblFallos.Text = scoreEntidad.Fallos.ToString();
        }

        private void llbScore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VerRanking();
        }

        void VerRanking()
        {
            GuardarClasificacion();
            Ranking ranking = new();
            this.Hide(); // Oculta la ventana actual
            ranking.ShowDialog(); // Muestra la nueva ventana y espera a que se cierre
            this.Close(); // Cierra definitivamente la ventana original
        }


        void GuardarClasificacion()
        {
            string username = lblUsername.Text;


            string basePath = Application.StartupPath;
            string relativePath = @"..\..\..\Ranking.txt";
            string fullPath = Path.Combine(basePath, relativePath);


            // Escribir los datos en un archivo txt
            using StreamWriter sw = new StreamWriter(fullPath, true);
            sw.WriteLine($"{username} {llbScore.Text}");
        }

        private void btnReinentar_Click(object sender, EventArgs e)
        {
            string username = lblUsername.Text;
            Preguntas preguntas = new(username);
            this.Hide(); // Oculta la ventana actual
            preguntas.ShowDialog(); // Muestra la nueva ventana y espera a que se cierre
            this.Close(); // Cierra definitivamente la ventana original
        }

        private void Score_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VerRanking();
            }
        }
    }

    public class ScoreEntidad
    {
        public string Username { get; set; }
        public int Score { get; set; }
        public int Aciertos { get; set; }
        public int Fallos { get; set; }
    }
}

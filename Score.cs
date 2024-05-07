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
    }

    public class ScoreEntidad
    {
        public string Username { get; set; }
        public int Score { get; set; }
        public int Aciertos { get; set; }
        public int Fallos { get; set; }
    }
}

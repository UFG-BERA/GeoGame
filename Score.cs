namespace GeoGame // Define el espacio de nombres para el proyecto.
{
    public partial class Score : Form // Define la clase parcial `Score` que hereda de `Form`.
    {
        readonly Guid IdUser; // Identificador único del usuario, establecido como de solo lectura.

        public Score(ScoreEntidad scoreEntidad) // Constructor de la clase `Score`.
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            IdUser = scoreEntidad.IdUser; // Asigna el ID del usuario desde la entidad proporcionada.
            lblUsername.Text = scoreEntidad.Username; // Muestra el nombre de usuario en la etiqueta `lblUsername`.
            llbScore.Text = scoreEntidad.Score.ToString(); // Muestra la puntuación en el control `llbScore`.
            lblAciertos.Text = scoreEntidad.Aciertos.ToString(); // Muestra el número de aciertos en `lblAciertos`.
            lblFallos.Text = scoreEntidad.Fallos.ToString(); // Muestra el número de fallos en `lblFallos`.
        }

        private void llbScore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Controlador para el evento `LinkClicked` del control `llbScore`.
        {
            VerRanking(); // Llama al método `VerRanking` para ver el ranking.
        }

        void VerRanking() // Método para mostrar la ventana de ranking.
        {
            GuardarClasificacion(); // Guarda la clasificación antes de mostrar el ranking.
            Ranking ranking = new(IdUser, lblUsername.Text); // Crea una nueva ventana `Ranking` con el ID del usuario y nombre.
            this.Hide(); // Oculta la ventana actual.
            ranking.ShowDialog(); // Muestra la nueva ventana de ranking y espera a que se cierre.
            this.Close(); // Cierra definitivamente la ventana original.
        }

        void GuardarClasificacion() // Método para guardar la clasificación del usuario.
        {
            string username = lblUsername.Text; // Obtiene el nombre del usuario.

            string basePath = Application.StartupPath; // Obtiene la ruta de inicio de la aplicación.
            string relativePath = @"..\..\..\Ranking.txt"; // Ruta relativa al archivo de clasificación.
            string fullPath = Path.Combine(basePath, relativePath); // Construye la ruta completa del archivo.

            // Abre el archivo para escritura, agregando datos en modo `append`.
            using StreamWriter sw = new StreamWriter(fullPath, true);
            sw.WriteLine($"{IdUser} {username} {llbScore.Text}"); // Escribe el ID, nombre y puntuación en el archivo.
        }

        private void btnReinentar_Click(object sender, EventArgs e) // Controlador para el evento `Click` del botón `btnReinentar`.
        {
            string username = lblUsername.Text; // Obtiene el nombre del usuario.
            Preguntas preguntas = new(IdUser, username); // Crea una nueva ventana `Preguntas` con el ID del usuario y nombre.
            this.Hide(); // Oculta la ventana actual.
            preguntas.ShowDialog(); // Muestra la nueva ventana de preguntas y espera a que se cierre.
            this.Close(); // Cierra definitivamente la ventana original.
        }

        private void Score_KeyDown(object sender, KeyEventArgs e) // Controlador para el evento `KeyDown` de la ventana `Score`.
        {
            if (e.KeyCode == Keys.Enter) // Si la tecla presionada es `Enter`,
            {
                VerRanking(); // Llama al método `VerRanking` para ver el ranking.
            }
        }
    }

    public class ScoreEntidad // Define la clase `ScoreEntidad` para mantener la información de la puntuación.
    {
        public Guid IdUser { get; set; } // Propiedad para el ID del usuario.
        public string Username { get; set; } // Propiedad para el nombre del usuario.
        public int Score { get; set; } // Propiedad para la puntuación.
        public int Aciertos { get; set; } // Propiedad para el total de aciertos.
        public int Fallos { get; set; } // Propiedad para el total de fallos.
    }
}

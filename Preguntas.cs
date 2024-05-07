using System;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GeoGame
{
    public partial class Preguntas : Form
    {
        private PreguntasYRespuestas preguntasYRespuestas;
        private int indiceActual = 0;
        private readonly Stopwatch stopwatch;
        private readonly TimeSpan tiempoInicial = TimeSpan.FromSeconds(10);

        /// <summary>
        /// 
        /// </summary>
         static int puntuacion;
        static int fallos;
        static int aciertos;

        public Preguntas(string username)
        {
            InitializeComponent();
            lblUserName.Text = username;

            preguntasYRespuestas = new PreguntasYRespuestas();
            stopwatch = new Stopwatch();

            // Configura el temporizador
            TmrTemporizador.Interval = 100; // Actualiza cada 100 milisegundos
            TmrTemporizador.Start();

            // Inicia el cronómetro
            stopwatch.Start();

            // Carga la primera pregunta
            MostrarPreguntaActual();

            // Asignar el mismo manejador de eventos a todos los botones de respuesta
            btnRespuestaA.Click += btnRespuesta_Click;
            btnRespuestaB.Click += btnRespuesta_Click;
            btnRespuestaC.Click += btnRespuesta_Click;
            btnRespuestaD.Click += btnRespuesta_Click;
        }

        private void MostrarPreguntaActual()
        {

            if (indiceActual < preguntasYRespuestas.ListaPreguntas.Count)
            {
                var preguntaActual = preguntasYRespuestas.ListaPreguntas[indiceActual];
                lblPregunta.Text = preguntaActual.TextoPregunta;
                btnRespuestaA.Text = preguntaActual.Opciones["a"];
                btnRespuestaB.Text = preguntaActual.Opciones["b"];
                btnRespuestaC.Text = preguntaActual.Opciones["c"];
                btnRespuestaD.Text = preguntaActual.Opciones["d"];

                // Calcula la ruta correcta para las imágenes considerando la estructura de carpetas
                string basePath = Application.StartupPath;
                string relativePath = @"..\..\..\Imagenes\Banderas\";  // Ajusta esto según la estructura de carpetas real
                string fullPath = Path.Combine(basePath, relativePath, preguntaActual.UrlImagen);

                picPregunta.Load(fullPath);  // Carga la imagen desde la ruta construida
            }
            else
            {
                MessageBox.Show("No hay más preguntas.");
                TmrTemporizador.Stop();
                stopwatch.Stop();
                FinalizarQuiz();
            }
        }


        private void btnRespuesta_Click(object sender, EventArgs e)
        {
            Button btnRespuesta = sender as Button;
            if (btnRespuesta != null)
            {
                var preguntaActual = preguntasYRespuestas.ListaPreguntas[indiceActual];
                string respuestaSeleccionada = btnRespuesta.Text;  // Esto obtiene el texto del botón, que es la respuesta seleccionada
                string claveCorrecta = preguntaActual.RespuestaCorrecta;  // Esto debería ser 'a', 'b', 'c', o 'd'

                // Asegúrate de comparar el texto del botón con la respuesta correcta del diccionario de opciones usando la clave correcta
                if (respuestaSeleccionada == preguntaActual.Opciones[claveCorrecta])
                {
                    lblScore.Text = $"{++puntuacion}";
                    lblCorrecto.Enabled = true;
                    aciertos++;
                }
                else
                {
                    lblIncorrecto.Enabled = true;
                    fallos++;
                    //MessageBox.Show($"Incorrecto. La respuesta correcta era: {preguntaActual.Opciones[claveCorrecta]}.");
                }

                // Lógica para eliminar la pregunta y cargar la siguiente, o terminar el juego
                preguntasYRespuestas.ListaPreguntas.RemoveAt(indiceActual);
                if (preguntasYRespuestas.ListaPreguntas.Count > 0)
                {
                    if (indiceActual >= preguntasYRespuestas.ListaPreguntas.Count)
                    {
                        indiceActual = 0; // Reiniciar al inicio si se pasa del límite
                    }
                    Thread.Sleep(100);

                    lblCorrecto.Enabled = false;
                    lblIncorrecto.Enabled = false;
                    MostrarPreguntaActual();
                }
                else
                {
                    MessageBox.Show("Todas las preguntas han sido respondidas.");
                    TmrTemporizador.Stop();
                    stopwatch.Stop();
                    FinalizarQuiz();
                }
            }
        }


        private void TmrTemporizador_Tick(object sender, EventArgs e)
        {
            var tiempoRestante = tiempoInicial - stopwatch.Elapsed;
            if (tiempoRestante > TimeSpan.Zero)
            {
                lblTemporizador.Text = tiempoRestante.ToString(@"mm\:ss\.fff");
            }
            else
            {
                // Detén el temporizador y el cronómetro cuando el tiempo se haya agotado
                lblTemporizador.Text = "00:00.000";
                TmrTemporizador.Stop();
                stopwatch.Stop();
                FinalizarQuiz();
            }
        }

        void FinalizarQuiz()
        {
            Score ventanaNueva = new(new ScoreEntidad
            {
                Username = lblUserName.Text,
                Score = puntuacion,
                Aciertos = aciertos,
                Fallos = fallos
                
            });
            this.Hide(); // Oculta la ventana actual
            ventanaNueva.ShowDialog(); // Muestra la nueva ventana y espera a que se cierre
            this.Close(); // Cierra definitivamente la ventana original
        }
    }
}

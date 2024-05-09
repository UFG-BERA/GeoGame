using System.Diagnostics; // Proporciona clases para trabajar con procesos, eventos y rendimiento.

namespace GeoGame // Define el espacio de nombres para el proyecto.
{
    public partial class Preguntas : Form // Define la clase parcial `Preguntas` que hereda de `Form`.
    {
        readonly Guid IdUser; // Identificador único para el usuario, establecido como de solo lectura.
        private PreguntasYRespuestas preguntasYRespuestas; // Objeto que contendrá las preguntas y respuestas.
        private int indiceActual = 0; // Índice que señala la pregunta actual.
        private readonly Stopwatch stopwatch; // Cronómetro para medir el tiempo transcurrido.
        private readonly TimeSpan tiempoInicial = TimeSpan.FromSeconds(60); // Tiempo inicial para cada pregunta, en segundos.

        /// <summary>
        /// Campos que registran la puntuación, errores y aciertos.
        /// </summary>
        int puntuacion = 0; // Puntuación inicial del juego.
        int fallos = 0; // Contador de respuestas incorrectas.
        int aciertos = 0; // Contador de respuestas correctas.

        public Preguntas(Guid idUser, string username) // Constructor de la clase `Preguntas`.
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            IdUser = idUser; // Asigna el identificador único del usuario.
            lblUserName.Text = username; // Muestra el nombre de usuario en la etiqueta `lblUserName`.

            preguntasYRespuestas = new PreguntasYRespuestas(); // Inicializa la lista de preguntas y respuestas.
            stopwatch = new Stopwatch(); // Inicializa el cronómetro.

            // Configura el temporizador para actualizar cada 100 milisegundos.
            TmrTemporizador.Interval = 100;
            TmrTemporizador.Start(); // Inicia el temporizador.

            stopwatch.Start(); // Inicia el cronómetro.

            MostrarPreguntaActual(); // Carga la primera pregunta.

            // Asigna el mismo controlador de eventos a todos los botones de respuestas.
            btnRespuestaA.Click += btnRespuesta_Click;
            btnRespuestaB.Click += btnRespuesta_Click;
            btnRespuestaC.Click += btnRespuesta_Click;
            btnRespuestaD.Click += btnRespuesta_Click;
        }

        private void MostrarPreguntaActual() // Método para mostrar la pregunta actual.
        {
            if (indiceActual < preguntasYRespuestas.ListaPreguntas.Count) // Verifica que haya más preguntas disponibles.
            {
                var preguntaActual = preguntasYRespuestas.ListaPreguntas[indiceActual]; // Obtiene la pregunta actual.
                lblPregunta.Text = preguntaActual.TextoPregunta; // Muestra el texto de la pregunta.
                btnRespuestaA.Text = preguntaActual.Opciones["a"]; // Establece la opción A.
                btnRespuestaB.Text = preguntaActual.Opciones["b"]; // Establece la opción B.
                btnRespuestaC.Text = preguntaActual.Opciones["c"]; // Establece la opción C.
                btnRespuestaD.Text = preguntaActual.Opciones["d"]; // Establece la opción D.

                // Calcula la ruta correcta para las imágenes, considerando la estructura de carpetas.
                string basePath = Application.StartupPath; // Obtiene la ruta de inicio de la aplicación.
                string relativePath = @"..\..\..\Imagenes\Banderas\"; // Ruta relativa a la carpeta de imágenes (ajusta según sea necesario).
                string fullPath = Path.Combine(basePath, relativePath, preguntaActual.UrlImagen); // Construye la ruta completa.

                picPregunta.Load(fullPath); // Carga la imagen desde la ruta especificada.
            }
            else
            {
                // Si no hay más preguntas, detén el temporizador y cronómetro.
                TmrTemporizador.Stop();
                stopwatch.Stop();
                FinalizarQuiz(); // Llama al método para finalizar el cuestionario.
            }
        }

        private void btnRespuesta_Click(object sender, EventArgs e) // Controlador de evento para los botones de respuesta.
        {
            Button btnRespuesta = sender as Button; // Obtiene el botón que se hizo clic.
            if (btnRespuesta != null) // Comprueba que el botón no sea nulo.
            {
                var preguntaActual = preguntasYRespuestas.ListaPreguntas[indiceActual]; // Obtiene la pregunta actual.
                string respuestaSeleccionada = btnRespuesta.Text; // Obtiene el texto del botón como la respuesta seleccionada.
                string claveCorrecta = preguntaActual.RespuestaCorrecta; // Clave de la respuesta correcta ('a', 'b', 'c' o 'd').

                // Compara el texto del botón con la respuesta correcta utilizando la clave.
                if (respuestaSeleccionada == preguntaActual.Opciones[claveCorrecta])
                {
                    lblScore.Text = $"{++puntuacion}"; // Incrementa la puntuación.
                    lblCorrecto.Enabled = true; // Activa la etiqueta de respuesta correcta.
                    aciertos++; // Incrementa el contador de respuestas correctas.
                }
                else
                {
                    lblIncorrecto.Enabled = true; // Activa la etiqueta de respuesta incorrecta.
                    fallos++; // Incrementa el contador de respuestas incorrectas.
                }

                // Elimina la pregunta actual y carga la siguiente, o finaliza el juego.
                preguntasYRespuestas.ListaPreguntas.RemoveAt(indiceActual); // Elimina la pregunta de la lista.
                if (preguntasYRespuestas.ListaPreguntas.Count > 0) // Verifica si quedan preguntas.
                {
                    if (indiceActual >= preguntasYRespuestas.ListaPreguntas.Count) // Si el índice supera la cantidad de preguntas, reinícialo.
                    {
                        indiceActual = 0;
                    }
                    System.Threading.Thread.Sleep(100); // Pausa para mejorar la transición entre preguntas.

                    lblCorrecto.Enabled = false; // Desactiva la etiqueta correcta.
                    lblIncorrecto.Enabled = false; // Desactiva la etiqueta incorrecta.
                    MostrarPreguntaActual(); // Muestra la siguiente pregunta.
                }
                else
                {
                    // Si no hay más preguntas, detén el temporizador y cronómetro.
                    TmrTemporizador.Stop();
                    stopwatch.Stop();
                    FinalizarQuiz(); // Llama al método para finalizar el cuestionario.
                }
            }
        }

        private void TmrTemporizador_Tick(object sender, EventArgs e) // Controlador para el evento de tick del temporizador.
        {
            var tiempoRestante = tiempoInicial - stopwatch.Elapsed; // Calcula el tiempo restante.
            if (tiempoRestante > TimeSpan.Zero) // Verifica si queda tiempo.
            {
                lblTemporizador.Text = tiempoRestante.ToString(@"mm\:ss\.fff"); // Muestra el tiempo restante.
            }
            else
            {
                // Si el tiempo se agota, detén el temporizador y cronómetro.
                lblTemporizador.Text = "00:00.000";
                TmrTemporizador.Stop();
                stopwatch.Stop();
                FinalizarQuiz(); // Llama al método para finalizar el cuestionario.
            }
        }

        void FinalizarQuiz() // Método para finalizar el cuestionario.
        {
            Score ventanaNueva = new(new ScoreEntidad // Crea una nueva ventana `Score`.
            {
                IdUser = IdUser, // Asigna el ID del usuario.
                Username = lblUserName.Text, // Asigna el nombre del usuario.
                Score = puntuacion, // Asigna la puntuación final.
                Aciertos = aciertos, // Asigna el total de respuestas correctas.
                Fallos = fallos // Asigna el total de respuestas incorrectas.
            });
            this.Hide(); // Oculta la ventana actual.
            ventanaNueva.ShowDialog(); // Muestra la nueva ventana y espera a que se cierre.
            this.Close(); // Cierra definitivamente la ventana original.
        }
    }
}

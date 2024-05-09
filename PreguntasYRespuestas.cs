using System; // Proporciona clases básicas y excepciones.
using System.Collections.Generic; // Proporciona clases para listas y diccionarios.
using System.Linq; // Proporciona funcionalidades para manipulación de colecciones.

namespace GeoGame // Define el espacio de nombres para el proyecto.
{
    public class Pregunta // Clase que representa una pregunta con varias opciones.
    {
        public string TextoPregunta { get; set; } // Texto que contiene la pregunta.
        public Dictionary<string, string> Opciones { get; set; } // Opciones de respuesta disponibles, mapeadas por clave (a, b, c, d).
        public string RespuestaCorrecta { get; set; } // Clave de la opción correcta.
        public string UrlImagen { get; set; } // Ruta a la imagen asociada a la pregunta.

        public Pregunta(string textoPregunta, string respuestaCorrecta, string urlImagen) // Constructor que inicializa una nueva pregunta.
        {
            TextoPregunta = textoPregunta; // Asigna el texto de la pregunta.
            RespuestaCorrecta = respuestaCorrecta; // Asigna la respuesta correcta (nombre).
            UrlImagen = urlImagen; // Asigna la URL de la imagen.
            Opciones = new Dictionary<string, string>(); // Inicializa el diccionario vacío para las opciones de respuesta.
        }
    }

    public class PreguntasYRespuestas // Clase que administra una lista de preguntas y respuestas.
    {
        public List<Pregunta> ListaPreguntas { get; private set; } // Lista de preguntas que se usarán.
        private List<string> TodasLasRespuestas; // Lista de todas las respuestas disponibles (correctas e incorrectas).
        private Random rng; // Generador de números aleatorios para mezclar respuestas y preguntas.

        public PreguntasYRespuestas() // Constructor que inicializa las preguntas y respuestas.
        {
            rng = new Random(); // Inicializa el generador de números aleatorios.
            ListaPreguntas = new List<Pregunta>(); // Inicializa la lista vacía de preguntas.
            CargarPreguntas(); // Llama al método para cargar las preguntas en la lista.
        }

        private void CargarPreguntas() // Método para cargar todas las preguntas en la lista.
        {
            // Añade preguntas específicas a la lista, especificando el texto, respuesta correcta y la URL de la imagen.
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Francia?", "París", "FRANCIA.png"));
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Italia?", "Roma", "ITALIA.png"));
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Japón?", "Tokio", "JAPON.png"));
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Alemania?", "Berlín", "ALEMANIA.png"));
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de España?", "Madrid", "ESPAÑA.png"));
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Canadá?", "Ottawa", "CANADA.png"));
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Australia?", "Canberra", "AUSTRALIA.png"));
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Brasil?", "Brasilia", "BRASIL.png"));
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de México?", "Ciudad de México", "MEXICO.png"));
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Rusia?", "Moscú", "RUSIA.png"));
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de China?", "Pekín", "CHINA.png"));
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de India?", "Nueva Delhi", "INDIA.png"));
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Egipto?", "El Cairo", "EGIPTO.png"));
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Argentina?", "Buenos Aires", "ARGENTINA.png"));
            //ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Chile?", "Santiago", "CHILE.png"));/////////
            //ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Sudáfrica?", "Pretoria", "SUDAFRICA.png"));/////////
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Turquía?", "Ankara", "TURQUIA.png"));
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Corea del Sur?", "Seúl", "COREA_SUR.png"));
            //ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Vietnam?", "Hanoi", "VIETNAM.png"));///////
            //ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Grecia?", "Atenas", "GRECIA.png"));/////////
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Portugal?", "Lisboa", "PORTUGAL.png"));
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Suecia?", "Estocolmo", "SUECIA.png"));
            //ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Noruega?", "Oslo", "NORUEGA.png")); ///////////
            //ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Dinamarca?", "Copenhague", "DINAMARCA.png"));///////////
            //ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Suiza?", "Berna", "SUIZA.png"));////////////////
            //ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Finlandia?", "Helsinki", "FINLANDIA.png"));
            //ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Nueva Zelanda?", "Wellington", "NUEVA_ZELANDA.png"));//////////
            //ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Polonia?", "Varsovia", "POLONIA.png"));//////////////////

            // Llama a los métodos para recolectar todas las respuestas, distribuirlas entre las preguntas y mezclar las preguntas.
            RecolectarRespuestas();
            DistribuirRespuestas();
            MezclarPreguntas();
        }

        private void RecolectarRespuestas() // Método para recolectar todas las respuestas posibles.
        {
            // Crea una lista con todas las respuestas correctas de las preguntas.
            TodasLasRespuestas = ListaPreguntas.Select(p => p.RespuestaCorrecta).ToList();

            // Añade respuestas incorrectas adicionales para completar la lista.
            TodasLasRespuestas.AddRange(new List<string>
    {
        "Barcelona", "Lisboa", "Atenas", "Seúl", "Bangkok", "Pekín",
        "Varsovia", "Ámsterdam", "Viena", "Estocolmo", "Oslo",
        "Copenhague", "Bruselas", "Luxemburgo", "Sofía", "Tallin",
        "Zagreb", "Vilna", "Liubliana", "Bratislava", "Budapest",
        "Sarajevo", "Belgrado", "Praga", "Riga", "Helsinki",
        "Montevideo", "Caracas", "Quito", "La Paz", "Bogotá",
        "Panamá", "Reikiavik", "Marrakech", "Kuala Lumpur", "Singapur",
        "Wellington", "Sydney", "San Petersburgo", "Venecia", "Florencia",
        "Edimburgo", "Londres", "Nueva York", "Los Ángeles", "Houston",
        "Santiago", "San José", "Puerto Príncipe", "Kingston", "San Salvador",
        "Tegucigalpa", "Managua", "Georgetown", "Paramaribo", "Asunción",
        "Sucre", "Guayaquil", "Manila", "Taipei", "Riad", "Dubái"
    });

            // Mezcla todas las respuestas usando un generador aleatorio.
            TodasLasRespuestas = TodasLasRespuestas.OrderBy(x => rng.Next()).ToList();
        }

        private void DistribuirRespuestas() // Método para distribuir las respuestas a cada pregunta.
        {
            foreach (var pregunta in ListaPreguntas) // Recorre cada pregunta en la lista.
            {
                // Selecciona un subconjunto de tres respuestas incorrectas y agrega la correcta.
                var respuestasOpciones = TodasLasRespuestas
                    .Where(r => r != pregunta.RespuestaCorrecta) // Excluye la respuesta correcta.
                    .OrderBy(x => rng.Next()) // Mezcla las respuestas.
                    .Take(3) // Toma tres respuestas incorrectas.
                    .ToList(); // Convierte a lista.

                // Añade la respuesta correcta.
                respuestasOpciones.Add(pregunta.RespuestaCorrecta);
                // Vuelve a mezclar todas las respuestas para asignarlas a las opciones.
                respuestasOpciones = respuestasOpciones.OrderBy(x => rng.Next()).ToList();

                // Asigna las opciones mezcladas a la pregunta.
                pregunta.Opciones = new Dictionary<string, string>
                {
                    {"a", respuestasOpciones[0]}, // Opción A.
                    {"b", respuestasOpciones[1]}, // Opción B.
                    {"c", respuestasOpciones[2]}, // Opción C.
                    {"d", respuestasOpciones[3]} // Opción D.
                };

                // Encuentra la clave correcta en el nuevo conjunto de opciones.
                pregunta.RespuestaCorrecta = pregunta.Opciones.First(kvp => kvp.Value == pregunta.RespuestaCorrecta).Key;
            }
        }

        private void MezclarPreguntas() // Método para mezclar el orden de las preguntas.
        {
            // Mezcla la lista completa de preguntas usando un generador aleatorio.
            ListaPreguntas = ListaPreguntas.OrderBy(x => rng.Next()).ToList();
        }
    }
}

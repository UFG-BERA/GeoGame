using System;
using System.Collections.Generic;
using System.Linq;

namespace GeoGame
{
    public class Pregunta
    {
        public string TextoPregunta { get; set; }
        public Dictionary<string, string> Opciones { get; set; }
        public string RespuestaCorrecta { get; set; }
        public string UrlImagen { get; set; }

        public Pregunta(string textoPregunta, string respuestaCorrecta, string urlImagen)
        {
            TextoPregunta = textoPregunta;
            RespuestaCorrecta = respuestaCorrecta;
            UrlImagen = urlImagen;
            Opciones = new Dictionary<string, string>();
        }
    }

    public class PreguntasYRespuestas
    {
        public List<Pregunta> ListaPreguntas { get; private set; }
        private List<string> TodasLasRespuestas;
        private Random rng;

        public PreguntasYRespuestas()
        {
            rng = new Random();
            ListaPreguntas = new List<Pregunta>();
            CargarPreguntas();
        }

        private void CargarPreguntas()
        {
            // Añadir todas las preguntas
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Francia?", "París", "FRANCIA.png"));
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Italia?", "Roma", "ITALIA.png"));
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Japón?", "Tokio", "JAPON.png"));
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de Alemania?", "Berlín", "ALEMANIA.png"));
            ListaPreguntas.Add(new Pregunta("¿Cuál es la capital de España?", "Madrid", "ESPAñA.png"));

            // Llama a los métodos para recolectar y distribuir respuestas
            RecolectarRespuestas();
            DistribuirRespuestas();
            MezclarPreguntas();
        }

        private void RecolectarRespuestas()
        {
            // Recolecta todas las respuestas correctas e incorrectas
            TodasLasRespuestas = ListaPreguntas.Select(p => p.RespuestaCorrecta).ToList();
            TodasLasRespuestas.AddRange(new List<string> { "Barcelona", "Lisboa", "Atenas", "Seúl", "Bangkok", "Pekín", "Varsovia", "Ámsterdam", "Viena" });

            // Mezcla todas las respuestas
            TodasLasRespuestas = TodasLasRespuestas.OrderBy(x => rng.Next()).ToList();
        }

        private void DistribuirRespuestas()
        {
            foreach (var pregunta in ListaPreguntas)
            {
                // Elige un subconjunto de respuestas incorrectas, incluyendo siempre la correcta
                var respuestasOpciones = TodasLasRespuestas
                    .Where(r => r != pregunta.RespuestaCorrecta)
                    .OrderBy(x => rng.Next())
                    .Take(3)
                    .ToList();

                respuestasOpciones.Add(pregunta.RespuestaCorrecta);
                respuestasOpciones = respuestasOpciones.OrderBy(x => rng.Next()).ToList();

                // Asigna las opciones mezcladas a la pregunta
                pregunta.Opciones = new Dictionary<string, string>
                {
                    {"a", respuestasOpciones[0]},
                    {"b", respuestasOpciones[1]},
                    {"c", respuestasOpciones[2]},
                    {"d", respuestasOpciones[3]}
                };

                // Encuentra la clave correcta en el nuevo conjunto de opciones
                pregunta.RespuestaCorrecta = pregunta.Opciones.First(kvp => kvp.Value == pregunta.RespuestaCorrecta).Key;
            }
        }

        private void MezclarPreguntas()
        {
            // Mezcla la lista completa de preguntas
            ListaPreguntas = ListaPreguntas.OrderBy(x => rng.Next()).ToList();
        }
    }
}

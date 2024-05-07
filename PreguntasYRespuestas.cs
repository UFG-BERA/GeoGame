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

        public Pregunta(string textoPregunta, Dictionary<string, string> opciones, string respuestaCorrecta, string urlImagen)
        {
            TextoPregunta = textoPregunta;
            Opciones = opciones;
            RespuestaCorrecta = respuestaCorrecta;
            UrlImagen = urlImagen;
            MezclarOpciones(); // Llama al método para mezclar las opciones al crear la pregunta
        }

        private void MezclarOpciones()
        {
            Random rng = new Random();
            var opcionesMezcladas = Opciones.OrderBy(x => rng.Next()).ToDictionary(item => item.Key, item => item.Value);
            Opciones = opcionesMezcladas;

            // Actualizar la clave de la respuesta correcta después de mezclar
            foreach (var kvp in Opciones)
            {
                if (kvp.Value == Opciones[RespuestaCorrecta])
                {
                    RespuestaCorrecta = kvp.Key;
                    break;
                }
            }
        }
    }

    public class PreguntasYRespuestas
    {
        public List<Pregunta> ListaPreguntas { get; private set; }

        public PreguntasYRespuestas()
        {
            ListaPreguntas = new List<Pregunta>();
            CargarPreguntas();
        }

        private void CargarPreguntas()
        {
            ListaPreguntas.Add(new Pregunta(
                "¿Cuál es la capital de Francia?",
                new Dictionary<string, string>
                {
                    {"a", "París"},
                    {"b", "Barcelona"},
                    {"c", "Lisboa"},
                    {"d", "Atenas"}
                },
                "a",
                "FRANCIA.png"
            ));

            ListaPreguntas.Add(new Pregunta(
                "¿Cuál es la capital de Italia?",
                new Dictionary<string, string>
                {
                    {"a", "Madrid"},
                    {"b", "París"},
                    {"c", "Roma"},
                    {"d", "Viena"}
                },
                "c",
                "ITALIA.png"
            ));

            ListaPreguntas.Add(new Pregunta(
                "¿Cuál es la capital de Japón?",
                new Dictionary<string, string>
                {
                    {"a", "Seúl"},
                    {"b", "Bangkok"},
                    {"c", "Pekín"},
                    {"d", "Tokio"}
                },
                "d",
                "JAPON.png"
            ));

            ListaPreguntas.Add(new Pregunta(
                "¿Cuál es la capital de Alemania?",
                new Dictionary<string, string>
                {
                    {"a", "Varsovia"},
                    {"b", "Berlín"},
                    {"c", "Ámsterdam"},
                    {"d", "Viena"}
                },
                "b",
                "ALEMANIA.png"
            ));

            ListaPreguntas.Add(new Pregunta(
                "¿Cuál es la capital de España?",
                new Dictionary<string, string>
                {
                    {"a", "Montreal"},
                    {"b", "Roma"},
                    {"c", "Madrid"},
                    {"d", "Atenas"}
                },
                "c",
                "ESPAñA.png"
            ));

            // Puedes seguir agregando más preguntas aquí

            // Mezclar preguntas después de todas están añadidas
            MezclarPreguntas();
        }

        private void MezclarPreguntas()
        {
            Random rng = new Random();
            int n = ListaPreguntas.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Pregunta valor = ListaPreguntas[k];
                ListaPreguntas[k] = ListaPreguntas[n];
                ListaPreguntas[n] = valor;
            }
        }
    }
}

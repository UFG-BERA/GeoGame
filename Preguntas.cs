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
    public partial class Preguntas : Form
    {

        //VARIABLES

        int respuestaCorrecta;
        int numeroPregunta = 1;
        int score;
        int porcentaje;
        int totalPreguntas;


        public Preguntas()
        {
            InitializeComponent();

            preguntarCuestion(numeroPregunta);

            totalPreguntas = 20;
        }

        private void revisionRespuestaEvento(object sender, EventArgs e)
        {
            var objetoEnviador = (Button)sender;

            int tagBoton = Convert.ToInt32(objetoEnviador.Tag);

            if (tagBoton == respuestaCorrecta) 
            {
                score++;
            }


            if (numeroPregunta == totalPreguntas)
            {

                porcentaje = (int)Math.Round((double)(score * 100) / totalPreguntas);


                MessageBox.Show(
                    "Quiz terminado"+Environment.NewLine +  
                    "Has respondido " + score + "preguntas correctamente." +Environment.NewLine + 
                    "Su porcentaje total es " + porcentaje + "%" + Environment.NewLine + 
                    "Haga click en OK para jugar de nuevo"
                    );

                score = 0;
                numeroPregunta = 0;
                preguntarCuestion(numeroPregunta);

            }


            numeroPregunta++;
            preguntarCuestion(numeroPregunta);
        }

        private void preguntarCuestion(int pnum)
        {
            switch (pnum)
            {

                case 1:
                    pictureBox1.Image = Properties.Resources.FRANCIA;

                    lblPregunta.Text = "¿Cuál es la capital de Francia?";

                    button1.Text = "París";
                    button2.Text = "Barcelona";
                    button3.Text = "Lisboa";
                    button4.Text = "Atenas";

                    respuestaCorrecta = 1;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.ITALIA;

                    lblPregunta.Text = "¿Cuál es la capital de Italia?";

                    button1.Text = "Madrid";
                    button2.Text = "París";
                    button3.Text = "Roma";
                    button4.Text = "Viena";

                    respuestaCorrecta = 3;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.JAPON;

                    lblPregunta.Text = "¿Cuál es la capital de Japón?";

                    button1.Text = "Seúl";
                    button2.Text = "Bangkok";
                    button3.Text = "Pekín";
                    button4.Text = "Tokio";

                    respuestaCorrecta = 4;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.ALEMANIA;

                    lblPregunta.Text = "¿Cuál es la capital de Alemania?";

                    button1.Text = "Varsovia";
                    button2.Text = "Berlín";
                    button3.Text = "Ámsterdam";
                    button4.Text = "Viena";

                    respuestaCorrecta = 2;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.ESPAÑA;

                    lblPregunta.Text = "¿Cuál es la capital de España?";

                    button1.Text = "Montreal";
                    button2.Text = "Roma";
                    button3.Text = "Madrid";
                    button4.Text = "Atenas";

                    respuestaCorrecta = 3;
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.CANADA;

                    lblPregunta.Text = "¿Cuál es la capital de Canada?";

                    button1.Text = "Toronto";
                    button2.Text = "Ottawa";
                    button3.Text = "Vancouver";
                    button4.Text = "Montreal";

                    respuestaCorrecta = 2;
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.CHINA1;

                    lblPregunta.Text = "¿Cuál es la capital de China?";

                    button1.Text = "Hong Kong";
                    button2.Text = "Shangái";
                    button3.Text = "Pekín";
                    button4.Text = "Seúl";

                    respuestaCorrecta = 3;
                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.RUSIA;

                    lblPregunta.Text = "¿Cuál es la capital de Rusia?";

                    button1.Text = "Moscú";
                    button2.Text = "Varsovia";
                    button3.Text = "San Petersburgo";
                    button4.Text = "Kiev";

                    respuestaCorrecta = 1;
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.AUSTRALIA;

                    lblPregunta.Text = "¿Cuál es la capital de Australia?";

                    button1.Text = "Sidney";
                    button2.Text = "Melbourne";
                    button3.Text = "Brisbane";
                    button4.Text = "Canberra";

                    respuestaCorrecta = 4;
                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.BRASIL;

                    lblPregunta.Text = "¿Cuál es la capital de Brasil?";

                    button1.Text = "Río de Janeiro";
                    button2.Text = "Sao Paulo";
                    button3.Text = "Brasilia";
                    button4.Text = "Buenos Aires";

                    respuestaCorrecta = 3;
                    break;

                case 11:
                    pictureBox1.Image = Properties.Resources.INDIA;

                    lblPregunta.Text = "¿Cuál es la capital de India?";

                    button1.Text = "Bombay";
                    button2.Text = "Calcuta";
                    button3.Text = "Karachi";
                    button4.Text = "Nueva Delhi";

                    respuestaCorrecta = 4;
                    break;

                case 12:
                    pictureBox1.Image = Properties.Resources.ARGENTINA;

                    lblPregunta.Text = "¿Cuál es la capital de Argentina?";

                    button1.Text = "Buenos Aires";
                    button2.Text = "Lima";
                    button3.Text = "Santiago";
                    button4.Text = "Montevideo";

                    respuestaCorrecta = 1;
                    break;

                case 13:
                    pictureBox1.Image = Properties.Resources.MEXICO;

                    lblPregunta.Text = "¿Cuál es la capital de México?";

                    button1.Text = "Monterrey";
                    button2.Text = "Guadalajara";
                    button3.Text = "Ciudad de México";
                    button4.Text = "Cancún";

                    respuestaCorrecta = 3;
                    break;

                case 14:
                    pictureBox1.Image = Properties.Resources.COREA_DEL_SUR;

                    lblPregunta.Text = "¿Cuál es la capital de Corea del Sur?";

                    button1.Text = "Tokio";
                    button2.Text = "Seúl";
                    button3.Text = "Bangkok";
                    button4.Text = "Pekín";

                    respuestaCorrecta = 2;
                    break;

                case 15:
                    pictureBox1.Image = Properties.Resources.REINO_UNIDO;

                    lblPregunta.Text = "¿Cuál es la capital de Reino Unido?";

                    button1.Text = "Liveropool";
                    button2.Text = "Glasgow";
                    button3.Text = "Dublín";
                    button4.Text = "Londres";

                    respuestaCorrecta = 4;
                    break;

                case 16:
                    pictureBox1.Image = Properties.Resources.TURQUIA;

                    lblPregunta.Text = "¿Cuál es la capital de Turquía?";

                    button1.Text = "Ankara";
                    button2.Text = "Estambul";
                    button3.Text = "Atenas";
                    button4.Text = "Budapest";

                    respuestaCorrecta = 1;
                    break;

                case 17:
                    pictureBox1.Image = Properties.Resources.EGIPTO;

                    lblPregunta.Text = "¿Cuál es la capital de Egipto?";

                    button1.Text = "Bagdad";
                    button2.Text = "Beiru";
                    button3.Text = "El Cairo";
                    button4.Text = "Ammán";

                    respuestaCorrecta = 3;
                    break;

                case 18:
                    pictureBox1.Image = Properties.Resources.SUECIA;

                    lblPregunta.Text = "¿Cuál es la capital de Suecia?";

                    button1.Text = "Oslo";
                    button2.Text = "Estocolmo";
                    button3.Text = "Copenhague";
                    button4.Text = "Helsinki";

                    respuestaCorrecta = 2;
                    break;

                case 19:
                    pictureBox1.Image = Properties.Resources.COLOMBIA;

                    lblPregunta.Text = "¿Cuál es la capital de Colombia?";

                    button1.Text = "Bogotá";
                    button2.Text = "Lima";
                    button3.Text = "Santiago";
                    button4.Text = "Caracas";

                    respuestaCorrecta = 1;
                    break;

                case 20:
                    pictureBox1.Image = Properties.Resources.PORTUGAL;

                    lblPregunta.Text = "¿Cuál es la capital de Portugal?";

                    button1.Text = "Barcelona";
                    button2.Text = "Madrid";
                    button3.Text = "Lisboa";
                    button4.Text = "Roma";

                    respuestaCorrecta = 3;
                    break;
            }
            }






    }
}

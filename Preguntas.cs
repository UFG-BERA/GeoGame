using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Exámen_de_geografía
{
    public partial class Preguntas : Form
    {
        //Variables para el temporizador
        int s = 0;
        int m = 0;
        //Se establece la forma de obtener el número Random
        Random rand = new Random();

        string nombre_usuario;
        public Preguntas(string Ningresado)
        {
            InitializeComponent();
            nombre_usuario = Ningresado;
        }


        //VARIABLES

        int respuestaCorrecta; 
        int numeroPregunta = 1;
        int score;
        int NPreguntas;
        int porcentaje; //Porcentaje de preguntas respondidas correctamente
        int totalPreguntas;


        public Preguntas()
        {
            InitializeComponent();

            //Se preguntará respecto al número de pregunta
            preguntarCuestion(numeroPregunta);

            //Total de preguntas dentro del quiz
            totalPreguntas = 10;

            //Datos pare el inicio del temporizador
            m = 1;
            countdownTimer.Start();
        }

        private void revisionRespuestaEvento(object sender, EventArgs e)
        {
            var objetoEnviador = (Button)sender;

            int tagBoton = Convert.ToInt32(objetoEnviador.Tag);

            if (tagBoton == respuestaCorrecta)
            {
                // Incremento en caso de Responder correctamente
                score += 10;
                NPreguntas++;

            }
            else if (tagBoton != respuestaCorrecta && score <= 0)
            {
                //estatico solo para no entrar en numero negativos
                score = 0;
            }
            else
            {
                // Decremento en Caso de fallar la pregunta
                score -= 5;
            }
            //código para cambio de color (esta incompleto)
            //objetoEnviador.BackColor = tagBoton == respuestaCorrecta ? Color.Green : Color.Red;

            //texto que define el score
            LabelScore.Text = "Score: " + score.ToString();


            if (numeroPregunta == totalPreguntas)
            {
                //GameOver Endgame = new GameOver();
                ////? ayuda
                ////AddOwnedForm(Endgame);
                ////Endgame.lblScore.Text = this.score.ToString();
                //Endgame.Show();
                //this.Dispose();

                porcentaje = (int)Math.Round((double)(score * 100) / totalPreguntas);


                MessageBox.Show(
                    "Quiz terminado"+Environment.NewLine +  
                    "Has respondido " + NPreguntas + "preguntas correctamente." +Environment.NewLine + 
                    "Su porcentaje total es " + porcentaje + "%" + Environment.NewLine + 
                    "Haga click en OK para jugar de nuevo"
                    );

                //score = 0;
                NPreguntas = 0;
                numeroPregunta = 0;
                preguntarCuestion(numeroPregunta);

            }


            numeroPregunta++;
            preguntarCuestion(numeroPregunta);
        }

        private void preguntarCuestion(int pnum)
        {
            //Se establece el cambio de número random para cada pregunta
            int randomNumber = rand.Next(1, 4);

            if (randomNumber == 3)
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
                }
            }
            else if (randomNumber == 2)
            {

                switch (pnum)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.INDIA;

                        lblPregunta.Text = "¿Cuál es la capital de India?";

                        button1.Text = "Bombay";
                        button2.Text = "Calcuta";
                        button3.Text = "Karachi";
                        button4.Text = "Nueva Delhi";

                        respuestaCorrecta = 4;
                        break;

                    case 2:
                        pictureBox1.Image = Properties.Resources.ARGENTINA;

                        lblPregunta.Text = "¿Cuál es la capital de Argentina?";

                        button1.Text = "Buenos Aires";
                        button2.Text = "Lima";
                        button3.Text = "Santiago";
                        button4.Text = "Montevideo";

                        respuestaCorrecta = 1;
                        break;

                    case 3:
                        pictureBox1.Image = Properties.Resources.MEXICO;

                        lblPregunta.Text = "¿Cuál es la capital de México?";

                        button1.Text = "Monterrey";
                        button2.Text = "Guadalajara";
                        button3.Text = "Ciudad de México";
                        button4.Text = "Cancún";

                        respuestaCorrecta = 3;
                        break;

                    case 4:
                        pictureBox1.Image = Properties.Resources.COREA_DEL_SUR;

                        lblPregunta.Text = "¿Cuál es la capital de Corea del Sur?";

                        button1.Text = "Tokio";
                        button2.Text = "Seúl";
                        button3.Text = "Bangkok";
                        button4.Text = "Pekín";

                        respuestaCorrecta = 2;
                        break;

                    case 5:
                        pictureBox1.Image = Properties.Resources.REINO_UNIDO;

                        lblPregunta.Text = "¿Cuál es la capital de Reino Unido?";

                        button1.Text = "Liveropool";
                        button2.Text = "Glasgow";
                        button3.Text = "Dublín";
                        button4.Text = "Londres";

                        respuestaCorrecta = 4;
                        break;

                    case 6:
                        pictureBox1.Image = Properties.Resources.TURQUIA;

                        lblPregunta.Text = "¿Cuál es la capital de Turquía?";

                        button1.Text = "Ankara";
                        button2.Text = "Estambul";
                        button3.Text = "Atenas";
                        button4.Text = "Budapest";

                        respuestaCorrecta = 1;
                        break;

                    case 7:
                        pictureBox1.Image = Properties.Resources.EGIPTO;

                        lblPregunta.Text = "¿Cuál es la capital de Egipto?";

                        button1.Text = "Bagdad";
                        button2.Text = "Beiru";
                        button3.Text = "El Cairo";
                        button4.Text = "Ammán";

                        respuestaCorrecta = 3;
                        break;

                    case 8:
                        pictureBox1.Image = Properties.Resources.SUECIA;

                        lblPregunta.Text = "¿Cuál es la capital de Suecia?";

                        button1.Text = "Oslo";
                        button2.Text = "Estocolmo";
                        button3.Text = "Copenhague";
                        button4.Text = "Helsinki";

                        respuestaCorrecta = 2;
                        break;

                    case 9:
                        pictureBox1.Image = Properties.Resources.COLOMBIA;

                        lblPregunta.Text = "¿Cuál es la capital de Colombia?";

                        button1.Text = "Bogotá";
                        button2.Text = "Lima";
                        button3.Text = "Santiago";
                        button4.Text = "Caracas";

                        respuestaCorrecta = 1;
                        break;

                    case 10:
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
            else if (randomNumber == 1)
            {
                switch (pnum)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.FINLANDIA;

                        lblPregunta.Text = "¿Cuál es la capital de Finlandia?";

                        button1.Text = "Oslo";
                        button2.Text = "Estocolmo";
                        button3.Text = "Copenhague";
                        button4.Text = "Helsinki";

                        respuestaCorrecta = 4;
                        break;

                    case 2:
                        pictureBox1.Image = Properties.Resources.CROACIA;

                        lblPregunta.Text = "¿Cuál es la capital de Croacia?";

                        button1.Text = "Zagreb";
                        button2.Text = "Belgrado";
                        button3.Text = "Saravejo";
                        button4.Text = "Sofía";

                        respuestaCorrecta = 1;
                        break;

                    case 3:
                        pictureBox1.Image = Properties.Resources.SUDAN;

                        lblPregunta.Text = "¿Cuál es la capital de Sudán?";

                        button1.Text = "Nairobi";
                        button2.Text = "Kampala";
                        button3.Text = "Jartum";
                        button4.Text = "Mogadiscio";

                        respuestaCorrecta = 3;
                        break;

                    case 4:
                        pictureBox1.Image = Properties.Resources.ISLANDIA;

                        lblPregunta.Text = "¿Cuál es la capital de Islandia?";

                        button1.Text = "Oslo";
                        button2.Text = "Reikiavik";
                        button3.Text = "Helsinki";
                        button4.Text = "Dublín";

                        respuestaCorrecta = 2;
                        break;

                    case 5:
                        pictureBox1.Image = Properties.Resources.ROMANIA;

                        lblPregunta.Text = "¿Cuál es la capital de Rumania?";

                        button1.Text = "Budapest";
                        button2.Text = "Praga";
                        button3.Text = "Varsovia";
                        button4.Text = "Bucarest";

                        respuestaCorrecta = 4;
                        break;

                    case 6:
                        pictureBox1.Image = Properties.Resources.BANGLADESH;

                        lblPregunta.Text = "¿Cuál es la capital de Bangladesh?";

                        button1.Text = "Daca";
                        button2.Text = "Colombo";
                        button3.Text = "Katmandú";
                        button4.Text = "Islamabad";

                        respuestaCorrecta = 1;
                        break;

                    case 7:
                        pictureBox1.Image = Properties.Resources.MARRUECOS;

                        lblPregunta.Text = "¿Cuál es la capital de Marruecos?";

                        button1.Text = "Túnez";
                        button2.Text = "Argel";
                        button3.Text = "Rabat";
                        button4.Text = "El Cairo";

                        respuestaCorrecta = 3;
                        break;

                    case 8:
                        pictureBox1.Image = Properties.Resources.UCRANIA;

                        lblPregunta.Text = "¿Cuál es la capital de Ucrania?";

                        button1.Text = "Bucarest";
                        button2.Text = "Kiev";
                        button3.Text = "Minsk";
                        button4.Text = "Moscú";

                        respuestaCorrecta = 2;
                        break;

                    case 9:
                        pictureBox1.Image = Properties.Resources.MALASIA;

                        lblPregunta.Text = "¿Cuál es la capital de Malasia?";

                        button1.Text = "Kuala Lumpur";
                        button2.Text = "Singapur";
                        button3.Text = "Yakarta";
                        button4.Text = "Manila";

                        respuestaCorrecta = 1;
                        break;

                    case 10:
                        pictureBox1.Image = Properties.Resources.VENEZUELA;

                        lblPregunta.Text = "¿Cuál es la capital de Venezuela?";

                        button1.Text = "Lima";
                        button2.Text = "Buenos Aires";
                        button3.Text = "Caracas";
                        button4.Text = "Bogotá";

                        respuestaCorrecta = 3;
                        break;
                }
            }
            else if (randomNumber == 4)
            {
                switch (pnum)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.MALAWI;

                        lblPregunta.Text = "¿Cuál es la capital de Malawi?";

                        button1.Text = "Lilongüe";
                        button2.Text = "Dar es Salaam";
                        button3.Text = "Kampala";
                        button4.Text = "Nairobi";

                        respuestaCorrecta = 1;
                        break;

                    case 2:
                        pictureBox1.Image = Properties.Resources.GHANA;

                        lblPregunta.Text = "¿Cuál es la capital de Ghana?";

                        button1.Text = "Lagos";
                        button2.Text = "Nairobi";
                        button3.Text = "Acra";
                        button4.Text = "Abuya";

                        respuestaCorrecta = 3;
                        break;

                    case 3:
                        pictureBox1.Image = Properties.Resources.NEPAL;

                        lblPregunta.Text = "¿Cuál es la capital de Nepal?";

                        button1.Text = "Katmandú del Sur";
                        button2.Text = "Lhasa";
                        button3.Text = "Daca";
                        button4.Text = "Katmandú";

                        respuestaCorrecta = 4;
                        break;

                    case 4:
                        pictureBox1.Image = Properties.Resources.SERBIA;

                        lblPregunta.Text = "¿Cuál es la capital de Serbia?";

                        button1.Text = "Zagreb";
                        button2.Text = "Belgrado";
                        button3.Text = "Saravejo";
                        button4.Text = "Podgorica";

                        respuestaCorrecta = 2;
                        break;

                    case 5:
                        pictureBox1.Image = Properties.Resources.ESLOVENIA;

                        lblPregunta.Text = "¿Cuál es la capital de Eslovenia?";

                        button1.Text = "Praga";
                        button2.Text = "Liubliana";
                        button3.Text = "Zagreb";
                        button4.Text = "Bratislava";

                        respuestaCorrecta = 2;
                        break;

                    case 6:
                        pictureBox1.Image = Properties.Resources.BULGARIA;

                        lblPregunta.Text = "¿Cuál es la capital de Bulgaria?";

                        button1.Text = "Belgrado";
                        button2.Text = "Bucarest";
                        button3.Text = "Sofía";
                        button4.Text = "Sofía del Norte";

                        respuestaCorrecta = 3;
                        break;

                    case 7:
                        pictureBox1.Image = Properties.Resources.ARMENIA;

                        lblPregunta.Text = "¿Cuál es la capital de Armenia?";

                        button1.Text = "Tiflis";
                        button2.Text = "Bakú";
                        button3.Text = "Ankara";
                        button4.Text = "Ereván";

                        respuestaCorrecta = 4;
                        break;

                    case 8:
                        pictureBox1.Image = Properties.Resources.ECUADOR;

                        lblPregunta.Text = "¿Cuál es la capital de Ecuador?";

                        button1.Text = "Quito";
                        button2.Text = "Lima";
                        button3.Text = "Bogotá";
                        button4.Text = "Caracas";

                        respuestaCorrecta = 1;
                        break;

                    case 9:
                        pictureBox1.Image = Properties.Resources.LAOS;

                        lblPregunta.Text = "¿Cuál es la capital de Laos?";

                        button1.Text = "Phnom Penh";
                        button2.Text = "Bangkok";
                        button3.Text = "Vientián";
                        button4.Text = "Hanoi";

                        respuestaCorrecta = 3;
                        break;

                    case 10:
                        pictureBox1.Image = Properties.Resources.ANGOLA;

                        lblPregunta.Text = "¿Cuál es la capital de Angola?";

                        button1.Text = "Maputo";
                        button2.Text = "Luanda";
                        button3.Text = "Windhoek";
                        button4.Text = "Accra";

                        respuestaCorrecta = 2;
                        break;
                }
            }

        }

        private void Preguntas_Load(object sender, EventArgs e)
        {

        }

        private void lblScreen_Click(object sender, EventArgs e)
        {

        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            lblScreen.Text = s--.ToString();

            //If para el que el temporizador pare al finalizar las preguntas o que se acabe el tiempo
            if (numeroPregunta == totalPreguntas || s <= 0 && m <= 0)
            {
                countdownTimer.Stop();
            }

            if (s <= 0 && m > 0)
            {
                s = 59;
                m -= 1;
            }
            //Formato que recibe el temporizador
            lblScreen.Text = $"{m:00}:{s:00}";
        }

        private void LabelScore_Click(object sender, EventArgs e)
        {

        }
    }
}

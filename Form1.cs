using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSG_GameOver;

namespace DuoligoBird
{
    public partial class Form1 : Form
    {
        int ContadorMovimiento = 1;
        bool VolarArriba = false;
        int Distancia = 0;
        Random PosicionRandom = new Random();
        RectangleF PlayerCollisionBox;
        int PuntajeValor =0;
        int PuntajeValorAnterior = 0;
        int CambioTuboColor = 0;

        int minutos = 0;
        int segundos = 0;
        int milisegundos = 0;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            IniciarJuego();
            
        }
        
        public void IniciarJuego()
        {
            minutos = 0;
            segundos = 0;
            milisegundos = 0;

            BackgroundImage = Properties.Resources.fondo_tierra;
    
            Player.Location = new Point(81, 198);
            PlayerCollisionBox = new RectangleF(Player.Bounds.X + 10, Player.Bounds.Y + 10, 50, 50); 
            Distancia = PosicionRandom.Next(-45, 50);
            TuboArriba.Location = new Point(305, -70 - Distancia);
            Distancia = PosicionRandom.Next(-20, 75);
            TuboAbajo.Location = new Point(305, 311 - Distancia);
            Distancia = PosicionRandom.Next(-45, 50);
            Tubo2Arriba.Image = Properties.Resources.tubo_morado;
            CambioTuboColor = 0;
            Tubo2Arriba.Location = new Point(585, -70 - Distancia);
            Distancia = PosicionRandom.Next(-20, 75);
            Tubo2Abajo.Location = new Point(585, 311 - Distancia);
            Puntaje.Text = PuntajeValor.ToString();

            Vuelo.Start();
            DesplazaTubos1.Start();
            DesplazaTubo2.Start();
            DesplazaPizo.Start();

        }


        private void Vuelo_Tick_1(object sender, EventArgs e)
        {
            Tiempo();
            int CantidadMovimientos = 5;
            if (ContadorMovimiento <= CantidadMovimientos)
            {
                Player.Image = Properties.Resources.buho2;
                ContadorMovimiento++;
            }
            if ((ContadorMovimiento > CantidadMovimientos / 2) && (ContadorMovimiento <= CantidadMovimientos * 2))
            {
                Player.Image = Properties.Resources.buho4;
                ContadorMovimiento++;
            }
            ContadorMovimiento = (ContadorMovimiento > CantidadMovimientos * 2) ? 0 : ContadorMovimiento;

            int ly = Player.Location.Y;
            int lx = Player.Location.X;

            if (VolarArriba)
            {
                if (ly > 5)
                {
                    ly = ly - 35;

                    VolarArriba = false;
                    Player.Image = Properties.Resources.buho3;
                }
                VolarArriba = false;

            }
            else
            {
                ly = ly + 4;
                //2

            }

            if ((PlayerCollisionBox.IntersectsWith(Tubo2Arriba.Bounds)) && CambioTuboColor == 1)
            {
                Tubo2Arriba.Image = Properties.Resources.tubo_morado;
                Puntaje.Text = Convert.ToString((Convert.ToInt32(Puntaje.Text) + 4));
                CambioTuboColor = 0;
                ly = ly + 10;
            }

            Player.Location = new Point(lx, ly);
            PlayerCollisionBox.Location = new Point(lx + 10, ly + 10);


            

            if ((PlayerCollisionBox.IntersectsWith(Piso.Bounds))
                || (PlayerCollisionBox.IntersectsWith(TuboArriba.Bounds)) || (PlayerCollisionBox.IntersectsWith(TuboAbajo.Bounds))
                || ((PlayerCollisionBox.IntersectsWith(Tubo2Arriba.Bounds)) && CambioTuboColor==0)
                || (PlayerCollisionBox.IntersectsWith(Tubo2Abajo.Bounds)))
            {

                
                MensajeGameOver();
            }

            

            Puntaje.Location = new Point(Player.Location.X + 25, Player.Location.Y - 25);
            Taza.Location= new Point(Player.Location.X + 50, Player.Location.Y - 38);

            Puntaje.Text = (TuboArriba.Location.X == Player.Location.X) ? Convert.ToString((Convert.ToInt32(Puntaje.Text) + 1)).ToString() : Puntaje.Text;

            Puntaje.Text = (Tubo2Arriba.Location.X == Player.Location.X) ? Convert.ToString((Convert.ToInt32(Puntaje.Text) + 1)).ToString() : Puntaje.Text;

            PuntajeValor = Convert.ToInt32(Puntaje.Text);

            

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                VolarArriba = true;
            }

        }

        private void DesplazaTubos1_Tick_1(object sender, EventArgs e)
        {
            //Mueve el primer par de tubos mientras sea mayor al limite del escenario
            if (TuboAbajo.Location.X > -40)
            {
                TuboAbajo.Location = new Point((TuboAbajo.Location.X) - 2, TuboAbajo.Location.Y);
                TuboArriba.Location = new Point((TuboArriba.Location.X) - 2, TuboArriba.Location.Y);
            }
            else
            {
                Distancia = PosicionRandom.Next(-40, 50);
                TuboArriba.Location = new Point(625, -70 - Distancia);                
                Distancia = PosicionRandom.Next(-20, 75);     
                TuboAbajo.Location = new Point(625, 311 - Distancia);
            }

        }

        private void DesplazaTubo2_Tick(object sender, EventArgs e)
        {

            //Mueve el segundo par de tubos mientras sea mayor al limite del escenario
            if (Tubo2Abajo.Location.X > -40)
            {
                Tubo2Abajo.Location = new Point((Tubo2Abajo.Location.X) - 2, Tubo2Abajo.Location.Y);
                Tubo2Arriba.Location = new Point((Tubo2Arriba.Location.X) - 2, Tubo2Arriba.Location.Y);
            }
            else
            {
                Distancia = PosicionRandom.Next(-40, 50);
                Tubo2Arriba.Location = new Point(625, -70 - Distancia);
                if (PuntajeValor % 2 == 0 && PuntajeValor!=0)
                {
                    Tubo2Arriba.Image = Properties.Resources.tubo_azul;
                    CambioTuboColor = 1;
                }
                else
                {
                    Tubo2Arriba.Image = Properties.Resources.tubo_morado;
                    CambioTuboColor = 0;
                }
                Distancia = PosicionRandom.Next(-20, 75);
                Tubo2Abajo.Location = new Point(625, 311 - Distancia);
            }
        }


        private void DesplazaPizo_Tick_1(object sender, EventArgs e)
        {
            Piso.Location = (Piso.Location.X > -305) ? new Point((Piso.Location.X) - 2, Piso.Location.Y) : Piso.Location = new Point(0, Piso.Location.Y);
        }

        private void MensajeGameOver()
        {
            Vuelo.Stop();
            DesplazaTubos1.Stop();
            DesplazaTubo2.Stop();
            DesplazaPizo.Stop();

            Player.Image = Properties.Resources.buho_llorando1;

            if (PuntajeValorAnterior < PuntajeValor)
            {
                PuntajeValorAnterior = PuntajeValor;
            }

            GlobalMSG.MessageBox_Show(PuntajeValor.ToString(), PuntajeValorAnterior.ToString());
            if (GlobalMSG.ResultDialog == "Yes")
            {
                PuntajeValor = 0;
                IniciarJuego();
            }
            else if (GlobalMSG.ResultDialog == "No")
            {
                Application.Exit();
            }
        }

        private void Tiempo()
        {
            // Incrementar los milisegundos
            milisegundos += 50;

            // Si los milisegundos alcanzan 1000, incrementar los segundos y resetear los milisegundos
            if (milisegundos == 1000)
            {
                milisegundos = 0;
                segundos++;

                // Si los segundos alcanzan 60, incrementar los minutos y resetear los segundos
                if (segundos == 60)
                {
                    segundos = 0;
                    minutos++;
                }
            }
            LabelTimer.Text = Convert.ToString("Tiempo = "+ minutos +":"+segundos);
        }

    }
}

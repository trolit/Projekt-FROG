﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_frog
{
    public partial class Form2 : Form
    {
        private int count_timer1 = 0;  
        private int count_timer2 = 0;
        bool right;
        bool left;
        bool up;
        bool down;
        bool can_move = true;  // flaga sprawdzajaca czy frog moze chodzic, na start ustawiamy na true
        

        public Form2()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Form2_KeyDown);      // ruch zaby
            
        }

        private void Wykryj_kolizje_froga()
        {
            if (frog.Location.Y < -4 || frog.Location.Y > 450)
            {
                frog.Location = new Point(392, 428);
            }
            else if (frog.Location.X < -4 || frog.Location.X > 815)
            {
                frog.Location = new Point(392, 428);
            }
        }

        #region Dzwiek skoku froga - metoda
        private void Wywolaj_dzwiek_skoku()
        {
            SoundPlayer skok = new SoundPlayer(Properties.Resources.frog_jump);
            skok.Play();
        }
        #endregion

        #region Frog_Movement_Core
        void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            int x = frog.Location.X;
            int y = frog.Location.Y;

            if (e.KeyCode == Keys.Right)
            {
                if (can_move == true)
                {
                    if (fatigue.Value >= 4)
                    {
                        timer1.Start();
                        right = true;
                        frog.Image = Image.FromFile("frog_right.gif");
                        x += 15;
                        Wywolaj_dzwiek_skoku();
                        fatigue.Value -= 4;
                    }
                    else
                    {
                        warning1.Visible = true;
                        warning2.Visible = true;
                        can_move = false;
                        timer2.Start();
                    }
                }
            }

            else if (e.KeyCode == Keys.Left)
            {
                if (can_move == true)
                {
                    timer1.Start();

                    if (fatigue.Value >= 4)
                    {
                        left = true;
                        frog.Image = Image.FromFile("frog_left.gif");
                        x -= 15;
                        Wywolaj_dzwiek_skoku();
                        fatigue.Value -= 4;
                    }
                    else
                    {
                        warning1.Visible = true;
                        warning2.Visible = true;
                        can_move = false;
                        timer2.Start();
                    }
                }

            }

            else if (e.KeyCode == Keys.Up)
            {
                if (can_move == true)
                {
                    timer1.Start();

                    // jesli zmeczenie jeszcze wieksze rowne 5 to moge isc do gory
                    if (fatigue.Value >= 5)
                    {
                        up = true;
                        frog.Image = Image.FromFile("frog_up.gif");
                        y -= 15;
                        Wywolaj_dzwiek_skoku();
                        fatigue.Value -= 5;
                    }
                    else
                    {
                        warning1.Visible = true;
                        warning2.Visible = true;
                        can_move = false;
                        timer2.Start();
                    }
                }

            }

            else if (e.KeyCode == Keys.Down)
            {
                if (can_move == true)
                {
                    timer1.Start();

                    if (fatigue.Value >= 5)
                    {
                        down = true;
                        frog.Image = Image.FromFile("frog_down.gif");
                        y += 15;
                        Wywolaj_dzwiek_skoku();
                        fatigue.Value -= 5;
                    }
                    else
                    {
                        warning1.Visible = true;
                        warning2.Visible = true;
                        can_move = false;
                        timer2.Start();
                    }
                }
            }

            // odzyskiwanie kondycji
            if (fatigue.Value <= 98)
            {
                fatigue.Value += 2;
            }

            frog.Location = new Point(x, y);
            Wykryj_kolizje_froga();
        }
#endregion
        #region Timer1(odpowiedzialny za wywolanie odpowiednich obrazkow froga)
        private void timer1_Tick(object sender, EventArgs e)  
        {
            count_timer1++;
            // 1 sekunda = 1000 milisekund, timer ustawiamy w milisekundach
            if (count_timer1 == 1)
            {
                if (down == true)
                {
                    frog.Image = Image.FromFile("frog_down_stand.png");
                    count_timer1 = 0;
                    down = false;   // resetowanie kontrolek
                    up = false;
                    left = false;
                    right = false;
                }

                else if (up == true)
                {
                    frog.Image = Image.FromFile("frog_up_stand.png");
                    count_timer1 = 0;
                    down = false;
                    up = false;           
                    left = false;
                    right = false;
                }

                else if (left == true)
                {
                    frog.Image = Image.FromFile("frog_left_stand.png");
                    count_timer1 = 0;
                    down = false;
                    up = false;
                    left = false;
                    right = false;
                }

                else if (right == true)
                {
                    frog.Image = Image.FromFile("frog_right_stand.png");
                    count_timer1 = 0;
                    down = false;
                    up = false;
                    left = false;
                    right = false;
                }

                else
                {
                    count_timer1 = 0;   // rozwiazanie problemu ciaglego chodzenia froga
                }
            }
        }
        #endregion
        #region Timer2(odpowiedzialny za odnowienie energii froga, pozbawienie mozliwosci ruchu, ukrycie labelkow)
        private void timer2_Tick(object sender, EventArgs e)
        {
            count_timer2++;

            if (count_timer2 == 9)
            {
                fatigue.Value = 93;
                count_timer2 = 0;
                can_move = true;
                warning1.Visible = false;
                warning2.Visible = false;
                timer2.Stop();
            }

        }
        #endregion

    }
}

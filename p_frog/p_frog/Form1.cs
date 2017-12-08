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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region 1. PRZYCISK GRAJ
        private void button1_Click(object sender, EventArgs e)
        {
            if (singlefrog.Checked && !doublefrog.Checked)
            {
                this.Hide();

                Form2 graj_solo = new Form2();
                graj_solo.Show();
            }
            else if (doublefrog.Checked && !singlefrog.Checked)
            {
                this.Hide();

                Form3 graj_dubla = new Form3();
                graj_dubla.Show();
            }
            else if (!doublefrog.Checked && !singlefrog.Checked)
            {
                no_choice_warn.Visible = true;
                too_much_warn.Visible = false;
            }
            else if (doublefrog.Checked && singlefrog.Checked)
            {
                no_choice_warn.Visible = false;
                too_much_warn.Visible = true;
            }
        }
        #endregion
        #region 2. PRZYCISK WYJSCIE
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region 3. ODTWÓRZ DZWIEK DLA WYJSCIA
        private void play_sound_wyjdz(object sender, EventArgs e)
        {
            SoundPlayer wyjdz = new SoundPlayer(Properties.Resources.frog_effect_2);
            wyjdz.Play();
        }
        #endregion
        #region 4. ODTWÓRZ DZWIEK DLA GRAJ
        private void play_sound_graj(object sender, EventArgs e)
        {
            SoundPlayer graj = new SoundPlayer(Properties.Resources.frog_effect_1);
            graj.Play();
        }
        #endregion
        #region 5. INSTRUKCJA(mechanika gry)
        private void see_help_on(object sender, EventArgs e)
        {
            help.Visible = true;
            SoundPlayer pomoc = new SoundPlayer(Properties.Resources.frog_effect_4);
            pomoc.Play();
        }

        private void see_help_off(object sender, EventArgs e)
        {
            help.Visible = false;
        }
        #endregion
        #region 6. INFOBOX(klawiszologia)
        private void show_on(object sender, EventArgs e)
        {
            help_key.Visible = true;
            SoundPlayer pomoc = new SoundPlayer(Properties.Resources.frog_effect_4);
            pomoc.Play();
        }

        private void show_off(object sender, EventArgs e)
        {
            help_key.Visible = false;
        }
        #endregion
    }
}

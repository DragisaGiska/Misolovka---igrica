using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimepleGame_20_4_2015.Properties;//Ne zaboravi Properties/Settings

namespace SimepleGame_20_4_2015
{
    public partial class FormSimpleGame : Form
    {

        public FormSimpleGame()
        {
            InitializeComponent();
            timerIzbaciSliku.Enabled = false;
            labelDateTime.Text ="Current date time: "+ DateTime.Now.ToString("dd.MM.yyyy  HH:mm");
            if (Settings.Default.prvo_pokretanje)
            {
                //this.Hide();
                FormSettings formSett = new FormSettings();
                formSett.Closed += (s, args) => this.Close();
                formSett.Shown += (s, args) => this.Hide();
               
                formSett.Show();
            }

            labelDifficulty.Text ="Difficulty: "+ Settings.Default.Difficulty;
            labelIgrac.Text = Settings.Default.Igrac + ": " + Settings.Default.broj_pobjeda;
            Settings.Default.Save();
        }

        private void button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.ToString());
            Button button = (Button)sender;
            if (button.Image != null && timerIzbaciSliku.Enabled)
            {
                timerIzbaciSliku.Enabled = false;
                Settings.Default.broj_pobjeda++;
                MessageBox.Show("You catched the rat!");
                labelIgrac.Text = Settings.Default.Igrac + ": " + Settings.Default.broj_pobjeda;
                // timerIzbaciSliku.Enabled = true;
                startGameToolStripMenuItem.Text = "Start game";
                Settings.Default.Save();
            }

        }


        private void Iskoci(TableLayoutControlCollection Controls, Bitmap slika)
        {
            Random rGen = new Random();
            Button[] btns = Controls.OfType<Button>().ToArray();
            foreach (Button btn in btns)
                btn.Image = null;

            //U Bjelicinoj f-ji je (0,10) pa moze dat i 10 i doce do greske jer je 9 dugmadi.
            btns[rGen.Next(0, 9)].Image = slika;

        }

        private void timerIzbaciSliku_Tick(object sender, EventArgs e)
        {
            setDifficulty();
            Bitmap bmp = new Bitmap("rat.png");
            Iskoci(tableLayoutPanel1.Controls, bmp);
        }


        private void setDifficulty()
        {
            if (Settings.Default.Difficulty == "Easy")
            {
                timerIzbaciSliku.Interval = 1000;
            }
            else if (Settings.Default.Difficulty == "Medium")
            {
                timerIzbaciSliku.Interval = 600;
            }
            else
            {
                timerIzbaciSliku.Interval = 150;
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (startGameToolStripMenuItem.Text == "Start game")
            {
                startGameToolStripMenuItem.Text = "Stop game";
                timerIzbaciSliku.Enabled = true;
            }
            else
            {
                startGameToolStripMenuItem.Text = "Start game";
                timerIzbaciSliku.Enabled = false;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings formSett = new FormSettings();
            formSett.Closed += (s, args) => this.Close();
            formSett.Shown += (s, args) => this.Hide();

            formSett.Show();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = "Current date time: " + DateTime.Now.ToString("dd.MM.yyyy  HH:mm");
        }

        private void FormSimpleGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool nadjeno = false;
            foreach (Button button in tableLayoutPanel1.Controls)
            {
                if (button.Text == e.KeyChar.ToString())
                {
                    button.Focus();
                    button.PerformClick();
                    nadjeno = true;
                }
            }
            if (!nadjeno && timerIzbaciSliku.Enabled)
            {
                timerIzbaciSliku.Enabled = false;
                MessageBox.Show("Invalid button");
                timerIzbaciSliku.Enabled = true;
            }
        }
    }
}

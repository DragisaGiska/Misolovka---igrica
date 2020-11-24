using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimepleGame_20_4_2015.Properties;

namespace SimepleGame_20_4_2015
{
    public partial class FormSettings : Form
    {

        System.Text.RegularExpressions.Regex player_regex = new System.Text.RegularExpressions.Regex(@"[A-Z]\w+");

       
        public FormSettings()
        {
            InitializeComponent();
            
            
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxPlayer.Text) || (!isAnyRadioButtonDifficultySelected()))
                {
                    throw new Exception("Popunite sva polja");
                }
                else if (!player_regex.IsMatch(textBoxPlayer.Text))
                {
                    throw new Exception("Korisnicko ime mora poceti velikim slovom i moze da sadrzi samo slova");
                }
                Settings.Default.prvo_pokretanje = false;
                Settings.Default.Igrac = textBoxPlayer.Text;
                Settings.Default.Difficulty = selected_difficulty();
                Settings.Default.broj_pobjeda = 0;
                this.Hide();
                FormSimpleGame game = new FormSimpleGame();
                game.Closed += (o, args) => this.Close();
                game.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private bool isAnyRadioButtonDifficultySelected()
        {
            foreach (RadioButton rb in groupBoxDifficulty.Controls)
            {
                if (rb.Checked)
                {
                    return true;
                }
            }
            return false;
        }


        private string selected_difficulty()
        {
            foreach (RadioButton rb in groupBoxDifficulty.Controls)
            {
                if (rb.Checked)
                {
                    return rb.Text;
                }
            }
            return "";
        }
    }
}

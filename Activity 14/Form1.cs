namespace Activity_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            speciesListbox.SelectedIndex = 0;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            ClearPrevious();
            characterLabel.Text = speciesListbox.SelectedItem.ToString() + " " + GetClass();
            if (statsCB.Checked)
                SetStats();
            if (backgroundCB.Checked)
                SetBackground();
        }

        private void SetBackground()
        {
            backgroundLabel.Text = "Your " + characterLabel.Text + "'s background was a " + RandomBackground();
        }

        private void SetStats()
        {
            strengthLabel.Visible = true;
            strLabel.Text = StatGenerator().ToString();
            dexterityLabel.Visible = true;
            dexLabel.Text = StatGenerator().ToString();
            constitutionLabel.Visible = true;
            conLabel.Text = StatGenerator().ToString();
            intelligenceLabel.Visible = true;
            intLabel.Text = StatGenerator().ToString();
            wisdomLabel.Visible = true;
            wisLabel.Text = StatGenerator().ToString();
            charismaLabel.Visible = true;
            chaLabel.Text = StatGenerator().ToString();
        }

        private void ClearPrevious()
        {
            strengthLabel.Visible = false;
            strLabel.Text = "";
            dexterityLabel.Visible = false;
            dexLabel.Text = "";
            constitutionLabel.Visible = false;
            conLabel.Text = "";
            intelligenceLabel.Visible = false;
            intLabel.Text = "";
            wisdomLabel.Visible = false;
            wisLabel.Text = "";
            charismaLabel.Visible = false;
            chaLabel.Text = "";
            backgroundLabel.Text = "";
        }

        private string GetClass()
        {
            if (artificerRB.Checked)
                return artificerRB.Text;
            if (barbarianRB.Checked)
                return barbarianRB.Text;
            if (bardRB.Checked)
                return bardRB.Text;
            if (bloodhunterRB.Checked)
                return bloodhunterRB.Text;
            if (clericRB.Checked)
                return clericRB.Text;
            if (druidRB.Checked)
                return druidRB.Text;
            if (fighterRB.Checked)
                return fighterRB.Text;
            if (monkRB.Checked)
                return monkRB.Text;
            if (paladinRB.Checked)
                return paladinRB.Text;
            if (rangerRB.Checked)
                return rangerRB.Text;
            if (rogueRB.Checked)
                return rogueRB.Text;
            if (sorcererRB.Checked)
                return sorcererRB.Text;
            if (warlockRB.Checked)
                return warlockRB.Text;
            if (wizardRB.Checked)
                return wizardRB.Text;
            //unreachable return
            return "";
        }

        private static int StatGenerator()
        {
            Random r = new Random();
            int die1 = r.Next(6) + 1;
            int die2 = r.Next(6) + 1;

            return die1 + die2 + 6;
        }

        private static string RandomBackground()
        {
            Random r = new Random();
            int backgroundNum = r.Next(6);
            string background = "";
            switch (backgroundNum)
            {
                case 0: background = "Soldier"; break;
                case 1: background = "Shopkeep"; break;
                case 2: background = "Gladiator"; break;
                case 3: background = "Hermit"; break;
                case 4: background = "Acolyte"; break;
                case 5: background = "Alchemist"; break;
            }
            return background;
        }

    }
}
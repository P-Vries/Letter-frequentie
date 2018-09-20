using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetterFrequenties
{
    public partial class frmLetterFrequentie : Form
    {
        //
        //Versie 3
        //
        public frmLetterFrequentie()
        {
            InitializeComponent();
        }
        //
        //Vars
        //
        char Doel;//We maken het charchter aan dat het doel is van deze Functie.

        //
        //Functies
        //
        private void Tel(RichTextBox textBox)//Een methode om te tellen in de richtextbox die je door geeft.
        {
            int nummerCount = 0;//We maken een Integer om te tellen hoevaak de gespecificeerde letter voorkomt.
            try{ Doel = Convert.ToChar(txbInL.Text.ToUpper()); }
            catch (Exception e) { MessageBox.Show(e.ToString()); }// We zetten de letter om naar een char in een try/catch block
            foreach(char c in textBox.Text)//Voor elke character in de textbox kijken we of hij gelijk is met de letter die we aangeven.
            {
                char chars = char.ToUpper(c);// We maken een hoofdletter van alle charachters
                if (chars == Doel)//We kijken of het aangemaakte chars hetzelfde is als de letter die we willen tellen.
                {
                    nummerCount = nummerCount + 1;//Als ze het zelfde zijn voegen we een toe aan de nummerCount
                }
                lblOut.Text = "De letter: " + Doel + " komt " + nummerCount + " keer voor";//We laten het aantal nummers zien in een label
            }
        }

        private void btnTel_Click(object sender, EventArgs e)
        {
            Tel(txbInT);//Verwijzing naar de methode met de Textbox
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IksOks
{
    public partial class Form1 : Form
    {
        bool red = true; //true je prvi false je drugi
        int broj_reda=0;
        public Form1()
        {
            InitializeComponent();
            PrviRez.Text = "0";
            DrugiRez.Text = "0";
        }
        private void button_click(object sender,EventArgs e)
        {
            if (red == true)
                PrikazReda.Text = "Igrac 2";
            else
                PrikazReda.Text = "Igrac 1";
            Button b = (Button)sender;
            if (red == true)
            {
                b.Text = "X";
            }
            else
                b.Text = "O";
            red = !red;
            broj_reda++;
            b.Enabled = false;
            Provera();
        }

        private void Provera()
        {
            bool pobednik = false;
            // ispituje se da li postoji vrsta/kolona/dijagonala sa tri ista znaka
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text !="")
                pobednik = true;
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text !="")
                pobednik = true;
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text !="")
                pobednik = true;
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button4.Text !="")
                pobednik = true;
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button5.Text !="")
                pobednik = true;
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button6.Text !="")
                pobednik = true;
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text !="")
                pobednik = true;
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button5.Text !="")
                pobednik = true;
            if (pobednik)
            {
                string w = "";
                if (red == false)
                {
                    w = "Prvi igrac je pobedio!";
                    string s = PrviRez.Text;
                    int a;
                    int.TryParse(s,out a);
                    a += 1;
                    PrviRez.Text = a.ToString();
                }
                else
                {
                    w = "Drugi igrac je pobedio!";
                    string s = DrugiRez.Text;
                    int a;
                    int.TryParse(s, out a);
                    a += 1;
                    DrugiRez.Text = a.ToString();
                }
                    MessageBox.Show(w + " Resetujte igricu!");
            }
            else if (broj_reda == 9) //ako su sva mesta popunjena a nema 3 pobednika
                MessageBox.Show("Nereseno je! Resetujte igricu!");

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.Text = "";
            button2.Enabled = true;
            button2.Text = "";
            button3.Enabled = true;
            button3.Text = "";
            button4.Enabled = true;
            button4.Text = "";
            button5.Enabled = true;
            button5.Text = "";
            button6.Enabled = true;
            button6.Text = "";
            button7.Enabled = true;
            button7.Text = "";
            button8.Enabled = true;
            button8.Text = "";
            button9.Enabled = true;
            button9.Text = "";
            PrikazReda.Text = "Igrac 1";
            broj_reda = 0;
            red = true;
        }

        private void Nova_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.Text = "";
            button2.Enabled = true;
            button2.Text = "";
            button3.Enabled = true;
            button3.Text = "";
            button4.Enabled = true;
            button4.Text = "";
            button5.Enabled = true;
            button5.Text = "";
            button6.Enabled = true;
            button6.Text = "";
            button7.Enabled = true;
            button7.Text = "";
            button8.Enabled = true;
            button8.Text = "";
            button9.Enabled = true;
            button9.Text = "";
            broj_reda = 0;
            red = true;
            PrikazReda.Text = "Igrac 1";
            PrviRez.Text = "0";
            DrugiRez.Text = "0";
        }
    }
}

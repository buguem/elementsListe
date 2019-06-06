using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ElementListes
{
    public partial class ElementListeForm : Form
    {
        public ElementListeForm()
        {
            InitializeComponent();
        }

        private void lettreAaZButton_Click(object sender, EventArgs e)
        {
            affichageListBox.Items.Clear();
            Keys keyAscii;

            for (keyAscii = Keys.A; keyAscii<=Keys.Z ; keyAscii++)
            {
                affichageListBox.Items.Add(keyAscii);
            }
        }

        private void lettreXaCButton_Click(object sender, EventArgs e)
        {
            affichageListBox.Items.Clear();
            int caractereInteger;

            for (caractereInteger = (int)Keys.X + 32; caractereInteger >= (int)Keys.C + 32;
                caractereInteger--) 
            {
                affichageListBox.Items.Add(Convert.ToChar(caractereInteger));
            }
        }

        private void suiteDiagonaleButton_Click(object sender, EventArgs e)
        {
            affichageListBox.Items.Clear();
            for (int i = 2; i <= 20 ; i+=2)
            {
                affichageListBox.Items.Add(i.ToString().PadLeft(i)); 
            }
        }

        private void fibonnaciButton_Click(object sender, EventArgs e)
        {
            affichageListBox.Items.Clear();

            int[] fibo = new int[24];

            // affichageListBox.Items.AddRange(new Object[] { 1, 2 });
            fibo[0] = 0;
            fibo[1] = 1;

            affichageListBox.Items.Add(fibo[0]);
            affichageListBox.Items.Add(fibo[1]);

            for (int i = 2; i < 23; i++)
            {
               fibo[i] = fibo[i - 1] + fibo[i-2];
                affichageListBox.Items.Add(fibo[i]);
            }
        }

        private void occurenceButton_Click(object sender, EventArgs e)
        {
            affichageListBox.Items.Clear();
            string[] pays = new string[6] { "canada","japonais","Etats-Unis","Maroc","Chine","Bresil" };
           affichageListBox.Items.AddRange(pays);

            

            for (int i = pays.Length ; i < 6; i++)
           {
              
            }
           //////for (string s in affichageListBox.Items)
           //// {
           ////     if (occurencesCaracteres(s, "a")>=1)
           ////     {
           ////         affichageListBox.SelectedItems.Add(s);
           ////     }
           //// }
        }
        
        private int occurencesCaracteres(string message, string caractere)
        {
            affichageListBox.Items.Clear();

            int occurencesCaractereInt = 0;
            if (message != null && caractere!=null)
            {
                int positionCaractereInt;

                positionCaractereInt = message.IndexOf(caractere, StringComparison.InvariantCultureIgnoreCase);

                while (positionCaractereInt!=1)
                {
                    occurencesCaractereInt += 1;

                    positionCaractereInt = message.IndexOf(caractere, positionCaractereInt + 1, StringComparison.InvariantCultureIgnoreCase);
                }
            }
            return 2;
        }

        private void inverseButton_Click(object sender, EventArgs e)
        {

        }

        private void suiteDeNbrButton_Click(object sender, EventArgs e)
        {

            for (double nb = -0.75; nb < 2.5; nb += 0.25) 
            {
                affichageListBox.Items.Add(nb.ToString("N2").PadLeft(5));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt2
{
    public partial class Assosiation : Form
    {
        public Assosiation(string str1, string str2)
        {
            InitializeComponent();
            player1 = str1;
            player2 = str2;
        }
        //Variablat per mi prdor edhe nforma tjera
        static string player1;
        static string player2;
        public static string a1;
        public static string a2;
        public static string a3;
        public static string a4;
        public static string zgjedhjaA;
        public static string b1;
        public static string b2;
        public static string b3;
        public static string b4;
        public static string zgjedhjaB;
        public static string c1;
        public static string c2;
        public static string c3;
        public static string c4;
        public static string zgjedhjaC;
        public static string d1;
        public static string d2;
        public static string d3;
        public static string d4;
        public static string zgjedhjaD;
        public static string Final;

        static int count = 0;
        private void btnAddAssosiation_Click(object sender, EventArgs e)
        {
            //variablave ja kom jap vleren qe ja japim te forma assosaition.
            a1 = txtA1.Text;
            a2 = txtA2.Text;
            a3 = txtA3.Text;
            a4 = txtA4.Text;
            zgjedhjaA = txtZgjedhjaA.Text;
            b1 = txtB1.Text;
            b2 = txtB2.Text;
            b3 = txtB3.Text;
            b4 = txtB4.Text;
            zgjedhjaB = txtZgjedhjaB.Text;
            c1 = txtC1.Text;
            c2 = txtC2.Text;
            c3 = txtC3.Text;
            c4 = txtC4.Text;
            zgjedhjaC = txtZgjedhjaC.Text;
            d1 = txtD1.Text;
            d2 = txtD2.Text;
            d3 = txtD3.Text;
            d4 = txtD4.Text;
            zgjedhjaD = txtZgjedhjaD.Text;
            Final = txtFinal.Text;

            MessageBox.Show("Your Assosiation is created.");
            this.Hide();
            Player playerForm = new Player();
            //butoni play bohet enabled edhe munesh me vazhdu me play. pa i jap vlerat per lojen me asosacione
            count += 1;
            if (count >= 1)
            {
                playerForm.btnPlay.Enabled = true;
            }

            playerForm.txtPlayer1.Text = player1;
            playerForm.txtPlayer2.Text = player2;
            playerForm.ShowDialog();
            this.Close();
            //masi ta klikojna ok mshelet forma assosiaction edhe osht veq forma e par.
        }
    }
}

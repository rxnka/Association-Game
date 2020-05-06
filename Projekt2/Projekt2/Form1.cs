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
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
             //add butoni e shfaq formen per me add asosacione
            this.Hide();
            Assosiation assosiation = new Assosiation(txtPlayer1.Text, txtPlayer2.Text);// per me i dergu vlerat te forma tjeter jan variablat per emerat e player. 
            assosiation.ShowDialog();
            this.Close();
            //Codi me lart eshte per me mbyll ket form dhe me hap formen tjeter nese e bojna x formen e dyt ka mu nal edhe run
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            play playForm = new play(txtPlayer1.Text,txtPlayer2.Text); // per me i dergu vlerat te forma tjeter jan variablat per emerat e player. 
            playForm.ShowDialog();//me shfaq formen e trete
            this.Close();
        }
    }
}

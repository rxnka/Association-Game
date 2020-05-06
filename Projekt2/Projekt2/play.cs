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
    public partial class play : Form
    {
        public play(string p1, string p2) //Si thapet forma play meniher i merr vlerat e emrit prej formes tjetr edhe i shenon te label player 1 edhe 2
        {
            InitializeComponent();
            lblplayPlayer1.Text = p1;
            lblplayPlayer2.Text = p2;
        }
        public static int answer = 0;
        public static int Aresult = 0;
        public static int Bresult = 0;
        public static int Cresult = 0;
        public static int Dresult = 0;
        static int finalresult = 0;
        public static int player1Result = 0;
        public static int player2Result = 0;
        Label firstclick;
        private void label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel == null) //kjo asht per ni click veq edhe kur ta klikon niher nuk e lejon me kliku apet.
                labels(sender);
            try
            {
                if (firstclick == null)
                {
                    firstclick = clickedLabel;
                    firstclick.ForeColor = Color.Gray;
                    labels(sender);
                }
            }
            catch (NullReferenceException) 
            {
                labels(sender);
            }
            
        } 
        public void labels(object sender) //this is qe kur ta klikon ni label mu ndrru veq qajo label jo krejt label-at pernjeher.
        {
            if (sender == lblA1) lblA1.Text = Assosiation.a1;
            else if (sender == lblA2) lblA2.Text = Assosiation.a2;
            else if (sender == lblA3) lblA3.Text = Assosiation.a3;
            else if (sender == lblA4) lblA4.Text = Assosiation.a4;
            else if (sender == lblB1) lblB1.Text = Assosiation.b1;
            else if (sender == lblB2) lblB2.Text = Assosiation.b2;
            else if (sender == lblB3) lblB3.Text = Assosiation.b3;
            else if (sender == lblB4) lblB4.Text = Assosiation.b4;
            else if (sender == lblC1) lblC1.Text = Assosiation.c1;
            else if (sender == lblC2) lblC2.Text = Assosiation.c2;
            else if (sender == lblC3) lblC3.Text = Assosiation.c3;
            else if (sender == lblC4) lblC4.Text = Assosiation.c4;
            else if (sender == lblD1) lblD1.Text = Assosiation.d1;
            else if (sender == lblD2) lblD2.Text = Assosiation.d2;
            else if (sender == lblD3) lblD3.Text = Assosiation.d3;
            else if (sender == lblD4) lblD4.Text = Assosiation.d4;
        }
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            answer++; //sa her klikojna rritet pernjeher.
            if (answer % 2 == 0) //Me take turns players
            {
                zgjedhjet(); //metoda per me kontrollu pergjigjjen

                lblPlayer1turn.Visible = true;
                lblPlayer2turn.Visible = false;
            }
            else
            {
                zgjedhjet();

                lblPlayer1turn.Visible = false;
                lblPlayer2turn.Visible = true;
            }
            lblresult1.Text = ": " + player1Result.ToString();
            lblresult2.Text = ": " + player2Result.ToString();
            label_Click(sender, e);
            firstclick = null; //pershkak ndryshojke vlera edhe nuk funksionojke me click again. edhe kur ta bojna click butonin answer kena drejt me hap ni label tjeter
        }
        public void zgjedhjet()
        {
            while (Aresult == 0) // for starters me ni loop pershkak se nuk kom mujt me ndal kur niher veq u bojke true qe mos me vazhdu me marr edhe player 2 edhe player 1 pikt.
            {
                if (Assosiation.zgjedhjaA.ToLower() == txtZgjedhjaAplay.Text.ToLower())
                {
                    textA(); //nese e gjejna zgjidhjen krejt A mu hap.

                    if (lblPlayer1turn.Visible == true)
                    {
                        player1Result += 20;
                        Aresult = 1; //nese lojtari par e bon tsakt vetem lojtari 1 i merr pikt. edhe nalet while kretj
                        MessageBox.Show("The answer of A is correct.");
                    }
                    else if (lblPlayer2turn.Visible == true)
                    {
                        player2Result += 20;
                        MessageBox.Show("The answer of A is correct.");
                        Aresult = 1;
                    }
                }
                else
                {
                    txtZgjedhjaAplay.Text = ""; //nese asht jo e sakt e fshin pergjigjjen qe mos me hy ninfinite loop ather e kom perdor break.
                    break;
                }
            }
            while (Bresult == 0) //per krejt vazhdon njejt deri te zgjedhja D
            {
                if (Assosiation.zgjedhjaB.ToLower() == txtZgjedhjaBplay.Text.ToLower())
                {
                    textB();

                    if (lblPlayer1turn.Visible == true)
                    {
                        player1Result += 20;
                        MessageBox.Show("The answer of B is correct.");
                        Bresult = 1;
                    }
                    else if (lblPlayer2turn.Visible == true)
                    {
                        player2Result += 20;
                        MessageBox.Show("The answer of B is correct.");
                        Bresult = 1;
                    }
                }
                else
                {
                    txtZgjedhjaBplay.Text = "";
                    break;
                }
            }
            while (Cresult == 0)
            {
                if (Assosiation.zgjedhjaC.ToLower() == txtZgjedhjaCplay.Text.ToLower())
                {
                    textC();

                    if (lblPlayer1turn.Visible == true)
                    {
                        player1Result += 20;
                        MessageBox.Show("The answer of C is correct.");
                        Cresult = 1;
                    }
                    else if (lblPlayer2turn.Visible == true)
                    {
                        player2Result += 20;
                        MessageBox.Show("The answer of C is correct.");
                        Cresult = 1;
                    }
                }
                else
                {
                    txtZgjedhjaCplay.Text = "";
                    break;
                }
            }
            while (Dresult == 0)
            {
                if (Assosiation.zgjedhjaD.ToLower() == txtZgjedhjaDplay.Text.ToLower())
                {
                    textD();

                    if (lblPlayer1turn.Visible == true)
                    {
                        player1Result += 20;
                        MessageBox.Show("The answer of D is correct.");
                        Dresult = 1;
                    }
                    else if (lblPlayer2turn.Visible == true)
                    {
                        player2Result += 20;
                        MessageBox.Show("The answer of D is correct.");
                        Dresult = 1;
                    }
                }
                else
                {
                    txtZgjedhjaDplay.Text = "";
                    break;
                }
            }
            while (finalresult == 0) //edhe final njejt si zgjedhjet tjera
            {
                if (Assosiation.Final.ToLower() == txtFinalplay.Text.ToLower())
                {
                    textA();
                    textB();
                    textC();
                    textD();
                    textzgjedhjet();

                    if (lblPlayer1turn.Visible == true)
                    {
                        player1Result += 50;
                        finalresult = 1;
                    }
                    else if (lblPlayer2turn.Visible == true)
                    {
                        player2Result += 50;
                        finalresult = 1;
                    }
                    if (player1Result > player2Result) //cili lojtar fiton
                    {
                        MessageBox.Show("The final answer is correct.\nThe winner is " + lblplayPlayer1.Text + " with " + player1Result + " points.");
                        Environment.Exit(0);
                    }
                    else
                    {
                        MessageBox.Show("The final answer is correct.\nThe winner is " + lblplayPlayer2.Text + " with " + player2Result + " points.");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    txtFinalplay.Text = "";
                    break;
                }
            }
            while(finalresult == 0)//kjo eshte perafesisht e njejt si ato lart, funskionon nese njera prej zgjedhjeve osht e sakt nuk e qet edhe mesazhin qe osht incorrect, mesazhi incorrect del veq nese pergjigjjen qe e kena jap eshte gabim ose nuk shenojna kurgjo.
            {
                if (Assosiation.zgjedhjaA.ToLower() == txtZgjedhjaAplay.Text.ToLower() && Aresult == 1)
                {
                    Aresult = 2; //i kom perdor tnjejtat pershkak se kur njeher bohet true edhe i provojna zgjidhjet tjera me u shfaq mesazhi incorrect logjika e njejt si ato lart.
                    break;
                }
                else if (Assosiation.zgjedhjaB.ToLower() == txtZgjedhjaBplay.Text.ToLower() && Bresult == 1)
                {
                    Bresult = 2;
                    break;
                }
                else if (Assosiation.zgjedhjaC.ToLower() == txtZgjedhjaCplay.Text.ToLower() && Cresult == 1)
                {
                    Cresult = 2;
                    break;
                }
                else if (Assosiation.zgjedhjaD.ToLower() == txtZgjedhjaDplay.Text.ToLower() && Dresult == 1)
                {
                    Dresult = 2;
                    break;
                }
                else
                {
                    MessageBox.Show("The answer is incorrect.");
                    break;
                }
            }
        }
        //per mos mi shenu shum her kto vlera i kom bo krejt naper metoda. kto i kom perdor vetem per ato nese e gjejna zgjidhjen para se mi hap zgjidhjet tjera ose pa i hap krejt labels.
        public void textA()
        {
            lblA1.Text = Assosiation.a1;
            lblA2.Text = Assosiation.a2;
            lblA3.Text = Assosiation.a3;
            lblA4.Text = Assosiation.a4;
            lblA1.Enabled = false;
            lblA2.Enabled = false;
            lblA3.Enabled = false;
            lblA4.Enabled = false;
        }
        public void textB()
        {
            lblB1.Text = Assosiation.b1;
            lblB2.Text = Assosiation.b2;
            lblB3.Text = Assosiation.b3;
            lblB4.Text = Assosiation.b4;
            lblB1.Enabled = false;
            lblB2.Enabled = false;
            lblB3.Enabled = false;
            lblB4.Enabled = false;
        }
        public void textC()
        {
            lblC1.Text = Assosiation.c1;
            lblC2.Text = Assosiation.c2;
            lblC3.Text = Assosiation.c3;
            lblC4.Text = Assosiation.c4;
            lblC1.Enabled = false;
            lblC2.Enabled = false;
            lblC3.Enabled = false;
            lblC4.Enabled = false;
        }
        public void textD()
        {
            lblD1.Text = Assosiation.d1;
            lblD2.Text = Assosiation.d2;
            lblD3.Text = Assosiation.d3;
            lblD4.Text = Assosiation.d4;
            lblD1.Enabled = false;
            lblD2.Enabled = false;
            lblD3.Enabled = false;
            lblD4.Enabled = false;
        }
        public void textzgjedhjet()
        {
            txtZgjedhjaAplay.Text = Assosiation.zgjedhjaA;
            txtZgjedhjaBplay.Text = Assosiation.zgjedhjaB;
            txtZgjedhjaCplay.Text = Assosiation.zgjedhjaC;
            txtZgjedhjaDplay.Text = Assosiation.zgjedhjaD;
        }
    }
}

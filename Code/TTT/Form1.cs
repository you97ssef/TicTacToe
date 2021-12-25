using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace TTT
{
    public partial class Form1 : Form
    {
        char[] champs = new char[9];
        Random rd = new Random();
        List<int> nonavailable = new List<int>();
        int ps, cs = 0;

        int generaterandomchoice()
        {
            int i = rd.Next(1, 10);
            while(nonavailable.Contains(i) && nonavailable.Count < 9)
            {
                i = rd.Next(1, 10);
            }
            return i;
        }
        bool b = false;
        bool check()
        {
            if (champs[0] == champs[1] && champs[1] == champs[2] && champs[0] != ' ' && winlabel.Text == "")
            {
                //Win 
                if (champs[0] == 'X')
                {
                    winlabel.Text = "Player win!";
                    winlabel.Visible = true;
                    ps++;
                    button10.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label5.Text = ps.ToString();
                }
                else
                {
                    winlabel.Text = "Computer win!";
                    winlabel.Visible = true;
                    cs++;
                    button10.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label4.Text = cs.ToString();
                }
                return true;
            }
            else if (champs[3] == champs[4] && champs[4] == champs[5] && champs[3] != ' ' && winlabel.Text == "")
            {
                //Win
                if (champs[3] == 'X')
                {
                    winlabel.Text = "Player win!";
                    winlabel.Visible = true;
                    ps++;
                    button10.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label5.Text = ps.ToString();
                }
                else
                {
                    winlabel.Text = "Computer win!";
                    winlabel.Visible = true;
                    cs++;
                    button10.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label4.Text = cs.ToString();
                }
                return true;
            }
            else if (champs[6] == champs[7] && champs[7] == champs[8] && champs[6] != ' ' && winlabel.Text == "")
            {
                //Win
                if (champs[6] == 'X')
                {
                    winlabel.Text = "Player win!";
                    winlabel.Visible = true;
                    ps++;
                    button10.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label5.Text = ps.ToString();
                }
                else
                {
                    winlabel.Text = "Computer win!";
                    winlabel.Visible = true;
                    cs++;
                    button10.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label4.Text = cs.ToString();
                }
                return true;
            }
            else if (champs[0] == champs[3] && champs[3] == champs[6] && champs[0] != ' ' && winlabel.Text == "")
            {
                //Win
                if (champs[0] == 'X')
                {
                    winlabel.Text = "Player win!";
                    winlabel.Visible = true;
                    ps++;
                    button10.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label5.Text = ps.ToString();
                }
                else
                {
                    winlabel.Text = "Computer win!";
                    winlabel.Visible = true;
                    cs++;
                    button10.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label4.Text = cs.ToString();
                }
                return true;
            }
            else if (champs[1] == champs[4] && champs[4] == champs[7] && champs[1] != ' ' && winlabel.Text == "")
            {
                //Win
                if (champs[1] == 'X')
                {
                    winlabel.Text = "Player win!";
                    winlabel.Visible = true;
                    ps++;
                    button10.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label5.Text = ps.ToString();
                }
                else
                {
                    winlabel.Text = "Computer win!";
                    winlabel.Visible = true;
                    cs++;
                    button10.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label4.Text = cs.ToString();
                }
                return true;
            }
            else if (champs[2] == champs[5] && champs[5] == champs[8] && champs[2] != ' ' && winlabel.Text == "")
            {
                //Win
                if (champs[2] == 'X')
                {
                    winlabel.Text = "Player win!";
                    winlabel.Visible = true;
                    ps++;
                    button10.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label5.Text = ps.ToString();
                }
                else
                {
                    winlabel.Text = "Computer win!";
                    winlabel.Visible = true;
                    cs++;
                    button10.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label4.Text = cs.ToString();
                }
                return true;
            }
            else if (champs[0] == champs[4] && champs[4] == champs[8] && champs[0] != ' ' && winlabel.Text == "")
            {
                //Win
                if (champs[0] == 'X')
                {
                    winlabel.Text = "Player win!";
                    winlabel.Visible = true;
                    ps++;
                    button10.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label5.Text = ps.ToString();
                }
                else
                {
                    winlabel.Text = "Computer win!";
                    winlabel.Visible = true;
                    cs++;
                    button10.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label4.Text = cs.ToString();
                }
                return true;
            }
            else if (champs[2] == champs[4] && champs[4] == champs[6] && champs[2] != ' ' && winlabel.Text == "")
            {
                //Win
                if (champs[2] == 'X')
                {
                    winlabel.Text = "Player win!";
                    winlabel.Visible = true;
                    ps++;
                    button10.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label5.Text = ps.ToString();
                }
                else
                {
                    winlabel.Text = "Computer win!";
                    winlabel.Visible = true;
                    cs++;
                    button10.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    label4.Text = cs.ToString();
                }
                return true;
            }
            else if (nonavailable.Count >= 9 && winlabel.Text == "")
            {
                //tie
                winlabel.Text = "It's a tie!";
                winlabel.Visible = true;
                button10.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nonavailable.Add(1);
            button1.Enabled = false;
            champs[0] = 'X';
            button1.Text = "X";
            b = check();
            if (!b)
            {
                int i = generaterandomchoice();
                champs[i - 1] = 'O';
                nonavailable.Add(i);
                switch (i)
                {
                    case 1:
                        button1.Text = "O";
                        button1.Enabled = false;
                        break;
                    case 2:
                        button2.Text = "O";
                        button2.Enabled = false;
                        break;
                    case 3:
                        button3.Text = "O";
                        button3.Enabled = false;
                        break;
                    case 4:
                        button4.Text = "O";
                        button4.Enabled = false;
                        break;
                    case 5:
                        button5.Text = "O";
                        button5.Enabled = false;
                        break;
                    case 6:
                        button6.Text = "O";
                        button6.Enabled = false;
                        break;
                    case 7:
                        button7.Text = "O";
                        button7.Enabled = false;
                        break;
                    case 8:
                        button8.Text = "O";
                        button8.Enabled = false;
                        break;
                    case 9:
                        button9.Text = "O";
                        button9.Enabled = false;
                        break;
                }
                check();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            nonavailable.Add(7);
            button7.Enabled = false;
            champs[6] = 'X';
            button7.Text = "X";
            b = check();
            if (!b)
            {
                int i = generaterandomchoice();
                champs[i - 1] = 'O';
                nonavailable.Add(i);
                switch (i)
                {
                    case 1:
                        button1.Text = "O";
                        button1.Enabled = false;
                        break;
                    case 2:
                        button2.Text = "O";
                        button2.Enabled = false;
                        break;
                    case 3:
                        button3.Text = "O";
                        button3.Enabled = false;
                        break;
                    case 4:
                        button4.Text = "O";
                        button4.Enabled = false;
                        break;
                    case 5:
                        button5.Text = "O";
                        button5.Enabled = false;
                        break;
                    case 6:
                        button6.Text = "O";
                        button6.Enabled = false;
                        break;
                    case 7:
                        button7.Text = "O";
                        button7.Enabled = false;
                        break;
                    case 8:
                        button8.Text = "O";
                        button8.Enabled = false;
                        break;
                    case 9:
                        button9.Text = "O";
                        button9.Enabled = false;
                        break;
                }
                check();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nonavailable.Add(2);
            button2.Enabled = false;
            champs[1] = 'X';
            button2.Text = "X";
            b = check();
            if (!b)
            {
                int i = generaterandomchoice();
                champs[i - 1] = 'O';
                nonavailable.Add(i);
                switch (i)
                {
                    case 1:
                        button1.Text = "O";
                        button1.Enabled = false;
                        break;
                    case 2:
                        button2.Text = "O";
                        button2.Enabled = false;
                        break;
                    case 3:
                        button3.Text = "O";
                        button3.Enabled = false;
                        break;
                    case 4:
                        button4.Text = "O";
                        button4.Enabled = false;
                        break;
                    case 5:
                        button5.Text = "O";
                        button5.Enabled = false;
                        break;
                    case 6:
                        button6.Text = "O";
                        button6.Enabled = false;
                        break;
                    case 7:
                        button7.Text = "O";
                        button7.Enabled = false;
                        break;
                    case 8:
                        button8.Text = "O";
                        button8.Enabled = false;
                        break;
                    case 9:
                        button9.Text = "O";
                        button9.Enabled = false;
                        break;
                }
                check();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            nonavailable.Add(8);
            button8.Enabled = false;
            champs[7] = 'X';
            button8.Text = "X";
            b = check();
            if (!b)
            {
                int i = generaterandomchoice();
                champs[i - 1] = 'O';
                nonavailable.Add(i);
                switch (i)
                {
                    case 1:
                        button1.Text = "O";
                        button1.Enabled = false;
                        break;
                    case 2:
                        button2.Text = "O";
                        button2.Enabled = false;
                        break;
                    case 3:
                        button3.Text = "O";
                        button3.Enabled = false;
                        break;
                    case 4:
                        button4.Text = "O";
                        button4.Enabled = false;
                        break;
                    case 5:
                        button5.Text = "O";
                        button5.Enabled = false;
                        break;
                    case 6:
                        button6.Text = "O";
                        button6.Enabled = false;
                        break;
                    case 7:
                        button7.Text = "O";
                        button7.Enabled = false;
                        break;
                    case 8:
                        button8.Text = "O";
                        button8.Enabled = false;
                        break;
                    case 9:
                        button9.Text = "O";
                        button9.Enabled = false;
                        break;
                }
                check();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nonavailable.Add(3);
            button3.Enabled = false;
            champs[2] = 'X';
            button3.Text = "X";
            b = check();
            if (!b)
            {
                int i = generaterandomchoice();
                champs[i - 1] = 'O';
                nonavailable.Add(i);
                switch (i)
                {
                    case 1:
                        button1.Text = "O";
                        button1.Enabled = false;
                        break;
                    case 2:
                        button2.Text = "O";
                        button2.Enabled = false;
                        break;
                    case 3:
                        button3.Text = "O";
                        button3.Enabled = false;
                        break;
                    case 4:
                        button4.Text = "O";
                        button4.Enabled = false;
                        break;
                    case 5:
                        button5.Text = "O";
                        button5.Enabled = false;
                        break;
                    case 6:
                        button6.Text = "O";
                        button6.Enabled = false;
                        break;
                    case 7:
                        button7.Text = "O";
                        button7.Enabled = false;
                        break;
                    case 8:
                        button8.Text = "O";
                        button8.Enabled = false;
                        break;
                    case 9:
                        button9.Text = "O";
                        button9.Enabled = false;
                        break;
                }
                check();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            nonavailable.Add(9);
            button9.Enabled = false;
            champs[8] = 'X';
            button9.Text = "X";
            b = check();
            if (!b)
            {
                int i = generaterandomchoice();
                champs[i - 1] = 'O';
                nonavailable.Add(i);
                switch (i)
                {
                    case 1:
                        button1.Text = "O";
                        button1.Enabled = false;
                        break;
                    case 2:
                        button2.Text = "O";
                        button2.Enabled = false;
                        break;
                    case 3:
                        button3.Text = "O";
                        button3.Enabled = false;
                        break;
                    case 4:
                        button4.Text = "O";
                        button4.Enabled = false;
                        break;
                    case 5:
                        button5.Text = "O";
                        button5.Enabled = false;
                        break;
                    case 6:
                        button6.Text = "O";
                        button6.Enabled = false;
                        break;
                    case 7:
                        button7.Text = "O";
                        button7.Enabled = false;
                        break;
                    case 8:
                        button8.Text = "O";
                        button8.Enabled = false;
                        break;
                    case 9:
                        button9.Text = "O";
                        button9.Enabled = false;
                        break;
                }
                check();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nonavailable.Add(6);
            button6.Enabled = false;
            champs[5] = 'X';
            button6.Text = "X";
            b = check();
            if (!b)
            {
                int i = generaterandomchoice();
                champs[i - 1] = 'O';
                nonavailable.Add(i);
                switch (i)
                {
                    case 1:
                        button1.Text = "O";
                        button1.Enabled = false;
                        break;
                    case 2:
                        button2.Text = "O";
                        button2.Enabled = false;
                        break;
                    case 3:
                        button3.Text = "O";
                        button3.Enabled = false;
                        break;
                    case 4:
                        button4.Text = "O";
                        button4.Enabled = false;
                        break;
                    case 5:
                        button5.Text = "O";
                        button5.Enabled = false;
                        break;
                    case 6:
                        button6.Text = "O";
                        button6.Enabled = false;
                        break;
                    case 7:
                        button7.Text = "O";
                        button7.Enabled = false;
                        break;
                    case 8:
                        button8.Text = "O";
                        button8.Enabled = false;
                        break;
                    case 9:
                        button9.Text = "O";
                        button9.Enabled = false;
                        break;
                }
                check();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nonavailable.Add(4);
            button4.Enabled = false;
            champs[3] = 'X';
            button4.Text = "X";
            b = check();
            if (!b)
            {
                int i = generaterandomchoice();
                champs[i - 1] = 'O';
                nonavailable.Add(i);
                switch (i)
                {
                    case 1:
                        button1.Text = "O";
                        button1.Enabled = false;
                        break;
                    case 2:
                        button2.Text = "O";
                        button2.Enabled = false;
                        break;
                    case 3:
                        button3.Text = "O";
                        button3.Enabled = false;
                        break;
                    case 4:
                        button4.Text = "O";
                        button4.Enabled = false;
                        break;
                    case 5:
                        button5.Text = "O";
                        button5.Enabled = false;
                        break;
                    case 6:
                        button6.Text = "O";
                        button6.Enabled = false;
                        break;
                    case 7:
                        button7.Text = "O";
                        button7.Enabled = false;
                        break;
                    case 8:
                        button8.Text = "O";
                        button8.Enabled = false;
                        break;
                    case 9:
                        button9.Text = "O";
                        button9.Enabled = false;
                        break;
                }
                check();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 9; i++)
            {
                champs[i] = ' ';
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            for (int i = 0; i < 9; i++)
            {
                champs[i] = ' ';
            }
            button10.Enabled = false;
            nonavailable.Clear();

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            winlabel.Text = "";
            winlabel.Visible = false;
            b = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                champs[i] = ' ';
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

            nonavailable.Clear();
            ps = 0;
            cs = 0;
            label4.Text = "0";
            label5.Text = "0";
            button10.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            b = false;
            winlabel.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            nonavailable.Add(5);
            button5.Enabled = false;
            champs[4] = 'X';
            button5.Text = "X";
            b = check();
            if (!b)
            {
                int i = generaterandomchoice();
                champs[i - 1] = 'O';
                nonavailable.Add(i);
                switch (i)
                {
                    case 1:
                        button1.Text = "O";
                        button1.Enabled = false;
                        break;
                    case 2:
                        button2.Text = "O";
                        button2.Enabled = false;
                        break;
                    case 3:
                        button3.Text = "O";
                        button3.Enabled = false;
                        break;
                    case 4:
                        button4.Text = "O";
                        button4.Enabled = false;
                        break;
                    case 5:
                        button5.Text = "O";
                        button5.Enabled = false;
                        break;
                    case 6:
                        button6.Text = "O";
                        button6.Enabled = false;
                        break;
                    case 7:
                        button7.Text = "O";
                        button7.Enabled = false;
                        break;
                    case 8:
                        button8.Text = "O";
                        button8.Enabled = false;
                        break;
                    case 9:
                        button9.Text = "O";
                        button9.Enabled = false;
                        break;
                }
                check();
            }
        }
    }
}

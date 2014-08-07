using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8PuzzaleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button1.Text;
                button2.BackColor = Color.White;
                button1.Text = "";
                button1.BackColor = Color.Gray;

            }
            if (button4.Text == "")
            {
                button4.Text = button1.Text;
                button4.BackColor = Color.White;
                button1.Text = "";
                button1.BackColor = Color.Gray;
            }
            Finish();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button2.Text;
                button1.BackColor = Color.White;
                button2.Text = "";
                button2.BackColor = Color.Gray;
            }
            if (button3.Text == "")
            {
                button3.Text = button2.Text;
                button3.BackColor = Color.White;
                button2.Text = "";
                button2.BackColor = Color.Gray;
            }

            if (button5.Text == "")
            {
                button5.Text = button2.Text;
                button5.BackColor = Color.White;
                button2.Text = "";
                button2.BackColor = Color.Gray;
            }
            Finish();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button3.Text;
                button2.BackColor = Color.White;
                button3.Text = "";
                button3.BackColor = Color.Gray;
                
            }
            if (button6.Text == "")
            {
                button6.Text = button3.Text;
                button6.BackColor = Color.White;
                button3.Text = "";
                button3.BackColor = Color.Gray;

            }
            Finish();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button4.Text;
                button1.BackColor = Color.White;
                button4.Text = "";
                button4.BackColor = Color.Gray;

            }
            if (button5.Text == "")
            {
                button5.Text = button4.Text;
                button5.BackColor = Color.White;
                button4.Text = "";
                button4.BackColor = Color.Gray;

            }
            if (button7.Text == "")
            {
                button7.Text = button4.Text;
                button7.BackColor = Color.White;
                button4.Text = "";
                button4.BackColor = Color.Gray;

            }
            Finish();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button5.Text;
                button2.BackColor = Color.White;
                button5.Text = "";
                button5.BackColor = Color.Gray;

            }
            if (button4.Text == "")
            {
                button4.Text = button5.Text;
                button4.BackColor = Color.White;
                button5.Text = "";
                button5.BackColor = Color.Gray;

            }
            if (button6.Text == "")
            {
                button6.Text = button5.Text;
                button6.BackColor = Color.White;
                button5.Text = "";
                button5.BackColor = Color.Gray;

            }
            if (button8.Text == "")
            {
                button8.Text = button5.Text;
                button8.BackColor = Color.White;
                button5.Text = "";
                button5.BackColor = Color.Gray;

            }
            Finish();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = button6.Text;
                button3.BackColor = Color.White;
                button6.Text = "";
                button6.BackColor = Color.Gray;

            }
            if (button5.Text == "")
            {
                button5.Text = button6.Text;
                button5.BackColor = Color.White;
                button6.Text = "";
                button6.BackColor = Color.Gray;

            }
            if (button9.Text == "")
            {
                button9.Text = button6.Text;
                button9.BackColor = Color.White;
                button6.Text = "";
                button6.BackColor = Color.Gray;

            }
            Finish();



        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = button7.Text;
                button4.BackColor = Color.White;
                button7.Text = "";
                button7.BackColor = Color.Gray;

            }
            if (button8.Text == "")
            {
                button8.Text = button7.Text;
                button8.BackColor = Color.White;
                button7.Text = "";
                button7.BackColor = Color.Gray;

            }
            Finish();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = button8.Text;
                button5.BackColor = Color.White;
                button8.Text = "";
                button8.BackColor = Color.Gray;

            }
            if (button7.Text == "")
            {
                button7.Text = button8.Text;
                button7.BackColor = Color.White;
                button8.Text = "";
                button8.BackColor = Color.Gray;

            }
            if (button9.Text == "")
            {
                button9.Text = button8.Text;
                button9.BackColor = Color.White;
                button8.Text = "";
                button8.BackColor = Color.Gray;

            }
            Finish();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = button9.Text;
                button6.BackColor = Color.White;
                button9.Text = "";
                button9.BackColor = Color.Gray;

            }
            if (button8.Text == "")
            {
                button8.Text = button9.Text;
                button8.BackColor = Color.White;
                button9.Text = "";
                button9.BackColor = Color.Gray;

            }
            Finish();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
     
        int countMin = 1;
        int countSec = 60;
        int flag = 1;
        private void timer2_Tick(object sender, EventArgs e)
        {
            GetTimer();
        }

        private int setMin = 1;
        private void GetTimer()
        {
            
            if (flag == 1)
            {
                countMin -= 1;
                minLebel.Text = countMin.ToString();
                flag++;
            }
            countSec -= 1;
            secLabel.Text = countSec.ToString();
            if (countSec == 0)
            {
                countMin -= 1;
                minLebel.Text = countMin.ToString();
                if (countMin < 0)
                {
                    timer2.Stop();

                    MessageBox.Show("GAME OVER");
                    // Form1.BackColor = Color.Red;
                }
                countSec = 60;
            }
        }

        private void reshuffleButton_Click(object sender, EventArgs e)
        {
            ReShuffle();
        }

        private void ReShuffle()
        {
            int[] rndValue = new int[8];
            Random randNum = new Random();

            // Create an ArrayList object that will hold the numbers
            ArrayList lstNumbers = new ArrayList();
            // The Random class will be used to generate numbers
            Random rndNumber = new Random();

            // Generate a random number between 1 and the Max
            int number = rndNumber.Next(1, 9);
            // Add this first random number to the list
            lstNumbers.Add(number);
            // Set a count of numbers to 0 to start
            int count = 0;

            do // Repeatedly...
            {
                // ... generate a random number between 1 and the Max
                number = rndNumber.Next(1, 9);

                // If the newly generated number in not yet in the list...
                if (!lstNumbers.Contains(number))
                {
                    // ... add it
                    lstNumbers.Add(number);
                }

                // Increase the count
                count++;
            } while (count <= 10*8); // Do that again

            button1.Text = (lstNumbers[0]).ToString();
            button1.BackColor = Color.White;
            button2.Text = (lstNumbers[1]).ToString();
            button2.BackColor = Color.White;
            button3.Text = (lstNumbers[2]).ToString();
            button3.BackColor = Color.White;
            button4.Text = lstNumbers[3].ToString();
            button4.BackColor = Color.White;
            button5.Text = (lstNumbers[4]).ToString();
            button5.BackColor = Color.White;
            button6.Text = (lstNumbers[5]).ToString();
            button6.BackColor = Color.White;
            button7.Text = (lstNumbers[6]).ToString();
            button9.BackColor = Color.White;
            button8.Text = (lstNumbers[7]).ToString();
            button8.BackColor = Color.White;
            button9.Text = "";
            button9.BackColor = Color.Gray;
            countMin = setMin;
            countSec = 60;
            flag = 1;
            timer2.Start();
        }


        public void Finish()
        {
            if(button1.Text =="1")
                if(button2.Text =="2")
                    if(button3.Text =="3")
                        if(button4.Text =="4")
                            if(button5.Text =="5")
                                if(button6.Text =="6")
                                    if(button7.Text =="7")
                                        if (button8.Text == "8")
                                        {
                                            timer2.Stop();
                                            MessageBox.Show("CONGRATULATIONS! You won/n Remaning Time:" + countMin + ":" +
                                                            countSec);
                                            
                                        }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReShuffle();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setMin = 1;
            countMin = setMin;
            ReShuffle();
        }

        private void minToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            setMin = 2;
            countMin = setMin;
            ReShuffle();

        }

        private void minToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            setMin = 3;
            countMin = setMin;
            ReShuffle();
        }

        private void minToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            setMin = 5;
            countMin = setMin;
            ReShuffle();
        }
        
        
    }
    }


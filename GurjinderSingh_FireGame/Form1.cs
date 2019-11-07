using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GurjinderSingh_FireGame
{
    public partial class Form1 : Form
    {
        //global variable to work with the game and pass the working 
        int trigger = 0;
        int clk = 0, fire = 0, chance = 0,chance1=0, clk2 = 0;
        //obj of the 
        mainClass obj_class = new mainClass();

        public Form1()
        {
            InitializeComponent();
            //fetching the no of the trigger to fire 
            fire = obj_class.clik(1,3);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // starting the game of the fire 
            trigger++;
            pb.Image = Resource1.new1;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // code for loading the bullet in the gun
            trigger++;
            pb.Image = Resource1.new2;
            button2.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this code is used to exit from the game this is not compulsory to exit at last you can exit at anytime 
            System.Environment.Exit(0);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (trigger==3) {
                clk2++;
                if (clk2==fire) {
                    // generate the sound of the  fire trigger 
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resource1.fire);
                    player.Play();
                    chance1++;
                    // when the user used his 2 bullets then show the message box and change the color of label 
                    if (clk2 == 1)
                    {
                        b1.BackColor = Color.Green;
                    }
                    if (clk2 == 2)
                    {
                        b2.BackColor = Color.Green;
                    }
                    if (clk2 == 3)
                    {
                        b3.BackColor = Color.Green;
                    }
                    if (clk2 == 4)
                    {
                        b4.BackColor = Color.Green;
                    }
                    if (clk2 == 5)
                    {
                        b5.BackColor = Color.Green;
                    }
                    if (clk2 == 6)
                    {
                        b6.BackColor = Color.Green;
                    }

                    // code to fetch the 2nd trigger 
                    fire = obj_class.clik(3, 6);
                }

                // when the user click on button six  times then frst alert will show 
                if (clk2 == 6)
                {
                   
                    //when the 2nd chance is over 
                    if (chance1 >=1)
                    {
                        MessageBox.Show("Your chances are over now ");
                        button6.Enabled = false;
                    }

                    //reset all the variable 
                    b1.BackColor = Color.Gray;
                    b2.BackColor = Color.Gray;
                    b3.BackColor = Color.Gray;
                    b4.BackColor = Color.Gray;
                    b5.BackColor = Color.Gray;
                    b6.BackColor = Color.Gray;
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // code to spin the bullet for fire for better perfomrance like shoot 
            trigger++;
            pb.Image = Resource1.new3;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // shoot code is used to trigger the gun after following the upper button like clk on all the button 
            if (trigger==3) {
                clk++;
                //when the value of click and fire equal then it will generate the sound of fire 
                if (clk==fire) {

                    // generate the sound of the  fire trigger 
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resource1.fire);
                    player.Play();

                    // when the user used his 2 bullets then show the message box and change the color of label 
                    if (clk==1) {
                        b1.BackColor = Color.Green;
                    }
                    if (clk == 2)
                    {
                        b2.BackColor = Color.Green;
                    }
                    if (clk == 3)
                    {
                        b3.BackColor = Color.Green;
                    }
                    if (clk == 4)
                    {
                        b4.BackColor = Color.Green;
                    }
                    if (clk == 5)
                    {
                        b5.BackColor = Color.Green;
                    }
                    if (clk == 6)
                    {
                        b6.BackColor = Color.Green;
                    }

                    // code to fetch the 2nd trigger 
                    fire = obj_class.clik(3, 6);
                }

                // when the user click on button six  times then frst alert will show 
                if (clk==6) {
                    chance++;
                    //when frst chance is over 
                    if (chance==1) {
                        MessageBox.Show("First chance is over now \n this is your last chance ");
                        fire = obj_class.clik(1, 3);
                        clk = 0;  
                    }
                    //when the 2nd chance is over 
                    if (chance==2) {
                        MessageBox.Show("Your chances are over now ");
                        button4.Enabled = false;
                    }

                    //reset all the variable 
                    b1.BackColor = Color.Gray;
                    b2.BackColor = Color.Gray;
                    b3.BackColor = Color.Gray;
                    b4.BackColor = Color.Gray;
                    b5.BackColor = Color.Gray;
                    b6.BackColor = Color.Gray;
                }

            }
        }
    }
}

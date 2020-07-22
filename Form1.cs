using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//-------------------------------------------------------------------------------------------------------
			            /* Class 2 Checkpoint / Polly's Pizza Parlour */
//-------------------------------------------------------------------------------------------------------

/* Program name: 	    Class 2 CheckPoint - Polly's Pizza Parlour
   Project file name:   class2checkpoint
   Author:		        Kylie Blair
   Date:	            22/07/2020
   Language:		    C#
   Platform:		    Microsoft Visual Studio 2019
   Purpose:		        Allows the user to select the pizza options they desire. Totals the cost,
                        and clears the form.

   Description:		    The form has options via radio buttons and checkboxes. The user 
                        selects what options they would like, then they can click on preview to see a 
                        picutre of the pizza they want. When ready, they can click place order which 
                        brings up the total price. If the user makes a mistake they can click the clear 
                        order button to clear the listbox.

   Known Bugs:		    I did have some bugs, mainly just typos which I fixed. Code compiles.

   Additional Features: I added preview photos for each pizza, plus some extra options. I also
                        added a dedicated clear button. I also created a logo in photoshop.
*/
 
 //------------------------------------------------------------------------------------------------------
			
//-------------------------------------------------------------------------------------------------------

namespace class2checkpoint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                pictureBox2.Image = Properties.Resources.chick;
            }

            if (radioButton6.Checked == true)
            {
                pictureBox2.Image = Properties.Resources.meat;
            }

            if (radioButton7.Checked == true)
            {
                pictureBox2.Image = Properties.Resources.hawaii;
            }

            if (radioButton8.Checked == true)
            {
                pictureBox2.Image = Properties.Resources.vege;
            }
        }
        private void radioButton2_Click(object sender, EventArgs e)
        {
            double large = 10.00;
            listBox1.Items.Add("Large $" + large);
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            double small = 5.00;
            listBox1.Items.Add("Small $" + small);
        }
        public void checkBox1_Click(object sender, EventArgs e)
        {

            double check1 = 2.00;
            listBox1.Items.Add("With Extra Cheese $" + check1);

        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Gourmet Chicken Pizza");
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("MeatLovers Pizza");
        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Hawaiian Pizza");
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add("Trio O' Vege Pizza");
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            double check2 = 2.00;
            listBox1.Items.Add("With Extra Italian Sausage $" + check2);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            double check3 = 1.00;
            listBox1.Items.Add("With Extra Mushroom $" + check3);
        }

        private void checkBox4_CheckStateChanged(object sender, EventArgs e)
        {
            double check4 = 2.00;
            listBox1.Items.Add("With Extra Bacon $" + check4);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            double check5 = 1.00;
            listBox1.Items.Add("With Extra Olives $" + check5);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add("Thin Base");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add("Deep Pan Base");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalSum();
        }

        private void totalSum()
        {
            double total = 0;
            double check1 = 2.00;
            double check2 = 1.00;

            if (radioButton1.Checked == true)
            {
                total = 5.00;
            }

            if (radioButton2.Checked == true)
            {
                total = 10.00;
            }

            if (checkBox1.Checked == true)
            {
                total = total + check1;
                check1++;
            }

            if (checkBox2.Checked == true)
            {
                total = total + check1;
                check1++;
            }

            if (checkBox3.Checked == true)
            {
                total = total + check2;
                check2++;
            }

            if (checkBox4.Checked == true)
            {
                total = total + check1;
                check1++;
            }

            if (checkBox5.Checked == true)
            {
                total = total + check2;
                check2++;
            }

            listBox1.Items.Add("Your total cost is $" + total);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}

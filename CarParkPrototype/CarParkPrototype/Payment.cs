using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkPrototype
{
    public partial class Payment : Form
    {
        int counter = 0;
        bool enterCoinValid = false;
        bool enterCoinInvalid = false;
        bool discountValid = false;
        bool discountInvalid = false;
        bool enterCoin = false;
        bool valid1 = false;
        bool pay = false;
        
        public Payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Checking coin";
            if (enterCoinValid)
            {
                enterCoin = true;
                textBox1.Text = "Valid Coin, continue with payment";
                button1.Visible = false;
                button7.Visible = false;
                button6.Visible = false;
                
                button8.Visible = false;
                button9.Visible = true;
            }
            else if (enterCoinInvalid)
            {
                enterCoin = false;
                textBox1.Text = "Invalid Coin, please try again";
                button1.Visible = false;
                button7.Visible = true;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (enterCoin)
            {
                textBox2.Visible = true;
                if (discountValid) //discount card is valid
                {
                    textBox2.Text = "Checking Card";
                    textBox2.Refresh();
                    System.Threading.Thread.Sleep(2000);
                    textBox2.Text = "Discount Valid";
                    discountValid = false;
                    textBox3.Text = "£0.50";
                    textBox4.Text = "£1.50";
                    textBox5.Text = "£2.50";
                    textBox6.Text = "£3.00";
                    textBox7.Text = "£4.00";
                }
                else if (discountInvalid)    //invalid discount card
                {
                    textBox2.Text = "Checking Card";
                    textBox2.Refresh();
                    System.Threading.Thread.Sleep(2000);
                    textBox2.Text = "Card not valid";
                    discountInvalid = false;
                }
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            enterCoinValid = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            enterCoinInvalid = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            discountValid = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            discountInvalid = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button5.Visible = false;
            button3.Visible = true;
            button4.Visible = true;
            button2.Visible = true;
            textBox2.Visible = true;
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (counter >= 2)
            {
                if (valid1)
                {
                    textBox1.Text = "Invalid Coin, please seek assistance";
                }
                else
                {
                    enterCoinInvalid = false;
                    enterCoinValid = true;
                    button7.Visible = false; 
                    button1.Visible = true;
                }
            }
            else
            {
                             
                textBox1.Text = "Invalid Coin, please try again";
                counter++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
             enterCoinInvalid = true;
             valid1 = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Payment Complete, Please take coin";
            pay = true;
            button9.Visible = false;
            button1.Visible = true;
            button6.Visible = true;
            button8.Visible = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (pay)
            {
                MessageBox.Show("Payment complete", "Payment", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
            {
                MessageBox.Show("Payment Cancelled", "Payment", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

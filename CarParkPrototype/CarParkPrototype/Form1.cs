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
    public partial class Form1 : Form
    {
        int avaiableSpaces = 10;
        int MaxSpaces = 10;
        public bool Exit1, Exit2, Exit3, Exit4, Exit5;
        int payCounter = 0;
        bool NormalSituation, NormalSituation2;
        int pressCount = 0;
        int counter = 0;
        int Emergency1 = 0;
        int Emergency2 = 0;
        int Emergency3 = 0;

        public Form1()
        {
            InitializeComponent();
            Exit1 = true;
            Exit2 = true;
            Exit3 = true;
            Exit4 = false;
            Exit5 = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            avaiableSpaces -= 1;
            if (avaiableSpaces >= 0)
            {               
                String textChange = Convert.ToString(avaiableSpaces);
                textBox1.Text = textChange;
                textBox2.Text = "Down";
                button1.Visible = false;
                button9.Visible = true;
            }
            if (avaiableSpaces == 0)
            {
                button1.Text = "CarPark is full";
                button1.Visible = true;
                button9.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {        
            if(Exit1 && (payCounter > 0) )
            {                
                button2.Visible = false;
                button19.Visible = true;
                payCounter--;                                    
                avaiableSpaces += 1;              
            }
            else if (NormalSituation2)
            {
                button2.Visible = false;
                button19.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Exit2 && (payCounter > 0))
            {
                button3.Visible = false;
                button20.Visible = true;
                payCounter--;
                avaiableSpaces += 1;
            }
            else if (NormalSituation2)
            {
                button3.Visible = false;
                button20.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Exit3 && (payCounter > 0))
            {
                button4.Visible = false;
                button21.Visible = true;
                payCounter--;
                avaiableSpaces += 1;
            }
            else if (NormalSituation2)
            {
                button4.Visible = false;
                button21.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Exit4 && (payCounter > 0))
            {
                button5.Visible = false;
                button22.Visible = true;
                payCounter--;
                avaiableSpaces += 1;
            }
            else if (NormalSituation2)
            {
                button5.Visible = false;
                button22.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Exit5 && (payCounter > 0))
            {
                button6.Visible = false;
                button23.Visible = true;
                payCounter--;
                avaiableSpaces += 1;
            }
            else if (NormalSituation2)
            {
                button6.Visible = false;
                button23.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {//no entrance but normal exit
            if (Emergency1 == 0)
            {
                button7.BackColor = Color.Green;
                button44.Visible = true;
                textBox2.Text = "Raise";
                textBox13.Text = "Emergency access through the main enterance";
                Emergency1++;
            }
            else if (Emergency1 == 1)
            {
                button7.BackColor = Color.Red;
                button44.Visible = false;
                textBox2.Text = "Down";
                textBox13.Text = "The situation is over";
                Emergency1 = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Payment PaymentForm = new Payment();
            PaymentForm.Show();
            payCounter++;
            NormalSituation = true;
            NormalSituation2 = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            button10.Visible = true;            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Visible = false;
            button1.Visible = true;
            textBox2.Text = "Raised";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {//no enterance. limited exit
            //emergency 2
            if (Emergency2 == 0)
            {
                button12.BackColor = Color.Green;
                button44.Visible = true;
                textBox2.Text = "Raise";
                textBox13.Text = "More access for emergency services";
                textBox9.BackColor = Color.Red;
                Exit2 = false;
                textBox4.Text = "Raise";
                textBox12.BackColor = Color.Red;
                Exit5 = false;
                textBox7.Text = "Raise";
                Emergency2++;
            }
            else if (Emergency2 == 1)
            {
                button12.BackColor = Color.Red;
                button44.Visible = false;
                textBox2.Text = "Down";
                textBox13.Text = "The situation is over";
                textBox9.BackColor = Color.Green;
                Exit2 = false;
                textBox4.Text = "Down";
                textBox12.BackColor = Color.Red;
                Exit5 = false;
                textBox7.Text = "Down";
                Emergency2 = 0;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {//no enterance, one exit
            //emergency 3
            if (Emergency3 == 0)
            {
                button11.BackColor = Color.Green;
                button44.Visible = true;
                textBox2.Text = "Raise";
                textBox13.Text = "More access for emergency services";
                textBox9.BackColor = Color.Red;
                Exit2 = false;
                textBox4.Text = "Raise";
                textBox12.BackColor = Color.Red;
                Exit5 = false;
                textBox7.Text = "Raise";
                textBox11.BackColor = Color.Red;
                Exit4 = false;
                textBox6.Text = "Raise";
                textBox10.BackColor = Color.Red;
                Exit3 = false;
                textBox5.Text = "Raise";
                Emergency3++;
            }
            else if (Emergency3 == 1)
            {
                button11.BackColor = Color.Red;
                button44.Visible = false;
                textBox2.Text = "Down";
                textBox13.Text = "The situation is over";
                textBox9.BackColor = Color.Green;
                Exit2 = true;
                textBox4.Text = "Down";
                textBox12.BackColor = Color.Red;
                Exit5 = false;
                textBox7.Text = "Down";
                textBox11.BackColor = Color.Green;
                Exit4 = true;
                textBox6.Text = "Down";
                textBox10.BackColor = Color.Green;
                Exit3 = true;
                textBox5.Text = "Down";
                Emergency3 = 0;

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            NormalSituation = true;
            NormalSituation2 = false;
            textBox13.Text = "Trying to leave after paying, with no problems";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            NormalSituation2 = true;
            NormalSituation = false;
            textBox13.Text = "Trying to leave without paying";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Visible = false;
            button16.Visible = true;
            textBox17.Visible = true;
            textBox16.Visible = true;
            textBox15.Visible = true;
            textBox14.Visible = true;
            label10.Visible = true;
            label9.Visible = true;
            label8.Visible = true;
            label7.Visible = true;
            label6.Visible = true;           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button15.Visible = true;
            button16.Visible = false;
            textBox17.Visible = false;
            textBox16.Visible = false;
            textBox15.Visible = false;
            textBox14.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            label8.Visible = false;
            label7.Visible = false;
            label6.Visible = false;     
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            //check Coin 1
            if (NormalSituation) //payed
            {
                textBox3.Text = "Raised";
                button17.Visible = false;
                button18.Visible = true;
                String textChange = Convert.ToString(avaiableSpaces);
                textBox1.Text = textChange;
            }
            else if (NormalSituation2) // not payed
            {
                button17.Text = "Please Pay";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //leave 1
            button2.Visible = true;
            button18.Visible = false;
            textBox3.Text = "Down";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.Visible = false;
            button17.Visible = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //enter coin 2
            button20.Visible = false;
            button24.Visible = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //enter coin 3
            button21.Visible = false;
            button25.Visible = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //enter coin 4
            button22.Visible = false;
            button26.Visible = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //enter coin 5
            button23.Visible = false;
            button27.Visible = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //check pay 2
            if (NormalSituation) //payed
            {
                textBox4.Text = "Raised";
                button24.Visible = false;
                button28.Visible = true;
                String textChange = Convert.ToString(avaiableSpaces);
                textBox1.Text = textChange;
            }
            else if (NormalSituation2) // not payed
            {
                button24.Text = "Please Pay";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //check pay 3
            if (NormalSituation) //payed
            {
                textBox5.Text = "Raised";
                button25.Visible = false;
                button29.Visible = true;
                String textChange = Convert.ToString(avaiableSpaces);
                textBox1.Text = textChange;
            }
            else if (NormalSituation2) // not payed
            {
                button25.Text = "Please Pay";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //check pay 4
            if (NormalSituation) //payed
            {
                textBox6.Text = "Raised";
                button26.Visible = false;
                button30.Visible = true;
                String textChange = Convert.ToString(avaiableSpaces);
                textBox1.Text = textChange;
            }
            else if (NormalSituation2) // not payed
            {
                button26.Text = "Please Pay";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //check pay 5
            if (NormalSituation) //payed
            {
                textBox7.Text = "Raised";
                button27.Visible = false;
                button31.Visible = true;
                String textChange = Convert.ToString(avaiableSpaces);
                textBox1.Text = textChange;
            }
            else if (NormalSituation2) // not payed
            {
                button27.Text = "Please Pay";
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //leave 2
            button3.Visible = true;
            button28.Visible = false;
            textBox4.Text = "Down";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //leave 3
            button4.Visible = true;
            button29.Visible = false;
            textBox5.Text = "Down";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //leave 4
            button5.Visible = true;
            button20.Visible = false;
            textBox6.Text = "Down";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            //leave 5
            button6.Visible = true;
            button31.Visible = false;
            textBox7.Text = "Down";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.Green;
            Exit1 = true;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.Red;
            Exit1 = false;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox9.BackColor = Color.Green;
            Exit2 = true;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox9.BackColor = Color.Red;
            Exit2 = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox10.BackColor = Color.Green;
            Exit3 = true;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox10.BackColor = Color.Red;
            Exit3 = false;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox11.BackColor = Color.Green;
            Exit4 = true;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox11.BackColor = Color.Red;
            Exit4 = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox12.BackColor = Color.Green;
            Exit5 = true;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox12.BackColor = Color.Red;
            Exit5 = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //morning, afternoon, evening, weekend prices
            if (counter == 0)
            {
                if (pressCount == 0)
                {
                    label10.Text = "Morning Prices";
                    textBox17.Text = "£2.50";
                    textBox16.Text = "£3.50";
                    textBox15.Text = "£4.50";
                    textBox14.Text = "£5.00";
                    pressCount++;
                }
                else if (pressCount == 1)
                {
                    label10.Text = "Afternoon Prices";
                    textBox17.Text = "£2.00";
                    textBox16.Text = "£2.50";
                    textBox15.Text = "£3.50";
                    textBox14.Text = "£4.00";
                    pressCount++;
                }
                else if (pressCount == 2)
                {
                    label10.Text = "Evening Prices";
                    textBox17.Text = "£1.50";
                    textBox16.Text = "£2.50";
                    textBox15.Text = "£3.50";
                    textBox14.Text = "£4.00";
                    pressCount++;
                }
                else if (pressCount == 3)
                {
                    label10.Text = "Weekend Prices";
                    textBox17.Text = "£1.50";
                    textBox16.Text = "£2.50";
                    textBox15.Text = "£4.00";
                    textBox14.Text = "£4.50";
                    pressCount = 0;
                }
            }
            else if (counter == 1)
            {
                if (pressCount == 0)
                {
                    label10.Text = "Morning Prices";
                    textBox17.Text = "£2.00";
                    textBox16.Text = "£2.50";
                    textBox15.Text = "£3.50";
                    textBox14.Text = "£4.00";
                    pressCount++;
                }
                else if (pressCount == 1)
                {
                    label10.Text = "Afternoon Prices";
                    textBox17.Text = "£1.50";
                    textBox16.Text = "£2.00";
                    textBox15.Text = "£3.00";
                    textBox14.Text = "£4.00";
                    pressCount++;
                }
                else if (pressCount == 2)
                {
                    label10.Text = "Evening Prices";
                    textBox17.Text = "£1.00";
                    textBox16.Text = "£2.00";
                    textBox15.Text = "£3.50";
                    textBox14.Text = "£4.00";
                    pressCount++;
                }
                else if (pressCount == 3)
                {
                    label10.Text = "Weekend Prices";
                    textBox17.Text = "£1.00";
                    textBox16.Text = "£2.50";
                    textBox15.Text = "£3.00";
                    textBox14.Text = "£4.00";
                    pressCount = 0;
                }
            }
            else if (counter == 2)
            {
                if (pressCount == 0)
                {
                    label10.Text = "Morning Prices";
                    textBox17.Text = "£3.50";
                    textBox16.Text = "£3.75";
                    textBox15.Text = "£4.00";
                    textBox14.Text = "£4.50";
                    pressCount++;
                }
                else if (pressCount == 1)
                {
                    label10.Text = "Afternoon Prices";
                    textBox17.Text = "£3.00";
                    textBox16.Text = "£3.50";
                    textBox15.Text = "£3.50";
                    textBox14.Text = "£4.00";
                    pressCount++;
                }
                else if (pressCount == 2)
                {
                    label10.Text = "Evening Prices";
                    textBox17.Text = "£2.50";
                    textBox16.Text = "£3.00";
                    textBox15.Text = "£3.50";
                    textBox14.Text = "£4.50";
                    pressCount++;
                }
                else if (pressCount == 3)
                {
                    label10.Text = "Weekend Prices";
                    textBox17.Text = "£2.00";
                    textBox16.Text = "£3.50";
                    textBox15.Text = "£4.00";
                    textBox14.Text = "£5.00";
                    pressCount = 0;
                }
            }
            else if (counter == 3)
            {
                if (pressCount == 0)
                {
                    label10.Text = "Morning Prices";
                    textBox17.Text = "£2.50";
                    textBox16.Text = "£3.00";
                    textBox15.Text = "£4.00";
                    textBox14.Text = "£5.00";
                    pressCount++;
                }
                else if (pressCount == 1)
                {
                    label10.Text = "Afternoon Prices";
                    textBox17.Text = "£2.00";
                    textBox16.Text = "£2.50";
                    textBox15.Text = "£3.50";
                    textBox14.Text = "£4.00";
                    pressCount++;
                }
                else if (pressCount == 2)
                {
                    label10.Text = "Evening Prices";
                    textBox17.Text = "£1.50";
                    textBox16.Text = "£2.50";
                    textBox15.Text = "£3.50";
                    textBox14.Text = "£4.00";
                    pressCount++;
                }
                else if (pressCount == 3)
                {
                    label10.Text = "Weekend Prices";
                    textBox17.Text = "£1.50";
                    textBox16.Text = "£2.50";
                    textBox15.Text = "£4.00";
                    textBox14.Text = "£4.50";
                    pressCount = 0;
                }
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {//park number

        }

        private void button43_Click(object sender, EventArgs e)
        {//chnage park
            if (counter == 0)
            {
                textBox18.Text = "1";
                label10.Text = "Morning Prices";
                textBox17.Text = "£2.50";
                textBox16.Text = "£3.50";
                textBox15.Text = "£4.50";
                textBox14.Text = "£5.00";
                textBox19.Text = "10";
                textBox1.Text = "10";
                counter++;
            }
            else if(counter == 1)
            {
                textBox18.Text = "2";
                textBox17.Text = "£2.00";
                textBox16.Text = "£2.50";
                textBox15.Text = "£3.50";
                textBox14.Text = "£4.00";
                textBox19.Text = "30";
                textBox1.Text = "5";
                counter++;
            }
            else if (counter == 2)
            {
                textBox18.Text = "3";
                textBox17.Text = "£3.50";
                textBox16.Text = "£3.75";
                textBox15.Text = "£4.00";
                textBox14.Text = "£4.50";
                textBox19.Text = "25";
                textBox1.Text = "23";
                counter++;
            }
            else if (counter == 3)
            {
                textBox18.Text = "4";
                textBox17.Text = "£2.50";
                textBox16.Text = "£3.00";
                textBox15.Text = "£4.00";
                textBox14.Text = "£5.00";
                textBox19.Text = "50";
                textBox1.Text = "15";
                counter = 0;
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            //max cap
        }

        private void button44_Click(object sender, EventArgs e)
        {
            textBox13.Text = "Emergency service on site";
        }
    }
}

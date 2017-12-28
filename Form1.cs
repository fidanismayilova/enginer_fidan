using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ortalama_hesapla_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(textBox4.Text);
            listBox5.Items.Add(textBox5.Text);
            double ortalama = (Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox4.Text) + Convert.ToDouble(textBox5.Text)) / 3;
            listBox6.Items.Add(ortalama);
            if (ortalama >= 50)
            {
                listBox7.Items.Add("GEÇTİ");
                if (ortalama >= 90)
                {
                    listBox8.Items.Add("AA");
                }
                else if (ortalama >= 85 & ortalama <=89)
                {
                    listBox8.Items.Add("BA");
                }
                else if (ortalama >= 80 & ortalama <= 84)
                {
                    listBox8.Items.Add("BB");
                }
                else if (ortalama >= 75 & ortalama <= 79)
                {
                    listBox8.Items.Add("CB");
                }
                else if (ortalama >= 65 & ortalama <= 74)
                {
                    listBox8.Items.Add("CC");
                }
                else if (ortalama >= 58 & ortalama <= 64)
                {
                    listBox8.Items.Add("DC");
                }
                else if  (ortalama >= 51 & ortalama <= 57)
                {
                    listBox8.Items.Add("DD-KOŞULLU");
                }
            }
            else 
            {
                listBox7.Items.Add("KALDI");
                listBox8.Items.Add("FF");
            }
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
        }
       
        private void pd_PrintPage(Object sender,PrintPageEventArgs e)
        {
            //Font printfont = new Font("times new roman",12);
           // e.Graphics.DrawString(listBox1.Items.ToString, printfont, Brushes.Black, 0, 0);
            
        }        
        private void button3_Click_1(object sender, EventArgs e)
        {
           // PrintDocument pd = new PrintDocument();
           // pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
           // pd.Print();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
             
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders2323
{
    public partial class Form1 : Form
    {

        string[] ad = new string[10];
        int[]not=new int[10];
        int sıra = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          if (txtad.Text==""&&txtnot.Text=="")
            {
                MessageBox.Show("öğrneci adını ve notunu giriniz.");
            }
            else
            {
                ad[sıra] = txtad.Text;
                not[sıra] = Convert.ToInt16(txtnot.Text);
                sıra++;
                if(sıra==10)
                {
                    button1.Enabled=false;
                    button1.BackColor = Color.Red;
                }
            }
            
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i=0;i<10;i++)
            {
                listBox1.Items.Add(ad[i] + "\t" + not[i]);
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i=0;i<10;i++)
            {
                if (not[i]>85)
                {
                    listBox1.Items.Add(ad[i]+"\t" + not[i]);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i <3; i++)
            {
                if (not[i] >= 70 && not[i] <= 85)
                {
                    listBox1.Items.Add(ad[i] + "\t" + not[i]);
                }
            }    }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i=-0;i<3;i++)
            {
                if (not[i]<50)
                {
                    listBox1.Items.Add(ad[i] + "\t" + not[i]);
                }
               
            }




        }
    }
}

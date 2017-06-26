using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodRandom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                String[] Manu = { "", "กระเพราะไก่", "ข้าวผัด", "ข้าวหมูทอด", "ข้าวไข่เจียว", "ก๋วยเตี๋ยวต้มยำ", "ส้มตำ", "ขนมจีน", "คอหมูย่างราดข้าว", "ไก่ทอด", "พิซซ่า" };
                Random ran = new Random();
                int a = ran.Next(1, 11);
                for (i = 1; i <= 10; i++)
                {
                    String x = Manu[i];                                        
                }
                switch (a)
                {
                    case 1: label3.Text = "1 : " + Manu[1]; break;
                    case 2: label3.Text = "2 : " + Manu[2]; break;
                    case 3: label3.Text = "3 : " + Manu[3]; break;
                    case 4: label3.Text = "4 : " + Manu[4]; break;
                    case 5: label3.Text = "5 : " + Manu[5]; break;
                    case 6: label3.Text = "6 : " + Manu[6]; break;
                    case 7: label3.Text = "7 : " + Manu[7]; break;
                    case 8: label3.Text = "8 : " + Manu[8]; break;
                    case 9: label3.Text = "9 : " + Manu[9]; break;
                    case 10: label3.Text = "10 : " + Manu[10]; break;
                }
            }
            catch
            {

            }      
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] Manu = { "", "กระเพราะไก่", "ข้าวผัด", "ข้าวหมูทอด", "ข้าวไข่เจียว", "ก๋วยเตี๋ยวต้มยำ", "ส้มตำ", "ขนมจีน", "คอหมูย่างราดข้าว", "ไก่ทอด", "พิซซ่า" };
            for (int i = 1; i <= 10; i++)
            {
                richTextBox1.Text += i + ": " + Manu[i]+"\n";
            }
        }
    }
}

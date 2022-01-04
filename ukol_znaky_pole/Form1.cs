using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_znaky_pole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maximum = 0;
            char[] pole = textBox1.Text.ToCharArray();
            if (pole[pole.Length - 1] >= 48 && pole[pole.Length - 1] <= 57) {
                for (int i = 0; i < pole.Length; i++)
                {
                    if (pole[i] <= 57 && pole[i] >= 48)
                    {
                        pole[i] = 'x';
                    }
                }
            }
            else {
                foreach (char sheesh in pole) {
                    if (sheesh > maximum) {
                        maximum = sheesh;
                    }
                }
                pole[Array.IndexOf(pole, Convert.ToChar(maximum))] = pole[pole.Length - 1];
                pole[pole.Length - 1] = Convert.ToChar(maximum);
            }
            string xd = new string(pole);
            textBox2.Text = xd;
        } 
    }
}

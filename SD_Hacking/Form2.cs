using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD_Hacking
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(1);
            switch (lbDiff.SelectedIndex)
            {
                case 0:
                    f = new Form1(4);
                    break;
                case 1:
                    f = new Form1(6);
                    break;
                case 2:
                    f = new Form1(8);
                    break;
                default:
                    f = new Form1(4);
                    break;
            }
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string line = "Depending on difficulty, enter unique numbers then press submit. The middle box (Result) will show numbers you have entered with color embedded.\n\n";
            line += "If the number is green, that number is in corrected order and no need to change.\n\n";
            line += "If the number is yellow, that number is not in corrected order. Swap the number around so that it changes to green.\n\n";
            line += "If the number is red, that number does not appear in the code. Choose another number.";
            MessageBox.Show(line, "How to Play", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

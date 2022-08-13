using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panels_and_usercontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int countR = 0,countB =0,countG = 0;

        private void lbl_Red_Click(object sender, EventArgs e)
        {
            countR++;
            panel2.BackColor = Color.Red;
            lbl_Red.ForeColor = Color.Red;
            lbl_Red.Text = "Turned to Red : "+Convert.ToString(countR)+" Times";
           
        }

        private void lbl_Blue_Click(object sender, EventArgs e)
        {   countB++;
            panel2.BackColor= Color.Blue;
            lbl_Blue.ForeColor = Color.Blue;
            lbl_Blue.Text = "Turned to Blue : "+Convert.ToString(countB)+" Times";

        }

        private void lbl_Black_Click(object sender, EventArgs e)
        {   countG++;
            panel2.BackColor = Color.Green;
            lbl_Black.ForeColor = Color.Green;
            lbl_Black.Text = "Turned to Green : "+Convert.ToString(countG)+" Times";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> Demo_list = new List<string>() { "True", "False", "Both", "Neither", "Ehhh" };

            foreach (var i in Demo_list)
            {
                UserControl1 usera = new UserControl1();
                usera.Prop= i;
                flowLayoutPanel1.Controls.Add(usera);
            }
        }


    }
}

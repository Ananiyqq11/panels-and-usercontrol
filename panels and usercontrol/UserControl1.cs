using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panels_and_usercontrol
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private string cust_prop;
        public string Prop
        {
            get { return cust_prop; }
            set { cust_prop = value; label1.Text = cust_prop; }
        }

      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }

        bool isTypingNumber = false;

        private void btn1_Click(object sender, EventArgs e)
        {
            if (isTypingNumber)
                lbldisplay.Text = lbldisplay.Text + "1";
            else
                lbldisplay.Text + "1"
        }
    }
}

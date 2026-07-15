using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "I'm Blue!";
            lblGoodbyeWorld.Text = "Click Here!";
            this.BackColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblGoodbyeWorld.Text = "I'm Red!";
            lblHelloWorld.Text = "Click Here!";
            this.BackColor = Color.Red;
        }

    }
}

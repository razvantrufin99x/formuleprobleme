using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace formuleprobleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //schimb problema
            int a = 10;
            int b = 5;
            schimb s = new schimb(ref a,ref b);
            Text = a.ToString() + " : " + b.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figure
{
    public partial class Form1 : Form
    {
        private int radisu;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtRadius_TextChanged(object sender, EventArgs e)
        {
            radisu = int.Parse(txtRadius.Text);
        }

        private void btnCirkle_Click(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            graphics.Clear(BackColor);
            graphics.FillEllipse(Brushes.Aquamarine, 100, 100, radisu * 2, radisu * 2);
            graphics.Dispose();
        }
    }
}

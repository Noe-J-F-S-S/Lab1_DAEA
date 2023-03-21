using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chkMayor.Checked)
            {
                MessageBox.Show("Bienbenido " + txtname.Text + " es mayor de edad");
            }
            MessageBox.Show("Bienbenido " + txtname.Text + " es menor de edad");

            MessageBox.Show("Bienvenido " + txtname.Text);
        }
    }
}

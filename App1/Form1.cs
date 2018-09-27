using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            var b = Convert.ToInt32(txtB.Text);
            Double lsthasil;
            switch (combo.SelectedIndex)
            {
                case 0:
                    lsthasil = a + b;
                    hasil.Text = Convert.ToString(lsthasil);
                    break;
                case 1:
                    lsthasil = a - b;
                    hasil.Text = Convert.ToString(lsthasil);
                    break;
                case 2:
                    lsthasil = a * b;
                    hasil.Text = Convert.ToString(lsthasil);
                    break;
                case 3:
                    lsthasil = a / b;
                    hasil.Text = Convert.ToString(lsthasil);
                    break;
            }
        }
    }
}

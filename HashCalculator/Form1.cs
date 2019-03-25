using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace HashCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFile1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = pathFile1.Text;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathFile1.Text = openFileDialog1.FileName;
                hashFile1.Clear();
            }
        }

        private void btnFile2_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = pathFile2.Text;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathFile2.Text = openFileDialog1.FileName;
                hashFile2.Clear();
            }
        }
    }
}

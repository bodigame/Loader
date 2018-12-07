using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBox1.Text = Enigma_IDE.EP_ProtectedStringByKeyAsAnsiString("fyi6z02Y");
            textBox2.Text = Enigma_IDE.EP_ProtectedStringByIDAsAnsiString(1);
            textBox3.Text = Enigma_IDE.EP_ProtectedStringByKeyAsAnsiString("26Lu66Er");
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eventTest_1
{
    enum TTT
    {
        OxF2,
        oxff
    }
    public partial class Form1 : Form
    {
        MyTestClass obj = new MyTestClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            obj.TestEevnt += TestDel;
            TTT a = TTT.OxF2;
            
        }

        private void TestDel()
        {
            label1.Text += "My method " + "\n i am raja";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.RaiseEvent();
        }
    }
}

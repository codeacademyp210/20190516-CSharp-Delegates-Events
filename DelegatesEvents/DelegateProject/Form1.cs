using System;
using System.Windows.Forms;

namespace DelegateProject
{
    public partial class Form1 : Form
    {
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Click -= button1_Click;
            MessageBox.Show("Button clicked");
        }


        private void MyMethod(object sender, EventArgs e)
        {
            MessageBox.Show("My Method worked");
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            a++;
            MessageBox.Show(a.ToString());

            if (a % 2 == 0)
            {
                button1.Click -= button1_Click;
                button1.Click += MyMethod;
            }
            else
            {
                button1.Click -= MyMethod;
                button1.Click += button1_Click;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int A = 2;
        int A2 = 35;

        private void button1_Click(object sender, EventArgs e)
        {
            if (A <= 9)
            {
                Label lbl = new Label();
                Controls.Add(lbl);
                lbl.Top = 0 * A2;
                lbl.Width = 30;
                lbl.Height = 1000;
                lbl.BackColor = Color.BlueViolet;
                AddNewTextBox();
            }
            else
            {
                MessageBox.Show("Complete this first then think about addding more tasks !");
            }
        }
        public CheckBox AddNewTextBox()
        {
            CheckBox txt = new CheckBox();
            Controls.Add(txt);

            txt.Top = A * A2;
            txt.Left = 10;
            txt.Font = new Font("Century Gothic", 12);
            txt.Width = 400;
            txt.Height = 30;
            txt.BackColor = Color.BlueViolet;
            txt.ForeColor = Color.White;
            txt.Text = textBox1.Text;
            txt.BringToFront();
            textBox1.Text = "";

            A++;
            return txt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (CheckBox chbx in Controls.OfType<CheckBox>())
            {
                if (chbx.Checked)
                {
                    chbx.Dispose(); 
                    A = 2;
                }
            }
        }

        private Form2 _f2;
        public Form2 f2
        {
            get
            {
                if (_f2 == null)
                {
                    _f2 = new Form2(this);  // Pass form 1 as parameter to form 2.
                }
                return _f2;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            f2.Show();
        }
    }
}

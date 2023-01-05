using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ToDO
{
    public partial class Form2 : Form
    {
        System.Timers.Timer timer;

        private readonly Form1 _form1;

        public Form2(Form1 form1)
        {
            _form1 = form1;
            InitializeComponent();

            textBox1.ScrollBars = ScrollBars.Vertical;

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;

            InstalledFontCollection fonts = new InstalledFontCollection();
            try
            {
                foreach (FontFamily font in fonts.Families)
                {
                    listBox1.Items.Add(font.Name);
                }
            }
            catch
            {

            }

        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker1.Value;





            label10.Text = currentTime.ToString("hh:mm:ss tt");

            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                timer.Stop();
                label6.Text = "STOP";
                MessageBox.Show("Reminder - Timer Stop");
                label6.Text = "TIME";
                label9.Text = "";
                label10.Text = "";
            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string customPath = "C:\\Project ToDO\\BackGround Rex";
            string filename = "1.jpg";
            _form1.BackgroundImageLayout = ImageLayout.Stretch;
            _form1.BackgroundImage = Image.FromFile(Path.Combine(customPath, filename));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string customPath = "C:\\Project ToDO\\BackGround Rex";
            string filename = "2.png";
            _form1.BackgroundImageLayout = ImageLayout.Stretch;
            _form1.BackgroundImage = Image.FromFile(Path.Combine(customPath, filename));
        }

        private void btnBG_3_Click(object sender, EventArgs e)
        {
            string customPath = "C:\\Project ToDO\\BackGround Rex";
            string filename = "3.jpg";
            _form1.BackgroundImageLayout = ImageLayout.Stretch;
            _form1.BackgroundImage = Image.FromFile(Path.Combine(customPath, filename));
        }

        private void btnBG_4_Click(object sender, EventArgs e)
        {
            string customPath = "C:\\Project ToDO\\BackGround Rex";
            string filename = "7.jpg";
            _form1.BackgroundImageLayout = ImageLayout.Stretch;
            _form1.BackgroundImage = Image.FromFile(Path.Combine(customPath, filename));
        }

        private void btnBG_5_Click_1(object sender, EventArgs e)
        {
            string customPath = "C:\\Project ToDO\\BackGround Rex";
            string filename = "9.jpg";
            _form1.BackgroundImageLayout = ImageLayout.Stretch;
            _form1.BackgroundImage = Image.FromFile(Path.Combine(customPath, filename));
        }

        private void btnBG_6_Click_1(object sender, EventArgs e)
        {
            string customPath = "C:\\Project ToDO\\BackGround Rex";
            string filename = "6.jpg";
            _form1.BackgroundImageLayout = ImageLayout.Stretch;
            _form1.BackgroundImage = Image.FromFile(Path.Combine(customPath, filename));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Project ToDO";
            SaveFileDialog dlg = new SaveFileDialog
            {
                Filter = "*.txt|*.txt",
                RestoreDirectory = true
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, textBox1.Text);
                label2.Visible = false;

                string fn = dlg.FileName;
                label1.Text = " " + fn.Remove(0, 3);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Project ToDO";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog1.FileName);
                string filePath = openFileDialog1.FileName;
                filePath = openFileDialog1.FileName;

                // For preview of the open file in textbox
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                label1.Text = " " + fileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items != null && txtChngClr.Text != null && comboBox1.Items != null)
                {
                    comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                    string fntStyle = comboBox1.SelectedItem.ToString();
                    string clr = txtChngClr.Text;
                    textBox1.ForeColor = Color.FromName(clr);
                    label13.ForeColor  = Color.FromName(clr);

                    if (fntStyle == "Regular")
                    {
                        textBox1.Font = new Font((string)listBox1.SelectedItem, (int)numericUpDown1.Value, FontStyle.Regular);
                        label13.Font = new Font((string)listBox1.SelectedItem, (int)numericUpDown1.Value, FontStyle.Regular);
                    }
                    else if (fntStyle == "Bold")
                    {
                        textBox1.Font = new Font((string)listBox1.SelectedItem, (int)numericUpDown1.Value, FontStyle.Bold);
                        label13.Font = new Font((string)listBox1.SelectedItem, (int)numericUpDown1.Value, FontStyle.Bold);
                    }
                    else if (fntStyle == "Italic")
                    {
                        textBox1.Font = new Font((string)listBox1.SelectedItem, (int)numericUpDown1.Value, FontStyle.Italic );
                        label13.Font = new Font((string)listBox1.SelectedItem, (int)numericUpDown1.Value, FontStyle.Italic);
                    }
                    else if (fntStyle == "Bold Iatalic")
                    {
                        textBox1.Font = new Font((string)listBox1.SelectedItem, (int)numericUpDown1.Value, FontStyle.Bold | FontStyle.Italic);
                        label13.Font = new Font((string)listBox1.SelectedItem, (int)numericUpDown1.Value, FontStyle.Bold | FontStyle.Italic);
                    }
                }
                else
                {
                    MessageBox.Show("Please specify all fields");
                }

            } catch { }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Century Gothic", 12);
            textBox1.ForeColor = Color.Black;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer.Start();
            label6.Text = "Task Running";
            label9.Text = "The current task " + textBox4.Text + " will completed in " + dateTimePicker1.Value + "";
            textBox4.Text = "";
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            timer.Stop();
            label6.Text = "TIME";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();   
        }
    }
}
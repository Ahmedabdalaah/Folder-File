using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Folder
{
    public partial class ReadFile : Form
    {
        public ReadFile()
        {
            InitializeComponent();
        }

        private void ReadFile_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frame1 fraw = new Frame1();
            fraw.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            richTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String line;
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("file name must not be empty ");
                }
                else if(!File.Exists(textBox1.Text))
                {
                    MessageBox.Show(textBox1.Text+" file is not found");
                }
                else
                {
                    StreamReader stream = new StreamReader(textBox1.Text);
                    line = stream.ReadLine();
                    while(line !=null)
                    {
                        richTextBox1.Text += line;
                        line = stream.ReadLine();
                    }
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

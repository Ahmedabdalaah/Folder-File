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
    public partial class AddFolder : Form
    {
        public AddFolder()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frame1 fra = new Frame1();
            fra.Visible = true;
            this.Visible=false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text == "")
                {
                    MessageBox.Show("Error, you must enter the name");
                }
                else if (Directory.Exists(textBox1.Text))
                {
                    MessageBox.Show("Invalid name, This folder is exist");

                }
                else
                {
                    Directory.CreateDirectory(textBox1.Text);
                    MessageBox.Show("Done");
                    textBox1.Text = "";
                }
                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

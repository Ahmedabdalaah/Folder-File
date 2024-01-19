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
    public partial class DeleteFile : Form
    {
        public DeleteFile()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frame1 fr = new Frame1();
            fr.Visible = true;
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
                if (textBox1.Text == "")
                {
                    MessageBox.Show(" the path is not allowed to be empty");
                }
                else if (File.Exists(textBox1.Text))
                {
                    // If file found, delete it
                    File.Delete(textBox1.Text);
                    MessageBox.Show(textBox1.Text+" File is deleted");
                    textBox1.Text = "";
                }
                else MessageBox.Show("File not found");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
    public partial class DeleteFolder : Form
    {
        public DeleteFolder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Error , name must not be empty");
                }
                else if (!Directory.Exists(textBox1.Text))
                {
                    MessageBox.Show("this folder is already not found");
                }
                else
                {
                    Directory.Delete(textBox1.Text);
                    MessageBox.Show(textBox1.Text + " folder is deleted");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frame1 fra = new Frame1();
            fra.Visible = true;
            this.Visible = false;
        }
    }
}

﻿using System;
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
    public partial class Write : Form
    {
        public Write()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            richTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frame1 fram = new Frame1();
            fram.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == "") || (richTextBox1.Text==""))
                {
                    MessageBox.Show("data must be not empty");
                }
                else if (!File.Exists(textBox1.Text))
                {
                    MessageBox.Show("Error , File is not Found");
                }
                else
                {
                    StreamWriter stream = new StreamWriter(textBox1.Text);
                    stream.WriteLine(richTextBox1.Text);
                    stream.Close();
                    MessageBox.Show("Done");
                    textBox1.Text = "";
                    richTextBox1.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            {

            }
        }
    }
}

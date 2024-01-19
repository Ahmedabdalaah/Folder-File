namespace Win_Folder
{
    public partial class Frame1 : Form
    {
        public Frame1()
        {
            InitializeComponent();
        }

        private void Folder_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFolder afold = new AddFolder();
            afold.Visible = true;
            this.Visible = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddFile addfile = new AddFile();
            addfile.Visible = true;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteFile df = new DeleteFile();
            df.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteFolder df = new DeleteFolder();
            df.Visible = true;
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Write w = new Write();
            w.Visible = true;
            this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReadFile rf = new ReadFile();
            rf.Visible = true;
            this.Visible = false;
        }
    }
}

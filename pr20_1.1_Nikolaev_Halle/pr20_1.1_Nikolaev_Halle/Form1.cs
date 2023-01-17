namespace pr20_1._1_Nikolaev_Halle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left < 520) pictureBox1.Left += 2;
            else pictureBox1.Left = 4;
        }

        private void StartBut_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void StopBut_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }


    }
}
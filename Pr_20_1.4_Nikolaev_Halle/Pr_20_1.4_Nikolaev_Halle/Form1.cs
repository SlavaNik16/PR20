namespace Pr_20_1._4_Nikolaev_Halle
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bit;
        int stage = 0, x = 0, y = 0;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Blue;
            bit = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bit);
            var bf = new SolidBrush(Color.White);
            g.FillRectangle(bf, 0, 0, pictureBox1.Width, pictureBox1.Height);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (stage < 1)
            {
                imageList1.Draw(g, new Point(x, y), 0);
                stage++;
            }
            else if(stage < 2)
            {
                imageList1.Draw(g, new Point(x, y), 1);
                stage++;
            }
            else if (stage < 3)
            {
                imageList1.Draw(g, new Point(x, y), 2);
                stage++;
            }
            else if (stage == 3)
            {
                stage = 0;
                x += 3; y += 2;
            }
            pictureBox1.Image = bit;
            if (x > pictureBox1.Width)
            {
                x = 0;
                y = 0;
            }
        }
    }
}
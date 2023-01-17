
namespace Pr_20_1._2_Nikolaev_Halle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 40;
            int count = 0, max = 150, x = 20, y = 20, d = 60;

            Graphics g = this.CreateGraphics();
            g.Clear(Color.DarkCyan);
            var br =  new SolidBrush(Color.Yellow);
            var brf = new SolidBrush(Color.DarkCyan);
            g.FillEllipse(br, x, y, d, d);
            timer.Tick += new EventHandler((o, ev) =>
            {
                g.FillEllipse(brf, x, y, d, d);
                x += 5;
                y += 2;
                g.FillEllipse(br, x, y, d, d);
                count++;
                if (count == max)
                    timer.Stop();

            });
            timer.Start();


        }
    }
}
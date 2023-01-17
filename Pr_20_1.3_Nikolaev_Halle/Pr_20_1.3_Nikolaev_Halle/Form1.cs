using System.Drawing.Drawing2D;
namespace Pr_20_1._3_Nikolaev_Halle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.DarkRed, 2);
        }
        private double a;
        private int x1, y1, x2, y2, r;

        private void timer1_Tick(object sender, EventArgs e)
        {
            a -= 0.01;
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = ClientRectangle.Width / 2;
            y1 = ClientRectangle.Height / 2;
            r = 100;
            a = 0;
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1  - (int)(r * Math.Sin(a));

        }

        private Pen pen;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            pen.Width = 5;
            pen.DashStyle = DashStyle.Solid;
            pen.EndCap = LineCap.ArrowAnchor;
            g.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}
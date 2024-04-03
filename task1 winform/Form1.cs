using Microsoft.VisualBasic.Devices;

namespace task1_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "WOW";
        }

        private void mouseHover(object sender, EventArgs e)
        {
            Random random = new Random();
            int en = random.Next(0, 700);
            int uzunluq = random.Next(0, 400);
            label2.Location=new Point(en, uzunluq);
            
           
        }
    }
}

namespace Digital_Clock_WFApp
{
    public partial class Form1 : Form
    {
        private bool hrono = false;
        private bool clock = true;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (clock) label1.Text = DateTime.Now.ToString("HH:mm:ss");
            else if (hrono) label1.Text = "00:00:00";
            //SetRandomColor();

        }

        private void SetRandomColor()
        {
            int r = random.Next(0, 255);
            int g = random.Next(0, 255);
            int b = random.Next(0, 255);

            Color color = Color.FromArgb(r, g, b);
            this.label1.ForeColor = color;
        }

        private void ClockClickEvent(object sender, MouseEventArgs e)
        {
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;

            hrono = false;
            clock = true;
        }

        private void ColorClickEvent(object sender, MouseEventArgs e)
        {
            SetRandomColor();
        }

        private void HronoClickEvent(object sender, MouseEventArgs e)
        {
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;

            clock = false;
            hrono = true;

        }
    }
}
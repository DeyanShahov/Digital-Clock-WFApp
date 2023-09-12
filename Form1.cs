using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Digital_Clock_WFApp
{
    public partial class Form1 : Form
    {
        private bool hrono = false;
        private bool hronoToStart = false;
        private bool clock = true;
        private bool timer = false;
        
        private int elapsedSeconds = 0;
        private int secondsLeft = 13500;

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (clock) label1.Text = DateTime.Now.ToString("HH:mm:ss");
            else if (hrono)
            {
                if (hronoToStart)
                {
                    elapsedSeconds++;
                    TimeSpan time = TimeSpan.FromSeconds(elapsedSeconds);
                    label1.Text = time.ToString("hh':'mm':'ss");
                }
            }
            else if (timer)
            {
                if (secondsLeft > 0)
                {
                    secondsLeft--;
                    TimeSpan time = TimeSpan.FromSeconds(secondsLeft);
                    label1.Text = time.ToString("hh':'mm':'ss");
                }
                else
                {
                    timer1.Stop();
                    label1.Text = "End time!";
                }
            }
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
            timer = false;
            clock = true;

            elapsedSeconds = 0;
            hronoToStart = false;
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
            timer = false;
            hrono = true;

            label1.Text = "00:00:00";

        }

        private void HronoStartEvent(object sender, MouseEventArgs e) => hronoToStart = true;

        private void HronoResetEvent(object sender, MouseEventArgs e)
        {
            elapsedSeconds = 0;
            hronoToStart = false;

            label1.Text = "00:00:00";
        }

        private void HronoStopEvent(object sender, MouseEventArgs e) => hronoToStart = false;

        private void TimerClickEvent(object sender, MouseEventArgs e)
        {
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;

            hrono = false;
            clock = false;
            timer = true;
        }
    }
}
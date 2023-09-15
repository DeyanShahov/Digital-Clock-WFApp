using System.Diagnostics;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Digital_Clock_WFApp
{
    public partial class Form1 : Form
    {
        private PerformanceCounter ramCounter;
        private PerformanceCounter cpuCounter;

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

            ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use", true);
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            float ramUsagePercent = ramCounter.NextValue();
            float cpuUsage = cpuCounter.NextValue();
            lblRam.Text = $"RAM: {ramUsagePercent:F0}%";
            lblCpu.Text = $"CPU: {cpuUsage:F0}%";

            if (clock)
            {
                TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
                DateLabel.Text = DateTime.Now.ToString("dd MMM yyyy", new CultureInfo("en-US"));
                DateLabel.Location = new Point(TimeLabel.Location.X, TimeLabel.Location.Y + TimeLabel.Height);
                DayLabel.Text = DateTime.Now.ToString("dddd", new CultureInfo("en-US"));
                DayLabel.Location = new Point(DateLabel.Location.X + DateLabel.Width + 10, DateLabel.Location.Y);

            }
            else if (hrono)
            {
                if (hronoToStart)
                {
                    elapsedSeconds++;
                    TimeSpan time = TimeSpan.FromSeconds(elapsedSeconds);
                    TimeLabel.Text = time.ToString("hh':'mm':'ss");
                }
            }
            else if (timer)
            {
                if (secondsLeft > 0)
                {
                    secondsLeft--;
                    TimeSpan time = TimeSpan.FromSeconds(secondsLeft);
                    TimeLabel.Text = time.ToString("hh':'mm':'ss");
                }
                else
                {
                    timer1.Stop();
                    TimeLabel.Text = "End time!";
                }
            }
        }

        private void SetRandomColor()
        {
            int r = random.Next(0, 255);
            int g = random.Next(0, 255);
            int b = random.Next(0, 255);

            Color color = Color.FromArgb(r, g, b);
            this.TimeLabel.ForeColor = color;
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

            TimeLabel.Text = "00:00:00";

        }

        private void HronoStartEvent(object sender, MouseEventArgs e) => hronoToStart = true;

        private void HronoResetEvent(object sender, MouseEventArgs e)
        {
            elapsedSeconds = 0;
            hronoToStart = false;

            TimeLabel.Text = "00:00:00";
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
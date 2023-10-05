using Digital_Clock_WFApp.Weather;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.Owin.Hosting;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Globalization;
using System.Net;

namespace Digital_Clock_WFApp
{
    public partial class Form1 : Form
    {
        private PerformanceCounter ramCounter;
        private PerformanceCounter cpuCounter;

        private bool hrono = false;
        private bool clock = true;
        private bool timer = false;
        private bool toStart = false;

        private int elapsedSeconds = 0;
        private int secondsLeft = 0;

        Random random = new Random();

        private bool isDragging = false;
        private Point startPoint;

        private HubConnection hubConnection;
        private IHubProxy chatHubProxy;


        public Form1()
        {
            InitializeComponent();

            ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use", true);
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);

            timerWeather.Start();

            SetTempOnScreen();

            hubConnection = new HubConnection("http://localhost:8080");
            chatHubProxy = hubConnection.CreateHubProxy("ChatHub");
            hubConnection.Start().Wait();

            chatHubProxy.On<List<string>>("Send", messages =>
            {
                UpdateChat(messages);
            });
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
            else if (hrono && toStart)
            {
                SetTimeText(++elapsedSeconds);
            }
            else if (timer && toStart)
            {
                if (secondsLeft > 0)
                {
                    SetTimeText(--secondsLeft);
                }
                else
                {
                    timer1.Stop();
                    TimeLabel.Text = "End time!";
                }
            }
        }

        private void ColorClickEvent(object sender, MouseEventArgs e) => SetRandomColor();

        private void ClockClickEvent(object sender, MouseEventArgs e)
        {
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;

            DateLabel.Enabled = true;
            DayLabel.Enabled = true;

            lblHoursUp.Visible = false;
            lblHoursDown.Visible = false;
            lblMinutesUp.Visible = false;
            lblMinutesDown.Visible = false;
            lblSecondsUp.Visible = false;
            lblSecondsDown.Visible = false;

            toStart = false;
            hrono = false;
            timer = false;
            clock = true;

            secondsLeft = 0;
            elapsedSeconds = 0;

            timer1.Start();
        }


        private void HronoClickEvent(object sender, MouseEventArgs e)
        {
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;

            DateLabel.Enabled = false;
            DayLabel.Enabled = false;

            lblHoursUp.Visible = false;
            lblHoursDown.Visible = false;
            lblMinutesUp.Visible = false;
            lblMinutesDown.Visible = false;
            lblSecondsUp.Visible = false;
            lblSecondsDown.Visible = false;

            toStart = false;
            clock = false;
            timer = false;
            hrono = true;

            secondsLeft = 0;
            elapsedSeconds = 0;

            TimeLabel.Text = "00:00:00";
        }

        private void TimerClickEvent(object sender, MouseEventArgs e)
        {
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;

            DateLabel.Enabled = false;
            DayLabel.Enabled = false;

            lblHoursUp.Visible = true;
            lblHoursDown.Visible = true;
            lblMinutesUp.Visible = true;
            lblMinutesDown.Visible = true;
            lblSecondsUp.Visible = true;
            lblSecondsDown.Visible = true;

            toStart = false;
            hrono = false;
            clock = false;
            timer = true;

            secondsLeft = 0;
            elapsedSeconds = 0;

            TimeLabel.Text = "00:00:00";
        }

        private void StartEvent(object sender, MouseEventArgs e)
        {
            toStart = true;
            timer1.Start();
        }

        private void ResetEvent(object sender, MouseEventArgs e)
        {
            elapsedSeconds = 0;
            secondsLeft = 0;

            toStart = false;
            TimeLabel.Text = "00:00:00";
        }

        private void StopEvent(object sender, MouseEventArgs e) => toStart = false;

        private void lblHoursUp_Click(object sender, EventArgs e)
        {
            if (secondsLeft + 3600 <= 99 * 3600)
            {
                secondsLeft += 3600;
                SetTimeText(secondsLeft);
            }
        }

        private void lblHoursDown_Click(object sender, EventArgs e)
        {
            if (secondsLeft - 3600 > 0)
            {
                secondsLeft -= 3600;
                SetTimeText(secondsLeft);
            }
        }

        private void lblMinutesUp_Click(object sender, EventArgs e)
        {
            secondsLeft += 60;
            SetTimeText(secondsLeft);
        }

        private void lblMinutesDown_Click(object sender, EventArgs e)
        {
            if (secondsLeft - 60 > 0)
            {
                secondsLeft -= 60;
                SetTimeText(secondsLeft);
            }
        }

        private void lblSecondsUp_Click(object sender, EventArgs e) => SetTimeText(++secondsLeft);

        private void lblSecondsDown_Click(object sender, EventArgs e)
        {
            if (secondsLeft - 1 > 0) SetTimeText(--secondsLeft);
        }


        private void SetTimeText(int timeSeconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(timeSeconds);
            TimeLabel.Text = time.ToString("hh':'mm':'ss");
        }

        private void SetRandomColor()
        {
            int r = random.Next(0, 255);
            int g = random.Next(0, 255);
            int b = random.Next(0, 255);

            Color color = Color.FromArgb(r, g, b);
            this.TimeLabel.ForeColor = color;
        }

        private void FormMouseDownEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void FormMouseMoveEvent(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int dx = e.X - startPoint.X;
                int dy = e.Y - startPoint.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void FormMouseUpEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void lvlExit_Click(object sender, EventArgs e) => Application.Exit();


        #region Weather
        private async void lblWeather_Click(object sender, EventArgs e)
        {
            if (panWeather.Visible == false)
            {
                panWeather.Visible = true;
                await GetWeatherInfo();
            }
            else panWeather.Visible = false;
        }

        private async Task<Root> GetWeatherInfo(string city = "Burgas")
        {
            string appiKey = "8e8172944760f0c68c1f84d53f3d3f40";
            string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&appid={1}", city, appiKey);

            try
            {
                using (WebClient client = new WebClient())
                {
                    string json = await client.DownloadStringTaskAsync(url);
                    Root weatherInfo = JsonConvert.DeserializeObject<Root>(json);

                    return weatherInfo;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void timerWeather_Tick(object sender, EventArgs e)
        {
            SetTempOnScreen();
        }

        private async void SetTempOnScreen()
        {
            var weatherInfo = await GetWeatherInfo();

            if (weatherInfo != null) lblWeatherTemp.Text = Math.Round(weatherInfo.main.temp) + " °C";
            else lblWeatherTemp.Text = "Error";
        }

        private async void btnWeatherLoad_Click(object sender, EventArgs e)
        {
            Root weatherInfo;

            if (!string.IsNullOrEmpty(textBoxWeatherCity.Text)) weatherInfo = await GetWeatherInfo(textBoxWeatherCity.Text);
            else weatherInfo = await GetWeatherInfo();

            if (weatherInfo != null)
            {
                lblWeatherMain.Text = weatherInfo.weather.FirstOrDefault()?.main;
                lblWeatherDescription.Text = weatherInfo.weather.FirstOrDefault()?.description;
                lblWeatherFullTemp.Text = "Temp: " + Math.Round(weatherInfo.main.temp) + " °C";
                lblWeatherFeelsLike.Text = "Feels like: " + Math.Round(weatherInfo.main.feels_like) + " °C";
                lblWeatherHumidity.Text = "Humidity: " + weatherInfo.main.humidity + " %";
                lblWeatherMinMax.Text = Math.Round(weatherInfo.main.temp_min) + " / " + Math.Round(weatherInfo.main.temp_max) + " °C";
                lblWeatherWindSpeed.Text = "Wind Speed: " + weatherInfo.wind.speed + " m/s";
                lblWeatherPressure.Text = "Pressure: " + weatherInfo.main.pressure + " hPa";
            }
            else
            {
                textBoxWeatherCity.Text = "Error on loading";
            }
        }

        #endregion

        private void StartUpChat()
        {
            string url = "http://localhost:8080";

            using (WebApp.Start(url))
            {
                textBoxChatContent.Text = $"Server running on {url}";
            }
        }

        private void UpdateChat(List<string> messages) => textBoxChatContent.Text = messages.Last();

        private void SendMessage(string message, string username) => chatHubProxy.Invoke("Send", message, username);

        private void RegisterUser(string username) => chatHubProxy.Invoke("RegisterUser", username);

        private void ChangeUsername(string oldUsername, string newUsername) => chatHubProxy.Invoke("ChangeUsername", oldUsername, newUsername);

        private void UnregisterUser(string username) => chatHubProxy.Invoke("UnregisterUser", username);

    }
}
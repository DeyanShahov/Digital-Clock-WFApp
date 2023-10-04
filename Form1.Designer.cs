namespace Digital_Clock_WFApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TimeLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ClockButton = new Label();
            ColorClock = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            DateLabel = new Label();
            DayLabel = new Label();
            lblRam = new Label();
            lblCpu = new Label();
            lblHoursUp = new Label();
            lblHoursDown = new Label();
            lblMinutesUp = new Label();
            lblMinutesDown = new Label();
            lblSecondsUp = new Label();
            lblSecondsDown = new Label();
            lvlExit = new Label();
            lblWeather = new Label();
            panWeather = new Panel();
            lblWeatherResult = new Label();
            timerWeather = new System.Windows.Forms.Timer(components);
            lblWeatherTemp = new Label();
            panWeather.SuspendLayout();
            SuspendLayout();
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Font = new Font("Digital-7", 71.99999F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLabel.ForeColor = Color.LawnGreen;
            TimeLabel.Location = new Point(67, 75);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(342, 96);
            TimeLabel.TabIndex = 0;
            TimeLabel.Text = "00:00:00";
            TimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += TimerTick;
            // 
            // ClockButton
            // 
            ClockButton.AutoSize = true;
            ClockButton.Font = new Font("Digital-7", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ClockButton.ForeColor = Color.LightSteelBlue;
            ClockButton.Location = new Point(436, 118);
            ClockButton.Name = "ClockButton";
            ClockButton.Size = new Size(75, 28);
            ClockButton.TabIndex = 1;
            ClockButton.Tag = "";
            ClockButton.Text = "clock";
            ClockButton.MouseClick += ClockClickEvent;
            // 
            // ColorClock
            // 
            ColorClock.AutoSize = true;
            ColorClock.Font = new Font("Digital-7", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ColorClock.ForeColor = Color.LightSteelBlue;
            ColorClock.Location = new Point(436, 75);
            ColorClock.Name = "ColorClock";
            ColorClock.Size = new Size(76, 28);
            ColorClock.TabIndex = 2;
            ColorClock.Text = "Color";
            ColorClock.MouseClick += ColorClickEvent;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Digital-7", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightSteelBlue;
            label2.Location = new Point(12, 195);
            label2.Name = "label2";
            label2.Size = new Size(100, 35);
            label2.TabIndex = 3;
            label2.Text = "Start";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.MouseClick += StartEvent;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowText;
            label3.Enabled = false;
            label3.Font = new Font("Digital-7", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LightSteelBlue;
            label3.Location = new Point(145, 195);
            label3.Name = "label3";
            label3.Size = new Size(83, 35);
            label3.TabIndex = 4;
            label3.Text = "Stop";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.MouseClick += StopEvent;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Digital-7", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.LightSteelBlue;
            label4.Location = new Point(269, 195);
            label4.Name = "label4";
            label4.Size = new Size(96, 35);
            label4.TabIndex = 5;
            label4.Text = "Reset";
            label4.MouseClick += ResetEvent;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Digital-7", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.LightSteelBlue;
            label5.Location = new Point(436, 159);
            label5.Name = "label5";
            label5.Size = new Size(77, 28);
            label5.TabIndex = 6;
            label5.Text = "Hrono";
            label5.MouseClick += HronoClickEvent;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Digital-7", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.LightSteelBlue;
            label6.Location = new Point(436, 199);
            label6.Name = "label6";
            label6.Size = new Size(67, 28);
            label6.TabIndex = 7;
            label6.Text = "Timer";
            label6.MouseClick += TimerClickEvent;
            // 
            // DateLabel
            // 
            DateLabel.Font = new Font("Digital-7", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel.ForeColor = Color.Lime;
            DateLabel.Location = new Point(90, 47);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(138, 28);
            DateLabel.TabIndex = 8;
            DateLabel.Text = "June 25 2023";
            DateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DayLabel
            // 
            DayLabel.Font = new Font("Digital-7", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            DayLabel.ForeColor = Color.Lime;
            DayLabel.Location = new Point(256, 47);
            DayLabel.Name = "DayLabel";
            DayLabel.Size = new Size(140, 28);
            DayLabel.TabIndex = 9;
            DayLabel.Text = "Monday";
            DayLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRam
            // 
            lblRam.AutoSize = true;
            lblRam.Font = new Font("Digital-7", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            lblRam.ForeColor = Color.Lime;
            lblRam.Location = new Point(90, 9);
            lblRam.Name = "lblRam";
            lblRam.Size = new Size(39, 20);
            lblRam.TabIndex = 10;
            lblRam.Text = "RAM:";
            // 
            // lblCpu
            // 
            lblCpu.AutoSize = true;
            lblCpu.Font = new Font("Digital-7", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            lblCpu.ForeColor = Color.Lime;
            lblCpu.Location = new Point(12, 9);
            lblCpu.Name = "lblCpu";
            lblCpu.Size = new Size(43, 20);
            lblCpu.TabIndex = 11;
            lblCpu.Text = "CPU: ";
            // 
            // lblHoursUp
            // 
            lblHoursUp.AutoSize = true;
            lblHoursUp.Font = new Font("Digital-7", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoursUp.ForeColor = Color.Lime;
            lblHoursUp.Location = new Point(90, 167);
            lblHoursUp.Name = "lblHoursUp";
            lblHoursUp.Size = new Size(26, 29);
            lblHoursUp.TabIndex = 12;
            lblHoursUp.Text = "+";
            lblHoursUp.Visible = false;
            lblHoursUp.Click += lblHoursUp_Click;
            // 
            // lblHoursDown
            // 
            lblHoursDown.AutoSize = true;
            lblHoursDown.Font = new Font("Digital-7", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoursDown.ForeColor = Color.Lime;
            lblHoursDown.Location = new Point(136, 167);
            lblHoursDown.Name = "lblHoursDown";
            lblHoursDown.Size = new Size(26, 29);
            lblHoursDown.TabIndex = 13;
            lblHoursDown.Text = "-";
            lblHoursDown.Visible = false;
            lblHoursDown.Click += lblHoursDown_Click;
            // 
            // lblMinutesUp
            // 
            lblMinutesUp.AutoSize = true;
            lblMinutesUp.Font = new Font("Digital-7", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMinutesUp.ForeColor = Color.Lime;
            lblMinutesUp.Location = new Point(204, 167);
            lblMinutesUp.Name = "lblMinutesUp";
            lblMinutesUp.Size = new Size(26, 29);
            lblMinutesUp.TabIndex = 14;
            lblMinutesUp.Text = "+";
            lblMinutesUp.Visible = false;
            lblMinutesUp.Click += lblMinutesUp_Click;
            // 
            // lblMinutesDown
            // 
            lblMinutesDown.AutoSize = true;
            lblMinutesDown.Font = new Font("Digital-7", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMinutesDown.ForeColor = Color.Lime;
            lblMinutesDown.Location = new Point(243, 167);
            lblMinutesDown.Name = "lblMinutesDown";
            lblMinutesDown.Size = new Size(26, 29);
            lblMinutesDown.TabIndex = 15;
            lblMinutesDown.Text = "-";
            lblMinutesDown.Visible = false;
            lblMinutesDown.Click += lblMinutesDown_Click;
            // 
            // lblSecondsUp
            // 
            lblSecondsUp.AutoSize = true;
            lblSecondsUp.Font = new Font("Digital-7", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSecondsUp.ForeColor = Color.Lime;
            lblSecondsUp.Location = new Point(306, 167);
            lblSecondsUp.Name = "lblSecondsUp";
            lblSecondsUp.Size = new Size(26, 29);
            lblSecondsUp.TabIndex = 16;
            lblSecondsUp.Text = "+";
            lblSecondsUp.Visible = false;
            lblSecondsUp.Click += lblSecondsUp_Click;
            // 
            // lblSecondsDown
            // 
            lblSecondsDown.AutoSize = true;
            lblSecondsDown.Font = new Font("Digital-7", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSecondsDown.ForeColor = Color.Lime;
            lblSecondsDown.Location = new Point(351, 167);
            lblSecondsDown.Name = "lblSecondsDown";
            lblSecondsDown.Size = new Size(26, 29);
            lblSecondsDown.TabIndex = 17;
            lblSecondsDown.Text = "-";
            lblSecondsDown.Visible = false;
            lblSecondsDown.Click += lblSecondsDown_Click;
            // 
            // lvlExit
            // 
            lvlExit.AutoSize = true;
            lvlExit.Font = new Font("Digital-7", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lvlExit.ForeColor = Color.Maroon;
            lvlExit.Location = new Point(470, 9);
            lvlExit.Name = "lvlExit";
            lvlExit.Size = new Size(42, 20);
            lvlExit.TabIndex = 18;
            lvlExit.Text = "EXIT";
            lvlExit.Click += lvlExit_Click;
            // 
            // lblWeather
            // 
            lblWeather.AutoSize = true;
            lblWeather.Font = new Font("Digital-7", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            lblWeather.ForeColor = Color.LightSteelBlue;
            lblWeather.Location = new Point(384, 9);
            lblWeather.Name = "lblWeather";
            lblWeather.Size = new Size(70, 20);
            lblWeather.TabIndex = 19;
            lblWeather.Text = "WEATHER";
            lblWeather.Click += lblWeather_Click;
            // 
            // panWeather
            // 
            panWeather.BackColor = SystemColors.ControlDark;
            panWeather.BorderStyle = BorderStyle.FixedSingle;
            panWeather.Controls.Add(lblWeatherResult);
            panWeather.Location = new Point(14, 9);
            panWeather.Name = "panWeather";
            panWeather.Size = new Size(363, 212);
            panWeather.TabIndex = 21;
            panWeather.Visible = false;
            // 
            // lblWeatherResult
            // 
            lblWeatherResult.AutoSize = true;
            lblWeatherResult.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblWeatherResult.Location = new Point(18, 19);
            lblWeatherResult.Name = "lblWeatherResult";
            lblWeatherResult.Size = new Size(50, 20);
            lblWeatherResult.TabIndex = 0;
            lblWeatherResult.Text = "label1";
            // 
            // timerWeather
            // 
            timerWeather.Enabled = true;
            timerWeather.Interval = 300000;
            timerWeather.Tick += timerWeather_Tick;
            // 
            // lblWeatherTemp
            // 
            lblWeatherTemp.AutoSize = true;
            lblWeatherTemp.Font = new Font("Digital-7", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            lblWeatherTemp.ForeColor = Color.Lime;
            lblWeatherTemp.Location = new Point(309, 9);
            lblWeatherTemp.Name = "lblWeatherTemp";
            lblWeatherTemp.Size = new Size(23, 20);
            lblWeatherTemp.TabIndex = 20;
            lblWeatherTemp.Text = "°C";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(524, 241);
            ControlBox = false;
            Controls.Add(panWeather);
            Controls.Add(lblWeather);
            Controls.Add(lvlExit);
            Controls.Add(lblSecondsDown);
            Controls.Add(lblSecondsUp);
            Controls.Add(lblMinutesDown);
            Controls.Add(lblMinutesUp);
            Controls.Add(lblHoursDown);
            Controls.Add(lblHoursUp);
            Controls.Add(lblCpu);
            Controls.Add(lblRam);
            Controls.Add(DayLabel);
            Controls.Add(DateLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ColorClock);
            Controls.Add(ClockButton);
            Controls.Add(TimeLabel);
            Controls.Add(lblWeatherTemp);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            MouseDown += FormMouseDownEvent;
            MouseMove += FormMouseMoveEvent;
            MouseUp += FormMouseUpEvent;
            panWeather.ResumeLayout(false);
            panWeather.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TimeLabel;
        private System.Windows.Forms.Timer timer1;
        private Label ClockButton;
        private Label ColorClock;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label DateLabel;
        private Label DayLabel;
        private Label lblRam;
        private Label lblCpu;
        private Label lblHoursUp;
        private Label lblHoursDown;
        private Label lblMinutesUp;
        private Label lblMinutesDown;
        private Label lblSecondsUp;
        private Label lblSecondsDown;
        private Label lvlExit;
        private Label lblWeather;
        private Panel panWeather;
        private Label lblWeatherResult;
        private System.Windows.Forms.Timer timerWeather;
        private Label lblWeatherTemp;
    }
}
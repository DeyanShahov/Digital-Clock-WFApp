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
            SuspendLayout();
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Font = new Font("Digital-7", 71.99999F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLabel.ForeColor = Color.LawnGreen;
            TimeLabel.Location = new Point(53, 64);
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
            ClockButton.Font = new Font("Digital-7", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            ClockButton.ForeColor = Color.LightSteelBlue;
            ClockButton.Location = new Point(474, 64);
            ClockButton.Name = "ClockButton";
            ClockButton.Size = new Size(96, 35);
            ClockButton.TabIndex = 1;
            ClockButton.Tag = "";
            ClockButton.Text = "clock";
            ClockButton.MouseClick += ClockClickEvent;
            // 
            // ColorClock
            // 
            ColorClock.AutoSize = true;
            ColorClock.Font = new Font("Digital-7", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            ColorClock.ForeColor = Color.LightSteelBlue;
            ColorClock.Location = new Point(474, 9);
            ColorClock.Name = "ColorClock";
            ColorClock.Size = new Size(98, 35);
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
            label2.Location = new Point(12, 233);
            label2.Name = "label2";
            label2.Size = new Size(100, 35);
            label2.TabIndex = 3;
            label2.Text = "Start";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.MouseClick += HronoStartEvent;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowText;
            label3.Enabled = false;
            label3.Font = new Font("Digital-7", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LightSteelBlue;
            label3.Location = new Point(146, 233);
            label3.Name = "label3";
            label3.Size = new Size(83, 35);
            label3.TabIndex = 4;
            label3.Text = "Stop";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.MouseClick += HronoStopEvent;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Digital-7", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.LightSteelBlue;
            label4.Location = new Point(269, 233);
            label4.Name = "label4";
            label4.Size = new Size(96, 35);
            label4.TabIndex = 5;
            label4.Text = "Reset";
            label4.MouseClick += HronoResetEvent;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Digital-7", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.LightSteelBlue;
            label5.Location = new Point(474, 125);
            label5.Name = "label5";
            label5.Size = new Size(100, 35);
            label5.TabIndex = 6;
            label5.Text = "Hrono";
            label5.MouseClick += HronoClickEvent;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Digital-7", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.LightSteelBlue;
            label6.Location = new Point(474, 176);
            label6.Name = "label6";
            label6.Size = new Size(87, 35);
            label6.TabIndex = 7;
            label6.Text = "Timer";
            label6.MouseClick += TimerClickEvent;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Digital-7", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel.ForeColor = Color.Lime;
            DateLabel.Location = new Point(74, 160);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(155, 28);
            DateLabel.TabIndex = 8;
            DateLabel.Text = "June 25 2023";
            // 
            // DayLabel
            // 
            DayLabel.AutoSize = true;
            DayLabel.Font = new Font("Digital-7", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            DayLabel.ForeColor = Color.Lime;
            DayLabel.Location = new Point(285, 160);
            DayLabel.Name = "DayLabel";
            DayLabel.Size = new Size(90, 28);
            DayLabel.TabIndex = 9;
            DayLabel.Text = "Monday";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(595, 291);
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
            Name = "Form1";
            Text = "Digital Clock";
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
    }
}
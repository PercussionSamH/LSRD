﻿namespace LSRD_hmi
{
    partial class Form_Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PB_Back_To_Home = new System.Windows.Forms.PictureBox();
            this.Toggle_doorman = new System.Windows.Forms.PictureBox();
            this.Toggle_drawing = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Toggle_scavenger = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Text_enter_initials_prompt = new System.Windows.Forms.Label();
            this.start_t_hr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PB_schedule_wave = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_current_time = new System.Windows.Forms.Label();
            this.text_clock = new System.Windows.Forms.TextBox();
            this.tmr_upd_clock = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.text_scheduled_time = new System.Windows.Forms.TextBox();
            this.t_duration = new System.Windows.Forms.NumericUpDown();
            this.start_t_min = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.start_t_PM = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.text_scheduled_length = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toggle_doorman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toggle_drawing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toggle_scavenger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_schedule_wave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Back_To_Home
            // 
            this.PB_Back_To_Home.BackColor = System.Drawing.Color.Transparent;
            this.PB_Back_To_Home.Image = global::LSRD_hmi.Properties.Resources.PB_gray_back_to_home;
            this.PB_Back_To_Home.Location = new System.Drawing.Point(27, 22);
            this.PB_Back_To_Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB_Back_To_Home.MaximumSize = new System.Drawing.Size(124, 80);
            this.PB_Back_To_Home.MinimumSize = new System.Drawing.Size(124, 80);
            this.PB_Back_To_Home.Name = "PB_Back_To_Home";
            this.PB_Back_To_Home.Size = new System.Drawing.Size(124, 80);
            this.PB_Back_To_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Back_To_Home.TabIndex = 12;
            this.PB_Back_To_Home.TabStop = false;
            this.PB_Back_To_Home.Click += new System.EventHandler(this.PB_Back_To_Home_Click);
            // 
            // Toggle_doorman
            // 
            this.Toggle_doorman.BackColor = System.Drawing.Color.Transparent;
            this.Toggle_doorman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Toggle_doorman.Image = global::LSRD_hmi.Properties.Resources.toggle_off;
            this.Toggle_doorman.Location = new System.Drawing.Point(411, 246);
            this.Toggle_doorman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Toggle_doorman.MaximumSize = new System.Drawing.Size(91, 46);
            this.Toggle_doorman.MinimumSize = new System.Drawing.Size(91, 46);
            this.Toggle_doorman.Name = "Toggle_doorman";
            this.Toggle_doorman.Size = new System.Drawing.Size(91, 46);
            this.Toggle_doorman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Toggle_doorman.TabIndex = 13;
            this.Toggle_doorman.TabStop = false;
            this.Toggle_doorman.Click += new System.EventHandler(this.Toggle_doorman_Click);
            // 
            // Toggle_drawing
            // 
            this.Toggle_drawing.BackColor = System.Drawing.Color.Transparent;
            this.Toggle_drawing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Toggle_drawing.Image = global::LSRD_hmi.Properties.Resources.toggle_on;
            this.Toggle_drawing.Location = new System.Drawing.Point(411, 327);
            this.Toggle_drawing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Toggle_drawing.MaximumSize = new System.Drawing.Size(91, 46);
            this.Toggle_drawing.MinimumSize = new System.Drawing.Size(91, 46);
            this.Toggle_drawing.Name = "Toggle_drawing";
            this.Toggle_drawing.Size = new System.Drawing.Size(91, 46);
            this.Toggle_drawing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Toggle_drawing.TabIndex = 14;
            this.Toggle_drawing.TabStop = false;
            this.Toggle_drawing.Click += new System.EventHandler(this.Toggle_drawing_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enable Modes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Doorman Mode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fish Drawing Demo";
            // 
            // Toggle_scavenger
            // 
            this.Toggle_scavenger.BackColor = System.Drawing.Color.Transparent;
            this.Toggle_scavenger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Toggle_scavenger.Image = global::LSRD_hmi.Properties.Resources.toggle_off;
            this.Toggle_scavenger.Location = new System.Drawing.Point(411, 409);
            this.Toggle_scavenger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Toggle_scavenger.MaximumSize = new System.Drawing.Size(91, 46);
            this.Toggle_scavenger.MinimumSize = new System.Drawing.Size(91, 46);
            this.Toggle_scavenger.Name = "Toggle_scavenger";
            this.Toggle_scavenger.Size = new System.Drawing.Size(91, 46);
            this.Toggle_scavenger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Toggle_scavenger.TabIndex = 18;
            this.Toggle_scavenger.TabStop = false;
            this.Toggle_scavenger.Click += new System.EventHandler(this.Toggle_scavenger_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Scavenger Hunt Demo";
            // 
            // Text_enter_initials_prompt
            // 
            this.Text_enter_initials_prompt.BackColor = System.Drawing.Color.Transparent;
            this.Text_enter_initials_prompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_enter_initials_prompt.ForeColor = System.Drawing.Color.Black;
            this.Text_enter_initials_prompt.Location = new System.Drawing.Point(601, 186);
            this.Text_enter_initials_prompt.Name = "Text_enter_initials_prompt";
            this.Text_enter_initials_prompt.Size = new System.Drawing.Size(205, 25);
            this.Text_enter_initials_prompt.TabIndex = 21;
            this.Text_enter_initials_prompt.Text = " Start Time:";
            this.Text_enter_initials_prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start_t_hr
            // 
            this.start_t_hr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.start_t_hr.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_t_hr.Location = new System.Drawing.Point(604, 219);
            this.start_t_hr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start_t_hr.MaxLength = 2;
            this.start_t_hr.Name = "start_t_hr";
            this.start_t_hr.Size = new System.Drawing.Size(56, 45);
            this.start_t_hr.TabIndex = 20;
            this.start_t_hr.Text = "00";
            this.start_t_hr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.start_t_hr.TextChanged += new System.EventHandler(this.start_time_hr_textchanged);
            this.start_t_hr.Enter += new System.EventHandler(this.start_time_hr_select);
            this.start_t_hr.Leave += new System.EventHandler(this.start_time_hour_unfocused);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(824, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = " Duration:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_schedule_wave
            // 
            this.PB_schedule_wave.BackColor = System.Drawing.Color.Transparent;
            this.PB_schedule_wave.Image = global::LSRD_hmi.Properties.Resources.PB_wave_demo1;
            this.PB_schedule_wave.Location = new System.Drawing.Point(695, 477);
            this.PB_schedule_wave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB_schedule_wave.MaximumSize = new System.Drawing.Size(188, 89);
            this.PB_schedule_wave.Name = "PB_schedule_wave";
            this.PB_schedule_wave.Size = new System.Drawing.Size(188, 89);
            this.PB_schedule_wave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_schedule_wave.TabIndex = 24;
            this.PB_schedule_wave.TabStop = false;
            this.PB_schedule_wave.Click += new System.EventHandler(this.PB_schedule_wave_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(609, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 50);
            this.label6.TabIndex = 25;
            this.label6.Text = "Configure Wave Demo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_current_time
            // 
            this.label_current_time.BackColor = System.Drawing.Color.Transparent;
            this.label_current_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_current_time.ForeColor = System.Drawing.Color.Black;
            this.label_current_time.Location = new System.Drawing.Point(315, 44);
            this.label_current_time.Name = "label_current_time";
            this.label_current_time.Size = new System.Drawing.Size(236, 41);
            this.label_current_time.TabIndex = 26;
            this.label_current_time.Text = "Current time:";
            this.label_current_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_clock
            // 
            this.text_clock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_clock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_clock.Location = new System.Drawing.Point(541, 46);
            this.text_clock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_clock.MaxLength = 2;
            this.text_clock.Name = "text_clock";
            this.text_clock.ReadOnly = true;
            this.text_clock.Size = new System.Drawing.Size(229, 45);
            this.text_clock.TabIndex = 27;
            this.text_clock.Text = "00:00:00 PM";
            this.text_clock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmr_upd_clock
            // 
            this.tmr_upd_clock.Interval = 1000;
            this.tmr_upd_clock.Tick += new System.EventHandler(this.tmr_upd_clock_Tick);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(608, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "(Format as HH:MM)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(827, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "(in minutes)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(637, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 50);
            this.label9.TabIndex = 31;
            this.label9.Text = "Wave Demo\r\nScheduled for:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_scheduled_time
            // 
            this.text_scheduled_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_scheduled_time.Location = new System.Drawing.Point(637, 380);
            this.text_scheduled_time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_scheduled_time.MaxLength = 5;
            this.text_scheduled_time.Name = "text_scheduled_time";
            this.text_scheduled_time.ReadOnly = true;
            this.text_scheduled_time.Size = new System.Drawing.Size(148, 38);
            this.text_scheduled_time.TabIndex = 32;
            this.text_scheduled_time.Text = "00:00 AM";
            this.text_scheduled_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t_duration
            // 
            this.t_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_duration.Location = new System.Drawing.Point(824, 219);
            this.t_duration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.t_duration.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.t_duration.Name = "t_duration";
            this.t_duration.Size = new System.Drawing.Size(95, 45);
            this.t_duration.TabIndex = 34;
            this.t_duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t_duration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // start_t_min
            // 
            this.start_t_min.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.start_t_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_t_min.Location = new System.Drawing.Point(657, 219);
            this.start_t_min.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start_t_min.MaxLength = 2;
            this.start_t_min.Name = "start_t_min";
            this.start_t_min.Size = new System.Drawing.Size(56, 45);
            this.start_t_min.TabIndex = 35;
            this.start_t_min.Text = "00";
            this.start_t_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.start_t_min.TextChanged += new System.EventHandler(this.start_time_min_textchanged);
            this.start_t_min.Leave += new System.EventHandler(this.start_time_minute_unfocused);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(660, 222);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(7, 38);
            this.textBox1.TabIndex = 36;
            this.textBox1.Text = ":";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // start_t_PM
            // 
            this.start_t_PM.DropDownWidth = 12;
            this.start_t_PM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_t_PM.FormattingEnabled = true;
            this.start_t_PM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.start_t_PM.Location = new System.Drawing.Point(719, 220);
            this.start_t_PM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start_t_PM.MaxLength = 2;
            this.start_t_PM.Name = "start_t_PM";
            this.start_t_PM.Size = new System.Drawing.Size(81, 44);
            this.start_t_PM.TabIndex = 37;
            this.start_t_PM.Text = "AM";
            this.start_t_PM.Leave += new System.EventHandler(this.start_time_AM_PM_unfocused);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(-19, -18);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 38;
            // 
            // text_scheduled_length
            // 
            this.text_scheduled_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_scheduled_length.Location = new System.Drawing.Point(796, 380);
            this.text_scheduled_length.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_scheduled_length.MaxLength = 5;
            this.text_scheduled_length.Name = "text_scheduled_length";
            this.text_scheduled_length.ReadOnly = true;
            this.text_scheduled_length.Size = new System.Drawing.Size(148, 38);
            this.text_scheduled_length.TabIndex = 39;
            this.text_scheduled_length.Text = "44 min";
            this.text_scheduled_length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(796, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 50);
            this.label10.TabIndex = 40;
            this.label10.Text = "Length:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LSRD_hmi.Properties.Resources.PB_cancel_small_wave_demo1;
            this.pictureBox1.Location = new System.Drawing.Point(660, 420);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(188, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LSRD_hmi.Properties.Resources.slideshow_texture_white1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text_scheduled_length);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.start_t_PM);
            this.Controls.Add(this.t_duration);
            this.Controls.Add(this.text_scheduled_time);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_clock);
            this.Controls.Add(this.label_current_time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PB_schedule_wave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Text_enter_initials_prompt);
            this.Controls.Add(this.start_t_hr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Toggle_scavenger);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Toggle_drawing);
            this.Controls.Add(this.Toggle_doorman);
            this.Controls.Add(this.PB_Back_To_Home);
            this.Controls.Add(this.start_t_min);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1024, 601);
            this.MinimumSize = new System.Drawing.Size(1024, 601);
            this.Name = "Form_Settings";
            this.Text = "Form_Settings";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toggle_doorman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toggle_drawing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toggle_scavenger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_schedule_wave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Back_To_Home;
        private System.Windows.Forms.PictureBox Toggle_doorman;
        private System.Windows.Forms.PictureBox Toggle_drawing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Toggle_scavenger;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Text_enter_initials_prompt;
        private System.Windows.Forms.TextBox start_t_hr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox PB_schedule_wave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_current_time;
        private System.Windows.Forms.TextBox text_clock;
        private System.Windows.Forms.Timer tmr_upd_clock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_scheduled_time;
        private System.Windows.Forms.NumericUpDown t_duration;
        private System.Windows.Forms.TextBox start_t_min;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox start_t_PM;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox text_scheduled_length;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
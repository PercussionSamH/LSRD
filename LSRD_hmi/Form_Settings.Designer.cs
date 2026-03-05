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
            this.i_start_time_hr = new System.Windows.Forms.TextBox();
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
            this.i_num_duration = new System.Windows.Forms.NumericUpDown();
            this.i_start_time_min = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.i_start_time_AM_PM = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toggle_doorman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toggle_drawing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toggle_scavenger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_schedule_wave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_num_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Back_To_Home
            // 
            this.PB_Back_To_Home.BackColor = System.Drawing.Color.Transparent;
            this.PB_Back_To_Home.Image = global::LSRD_hmi.Properties.Resources.PB_gray_back_to_home;
            this.PB_Back_To_Home.Location = new System.Drawing.Point(27, 22);
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
            this.Toggle_doorman.Location = new System.Drawing.Point(364, 243);
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
            this.Toggle_drawing.Location = new System.Drawing.Point(364, 324);
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
            this.label1.Location = new System.Drawing.Point(166, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enable Modes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Doorman Mode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 327);
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
            this.Toggle_scavenger.Location = new System.Drawing.Point(364, 408);
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
            this.label4.Location = new System.Drawing.Point(36, 412);
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
            this.Text_enter_initials_prompt.Location = new System.Drawing.Point(595, 186);
            this.Text_enter_initials_prompt.Name = "Text_enter_initials_prompt";
            this.Text_enter_initials_prompt.Size = new System.Drawing.Size(176, 25);
            this.Text_enter_initials_prompt.TabIndex = 21;
            this.Text_enter_initials_prompt.Text = " Start Time:";
            this.Text_enter_initials_prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // i_start_time_hr
            // 
            this.i_start_time_hr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.i_start_time_hr.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i_start_time_hr.Location = new System.Drawing.Point(604, 219);
            this.i_start_time_hr.MaxLength = 2;
            this.i_start_time_hr.Name = "i_start_time_hr";
            this.i_start_time_hr.Size = new System.Drawing.Size(56, 45);
            this.i_start_time_hr.TabIndex = 20;
            this.i_start_time_hr.Text = "00";
            this.i_start_time_hr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.i_start_time_hr.TextChanged += new System.EventHandler(this.start_time_hr_textchanged);
            this.i_start_time_hr.Enter += new System.EventHandler(this.start_time_hr_select);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(796, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = " Duration:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_schedule_wave
            // 
            this.PB_schedule_wave.BackColor = System.Drawing.Color.Transparent;
            this.PB_schedule_wave.Image = global::LSRD_hmi.Properties.Resources.PB_wave_demo;
            this.PB_schedule_wave.Location = new System.Drawing.Point(695, 460);
            this.PB_schedule_wave.MaximumSize = new System.Drawing.Size(200, 100);
            this.PB_schedule_wave.MinimumSize = new System.Drawing.Size(200, 100);
            this.PB_schedule_wave.Name = "PB_schedule_wave";
            this.PB_schedule_wave.Size = new System.Drawing.Size(200, 100);
            this.PB_schedule_wave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_schedule_wave.TabIndex = 24;
            this.PB_schedule_wave.TabStop = false;
            this.PB_schedule_wave.Click += new System.EventHandler(this.PB_schedule_wave_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(609, 125);
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
            this.label_current_time.Size = new System.Drawing.Size(236, 45);
            this.label_current_time.TabIndex = 26;
            this.label_current_time.Text = "Current time:\r\n";
            this.label_current_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_clock
            // 
            this.text_clock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_clock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_clock.Location = new System.Drawing.Point(542, 44);
            this.text_clock.MaxLength = 2;
            this.text_clock.Name = "text_clock";
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
            this.label7.Location = new System.Drawing.Point(595, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Format as HH:MM";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(791, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Duration in minutes";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(666, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Wave Demo Scheduled for:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // text_scheduled_time
            // 
            this.text_scheduled_time.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_scheduled_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_scheduled_time.Location = new System.Drawing.Point(714, 371);
            this.text_scheduled_time.MaxLength = 5;
            this.text_scheduled_time.Name = "text_scheduled_time";
            this.text_scheduled_time.Size = new System.Drawing.Size(148, 38);
            this.text_scheduled_time.TabIndex = 32;
            this.text_scheduled_time.Text = "00:00 AM";
            this.text_scheduled_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // i_num_duration
            // 
            this.i_num_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i_num_duration.Location = new System.Drawing.Point(824, 219);
            this.i_num_duration.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.i_num_duration.Name = "i_num_duration";
            this.i_num_duration.Size = new System.Drawing.Size(95, 45);
            this.i_num_duration.TabIndex = 34;
            this.i_num_duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.i_num_duration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // i_start_time_min
            // 
            this.i_start_time_min.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.i_start_time_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i_start_time_min.Location = new System.Drawing.Point(657, 219);
            this.i_start_time_min.MaxLength = 2;
            this.i_start_time_min.Name = "i_start_time_min";
            this.i_start_time_min.Size = new System.Drawing.Size(56, 45);
            this.i_start_time_min.TabIndex = 35;
            this.i_start_time_min.Text = "00";
            this.i_start_time_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.i_start_time_min.TextChanged += new System.EventHandler(this.start_time_min_textchanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(660, 222);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(7, 38);
            this.textBox1.TabIndex = 36;
            this.textBox1.Text = ":";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // i_start_time_AM_PM
            // 
            this.i_start_time_AM_PM.DropDownWidth = 12;
            this.i_start_time_AM_PM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i_start_time_AM_PM.FormattingEnabled = true;
            this.i_start_time_AM_PM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.i_start_time_AM_PM.Location = new System.Drawing.Point(719, 220);
            this.i_start_time_AM_PM.MaxLength = 2;
            this.i_start_time_AM_PM.Name = "i_start_time_AM_PM";
            this.i_start_time_AM_PM.Size = new System.Drawing.Size(82, 44);
            this.i_start_time_AM_PM.TabIndex = 37;
            this.i_start_time_AM_PM.Text = "AM";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(-19, -19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 38;
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LSRD_hmi.Properties.Resources.slideshow_texture_white1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.i_start_time_AM_PM);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.i_num_duration);
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
            this.Controls.Add(this.i_start_time_hr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Toggle_scavenger);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Toggle_drawing);
            this.Controls.Add(this.Toggle_doorman);
            this.Controls.Add(this.PB_Back_To_Home);
            this.Controls.Add(this.i_start_time_min);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form_Settings";
            this.Text = "Form_Settings";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toggle_doorman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toggle_drawing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toggle_scavenger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_schedule_wave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_num_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.TextBox i_start_time_hr;
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
        private System.Windows.Forms.NumericUpDown i_num_duration;
        private System.Windows.Forms.TextBox i_start_time_min;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox i_start_time_AM_PM;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
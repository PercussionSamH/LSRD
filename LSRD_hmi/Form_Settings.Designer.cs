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
            this.panel3 = new System.Windows.Forms.Panel();
            this.text_clock = new System.Windows.Forms.TextBox();
            this.label_current_time = new System.Windows.Forms.Label();
            this.Toggle_wave = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Toggle_scavenger = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Toggle_drawing = new System.Windows.Forms.PictureBox();
            this.Toggle_doorman = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_time_left = new System.Windows.Forms.TextBox();
            this.PB_start_wave_demo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.t_duration = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tmr_upd_clock = new System.Windows.Forms.Timer(this.components);
            this.PB_Back_To_Home = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Toggle_wave)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Toggle_scavenger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toggle_drawing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toggle_doorman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_start_wave_demo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.text_clock);
            this.panel3.Controls.Add(this.label_current_time);
            this.panel3.Location = new System.Drawing.Point(289, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 60);
            this.panel3.TabIndex = 47;
            // 
            // text_clock
            // 
            this.text_clock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.text_clock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_clock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_clock.Location = new System.Drawing.Point(223, 10);
            this.text_clock.Margin = new System.Windows.Forms.Padding(2);
            this.text_clock.MaxLength = 2;
            this.text_clock.Name = "text_clock";
            this.text_clock.ReadOnly = true;
            this.text_clock.Size = new System.Drawing.Size(251, 45);
            this.text_clock.TabIndex = 27;
            this.text_clock.Text = "00:00:00 PM";
            this.text_clock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_current_time
            // 
            this.label_current_time.BackColor = System.Drawing.Color.Transparent;
            this.label_current_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_current_time.ForeColor = System.Drawing.Color.Black;
            this.label_current_time.Location = new System.Drawing.Point(15, 10);
            this.label_current_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_current_time.Name = "label_current_time";
            this.label_current_time.Size = new System.Drawing.Size(204, 37);
            this.label_current_time.TabIndex = 26;
            this.label_current_time.Text = "Current time:";
            this.label_current_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Toggle_wave
            // 
            this.Toggle_wave.BackColor = System.Drawing.Color.Transparent;
            this.Toggle_wave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Toggle_wave.Image = global::LSRD_hmi.Properties.Resources.toggle_off;
            this.Toggle_wave.Location = new System.Drawing.Point(313, 305);
            this.Toggle_wave.Margin = new System.Windows.Forms.Padding(2);
            this.Toggle_wave.MaximumSize = new System.Drawing.Size(80, 48);
            this.Toggle_wave.Name = "Toggle_wave";
            this.Toggle_wave.Size = new System.Drawing.Size(80, 48);
            this.Toggle_wave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Toggle_wave.TabIndex = 20;
            this.Toggle_wave.TabStop = false;
            this.Toggle_wave.Click += new System.EventHandler(this.Toggle_wave_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Toggle_wave);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Toggle_scavenger);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Toggle_drawing);
            this.panel2.Controls.Add(this.Toggle_doorman);
            this.panel2.Location = new System.Drawing.Point(33, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 394);
            this.panel2.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 305);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 48);
            this.label5.TabIndex = 21;
            this.label5.Text = "Wave Demo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Toggle_scavenger
            // 
            this.Toggle_scavenger.BackColor = System.Drawing.Color.Transparent;
            this.Toggle_scavenger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Toggle_scavenger.Image = global::LSRD_hmi.Properties.Resources.toggle_off;
            this.Toggle_scavenger.Location = new System.Drawing.Point(313, 230);
            this.Toggle_scavenger.Margin = new System.Windows.Forms.Padding(2);
            this.Toggle_scavenger.MaximumSize = new System.Drawing.Size(80, 48);
            this.Toggle_scavenger.Name = "Toggle_scavenger";
            this.Toggle_scavenger.Size = new System.Drawing.Size(80, 48);
            this.Toggle_scavenger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Toggle_scavenger.TabIndex = 18;
            this.Toggle_scavenger.TabStop = false;
            this.Toggle_scavenger.Click += new System.EventHandler(this.Toggle_scavenger_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 48);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fish Drawing Mode";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 48);
            this.label2.TabIndex = 16;
            this.label2.Text = "Doorman Mode";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 56);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enable Modes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 48);
            this.label4.TabIndex = 19;
            this.label4.Text = "Scavenger Hunt";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Toggle_drawing
            // 
            this.Toggle_drawing.BackColor = System.Drawing.Color.Transparent;
            this.Toggle_drawing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Toggle_drawing.Image = global::LSRD_hmi.Properties.Resources.toggle_on;
            this.Toggle_drawing.Location = new System.Drawing.Point(313, 155);
            this.Toggle_drawing.Margin = new System.Windows.Forms.Padding(2);
            this.Toggle_drawing.MaximumSize = new System.Drawing.Size(80, 48);
            this.Toggle_drawing.Name = "Toggle_drawing";
            this.Toggle_drawing.Size = new System.Drawing.Size(80, 48);
            this.Toggle_drawing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Toggle_drawing.TabIndex = 14;
            this.Toggle_drawing.TabStop = false;
            this.Toggle_drawing.Click += new System.EventHandler(this.Toggle_drawing_Click);
            // 
            // Toggle_doorman
            // 
            this.Toggle_doorman.BackColor = System.Drawing.Color.Transparent;
            this.Toggle_doorman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Toggle_doorman.Image = global::LSRD_hmi.Properties.Resources.toggle_off;
            this.Toggle_doorman.Location = new System.Drawing.Point(313, 80);
            this.Toggle_doorman.Margin = new System.Windows.Forms.Padding(2);
            this.Toggle_doorman.MaximumSize = new System.Drawing.Size(80, 48);
            this.Toggle_doorman.Name = "Toggle_doorman";
            this.Toggle_doorman.Size = new System.Drawing.Size(80, 48);
            this.Toggle_doorman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Toggle_doorman.TabIndex = 13;
            this.Toggle_doorman.TabStop = false;
            this.Toggle_doorman.Click += new System.EventHandler(this.Toggle_doorman_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(56, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 45);
            this.label7.TabIndex = 42;
            this.label7.Text = "Time Left:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_time_left
            // 
            this.text_time_left.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.text_time_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_time_left.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_time_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_time_left.Location = new System.Drawing.Point(253, 162);
            this.text_time_left.Margin = new System.Windows.Forms.Padding(2);
            this.text_time_left.MaxLength = 2;
            this.text_time_left.Name = "text_time_left";
            this.text_time_left.ReadOnly = true;
            this.text_time_left.Size = new System.Drawing.Size(133, 45);
            this.text_time_left.TabIndex = 28;
            this.text_time_left.Text = "00";
            this.text_time_left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PB_start_wave_demo
            // 
            this.PB_start_wave_demo.BackColor = System.Drawing.Color.Transparent;
            this.PB_start_wave_demo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_start_wave_demo.Image = global::LSRD_hmi.Properties.Resources.PB_wave_demo2;
            this.PB_start_wave_demo.Location = new System.Drawing.Point(135, 237);
            this.PB_start_wave_demo.Margin = new System.Windows.Forms.Padding(2);
            this.PB_start_wave_demo.MinimumSize = new System.Drawing.Size(80, 48);
            this.PB_start_wave_demo.Name = "PB_start_wave_demo";
            this.PB_start_wave_demo.Size = new System.Drawing.Size(180, 79);
            this.PB_start_wave_demo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_start_wave_demo.TabIndex = 41;
            this.PB_start_wave_demo.TabStop = false;
            this.PB_start_wave_demo.Click += new System.EventHandler(this.PB_start_wave_demo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PB_start_wave_demo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.text_time_left);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.t_duration);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(540, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 358);
            this.panel1.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(78, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 45);
            this.label10.TabIndex = 40;
            this.label10.Text = "Length:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t_duration
            // 
            this.t_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_duration.Location = new System.Drawing.Point(253, 86);
            this.t_duration.Margin = new System.Windows.Forms.Padding(2);
            this.t_duration.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.t_duration.Name = "t_duration";
            this.t_duration.Size = new System.Drawing.Size(133, 45);
            this.t_duration.TabIndex = 34;
            this.t_duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_duration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(71, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 45);
            this.label8.TabIndex = 30;
            this.label8.Text = "(in minutes)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-1, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(452, 56);
            this.label6.TabIndex = 25;
            this.label6.Text = "Configure Wave Demo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmr_upd_clock
            // 
            this.tmr_upd_clock.Enabled = true;
            this.tmr_upd_clock.Interval = 1000;
            this.tmr_upd_clock.Tick += new System.EventHandler(this.tmr_upd_clock_Tick);
            // 
            // PB_Back_To_Home
            // 
            this.PB_Back_To_Home.BackColor = System.Drawing.Color.Transparent;
            this.PB_Back_To_Home.Image = global::LSRD_hmi.Properties.Resources.PB_back_wide1;
            this.PB_Back_To_Home.Location = new System.Drawing.Point(33, 32);
            this.PB_Back_To_Home.Margin = new System.Windows.Forms.Padding(2);
            this.PB_Back_To_Home.MaximumSize = new System.Drawing.Size(160, 80);
            this.PB_Back_To_Home.MinimumSize = new System.Drawing.Size(93, 65);
            this.PB_Back_To_Home.Name = "PB_Back_To_Home";
            this.PB_Back_To_Home.Size = new System.Drawing.Size(155, 75);
            this.PB_Back_To_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Back_To_Home.TabIndex = 44;
            this.PB_Back_To_Home.TabStop = false;
            this.PB_Back_To_Home.Click += new System.EventHandler(this.PB_Back_To_Home_Click);
            // 
            // Form_Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::LSRD_hmi.Properties.Resources.slideshow_texture_white2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PB_Back_To_Home);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form_Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Settings_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Toggle_wave)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Toggle_scavenger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toggle_drawing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toggle_doorman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_start_wave_demo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox text_clock;
        private System.Windows.Forms.Label label_current_time;
        private System.Windows.Forms.PictureBox Toggle_wave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Toggle_scavenger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Toggle_drawing;
        private System.Windows.Forms.PictureBox Toggle_doorman;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_time_left;
        private System.Windows.Forms.PictureBox PB_start_wave_demo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown t_duration;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer tmr_upd_clock;
        private System.Windows.Forms.PictureBox PB_Back_To_Home;
    }
}
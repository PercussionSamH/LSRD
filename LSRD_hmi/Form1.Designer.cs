namespace LSRD_hmi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer_Modbus_Com = new System.Windows.Forms.Timer(this.components);
            this.PB_Draw_Fish1 = new System.Windows.Forms.Button();
            this.PB_Draw_Square = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PB_Quit_Program = new System.Windows.Forms.Button();
            this.Picture_LSRD_Logo = new System.Windows.Forms.PictureBox();
            this.PB_doorman_mode = new System.Windows.Forms.PictureBox();
            this.PB_drawing_mode = new System.Windows.Forms.PictureBox();
            this.PB_scavenger_mode = new System.Windows.Forms.PictureBox();
            this.Picturebox_logo = new System.Windows.Forms.PictureBox();
            this.PB_staff_controls = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.test_textbox = new System.Windows.Forms.Label();
            this.tmr_update_vars = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_LSRD_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_doorman_mode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_drawing_mode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_scavenger_mode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_staff_controls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_Modbus_Com
            // 
            this.timer_Modbus_Com.Tick += new System.EventHandler(this.timer_Modbus_Com_Tick);
            // 
            // PB_Draw_Fish1
            // 
            this.PB_Draw_Fish1.BackColor = System.Drawing.Color.Silver;
            this.PB_Draw_Fish1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Draw_Fish1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PB_Draw_Fish1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PB_Draw_Fish1.Location = new System.Drawing.Point(13, 543);
            this.PB_Draw_Fish1.Margin = new System.Windows.Forms.Padding(4);
            this.PB_Draw_Fish1.Name = "PB_Draw_Fish1";
            this.PB_Draw_Fish1.Size = new System.Drawing.Size(60, 34);
            this.PB_Draw_Fish1.TabIndex = 2;
            this.PB_Draw_Fish1.Text = "Draw Fish One";
            this.PB_Draw_Fish1.UseVisualStyleBackColor = false;
            this.PB_Draw_Fish1.Visible = false;
            this.PB_Draw_Fish1.Click += new System.EventHandler(this.PB_Draw_Fish1_Click);
            // 
            // PB_Draw_Square
            // 
            this.PB_Draw_Square.BackColor = System.Drawing.Color.LightGray;
            this.PB_Draw_Square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Draw_Square.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PB_Draw_Square.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PB_Draw_Square.Location = new System.Drawing.Point(81, 543);
            this.PB_Draw_Square.Margin = new System.Windows.Forms.Padding(4);
            this.PB_Draw_Square.Name = "PB_Draw_Square";
            this.PB_Draw_Square.Size = new System.Drawing.Size(60, 34);
            this.PB_Draw_Square.TabIndex = 3;
            this.PB_Draw_Square.Text = "Draw Square";
            this.PB_Draw_Square.UseVisualStyleBackColor = false;
            this.PB_Draw_Square.Visible = false;
            this.PB_Draw_Square.Click += new System.EventHandler(this.PB_Draw_Square_Click);
            // 
            // PB_Quit_Program
            // 
            this.PB_Quit_Program.BackColor = System.Drawing.Color.Gainsboro;
            this.PB_Quit_Program.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Quit_Program.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PB_Quit_Program.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PB_Quit_Program.Location = new System.Drawing.Point(13, 324);
            this.PB_Quit_Program.Margin = new System.Windows.Forms.Padding(4);
            this.PB_Quit_Program.Name = "PB_Quit_Program";
            this.PB_Quit_Program.Size = new System.Drawing.Size(128, 76);
            this.PB_Quit_Program.TabIndex = 6;
            this.PB_Quit_Program.Text = "Quit program\r\n(debug only)";
            this.PB_Quit_Program.UseVisualStyleBackColor = false;
            this.PB_Quit_Program.Click += new System.EventHandler(this.PB_Quit_Program_Click);
            // 
            // Picture_LSRD_Logo
            // 
            this.Picture_LSRD_Logo.BackColor = System.Drawing.Color.Transparent;
            this.Picture_LSRD_Logo.Image = global::LSRD_hmi.Properties.Resources.LogoBright_transparent;
            this.Picture_LSRD_Logo.Location = new System.Drawing.Point(26, 82);
            this.Picture_LSRD_Logo.Name = "Picture_LSRD_Logo";
            this.Picture_LSRD_Logo.Size = new System.Drawing.Size(220, 196);
            this.Picture_LSRD_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_LSRD_Logo.TabIndex = 9;
            this.Picture_LSRD_Logo.TabStop = false;
            // 
            // PB_doorman_mode
            // 
            this.PB_doorman_mode.BackColor = System.Drawing.Color.Transparent;
            this.PB_doorman_mode.Image = global::LSRD_hmi.Properties.Resources.PB_gray_doorman_demo;
            this.PB_doorman_mode.Location = new System.Drawing.Point(154, 430);
            this.PB_doorman_mode.MaximumSize = new System.Drawing.Size(200, 100);
            this.PB_doorman_mode.MinimumSize = new System.Drawing.Size(200, 100);
            this.PB_doorman_mode.Name = "PB_doorman_mode";
            this.PB_doorman_mode.Size = new System.Drawing.Size(200, 100);
            this.PB_doorman_mode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_doorman_mode.TabIndex = 10;
            this.PB_doorman_mode.TabStop = false;
            this.PB_doorman_mode.Click += new System.EventHandler(this.PB_doorman_mode_Click);
            // 
            // PB_drawing_mode
            // 
            this.PB_drawing_mode.BackColor = System.Drawing.Color.Transparent;
            this.PB_drawing_mode.Image = global::LSRD_hmi.Properties.Resources.PB_gray_Drawing_demo;
            this.PB_drawing_mode.Location = new System.Drawing.Point(406, 430);
            this.PB_drawing_mode.MaximumSize = new System.Drawing.Size(200, 100);
            this.PB_drawing_mode.MinimumSize = new System.Drawing.Size(200, 100);
            this.PB_drawing_mode.Name = "PB_drawing_mode";
            this.PB_drawing_mode.Size = new System.Drawing.Size(200, 100);
            this.PB_drawing_mode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_drawing_mode.TabIndex = 11;
            this.PB_drawing_mode.TabStop = false;
            this.PB_drawing_mode.Click += new System.EventHandler(this.PB_drawing_mode_Click);
            // 
            // PB_scavenger_mode
            // 
            this.PB_scavenger_mode.BackColor = System.Drawing.Color.Transparent;
            this.PB_scavenger_mode.Image = ((System.Drawing.Image)(resources.GetObject("PB_scavenger_mode.Image")));
            this.PB_scavenger_mode.Location = new System.Drawing.Point(651, 430);
            this.PB_scavenger_mode.MaximumSize = new System.Drawing.Size(200, 100);
            this.PB_scavenger_mode.MinimumSize = new System.Drawing.Size(200, 100);
            this.PB_scavenger_mode.Name = "PB_scavenger_mode";
            this.PB_scavenger_mode.Size = new System.Drawing.Size(200, 100);
            this.PB_scavenger_mode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_scavenger_mode.TabIndex = 12;
            this.PB_scavenger_mode.TabStop = false;
            this.PB_scavenger_mode.Click += new System.EventHandler(this.PB_scavenger_mode_Click);
            // 
            // Picturebox_logo
            // 
            this.Picturebox_logo.BackColor = System.Drawing.Color.Transparent;
            this.Picturebox_logo.Image = global::LSRD_hmi.Properties.Resources.Title_text_light_green_fish_machine3;
            this.Picturebox_logo.Location = new System.Drawing.Point(283, 59);
            this.Picturebox_logo.MinimumSize = new System.Drawing.Size(277, 126);
            this.Picturebox_logo.Name = "Picturebox_logo";
            this.Picturebox_logo.Size = new System.Drawing.Size(429, 187);
            this.Picturebox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picturebox_logo.TabIndex = 13;
            this.Picturebox_logo.TabStop = false;
            // 
            // PB_staff_controls
            // 
            this.PB_staff_controls.BackColor = System.Drawing.Color.Transparent;
            this.PB_staff_controls.Image = ((System.Drawing.Image)(resources.GetObject("PB_staff_controls.Image")));
            this.PB_staff_controls.Location = new System.Drawing.Point(794, 12);
            this.PB_staff_controls.MaximumSize = new System.Drawing.Size(200, 100);
            this.PB_staff_controls.MinimumSize = new System.Drawing.Size(200, 100);
            this.PB_staff_controls.Name = "PB_staff_controls";
            this.PB_staff_controls.Size = new System.Drawing.Size(200, 100);
            this.PB_staff_controls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_staff_controls.TabIndex = 14;
            this.PB_staff_controls.TabStop = false;
            this.PB_staff_controls.Click += new System.EventHandler(this.PB_staff_controls_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LSRD_hmi.Properties.Resources.atlanticsalmon;
            this.pictureBox1.Location = new System.Drawing.Point(329, 252);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // test_textbox
            // 
            this.test_textbox.AutoSize = true;
            this.test_textbox.Location = new System.Drawing.Point(23, 523);
            this.test_textbox.Name = "test_textbox";
            this.test_textbox.Size = new System.Drawing.Size(44, 16);
            this.test_textbox.TabIndex = 4;
            this.test_textbox.Text = "label1";
            this.test_textbox.Visible = false;
            // 
            // tmr_update_vars
            // 
            this.tmr_update_vars.Enabled = true;
            this.tmr_update_vars.Tick += new System.EventHandler(this.tmr_update_vars_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(748, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(748, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LSRD_hmi.Properties.Resources.home_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB_staff_controls);
            this.Controls.Add(this.Picture_LSRD_Logo);
            this.Controls.Add(this.Picturebox_logo);
            this.Controls.Add(this.PB_scavenger_mode);
            this.Controls.Add(this.PB_drawing_mode);
            this.Controls.Add(this.PB_doorman_mode);
            this.Controls.Add(this.PB_Quit_Program);
            this.Controls.Add(this.test_textbox);
            this.Controls.Add(this.PB_Draw_Square);
            this.Controls.Add(this.PB_Draw_Fish1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_LSRD_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_doorman_mode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_drawing_mode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_scavenger_mode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_staff_controls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_Modbus_Com;
        private System.Windows.Forms.Button PB_Draw_Fish1;
        private System.Windows.Forms.Button PB_Draw_Square;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button PB_Quit_Program;
        private System.Windows.Forms.PictureBox Picture_LSRD_Logo;
        private System.Windows.Forms.PictureBox PB_doorman_mode;
        private System.Windows.Forms.PictureBox PB_drawing_mode;
        private System.Windows.Forms.PictureBox PB_scavenger_mode;
        private System.Windows.Forms.PictureBox Picturebox_logo;
        private System.Windows.Forms.PictureBox PB_staff_controls;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label test_textbox;
        private System.Windows.Forms.Timer tmr_update_vars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


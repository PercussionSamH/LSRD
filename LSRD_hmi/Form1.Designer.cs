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
            this.debug_wave_active = new System.Windows.Forms.Label();
            this.debug_wave_scheduled = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_panel = new System.Windows.Forms.Panel();
            this.pass4 = new System.Windows.Forms.DomainUpDown();
            this.pass3 = new System.Windows.Forms.DomainUpDown();
            this.pass2 = new System.Windows.Forms.DomainUpDown();
            this.pass1 = new System.Windows.Forms.DomainUpDown();
            this.text_wrong_pass = new System.Windows.Forms.Label();
            this.PB_confirm_pass = new System.Windows.Forms.PictureBox();
            this.PB_Back_To_Home = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_resolution = new System.Windows.Forms.Label();
            this.label_scaling = new System.Windows.Forms.Label();
            this.label_formsize = new System.Windows.Forms.Label();
            this.label_formsize2 = new System.Windows.Forms.Label();
            this.label_formsize3 = new System.Windows.Forms.Label();
            this.drawingactive = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tmr_wave_countdown = new System.Windows.Forms.Timer(this.components);
            this.debug_connection = new System.Windows.Forms.Label();
            this.debug_cred_text = new System.Windows.Forms.Label();
            this.debug_events = new System.Windows.Forms.Label();
            this.update_events = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_LSRD_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_doorman_mode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_drawing_mode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_scavenger_mode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_staff_controls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_confirm_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_Modbus_Com
            // 
            this.timer_Modbus_Com.Interval = 200;
            this.timer_Modbus_Com.Tick += new System.EventHandler(this.timer_Modbus_Com_Tick);
            // 
            // PB_Quit_Program
            // 
            this.PB_Quit_Program.BackColor = System.Drawing.Color.Gainsboro;
            this.PB_Quit_Program.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Quit_Program.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PB_Quit_Program.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PB_Quit_Program.Location = new System.Drawing.Point(10, 366);
            this.PB_Quit_Program.Name = "PB_Quit_Program";
            this.PB_Quit_Program.Size = new System.Drawing.Size(59, 45);
            this.PB_Quit_Program.TabIndex = 6;
            this.PB_Quit_Program.Text = "Quit program\r\n(debug only)";
            this.PB_Quit_Program.UseVisualStyleBackColor = false;
            this.PB_Quit_Program.Visible = false;
            this.PB_Quit_Program.Click += new System.EventHandler(this.PB_Quit_Program_Click);
            // 
            // Picture_LSRD_Logo
            // 
            this.Picture_LSRD_Logo.BackColor = System.Drawing.Color.Transparent;
            this.Picture_LSRD_Logo.Image = global::LSRD_hmi.Properties.Resources.colored_LogoBright1;
            this.Picture_LSRD_Logo.Location = new System.Drawing.Point(108, 195);
            this.Picture_LSRD_Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Picture_LSRD_Logo.Name = "Picture_LSRD_Logo";
            this.Picture_LSRD_Logo.Size = new System.Drawing.Size(180, 167);
            this.Picture_LSRD_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_LSRD_Logo.TabIndex = 9;
            this.Picture_LSRD_Logo.TabStop = false;
            // 
            // PB_doorman_mode
            // 
            this.PB_doorman_mode.BackColor = System.Drawing.Color.Transparent;
            this.PB_doorman_mode.Image = global::LSRD_hmi.Properties.Resources.PB_gray_doorman_demo;
            this.PB_doorman_mode.Location = new System.Drawing.Point(129, 450);
            this.PB_doorman_mode.Margin = new System.Windows.Forms.Padding(2);
            this.PB_doorman_mode.Name = "PB_doorman_mode";
            this.PB_doorman_mode.Size = new System.Drawing.Size(208, 105);
            this.PB_doorman_mode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_doorman_mode.TabIndex = 10;
            this.PB_doorman_mode.TabStop = false;
            this.PB_doorman_mode.Click += new System.EventHandler(this.PB_doorman_mode_Click);
            // 
            // PB_drawing_mode
            // 
            this.PB_drawing_mode.BackColor = System.Drawing.Color.Transparent;
            this.PB_drawing_mode.Image = global::LSRD_hmi.Properties.Resources.PB_gray_Draw_a_fish;
            this.PB_drawing_mode.Location = new System.Drawing.Point(408, 450);
            this.PB_drawing_mode.Margin = new System.Windows.Forms.Padding(2);
            this.PB_drawing_mode.Name = "PB_drawing_mode";
            this.PB_drawing_mode.Size = new System.Drawing.Size(208, 105);
            this.PB_drawing_mode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_drawing_mode.TabIndex = 11;
            this.PB_drawing_mode.TabStop = false;
            this.PB_drawing_mode.Click += new System.EventHandler(this.PB_drawing_mode_Click);
            // 
            // PB_scavenger_mode
            // 
            this.PB_scavenger_mode.BackColor = System.Drawing.Color.Transparent;
            this.PB_scavenger_mode.Image = ((System.Drawing.Image)(resources.GetObject("PB_scavenger_mode.Image")));
            this.PB_scavenger_mode.Location = new System.Drawing.Point(695, 450);
            this.PB_scavenger_mode.Margin = new System.Windows.Forms.Padding(2);
            this.PB_scavenger_mode.Name = "PB_scavenger_mode";
            this.PB_scavenger_mode.Size = new System.Drawing.Size(208, 105);
            this.PB_scavenger_mode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_scavenger_mode.TabIndex = 12;
            this.PB_scavenger_mode.TabStop = false;
            this.PB_scavenger_mode.Click += new System.EventHandler(this.PB_scavenger_mode_Click);
            // 
            // Picturebox_logo
            // 
            this.Picturebox_logo.BackColor = System.Drawing.Color.Transparent;
            this.Picturebox_logo.Image = global::LSRD_hmi.Properties.Resources.Title_text_CFREGOLD_fish_machine;
            this.Picturebox_logo.Location = new System.Drawing.Point(-22, 567);
            this.Picturebox_logo.Margin = new System.Windows.Forms.Padding(2);
            this.Picturebox_logo.MinimumSize = new System.Drawing.Size(208, 102);
            this.Picturebox_logo.Name = "Picturebox_logo";
            this.Picturebox_logo.Size = new System.Drawing.Size(401, 175);
            this.Picturebox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picturebox_logo.TabIndex = 13;
            this.Picturebox_logo.TabStop = false;
            this.Picturebox_logo.Visible = false;
            // 
            // PB_staff_controls
            // 
            this.PB_staff_controls.BackColor = System.Drawing.Color.Transparent;
            this.PB_staff_controls.Image = ((System.Drawing.Image)(resources.GetObject("PB_staff_controls.Image")));
            this.PB_staff_controls.Location = new System.Drawing.Point(749, 39);
            this.PB_staff_controls.Margin = new System.Windows.Forms.Padding(2);
            this.PB_staff_controls.Name = "PB_staff_controls";
            this.PB_staff_controls.Size = new System.Drawing.Size(208, 105);
            this.PB_staff_controls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_staff_controls.TabIndex = 14;
            this.PB_staff_controls.TabStop = false;
            this.PB_staff_controls.Click += new System.EventHandler(this.PB_staff_controls_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LSRD_hmi.Properties.Resources.the_fish_machine_gold2;
            this.pictureBox1.Location = new System.Drawing.Point(297, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // test_textbox
            // 
            this.test_textbox.AutoSize = true;
            this.test_textbox.Location = new System.Drawing.Point(11, 423);
            this.test_textbox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.test_textbox.Name = "test_textbox";
            this.test_textbox.Size = new System.Drawing.Size(41, 15);
            this.test_textbox.TabIndex = 4;
            this.test_textbox.Text = "label1";
            // 
            // tmr_update_vars
            // 
            this.tmr_update_vars.Enabled = true;
            this.tmr_update_vars.Tick += new System.EventHandler(this.tmr_update_vars_Tick);
            // 
            // debug_wave_active
            // 
            this.debug_wave_active.AutoSize = true;
            this.debug_wave_active.Location = new System.Drawing.Point(11, 444);
            this.debug_wave_active.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.debug_wave_active.Name = "debug_wave_active";
            this.debug_wave_active.Size = new System.Drawing.Size(41, 15);
            this.debug_wave_active.TabIndex = 16;
            this.debug_wave_active.Text = "label1";
            this.debug_wave_active.Visible = false;
            // 
            // debug_wave_scheduled
            // 
            this.debug_wave_scheduled.AutoSize = true;
            this.debug_wave_scheduled.Location = new System.Drawing.Point(11, 463);
            this.debug_wave_scheduled.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.debug_wave_scheduled.Name = "debug_wave_scheduled";
            this.debug_wave_scheduled.Size = new System.Drawing.Size(41, 15);
            this.debug_wave_scheduled.TabIndex = 17;
            this.debug_wave_scheduled.Text = "label2";
            this.debug_wave_scheduled.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(92, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 88);
            this.label3.TabIndex = 18;
            this.label3.Text = "Designed by\r\nTeam LSRD";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LSRD_hmi.Properties.Resources.cfre_logo_circle_notext_fix1;
            this.pictureBox2.Location = new System.Drawing.Point(763, 212);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 132);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::LSRD_hmi.Properties.Resources.Eng_logo_blue;
            this.pictureBox3.Location = new System.Drawing.Point(36, 43);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(246, 97);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Location = new System.Drawing.Point(706, 356);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 88);
            this.label4.TabIndex = 21;
            this.label4.Text = "In Collaboration\r\nWith CFRE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1024, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // login_panel
            // 
            this.login_panel.Controls.Add(this.pass4);
            this.login_panel.Controls.Add(this.pass3);
            this.login_panel.Controls.Add(this.pass2);
            this.login_panel.Controls.Add(this.pass1);
            this.login_panel.Controls.Add(this.text_wrong_pass);
            this.login_panel.Controls.Add(this.PB_confirm_pass);
            this.login_panel.Controls.Add(this.PB_Back_To_Home);
            this.login_panel.Controls.Add(this.label2);
            this.login_panel.Controls.Add(this.label5);
            this.login_panel.Location = new System.Drawing.Point(646, 567);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(460, 300);
            this.login_panel.TabIndex = 23;
            // 
            // pass4
            // 
            this.pass4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.pass4.Items.Add("0");
            this.pass4.Items.Add("1");
            this.pass4.Items.Add("2");
            this.pass4.Items.Add("3");
            this.pass4.Items.Add("4");
            this.pass4.Items.Add("5");
            this.pass4.Items.Add("6");
            this.pass4.Items.Add("7");
            this.pass4.Items.Add("8");
            this.pass4.Items.Add("9");
            this.pass4.Location = new System.Drawing.Point(372, 99);
            this.pass4.Name = "pass4";
            this.pass4.Size = new System.Drawing.Size(62, 61);
            this.pass4.TabIndex = 29;
            // 
            // pass3
            // 
            this.pass3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.pass3.Items.Add("0");
            this.pass3.Items.Add("1");
            this.pass3.Items.Add("2");
            this.pass3.Items.Add("3");
            this.pass3.Items.Add("4");
            this.pass3.Items.Add("5");
            this.pass3.Items.Add("6");
            this.pass3.Items.Add("7");
            this.pass3.Items.Add("8");
            this.pass3.Items.Add("9");
            this.pass3.Location = new System.Drawing.Point(304, 99);
            this.pass3.Name = "pass3";
            this.pass3.Size = new System.Drawing.Size(62, 61);
            this.pass3.TabIndex = 28;
            // 
            // pass2
            // 
            this.pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.pass2.Items.Add("0");
            this.pass2.Items.Add("1");
            this.pass2.Items.Add("2");
            this.pass2.Items.Add("3");
            this.pass2.Items.Add("4");
            this.pass2.Items.Add("5");
            this.pass2.Items.Add("6");
            this.pass2.Items.Add("7");
            this.pass2.Items.Add("8");
            this.pass2.Items.Add("9");
            this.pass2.Location = new System.Drawing.Point(236, 99);
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(62, 61);
            this.pass2.TabIndex = 27;
            // 
            // pass1
            // 
            this.pass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.pass1.Items.Add("0");
            this.pass1.Items.Add("1");
            this.pass1.Items.Add("2");
            this.pass1.Items.Add("3");
            this.pass1.Items.Add("4");
            this.pass1.Items.Add("5");
            this.pass1.Items.Add("6");
            this.pass1.Items.Add("7");
            this.pass1.Items.Add("8");
            this.pass1.Items.Add("9");
            this.pass1.Location = new System.Drawing.Point(168, 99);
            this.pass1.Name = "pass1";
            this.pass1.Size = new System.Drawing.Size(62, 61);
            this.pass1.TabIndex = 26;
            // 
            // text_wrong_pass
            // 
            this.text_wrong_pass.AutoSize = true;
            this.text_wrong_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_wrong_pass.ForeColor = System.Drawing.Color.Red;
            this.text_wrong_pass.Location = new System.Drawing.Point(70, 155);
            this.text_wrong_pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text_wrong_pass.Name = "text_wrong_pass";
            this.text_wrong_pass.Size = new System.Drawing.Size(392, 31);
            this.text_wrong_pass.TabIndex = 14;
            this.text_wrong_pass.Text = "Password is incorrect, try again";
            this.text_wrong_pass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.text_wrong_pass.Visible = false;
            // 
            // PB_confirm_pass
            // 
            this.PB_confirm_pass.BackColor = System.Drawing.Color.Transparent;
            this.PB_confirm_pass.Image = ((System.Drawing.Image)(resources.GetObject("PB_confirm_pass.Image")));
            this.PB_confirm_pass.Location = new System.Drawing.Point(246, 205);
            this.PB_confirm_pass.Margin = new System.Windows.Forms.Padding(2);
            this.PB_confirm_pass.MaximumSize = new System.Drawing.Size(130, 60);
            this.PB_confirm_pass.MinimumSize = new System.Drawing.Size(130, 60);
            this.PB_confirm_pass.Name = "PB_confirm_pass";
            this.PB_confirm_pass.Size = new System.Drawing.Size(130, 60);
            this.PB_confirm_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_confirm_pass.TabIndex = 13;
            this.PB_confirm_pass.TabStop = false;
            this.PB_confirm_pass.Click += new System.EventHandler(this.PB_confirm_pass_Click);
            // 
            // PB_Back_To_Home
            // 
            this.PB_Back_To_Home.BackColor = System.Drawing.Color.Transparent;
            this.PB_Back_To_Home.Image = ((System.Drawing.Image)(resources.GetObject("PB_Back_To_Home.Image")));
            this.PB_Back_To_Home.Location = new System.Drawing.Point(71, 205);
            this.PB_Back_To_Home.Margin = new System.Windows.Forms.Padding(2);
            this.PB_Back_To_Home.MaximumSize = new System.Drawing.Size(130, 60);
            this.PB_Back_To_Home.MinimumSize = new System.Drawing.Size(130, 60);
            this.PB_Back_To_Home.Name = "PB_Back_To_Home";
            this.PB_Back_To_Home.Size = new System.Drawing.Size(130, 60);
            this.PB_Back_To_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Back_To_Home.TabIndex = 12;
            this.PB_Back_To_Home.TabStop = false;
            this.PB_Back_To_Home.Click += new System.EventHandler(this.PB_Back_To_Home_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(437, 72);
            this.label5.TabIndex = 0;
            this.label5.Text = "Please enter password to \r\naccess staff settings";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_resolution
            // 
            this.label_resolution.AutoSize = true;
            this.label_resolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resolution.Location = new System.Drawing.Point(52, 152);
            this.label_resolution.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_resolution.Name = "label_resolution";
            this.label_resolution.Size = new System.Drawing.Size(145, 24);
            this.label_resolution.TabIndex = 24;
            this.label_resolution.Text = "Screen bounds:";
            this.label_resolution.Visible = false;
            // 
            // label_scaling
            // 
            this.label_scaling.AutoSize = true;
            this.label_scaling.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_scaling.Location = new System.Drawing.Point(52, 316);
            this.label_scaling.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_scaling.Name = "label_scaling";
            this.label_scaling.Size = new System.Drawing.Size(72, 24);
            this.label_scaling.TabIndex = 25;
            this.label_scaling.Text = "Scaling";
            this.label_scaling.Visible = false;
            // 
            // label_formsize
            // 
            this.label_formsize.AutoSize = true;
            this.label_formsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_formsize.Location = new System.Drawing.Point(52, 209);
            this.label_formsize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_formsize.Name = "label_formsize";
            this.label_formsize.Size = new System.Drawing.Size(93, 24);
            this.label_formsize.TabIndex = 26;
            this.label_formsize.Text = "ClientSize";
            this.label_formsize.Visible = false;
            // 
            // label_formsize2
            // 
            this.label_formsize2.AutoSize = true;
            this.label_formsize2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_formsize2.Location = new System.Drawing.Point(52, 245);
            this.label_formsize2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_formsize2.Name = "label_formsize2";
            this.label_formsize2.Size = new System.Drawing.Size(123, 24);
            this.label_formsize2.TabIndex = 27;
            this.label_formsize2.Text = "preferredSize";
            this.label_formsize2.Visible = false;
            // 
            // label_formsize3
            // 
            this.label_formsize3.AutoSize = true;
            this.label_formsize3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_formsize3.Location = new System.Drawing.Point(52, 273);
            this.label_formsize3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_formsize3.Name = "label_formsize3";
            this.label_formsize3.Size = new System.Drawing.Size(101, 24);
            this.label_formsize3.TabIndex = 28;
            this.label_formsize3.Text = "Form Size:";
            this.label_formsize3.Visible = false;
            // 
            // drawingactive
            // 
            this.drawingactive.BackColor = System.Drawing.Color.Transparent;
            this.drawingactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawingactive.ForeColor = System.Drawing.Color.Black;
            this.drawingactive.Location = new System.Drawing.Point(44, 537);
            this.drawingactive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drawingactive.Name = "drawingactive";
            this.drawingactive.Size = new System.Drawing.Size(131, 28);
            this.drawingactive.TabIndex = 29;
            this.drawingactive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tmr_wave_countdown
            // 
            this.tmr_wave_countdown.Enabled = true;
            this.tmr_wave_countdown.Interval = 1000;
            this.tmr_wave_countdown.Tick += new System.EventHandler(this.tmr_wave_countdown_Tick);
            // 
            // debug_connection
            // 
            this.debug_connection.AutoSize = true;
            this.debug_connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debug_connection.Location = new System.Drawing.Point(52, 43);
            this.debug_connection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.debug_connection.Name = "debug_connection";
            this.debug_connection.Size = new System.Drawing.Size(112, 24);
            this.debug_connection.TabIndex = 31;
            this.debug_connection.Text = "Connection:";
            this.debug_connection.Visible = false;
            // 
            // debug_cred_text
            // 
            this.debug_cred_text.AutoSize = true;
            this.debug_cred_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debug_cred_text.Location = new System.Drawing.Point(49, 67);
            this.debug_cred_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.debug_cred_text.Name = "debug_cred_text";
            this.debug_cred_text.Size = new System.Drawing.Size(104, 24);
            this.debug_cred_text.TabIndex = 30;
            this.debug_cred_text.Text = "Credentials";
            this.debug_cred_text.Visible = false;
            // 
            // debug_events
            // 
            this.debug_events.AutoSize = true;
            this.debug_events.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debug_events.Location = new System.Drawing.Point(52, 91);
            this.debug_events.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.debug_events.Name = "debug_events";
            this.debug_events.Size = new System.Drawing.Size(67, 24);
            this.debug_events.TabIndex = 32;
            this.debug_events.Text = "Events";
            this.debug_events.Visible = false;
            // 
            // update_events
            // 
            this.update_events.Enabled = true;
            this.update_events.Interval = 2000;
            this.update_events.Tick += new System.EventHandler(this.update_events_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::LSRD_hmi.Properties.Resources.home_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.debug_events);
            this.Controls.Add(this.debug_connection);
            this.Controls.Add(this.debug_cred_text);
            this.Controls.Add(this.drawingactive);
            this.Controls.Add(this.label_formsize3);
            this.Controls.Add(this.label_formsize2);
            this.Controls.Add(this.label_formsize);
            this.Controls.Add(this.label_scaling);
            this.Controls.Add(this.label_resolution);
            this.Controls.Add(this.login_panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.debug_wave_scheduled);
            this.Controls.Add(this.debug_wave_active);
            this.Controls.Add(this.PB_staff_controls);
            this.Controls.Add(this.Picture_LSRD_Logo);
            this.Controls.Add(this.Picturebox_logo);
            this.Controls.Add(this.PB_scavenger_mode);
            this.Controls.Add(this.PB_drawing_mode);
            this.Controls.Add(this.PB_doorman_mode);
            this.Controls.Add(this.PB_Quit_Program);
            this.Controls.Add(this.test_textbox);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_LSRD_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_doorman_mode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_drawing_mode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_scavenger_mode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_staff_controls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_confirm_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_Modbus_Com;
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
        private System.Windows.Forms.Label debug_wave_active;
        private System.Windows.Forms.Label debug_wave_scheduled;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Label text_wrong_pass;
        private System.Windows.Forms.PictureBox PB_confirm_pass;
        private System.Windows.Forms.PictureBox PB_Back_To_Home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_resolution;
        private System.Windows.Forms.Label label_scaling;
        private System.Windows.Forms.Label label_formsize;
        private System.Windows.Forms.Label label_formsize2;
        private System.Windows.Forms.Label label_formsize3;
        private System.Windows.Forms.DomainUpDown pass4;
        private System.Windows.Forms.DomainUpDown pass3;
        private System.Windows.Forms.DomainUpDown pass2;
        private System.Windows.Forms.DomainUpDown pass1;
        private System.Windows.Forms.Label drawingactive;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer tmr_wave_countdown;
        private System.Windows.Forms.Label debug_connection;
        private System.Windows.Forms.Label debug_cred_text;
        private System.Windows.Forms.Label debug_events;
        private System.Windows.Forms.Timer update_events;
    }
}


namespace LSRD_hmi
{
    partial class Form_doorman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_doorman));
            this.Scrollable_Events_Box = new System.Windows.Forms.FlowLayoutPanel();
            this.label_doorman_title = new System.Windows.Forms.Label();
            this.PB_Back_To_Home = new System.Windows.Forms.PictureBox();
            this.PB_area_work_cafe = new System.Windows.Forms.PictureBox();
            this.PB_area_seminar_room = new System.Windows.Forms.PictureBox();
            this.PB_area_discovery_lab = new System.Windows.Forms.PictureBox();
            this.PB_area_partner_suites = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_room_info = new System.Windows.Forms.Label();
            this.PB_get_directions = new System.Windows.Forms.PictureBox();
            this.lbl_room_info_back = new System.Windows.Forms.Label();
            this.button_room_info = new System.Windows.Forms.Button();
            this.button_events = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_area_work_cafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_area_seminar_room)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_area_discovery_lab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_area_partner_suites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_get_directions)).BeginInit();
            this.SuspendLayout();
            // 
            // Scrollable_Events_Box
            // 
            this.Scrollable_Events_Box.AutoScroll = true;
            this.Scrollable_Events_Box.BackColor = System.Drawing.Color.White;
            this.Scrollable_Events_Box.Location = new System.Drawing.Point(636, 158);
            this.Scrollable_Events_Box.Margin = new System.Windows.Forms.Padding(8);
            this.Scrollable_Events_Box.Name = "Scrollable_Events_Box";
            this.Scrollable_Events_Box.Padding = new System.Windows.Forms.Padding(8);
            this.Scrollable_Events_Box.Size = new System.Drawing.Size(352, 409);
            this.Scrollable_Events_Box.TabIndex = 6;
            // 
            // label_doorman_title
            // 
            this.label_doorman_title.BackColor = System.Drawing.Color.Transparent;
            this.label_doorman_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_doorman_title.Location = new System.Drawing.Point(2, 17);
            this.label_doorman_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_doorman_title.Name = "label_doorman_title";
            this.label_doorman_title.Size = new System.Drawing.Size(1023, 74);
            this.label_doorman_title.TabIndex = 17;
            this.label_doorman_title.Text = "Doorman Mode";
            this.label_doorman_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_Back_To_Home
            // 
            this.PB_Back_To_Home.BackColor = System.Drawing.Color.Transparent;
            this.PB_Back_To_Home.Image = global::LSRD_hmi.Properties.Resources.PB_back_wide1;
            this.PB_Back_To_Home.Location = new System.Drawing.Point(33, 26);
            this.PB_Back_To_Home.Margin = new System.Windows.Forms.Padding(2);
            this.PB_Back_To_Home.MaximumSize = new System.Drawing.Size(180, 97);
            this.PB_Back_To_Home.Name = "PB_Back_To_Home";
            this.PB_Back_To_Home.Size = new System.Drawing.Size(155, 75);
            this.PB_Back_To_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Back_To_Home.TabIndex = 21;
            this.PB_Back_To_Home.TabStop = false;
            this.PB_Back_To_Home.Click += new System.EventHandler(this.PB_Back_To_Home_Click);
            // 
            // PB_area_work_cafe
            // 
            this.PB_area_work_cafe.BackColor = System.Drawing.Color.Transparent;
            this.PB_area_work_cafe.Image = ((System.Drawing.Image)(resources.GetObject("PB_area_work_cafe.Image")));
            this.PB_area_work_cafe.InitialImage = ((System.Drawing.Image)(resources.GetObject("PB_area_work_cafe.InitialImage")));
            this.PB_area_work_cafe.Location = new System.Drawing.Point(117, 208);
            this.PB_area_work_cafe.Margin = new System.Windows.Forms.Padding(2);
            this.PB_area_work_cafe.Name = "PB_area_work_cafe";
            this.PB_area_work_cafe.Size = new System.Drawing.Size(180, 92);
            this.PB_area_work_cafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_area_work_cafe.TabIndex = 31;
            this.PB_area_work_cafe.TabStop = false;
            this.PB_area_work_cafe.Click += new System.EventHandler(this.PB_door_work_cafe_Click);
            // 
            // PB_area_seminar_room
            // 
            this.PB_area_seminar_room.BackColor = System.Drawing.Color.Transparent;
            this.PB_area_seminar_room.Image = ((System.Drawing.Image)(resources.GetObject("PB_area_seminar_room.Image")));
            this.PB_area_seminar_room.InitialImage = ((System.Drawing.Image)(resources.GetObject("PB_area_seminar_room.InitialImage")));
            this.PB_area_seminar_room.Location = new System.Drawing.Point(330, 208);
            this.PB_area_seminar_room.Margin = new System.Windows.Forms.Padding(2);
            this.PB_area_seminar_room.Name = "PB_area_seminar_room";
            this.PB_area_seminar_room.Size = new System.Drawing.Size(180, 92);
            this.PB_area_seminar_room.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_area_seminar_room.TabIndex = 32;
            this.PB_area_seminar_room.TabStop = false;
            this.PB_area_seminar_room.Click += new System.EventHandler(this.PB_door_seminar_room_Click);
            // 
            // PB_area_discovery_lab
            // 
            this.PB_area_discovery_lab.BackColor = System.Drawing.Color.Transparent;
            this.PB_area_discovery_lab.Image = ((System.Drawing.Image)(resources.GetObject("PB_area_discovery_lab.Image")));
            this.PB_area_discovery_lab.InitialImage = ((System.Drawing.Image)(resources.GetObject("PB_area_discovery_lab.InitialImage")));
            this.PB_area_discovery_lab.Location = new System.Drawing.Point(117, 327);
            this.PB_area_discovery_lab.Margin = new System.Windows.Forms.Padding(2);
            this.PB_area_discovery_lab.Name = "PB_area_discovery_lab";
            this.PB_area_discovery_lab.Size = new System.Drawing.Size(180, 92);
            this.PB_area_discovery_lab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_area_discovery_lab.TabIndex = 33;
            this.PB_area_discovery_lab.TabStop = false;
            this.PB_area_discovery_lab.Click += new System.EventHandler(this.PB_door_discovery_lab_Click);
            // 
            // PB_area_partner_suites
            // 
            this.PB_area_partner_suites.BackColor = System.Drawing.Color.Transparent;
            this.PB_area_partner_suites.Image = global::LSRD_hmi.Properties.Resources.PB_square_door_partner_suites_singleLine;
            this.PB_area_partner_suites.InitialImage = ((System.Drawing.Image)(resources.GetObject("PB_area_partner_suites.InitialImage")));
            this.PB_area_partner_suites.Location = new System.Drawing.Point(330, 327);
            this.PB_area_partner_suites.Margin = new System.Windows.Forms.Padding(2);
            this.PB_area_partner_suites.Name = "PB_area_partner_suites";
            this.PB_area_partner_suites.Size = new System.Drawing.Size(180, 92);
            this.PB_area_partner_suites.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_area_partner_suites.TabIndex = 34;
            this.PB_area_partner_suites.TabStop = false;
            this.PB_area_partner_suites.Click += new System.EventHandler(this.PB_door_partner_suites_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(43, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 70);
            this.label1.TabIndex = 36;
            this.label1.Text = "Please click on a meeting area below\r\n to see room details and get directions \r\n\r" +
    "\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_room_info
            // 
            this.lbl_room_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_room_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_info.Location = new System.Drawing.Point(434, 482);
            this.lbl_room_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_room_info.Name = "lbl_room_info";
            this.lbl_room_info.Padding = new System.Windows.Forms.Padding(4, 12, 0, 6);
            this.lbl_room_info.Size = new System.Drawing.Size(324, 180);
            this.lbl_room_info.TabIndex = 37;
            this.lbl_room_info.Text = "• Faculty Offices\r\n• USCG Great Lakes Oil \r\n  Spill Center of Expertise\r\n• Michig" +
    "an Sea Grant\r\n• HeadWaters North ";
            // 
            // PB_get_directions
            // 
            this.PB_get_directions.BackColor = System.Drawing.Color.Transparent;
            this.PB_get_directions.Image = global::LSRD_hmi.Properties.Resources.PB_square_door_get_directions;
            this.PB_get_directions.InitialImage = ((System.Drawing.Image)(resources.GetObject("PB_get_directions.InitialImage")));
            this.PB_get_directions.Location = new System.Drawing.Point(223, 446);
            this.PB_get_directions.Margin = new System.Windows.Forms.Padding(2);
            this.PB_get_directions.Name = "PB_get_directions";
            this.PB_get_directions.Size = new System.Drawing.Size(180, 92);
            this.PB_get_directions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_get_directions.TabIndex = 39;
            this.PB_get_directions.TabStop = false;
            this.PB_get_directions.Click += new System.EventHandler(this.PB_get_directions_Click);
            // 
            // lbl_room_info_back
            // 
            this.lbl_room_info_back.BackColor = System.Drawing.Color.White;
            this.lbl_room_info_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_info_back.Location = new System.Drawing.Point(418, 464);
            this.lbl_room_info_back.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_room_info_back.Name = "lbl_room_info_back";
            this.lbl_room_info_back.Padding = new System.Windows.Forms.Padding(4, 16, 0, 6);
            this.lbl_room_info_back.Size = new System.Drawing.Size(351, 409);
            this.lbl_room_info_back.TabIndex = 40;
            this.lbl_room_info_back.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_room_info
            // 
            this.button_room_info.BackColor = System.Drawing.Color.LightGray;
            this.button_room_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_room_info.Location = new System.Drawing.Point(809, 107);
            this.button_room_info.Name = "button_room_info";
            this.button_room_info.Size = new System.Drawing.Size(179, 52);
            this.button_room_info.TabIndex = 41;
            this.button_room_info.Text = "Room info";
            this.button_room_info.UseVisualStyleBackColor = false;
            this.button_room_info.Click += new System.EventHandler(this.button_room_info_Click);
            // 
            // button_events
            // 
            this.button_events.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_events.Location = new System.Drawing.Point(635, 107);
            this.button_events.Name = "button_events";
            this.button_events.Size = new System.Drawing.Size(179, 52);
            this.button_events.TabIndex = 42;
            this.button_events.Text = "Upcoming Events";
            this.button_events.UseVisualStyleBackColor = true;
            this.button_events.Click += new System.EventHandler(this.button_events_Click);
            // 
            // Form_doorman
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::LSRD_hmi.Properties.Resources.doorman_bkg_blueish_22;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.button_events);
            this.Controls.Add(this.button_room_info);
            this.Controls.Add(this.PB_get_directions);
            this.Controls.Add(this.lbl_room_info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB_area_partner_suites);
            this.Controls.Add(this.PB_area_discovery_lab);
            this.Controls.Add(this.PB_area_seminar_room);
            this.Controls.Add(this.PB_area_work_cafe);
            this.Controls.Add(this.PB_Back_To_Home);
            this.Controls.Add(this.label_doorman_title);
            this.Controls.Add(this.Scrollable_Events_Box);
            this.Controls.Add(this.lbl_room_info_back);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form_doorman";
            this.Text = "Form_doorman";
            this.Load += new System.EventHandler(this.Form_doorman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_area_work_cafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_area_seminar_room)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_area_discovery_lab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_area_partner_suites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_get_directions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel Scrollable_Events_Box;
        private System.Windows.Forms.Label label_doorman_title;
        private System.Windows.Forms.PictureBox PB_Back_To_Home;
        private System.Windows.Forms.PictureBox PB_area_work_cafe;
        private System.Windows.Forms.PictureBox PB_area_seminar_room;
        private System.Windows.Forms.PictureBox PB_area_discovery_lab;
        private System.Windows.Forms.PictureBox PB_area_partner_suites;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_room_info;
        private System.Windows.Forms.PictureBox PB_get_directions;
        private System.Windows.Forms.Label lbl_room_info_back;
        private System.Windows.Forms.Button button_room_info;
        private System.Windows.Forms.Button button_events;
    }
}
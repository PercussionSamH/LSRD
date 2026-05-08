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
            this.PB_area_discovery_lab = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_room_info = new System.Windows.Forms.Label();
            this.PB_get_directions = new System.Windows.Forms.PictureBox();
            this.lbl_room_info_back = new System.Windows.Forms.Label();
            this.button_room_info = new System.Windows.Forms.Button();
            this.button_events = new System.Windows.Forms.Button();
            this.PB_area_seminar_room = new System.Windows.Forms.PictureBox();
            this.PB_area_partner_suites = new System.Windows.Forms.PictureBox();
            this.popup_border = new System.Windows.Forms.Label();
            this.popup_back = new System.Windows.Forms.Label();
            this.popup_pb_close = new System.Windows.Forms.PictureBox();
            this.PB_robot_get_directions = new System.Windows.Forms.PictureBox();
            this.popup_title = new System.Windows.Forms.Label();
            this.popup_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_area_work_cafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_area_discovery_lab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_get_directions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_area_seminar_room)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_area_partner_suites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popup_pb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_robot_get_directions)).BeginInit();
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
            this.label_doorman_title.Location = new System.Drawing.Point(2, 19);
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
            this.PB_area_work_cafe.Image = global::LSRD_hmi.Properties.Resources.PB_square_door_work_cafe_offices;
            this.PB_area_work_cafe.InitialImage = ((System.Drawing.Image)(resources.GetObject("PB_area_work_cafe.InitialImage")));
            this.PB_area_work_cafe.Location = new System.Drawing.Point(123, 336);
            this.PB_area_work_cafe.Margin = new System.Windows.Forms.Padding(2);
            this.PB_area_work_cafe.Name = "PB_area_work_cafe";
            this.PB_area_work_cafe.Size = new System.Drawing.Size(180, 92);
            this.PB_area_work_cafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_area_work_cafe.TabIndex = 31;
            this.PB_area_work_cafe.TabStop = false;
            this.PB_area_work_cafe.Click += new System.EventHandler(this.PB_door_work_cafe_Click);
            // 
            // PB_area_discovery_lab
            // 
            this.PB_area_discovery_lab.BackColor = System.Drawing.Color.Transparent;
            this.PB_area_discovery_lab.Image = ((System.Drawing.Image)(resources.GetObject("PB_area_discovery_lab.Image")));
            this.PB_area_discovery_lab.InitialImage = ((System.Drawing.Image)(resources.GetObject("PB_area_discovery_lab.InitialImage")));
            this.PB_area_discovery_lab.Location = new System.Drawing.Point(123, 212);
            this.PB_area_discovery_lab.Margin = new System.Windows.Forms.Padding(2);
            this.PB_area_discovery_lab.Name = "PB_area_discovery_lab";
            this.PB_area_discovery_lab.Size = new System.Drawing.Size(180, 92);
            this.PB_area_discovery_lab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_area_discovery_lab.TabIndex = 33;
            this.PB_area_discovery_lab.TabStop = false;
            this.PB_area_discovery_lab.Click += new System.EventHandler(this.PB_door_discovery_lab_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(43, 122);
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
            this.PB_get_directions.Location = new System.Drawing.Point(223, 463);
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
            this.button_room_info.Location = new System.Drawing.Point(809, 105);
            this.button_room_info.Name = "button_room_info";
            this.button_room_info.Size = new System.Drawing.Size(179, 54);
            this.button_room_info.TabIndex = 41;
            this.button_room_info.Text = "Room info";
            this.button_room_info.UseVisualStyleBackColor = false;
            this.button_room_info.Click += new System.EventHandler(this.button_room_info_Click);
            // 
            // button_events
            // 
            this.button_events.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_events.Location = new System.Drawing.Point(638, 105);
            this.button_events.Name = "button_events";
            this.button_events.Size = new System.Drawing.Size(179, 54);
            this.button_events.TabIndex = 42;
            this.button_events.Text = "Upcoming Events";
            this.button_events.UseVisualStyleBackColor = true;
            this.button_events.Click += new System.EventHandler(this.button_events_Click);
            // 
            // PB_area_seminar_room
            // 
            this.PB_area_seminar_room.BackColor = System.Drawing.Color.Transparent;
            this.PB_area_seminar_room.Image = ((System.Drawing.Image)(resources.GetObject("PB_area_seminar_room.Image")));
            this.PB_area_seminar_room.InitialImage = ((System.Drawing.Image)(resources.GetObject("PB_area_seminar_room.InitialImage")));
            this.PB_area_seminar_room.Location = new System.Drawing.Point(333, 336);
            this.PB_area_seminar_room.Margin = new System.Windows.Forms.Padding(2);
            this.PB_area_seminar_room.Name = "PB_area_seminar_room";
            this.PB_area_seminar_room.Size = new System.Drawing.Size(180, 92);
            this.PB_area_seminar_room.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_area_seminar_room.TabIndex = 32;
            this.PB_area_seminar_room.TabStop = false;
            this.PB_area_seminar_room.Click += new System.EventHandler(this.PB_door_seminar_room_Click);
            // 
            // PB_area_partner_suites
            // 
            this.PB_area_partner_suites.BackColor = System.Drawing.Color.Transparent;
            this.PB_area_partner_suites.Image = global::LSRD_hmi.Properties.Resources.PB_square_door_partner_suites_singleLine;
            this.PB_area_partner_suites.InitialImage = ((System.Drawing.Image)(resources.GetObject("PB_area_partner_suites.InitialImage")));
            this.PB_area_partner_suites.Location = new System.Drawing.Point(333, 212);
            this.PB_area_partner_suites.Margin = new System.Windows.Forms.Padding(2);
            this.PB_area_partner_suites.Name = "PB_area_partner_suites";
            this.PB_area_partner_suites.Size = new System.Drawing.Size(180, 92);
            this.PB_area_partner_suites.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_area_partner_suites.TabIndex = 34;
            this.PB_area_partner_suites.TabStop = false;
            this.PB_area_partner_suites.Click += new System.EventHandler(this.PB_door_partner_suites_Click);
            // 
            // popup_border
            // 
            this.popup_border.BackColor = System.Drawing.Color.DimGray;
            this.popup_border.Location = new System.Drawing.Point(271, 86);
            this.popup_border.Name = "popup_border";
            this.popup_border.Size = new System.Drawing.Size(506, 466);
            this.popup_border.TabIndex = 46;
            // 
            // popup_back
            // 
            this.popup_back.Location = new System.Drawing.Point(279, 93);
            this.popup_back.Name = "popup_back";
            this.popup_back.Size = new System.Drawing.Size(490, 450);
            this.popup_back.TabIndex = 45;
            // 
            // popup_pb_close
            // 
            this.popup_pb_close.BackColor = System.Drawing.Color.Transparent;
            this.popup_pb_close.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.popup_pb_close.Image = global::LSRD_hmi.Properties.Resources.PB_square_cancel1;
            this.popup_pb_close.Location = new System.Drawing.Point(339, 446);
            this.popup_pb_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.popup_pb_close.MaximumSize = new System.Drawing.Size(169, 78);
            this.popup_pb_close.MinimumSize = new System.Drawing.Size(131, 60);
            this.popup_pb_close.Name = "popup_pb_close";
            this.popup_pb_close.Size = new System.Drawing.Size(169, 78);
            this.popup_pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.popup_pb_close.TabIndex = 43;
            this.popup_pb_close.TabStop = false;
            this.popup_pb_close.Click += new System.EventHandler(this.popup_pb_close_Click);
            // 
            // PB_robot_get_directions
            // 
            this.PB_robot_get_directions.BackColor = System.Drawing.Color.Transparent;
            this.PB_robot_get_directions.Image = global::LSRD_hmi.Properties.Resources.PB_square_get_directions1;
            this.PB_robot_get_directions.Location = new System.Drawing.Point(540, 446);
            this.PB_robot_get_directions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB_robot_get_directions.MaximumSize = new System.Drawing.Size(169, 78);
            this.PB_robot_get_directions.MinimumSize = new System.Drawing.Size(131, 60);
            this.PB_robot_get_directions.Name = "PB_robot_get_directions";
            this.PB_robot_get_directions.Size = new System.Drawing.Size(169, 78);
            this.PB_robot_get_directions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_robot_get_directions.TabIndex = 44;
            this.PB_robot_get_directions.TabStop = false;
            this.PB_robot_get_directions.Click += new System.EventHandler(this.PB_robot_get_directions_Click);
            // 
            // popup_title
            // 
            this.popup_title.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.popup_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.popup_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popup_title.Location = new System.Drawing.Point(297, 115);
            this.popup_title.Name = "popup_title";
            this.popup_title.Size = new System.Drawing.Size(453, 63);
            this.popup_title.TabIndex = 48;
            this.popup_title.Text = "Work Cafe";
            this.popup_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // popup_text
            // 
            this.popup_text.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.popup_text.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.popup_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popup_text.Location = new System.Drawing.Point(297, 204);
            this.popup_text.Name = "popup_text";
            this.popup_text.Size = new System.Drawing.Size(453, 221);
            this.popup_text.TabIndex = 49;
            this.popup_text.Text = "steps";
            // 
            // Form_doorman
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::LSRD_hmi.Properties.Resources.doorman_bkg_blueish_22;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.popup_text);
            this.Controls.Add(this.popup_title);
            this.Controls.Add(this.PB_robot_get_directions);
            this.Controls.Add(this.popup_pb_close);
            this.Controls.Add(this.popup_back);
            this.Controls.Add(this.popup_border);
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
            ((System.ComponentModel.ISupportInitialize)(this.PB_area_discovery_lab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_get_directions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_area_seminar_room)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_area_partner_suites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popup_pb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_robot_get_directions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel Scrollable_Events_Box;
        private System.Windows.Forms.Label label_doorman_title;
        private System.Windows.Forms.PictureBox PB_Back_To_Home;
        private System.Windows.Forms.PictureBox PB_area_work_cafe;
        private System.Windows.Forms.PictureBox PB_area_discovery_lab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_room_info;
        private System.Windows.Forms.PictureBox PB_get_directions;
        private System.Windows.Forms.Label lbl_room_info_back;
        private System.Windows.Forms.Button button_room_info;
        private System.Windows.Forms.Button button_events;
        private System.Windows.Forms.PictureBox PB_area_seminar_room;
        private System.Windows.Forms.PictureBox PB_area_partner_suites;
        private System.Windows.Forms.Label popup_border;
        private System.Windows.Forms.Label popup_back;
        private System.Windows.Forms.PictureBox popup_pb_close;
        private System.Windows.Forms.PictureBox PB_robot_get_directions;
        private System.Windows.Forms.Label popup_title;
        private System.Windows.Forms.Label popup_text;
    }
}
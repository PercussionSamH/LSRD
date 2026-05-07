namespace LSRD_hmi
{
    partial class Form2
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
            this.Label_Fish_Type_Text = new System.Windows.Forms.Label();
            this.Fish_preview_picture = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PB_fish_select_left = new System.Windows.Forms.PictureBox();
            this.PB_fish_select_right = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PB_Back_To_Home = new System.Windows.Forms.PictureBox();
            this.Text_enter_initials_prompt = new System.Windows.Forms.Label();
            this.PB_drawing_mode = new System.Windows.Forms.PictureBox();
            this.Fish_desc = new System.Windows.Forms.Label();
            this.Fish_tagline = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Fish_desc2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modoutput = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.drawingactive = new System.Windows.Forms.Label();
            this.drawing = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Fish_preview_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_fish_select_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_fish_select_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_drawing_mode)).BeginInit();
            this.drawing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Fish_Type_Text
            // 
            this.Label_Fish_Type_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Fish_Type_Text.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label_Fish_Type_Text.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Label_Fish_Type_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Fish_Type_Text.Location = new System.Drawing.Point(420, 61);
            this.Label_Fish_Type_Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Fish_Type_Text.MaximumSize = new System.Drawing.Size(188, 41);
            this.Label_Fish_Type_Text.MinimumSize = new System.Drawing.Size(188, 41);
            this.Label_Fish_Type_Text.Name = "Label_Fish_Type_Text";
            this.Label_Fish_Type_Text.Size = new System.Drawing.Size(188, 41);
            this.Label_Fish_Type_Text.TabIndex = 2;
            this.Label_Fish_Type_Text.Text = "((fish type text))";
            this.Label_Fish_Type_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fish_preview_picture
            // 
            this.Fish_preview_picture.BackColor = System.Drawing.Color.White;
            this.Fish_preview_picture.Location = new System.Drawing.Point(397, 153);
            this.Fish_preview_picture.Margin = new System.Windows.Forms.Padding(19, 20, 19, 20);
            this.Fish_preview_picture.Name = "Fish_preview_picture";
            this.Fish_preview_picture.Padding = new System.Windows.Forms.Padding(8);
            this.Fish_preview_picture.Size = new System.Drawing.Size(234, 184);
            this.Fish_preview_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fish_preview_picture.TabIndex = 3;
            this.Fish_preview_picture.TabStop = false;
            // 
            // PB_fish_select_left
            // 
            this.PB_fish_select_left.BackColor = System.Drawing.Color.Transparent;
            this.PB_fish_select_left.Image = global::LSRD_hmi.Properties.Resources.button_left;
            this.PB_fish_select_left.Location = new System.Drawing.Point(299, 194);
            this.PB_fish_select_left.Margin = new System.Windows.Forms.Padding(2);
            this.PB_fish_select_left.MaximumSize = new System.Drawing.Size(90, 90);
            this.PB_fish_select_left.Name = "PB_fish_select_left";
            this.PB_fish_select_left.Size = new System.Drawing.Size(72, 81);
            this.PB_fish_select_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_fish_select_left.TabIndex = 5;
            this.PB_fish_select_left.TabStop = false;
            this.PB_fish_select_left.Click += new System.EventHandler(this.PB_fish_select_left_Click);
            // 
            // PB_fish_select_right
            // 
            this.PB_fish_select_right.BackColor = System.Drawing.Color.Transparent;
            this.PB_fish_select_right.Image = global::LSRD_hmi.Properties.Resources.button_right;
            this.PB_fish_select_right.Location = new System.Drawing.Point(657, 194);
            this.PB_fish_select_right.Margin = new System.Windows.Forms.Padding(2);
            this.PB_fish_select_right.MaximumSize = new System.Drawing.Size(90, 90);
            this.PB_fish_select_right.Name = "PB_fish_select_right";
            this.PB_fish_select_right.Size = new System.Drawing.Size(72, 81);
            this.PB_fish_select_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_fish_select_right.TabIndex = 6;
            this.PB_fish_select_right.TabStop = false;
            this.PB_fish_select_right.Click += new System.EventHandler(this.PB_fish_select_right_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LSRD_hmi.Properties.Resources.Frame_250_180;
            this.pictureBox1.Location = new System.Drawing.Point(380, 133);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PB_Back_To_Home
            // 
            this.PB_Back_To_Home.BackColor = System.Drawing.Color.Transparent;
            this.PB_Back_To_Home.Image = global::LSRD_hmi.Properties.Resources.PB_back_wide1;
            this.PB_Back_To_Home.Location = new System.Drawing.Point(61, 44);
            this.PB_Back_To_Home.Margin = new System.Windows.Forms.Padding(2);
            this.PB_Back_To_Home.Name = "PB_Back_To_Home";
            this.PB_Back_To_Home.Size = new System.Drawing.Size(155, 75);
            this.PB_Back_To_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Back_To_Home.TabIndex = 11;
            this.PB_Back_To_Home.TabStop = false;
            this.PB_Back_To_Home.Click += new System.EventHandler(this.PB_Back_To_Home_Click);
            // 
            // Text_enter_initials_prompt
            // 
            this.Text_enter_initials_prompt.BackColor = System.Drawing.Color.Transparent;
            this.Text_enter_initials_prompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_enter_initials_prompt.ForeColor = System.Drawing.Color.Black;
            this.Text_enter_initials_prompt.Location = new System.Drawing.Point(375, 362);
            this.Text_enter_initials_prompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Text_enter_initials_prompt.Name = "Text_enter_initials_prompt";
            this.Text_enter_initials_prompt.Size = new System.Drawing.Size(278, 28);
            this.Text_enter_initials_prompt.TabIndex = 13;
            this.Text_enter_initials_prompt.Text = "Enter your initials below:";
            this.Text_enter_initials_prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_drawing_mode
            // 
            this.PB_drawing_mode.BackColor = System.Drawing.Color.Transparent;
            this.PB_drawing_mode.Image = global::LSRD_hmi.Properties.Resources.PB_square_enter;
            this.PB_drawing_mode.Location = new System.Drawing.Point(434, 477);
            this.PB_drawing_mode.Margin = new System.Windows.Forms.Padding(2);
            this.PB_drawing_mode.MaximumSize = new System.Drawing.Size(160, 80);
            this.PB_drawing_mode.Name = "PB_drawing_mode";
            this.PB_drawing_mode.Size = new System.Drawing.Size(160, 80);
            this.PB_drawing_mode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_drawing_mode.TabIndex = 14;
            this.PB_drawing_mode.TabStop = false;
            this.PB_drawing_mode.Click += new System.EventHandler(this.PB_drawing_mode_Click);
            // 
            // Fish_desc
            // 
            this.Fish_desc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fish_desc.AutoSize = true;
            this.Fish_desc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Fish_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fish_desc.Location = new System.Drawing.Point(779, 182);
            this.Fish_desc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Fish_desc.MaximumSize = new System.Drawing.Size(210, 0);
            this.Fish_desc.MinimumSize = new System.Drawing.Size(210, 0);
            this.Fish_desc.Name = "Fish_desc";
            this.Fish_desc.Padding = new System.Windows.Forms.Padding(6, 6, 6, 15);
            this.Fish_desc.Size = new System.Drawing.Size(210, 81);
            this.Fish_desc.TabIndex = 15;
            this.Fish_desc.Text = "{{FISH DESCRIPTION}}";
            // 
            // Fish_tagline
            // 
            this.Fish_tagline.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Fish_tagline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fish_tagline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fish_tagline.ForeColor = System.Drawing.Color.Black;
            this.Fish_tagline.Location = new System.Drawing.Point(781, 100);
            this.Fish_tagline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Fish_tagline.MinimumSize = new System.Drawing.Size(150, 0);
            this.Fish_tagline.Name = "Fish_tagline";
            this.Fish_tagline.Padding = new System.Windows.Forms.Padding(6);
            this.Fish_tagline.Size = new System.Drawing.Size(210, 66);
            this.Fish_tagline.TabIndex = 16;
            this.Fish_tagline.Text = "{{FISH TAGLINE}}";
            this.Fish_tagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(774, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(6);
            this.label5.Size = new System.Drawing.Size(222, 50);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fish Facts:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3, 6, 6, 6);
            this.label6.Size = new System.Drawing.Size(205, 323);
            this.label6.TabIndex = 20;
            this.label6.Text = "-Select a fish\r\nusing the arrows\r\n\r\n-Press enter\r\n\r\n-Follow popup\r\ninstructions f" +
    "or\r\nnext steps\r\n";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(24, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.MinimumSize = new System.Drawing.Size(75, 8);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(6);
            this.label7.Size = new System.Drawing.Size(228, 50);
            this.label7.TabIndex = 21;
            this.label7.Text = " Instructions: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fish_desc2
            // 
            this.Fish_desc2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Fish_desc2.AutoSize = true;
            this.Fish_desc2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Fish_desc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fish_desc2.Location = new System.Drawing.Point(782, 277);
            this.Fish_desc2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Fish_desc2.MaximumSize = new System.Drawing.Size(210, 0);
            this.Fish_desc2.MinimumSize = new System.Drawing.Size(210, 0);
            this.Fish_desc2.Name = "Fish_desc2";
            this.Fish_desc2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 15);
            this.Fish_desc2.Size = new System.Drawing.Size(210, 110);
            this.Fish_desc2.TabIndex = 22;
            this.Fish_desc2.Text = "{{FISH DESCRIPTION EXTENDED}}";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6);
            this.label1.Size = new System.Drawing.Size(448, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Debug";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // modoutput
            // 
            this.modoutput.BackColor = System.Drawing.Color.Transparent;
            this.modoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modoutput.ForeColor = System.Drawing.Color.Black;
            this.modoutput.Location = new System.Drawing.Point(291, 103);
            this.modoutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modoutput.Name = "modoutput";
            this.modoutput.Size = new System.Drawing.Size(447, 28);
            this.modoutput.TabIndex = 24;
            this.modoutput.Text = "f f f f f";
            this.modoutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.domainUpDown1.Items.Add("A");
            this.domainUpDown1.Items.Add("B");
            this.domainUpDown1.Items.Add("C");
            this.domainUpDown1.Items.Add("D");
            this.domainUpDown1.Items.Add("E");
            this.domainUpDown1.Items.Add("F");
            this.domainUpDown1.Items.Add("G");
            this.domainUpDown1.Items.Add("H");
            this.domainUpDown1.Items.Add("I");
            this.domainUpDown1.Items.Add("J");
            this.domainUpDown1.Items.Add("K");
            this.domainUpDown1.Items.Add("L");
            this.domainUpDown1.Items.Add("M");
            this.domainUpDown1.Items.Add("N");
            this.domainUpDown1.Items.Add("O");
            this.domainUpDown1.Items.Add("P");
            this.domainUpDown1.Items.Add("Q");
            this.domainUpDown1.Items.Add("R");
            this.domainUpDown1.Items.Add("S");
            this.domainUpDown1.Items.Add("T");
            this.domainUpDown1.Items.Add("U");
            this.domainUpDown1.Items.Add("V");
            this.domainUpDown1.Items.Add("W");
            this.domainUpDown1.Items.Add("X");
            this.domainUpDown1.Items.Add("Y");
            this.domainUpDown1.Items.Add("Z");
            this.domainUpDown1.Location = new System.Drawing.Point(432, 411);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(80, 61);
            this.domainUpDown1.TabIndex = 25;
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.domainUpDown2.Items.Add("A");
            this.domainUpDown2.Items.Add("B");
            this.domainUpDown2.Items.Add("C");
            this.domainUpDown2.Items.Add("D");
            this.domainUpDown2.Items.Add("E");
            this.domainUpDown2.Items.Add("F");
            this.domainUpDown2.Items.Add("G");
            this.domainUpDown2.Items.Add("H");
            this.domainUpDown2.Items.Add("I");
            this.domainUpDown2.Items.Add("J");
            this.domainUpDown2.Items.Add("K");
            this.domainUpDown2.Items.Add("L");
            this.domainUpDown2.Items.Add("M");
            this.domainUpDown2.Items.Add("N");
            this.domainUpDown2.Items.Add("O");
            this.domainUpDown2.Items.Add("P");
            this.domainUpDown2.Items.Add("Q");
            this.domainUpDown2.Items.Add("R");
            this.domainUpDown2.Items.Add("S");
            this.domainUpDown2.Items.Add("T");
            this.domainUpDown2.Items.Add("U");
            this.domainUpDown2.Items.Add("V");
            this.domainUpDown2.Items.Add("W");
            this.domainUpDown2.Items.Add("X");
            this.domainUpDown2.Items.Add("Y");
            this.domainUpDown2.Items.Add("Z");
            this.domainUpDown2.Location = new System.Drawing.Point(518, 411);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(80, 61);
            this.domainUpDown2.TabIndex = 26;
            // 
            // drawingactive
            // 
            this.drawingactive.BackColor = System.Drawing.Color.Transparent;
            this.drawingactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawingactive.ForeColor = System.Drawing.Color.Black;
            this.drawingactive.Location = new System.Drawing.Point(598, 504);
            this.drawingactive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drawingactive.Name = "drawingactive";
            this.drawingactive.Size = new System.Drawing.Size(131, 28);
            this.drawingactive.TabIndex = 27;
            this.drawingactive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawing
            // 
            this.drawing.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.drawing.Controls.Add(this.label2);
            this.drawing.Controls.Add(this.pictureBox2);
            this.drawing.Location = new System.Drawing.Point(502, 100);
            this.drawing.Name = "drawing";
            this.drawing.Size = new System.Drawing.Size(636, 474);
            this.drawing.TabIndex = 28;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::LSRD_hmi.Properties.Resources.Zooplankton_250_180;
            this.pictureBox2.Location = new System.Drawing.Point(78, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 360);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label2.Location = new System.Drawing.Point(153, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your fish is being drawn!";
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::LSRD_hmi.Properties.Resources.fish_drawing_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.ControlBox = false;
            this.Controls.Add(this.drawing);
            this.Controls.Add(this.drawingactive);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.modoutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fish_desc2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Fish_tagline);
            this.Controls.Add(this.Fish_desc);
            this.Controls.Add(this.PB_drawing_mode);
            this.Controls.Add(this.Text_enter_initials_prompt);
            this.Controls.Add(this.PB_Back_To_Home);
            this.Controls.Add(this.Fish_preview_picture);
            this.Controls.Add(this.Label_Fish_Type_Text);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PB_fish_select_right);
            this.Controls.Add(this.PB_fish_select_left);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Fish_preview_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_fish_select_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_fish_select_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_drawing_mode)).EndInit();
            this.drawing.ResumeLayout(false);
            this.drawing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_Fish_Type_Text;
        private System.Windows.Forms.PictureBox Fish_preview_picture;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox PB_fish_select_left;
        private System.Windows.Forms.PictureBox PB_fish_select_right;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PB_Back_To_Home;
        private System.Windows.Forms.Label Text_enter_initials_prompt;
        private System.Windows.Forms.PictureBox PB_drawing_mode;
        private System.Windows.Forms.Label Fish_desc;
        private System.Windows.Forms.Label Fish_tagline;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Fish_desc2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label modoutput;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.Label drawingactive;
        private System.Windows.Forms.Panel drawing;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}
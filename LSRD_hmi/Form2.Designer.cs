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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Text_enter_initials_prompt = new System.Windows.Forms.Label();
            this.PB_drawing_mode = new System.Windows.Forms.PictureBox();
            this.Fish_desc = new System.Windows.Forms.Label();
            this.Fish_tagline = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Fish_desc2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Fish_preview_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_fish_select_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_fish_select_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_drawing_mode)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Fish_Type_Text
            // 
            this.Label_Fish_Type_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Fish_Type_Text.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label_Fish_Type_Text.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Label_Fish_Type_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Label_Fish_Type_Text.Location = new System.Drawing.Point(387, 54);
            this.Label_Fish_Type_Text.MaximumSize = new System.Drawing.Size(251, 50);
            this.Label_Fish_Type_Text.MinimumSize = new System.Drawing.Size(251, 50);
            this.Label_Fish_Type_Text.Name = "Label_Fish_Type_Text";
            this.Label_Fish_Type_Text.Size = new System.Drawing.Size(251, 50);
            this.Label_Fish_Type_Text.TabIndex = 2;
            this.Label_Fish_Type_Text.Text = "((fish type text))";
            this.Label_Fish_Type_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fish_preview_picture
            // 
            this.Fish_preview_picture.BackColor = System.Drawing.Color.White;
            this.Fish_preview_picture.Location = new System.Drawing.Point(387, 134);
            this.Fish_preview_picture.Margin = new System.Windows.Forms.Padding(25, 25, 25, 25);
            this.Fish_preview_picture.MaximumSize = new System.Drawing.Size(251, 185);
            this.Fish_preview_picture.MinimumSize = new System.Drawing.Size(251, 180);
            this.Fish_preview_picture.Name = "Fish_preview_picture";
            this.Fish_preview_picture.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Fish_preview_picture.Size = new System.Drawing.Size(251, 180);
            this.Fish_preview_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fish_preview_picture.TabIndex = 3;
            this.Fish_preview_picture.TabStop = false;
            // 
            // PB_fish_select_left
            // 
            this.PB_fish_select_left.BackColor = System.Drawing.Color.Transparent;
            this.PB_fish_select_left.Image = global::LSRD_hmi.Properties.Resources.button_left;
            this.PB_fish_select_left.Location = new System.Drawing.Point(304, 180);
            this.PB_fish_select_left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB_fish_select_left.MaximumSize = new System.Drawing.Size(80, 80);
            this.PB_fish_select_left.MinimumSize = new System.Drawing.Size(80, 80);
            this.PB_fish_select_left.Name = "PB_fish_select_left";
            this.PB_fish_select_left.Size = new System.Drawing.Size(80, 80);
            this.PB_fish_select_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_fish_select_left.TabIndex = 5;
            this.PB_fish_select_left.TabStop = false;
            this.PB_fish_select_left.Click += new System.EventHandler(this.PB_fish_select_left_Click);
            // 
            // PB_fish_select_right
            // 
            this.PB_fish_select_right.BackColor = System.Drawing.Color.Transparent;
            this.PB_fish_select_right.Image = global::LSRD_hmi.Properties.Resources.button_right;
            this.PB_fish_select_right.Location = new System.Drawing.Point(643, 180);
            this.PB_fish_select_right.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB_fish_select_right.MaximumSize = new System.Drawing.Size(80, 80);
            this.PB_fish_select_right.MinimumSize = new System.Drawing.Size(80, 80);
            this.PB_fish_select_right.Name = "PB_fish_select_right";
            this.PB_fish_select_right.Size = new System.Drawing.Size(80, 80);
            this.PB_fish_select_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_fish_select_right.TabIndex = 6;
            this.PB_fish_select_right.TabStop = false;
            this.PB_fish_select_right.Click += new System.EventHandler(this.PB_fish_select_right_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LSRD_hmi.Properties.Resources.Frame_250_180;
            this.pictureBox1.Location = new System.Drawing.Point(368, 113);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PB_Back_To_Home
            // 
            this.PB_Back_To_Home.BackColor = System.Drawing.Color.Transparent;
            this.PB_Back_To_Home.Image = global::LSRD_hmi.Properties.Resources.PB_back_wide1;
            this.PB_Back_To_Home.Location = new System.Drawing.Point(57, 36);
            this.PB_Back_To_Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB_Back_To_Home.MaximumSize = new System.Drawing.Size(160, 80);
            this.PB_Back_To_Home.MinimumSize = new System.Drawing.Size(160, 80);
            this.PB_Back_To_Home.Name = "PB_Back_To_Home";
            this.PB_Back_To_Home.Size = new System.Drawing.Size(160, 80);
            this.PB_Back_To_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Back_To_Home.TabIndex = 11;
            this.PB_Back_To_Home.TabStop = false;
            this.PB_Back_To_Home.Click += new System.EventHandler(this.PB_Back_To_Home_Click);
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(459, 390);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 45);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Text_enter_initials_prompt
            // 
            this.Text_enter_initials_prompt.BackColor = System.Drawing.Color.Transparent;
            this.Text_enter_initials_prompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_enter_initials_prompt.ForeColor = System.Drawing.Color.Black;
            this.Text_enter_initials_prompt.Location = new System.Drawing.Point(459, 362);
            this.Text_enter_initials_prompt.Name = "Text_enter_initials_prompt";
            this.Text_enter_initials_prompt.Size = new System.Drawing.Size(107, 20);
            this.Text_enter_initials_prompt.TabIndex = 13;
            this.Text_enter_initials_prompt.Text = "Initials:";
            this.Text_enter_initials_prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_drawing_mode
            // 
            this.PB_drawing_mode.BackColor = System.Drawing.Color.Transparent;
            this.PB_drawing_mode.Image = global::LSRD_hmi.Properties.Resources.PB_square_enter;
            this.PB_drawing_mode.Location = new System.Drawing.Point(431, 465);
            this.PB_drawing_mode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB_drawing_mode.MaximumSize = new System.Drawing.Size(160, 80);
            this.PB_drawing_mode.MinimumSize = new System.Drawing.Size(160, 80);
            this.PB_drawing_mode.Name = "PB_drawing_mode";
            this.PB_drawing_mode.Size = new System.Drawing.Size(160, 80);
            this.PB_drawing_mode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_drawing_mode.TabIndex = 14;
            this.PB_drawing_mode.TabStop = false;
            // 
            // Fish_desc
            // 
            this.Fish_desc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fish_desc.AutoSize = true;
            this.Fish_desc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Fish_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fish_desc.Location = new System.Drawing.Point(785, 167);
            this.Fish_desc.MaximumSize = new System.Drawing.Size(200, 0);
            this.Fish_desc.MinimumSize = new System.Drawing.Size(200, 98);
            this.Fish_desc.Name = "Fish_desc";
            this.Fish_desc.Padding = new System.Windows.Forms.Padding(8, 7, 8, 18);
            this.Fish_desc.Size = new System.Drawing.Size(200, 98);
            this.Fish_desc.TabIndex = 15;
            this.Fish_desc.Text = "{{FISH DESCRIPTION}}";
            // 
            // Fish_tagline
            // 
            this.Fish_tagline.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Fish_tagline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fish_tagline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fish_tagline.ForeColor = System.Drawing.Color.Black;
            this.Fish_tagline.Location = new System.Drawing.Point(785, 80);
            this.Fish_tagline.MaximumSize = new System.Drawing.Size(200, 160);
            this.Fish_tagline.Name = "Fish_tagline";
            this.Fish_tagline.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Fish_tagline.Size = new System.Drawing.Size(200, 62);
            this.Fish_tagline.TabIndex = 16;
            this.Fish_tagline.Text = "{{FISH TAGLINE}}";
            this.Fish_tagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(785, 36);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.label5.Size = new System.Drawing.Size(200, 38);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fish Facts:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 203);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(4, 7, 8, 7);
            this.label6.Size = new System.Drawing.Size(203, 342);
            this.label6.TabIndex = 20;
            this.label6.Text = "1) Select a fish\r\n     using the \r\n     arrows\r\n\r\n2) Enter your \r\n     initials\r\n" +
    "\r\n3) Press enter\r\n\r\n4) Follow next \r\n     instructions\r\n     for paper\r\n";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(39, 154);
            this.label7.MaximumSize = new System.Drawing.Size(200, 160);
            this.label7.MinimumSize = new System.Drawing.Size(100, 10);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.label7.Size = new System.Drawing.Size(200, 48);
            this.label7.TabIndex = 21;
            this.label7.Text = " Instructions: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fish_desc2
            // 
            this.Fish_desc2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Fish_desc2.AutoSize = true;
            this.Fish_desc2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Fish_desc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fish_desc2.Location = new System.Drawing.Point(785, 295);
            this.Fish_desc2.MaximumSize = new System.Drawing.Size(200, 0);
            this.Fish_desc2.MinimumSize = new System.Drawing.Size(200, 100);
            this.Fish_desc2.Name = "Fish_desc2";
            this.Fish_desc2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 18);
            this.Fish_desc2.Size = new System.Drawing.Size(200, 100);
            this.Fish_desc2.TabIndex = 22;
            this.Fish_desc2.Text = "{{FISH DESCRIPTION EXTENDED}}";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LSRD_hmi.Properties.Resources.fish_drawing_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 601);
            this.ControlBox = false;
            this.Controls.Add(this.Fish_desc2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Fish_tagline);
            this.Controls.Add(this.Fish_desc);
            this.Controls.Add(this.PB_drawing_mode);
            this.Controls.Add(this.Text_enter_initials_prompt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PB_Back_To_Home);
            this.Controls.Add(this.Fish_preview_picture);
            this.Controls.Add(this.Label_Fish_Type_Text);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PB_fish_select_right);
            this.Controls.Add(this.PB_fish_select_left);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1024, 601);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 601);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Fish_preview_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_fish_select_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_fish_select_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_drawing_mode)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Text_enter_initials_prompt;
        private System.Windows.Forms.PictureBox PB_drawing_mode;
        private System.Windows.Forms.Label Fish_desc;
        private System.Windows.Forms.Label Fish_tagline;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Fish_desc2;
    }
}
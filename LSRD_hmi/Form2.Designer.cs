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
            this.PB_Screen_Main = new System.Windows.Forms.Button();
            this.Label_Fish_Type_Text = new System.Windows.Forms.Label();
            this.Fish_preview_picture = new System.Windows.Forms.PictureBox();
            this.Fish_Bg_preview_picture = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PB_fish_select_left = new System.Windows.Forms.PictureBox();
            this.PB_fish_select_right = new System.Windows.Forms.PictureBox();
            this.PB_bg_select_right = new System.Windows.Forms.PictureBox();
            this.PB_bg_select_left = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Fish_preview_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fish_Bg_preview_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_fish_select_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_fish_select_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_bg_select_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_bg_select_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Screen_Main
            // 
            this.PB_Screen_Main.BackColor = System.Drawing.Color.Gainsboro;
            this.PB_Screen_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Screen_Main.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PB_Screen_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PB_Screen_Main.Location = new System.Drawing.Point(38, 36);
            this.PB_Screen_Main.Margin = new System.Windows.Forms.Padding(4);
            this.PB_Screen_Main.Name = "PB_Screen_Main";
            this.PB_Screen_Main.Size = new System.Drawing.Size(158, 68);
            this.PB_Screen_Main.TabIndex = 1;
            this.PB_Screen_Main.Text = "Back";
            this.PB_Screen_Main.UseVisualStyleBackColor = false;
            this.PB_Screen_Main.Click += new System.EventHandler(this.PB_Screen_Main_Click);
            // 
            // Label_Fish_Type_Text
            // 
            this.Label_Fish_Type_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Fish_Type_Text.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label_Fish_Type_Text.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Label_Fish_Type_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Label_Fish_Type_Text.Location = new System.Drawing.Point(388, 33);
            this.Label_Fish_Type_Text.MaximumSize = new System.Drawing.Size(250, 50);
            this.Label_Fish_Type_Text.MinimumSize = new System.Drawing.Size(250, 50);
            this.Label_Fish_Type_Text.Name = "Label_Fish_Type_Text";
            this.Label_Fish_Type_Text.Size = new System.Drawing.Size(250, 50);
            this.Label_Fish_Type_Text.TabIndex = 2;
            this.Label_Fish_Type_Text.Text = "((fish type text))";
            this.Label_Fish_Type_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fish_preview_picture
            // 
            this.Fish_preview_picture.Image = global::LSRD_hmi.Properties.Resources.Zooplankton_250_180;
            this.Fish_preview_picture.Location = new System.Drawing.Point(387, 109);
            this.Fish_preview_picture.Margin = new System.Windows.Forms.Padding(25);
            this.Fish_preview_picture.MaximumSize = new System.Drawing.Size(250, 180);
            this.Fish_preview_picture.MinimumSize = new System.Drawing.Size(250, 180);
            this.Fish_preview_picture.Name = "Fish_preview_picture";
            this.Fish_preview_picture.Padding = new System.Windows.Forms.Padding(10);
            this.Fish_preview_picture.Size = new System.Drawing.Size(250, 180);
            this.Fish_preview_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fish_preview_picture.TabIndex = 3;
            this.Fish_preview_picture.TabStop = false;
            // 
            // Fish_Bg_preview_picture
            // 
            this.Fish_Bg_preview_picture.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fish_Bg_preview_picture.Location = new System.Drawing.Point(386, 327);
            this.Fish_Bg_preview_picture.Margin = new System.Windows.Forms.Padding(0);
            this.Fish_Bg_preview_picture.MaximumSize = new System.Drawing.Size(250, 180);
            this.Fish_Bg_preview_picture.Name = "Fish_Bg_preview_picture";
            this.Fish_Bg_preview_picture.Padding = new System.Windows.Forms.Padding(10);
            this.Fish_Bg_preview_picture.Size = new System.Drawing.Size(250, 180);
            this.Fish_Bg_preview_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fish_Bg_preview_picture.TabIndex = 4;
            this.Fish_Bg_preview_picture.TabStop = false;
            // 
            // PB_fish_select_left
            // 
            this.PB_fish_select_left.BackColor = System.Drawing.Color.Transparent;
            this.PB_fish_select_left.Image = global::LSRD_hmi.Properties.Resources.button_left;
            this.PB_fish_select_left.Location = new System.Drawing.Point(303, 155);
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
            this.PB_fish_select_right.Location = new System.Drawing.Point(642, 155);
            this.PB_fish_select_right.MaximumSize = new System.Drawing.Size(80, 80);
            this.PB_fish_select_right.MinimumSize = new System.Drawing.Size(80, 80);
            this.PB_fish_select_right.Name = "PB_fish_select_right";
            this.PB_fish_select_right.Size = new System.Drawing.Size(80, 80);
            this.PB_fish_select_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_fish_select_right.TabIndex = 6;
            this.PB_fish_select_right.TabStop = false;
            this.PB_fish_select_right.Click += new System.EventHandler(this.PB_fish_select_right_Click);
            // 
            // PB_bg_select_right
            // 
            this.PB_bg_select_right.BackColor = System.Drawing.Color.Transparent;
            this.PB_bg_select_right.Image = global::LSRD_hmi.Properties.Resources.button_right;
            this.PB_bg_select_right.Location = new System.Drawing.Point(642, 371);
            this.PB_bg_select_right.MaximumSize = new System.Drawing.Size(80, 80);
            this.PB_bg_select_right.MinimumSize = new System.Drawing.Size(80, 80);
            this.PB_bg_select_right.Name = "PB_bg_select_right";
            this.PB_bg_select_right.Size = new System.Drawing.Size(80, 80);
            this.PB_bg_select_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_bg_select_right.TabIndex = 7;
            this.PB_bg_select_right.TabStop = false;
            // 
            // PB_bg_select_left
            // 
            this.PB_bg_select_left.BackColor = System.Drawing.Color.Transparent;
            this.PB_bg_select_left.Image = global::LSRD_hmi.Properties.Resources.button_left;
            this.PB_bg_select_left.Location = new System.Drawing.Point(303, 371);
            this.PB_bg_select_left.MaximumSize = new System.Drawing.Size(80, 80);
            this.PB_bg_select_left.MinimumSize = new System.Drawing.Size(80, 80);
            this.PB_bg_select_left.Name = "PB_bg_select_left";
            this.PB_bg_select_left.Size = new System.Drawing.Size(80, 80);
            this.PB_bg_select_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_bg_select_left.TabIndex = 8;
            this.PB_bg_select_left.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LSRD_hmi.Properties.Resources.Frame_250_180;
            this.pictureBox1.Location = new System.Drawing.Point(368, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LSRD_hmi.Properties.Resources.Frame_250_180;
            this.pictureBox2.Location = new System.Drawing.Point(366, 305);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(295, 223);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LSRD_hmi.Properties.Resources.slideshow_texture_gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.Fish_Bg_preview_picture);
            this.Controls.Add(this.Fish_preview_picture);
            this.Controls.Add(this.Label_Fish_Type_Text);
            this.Controls.Add(this.PB_Screen_Main);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PB_fish_select_right);
            this.Controls.Add(this.PB_fish_select_left);
            this.Controls.Add(this.PB_bg_select_right);
            this.Controls.Add(this.PB_bg_select_left);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Fish_preview_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fish_Bg_preview_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_fish_select_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_fish_select_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_bg_select_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_bg_select_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PB_Screen_Main;
        private System.Windows.Forms.Label Label_Fish_Type_Text;
        private System.Windows.Forms.PictureBox Fish_preview_picture;
        private System.Windows.Forms.PictureBox Fish_Bg_preview_picture;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox PB_fish_select_left;
        private System.Windows.Forms.PictureBox PB_fish_select_right;
        private System.Windows.Forms.PictureBox PB_bg_select_right;
        private System.Windows.Forms.PictureBox PB_bg_select_left;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
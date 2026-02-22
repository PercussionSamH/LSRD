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
            ((System.ComponentModel.ISupportInitialize)(this.Fish_preview_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_fish_select_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_fish_select_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).BeginInit();
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
            // PB_Back_To_Home
            // 
            this.PB_Back_To_Home.BackColor = System.Drawing.Color.Transparent;
            this.PB_Back_To_Home.Image = global::LSRD_hmi.Properties.Resources.PB_gray_back_to_home2;
            this.PB_Back_To_Home.Location = new System.Drawing.Point(54, 59);
            this.PB_Back_To_Home.MaximumSize = new System.Drawing.Size(124, 80);
            this.PB_Back_To_Home.MinimumSize = new System.Drawing.Size(124, 80);
            this.PB_Back_To_Home.Name = "PB_Back_To_Home";
            this.PB_Back_To_Home.Size = new System.Drawing.Size(124, 80);
            this.PB_Back_To_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Back_To_Home.TabIndex = 11;
            this.PB_Back_To_Home.TabStop = false;
            this.PB_Back_To_Home.Click += new System.EventHandler(this.PB_Back_To_Home_Click);
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(471, 390);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 45);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LSRD_hmi.Properties.Resources.slideshow_texture_gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PB_Back_To_Home);
            this.Controls.Add(this.Fish_preview_picture);
            this.Controls.Add(this.Label_Fish_Type_Text);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PB_fish_select_right);
            this.Controls.Add(this.PB_fish_select_left);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Fish_preview_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_fish_select_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_fish_select_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).EndInit();
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
    }
}
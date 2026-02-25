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
            this.Scrollable_Events_Box = new System.Windows.Forms.FlowLayoutPanel();
            this.PB_Back_To_Home = new System.Windows.Forms.PictureBox();
            this.richtext_room1 = new System.Windows.Forms.RichTextBox();
            this.label_doorman_title = new System.Windows.Forms.Label();
            this.richtext_room2 = new System.Windows.Forms.RichTextBox();
            this.richtext_room3 = new System.Windows.Forms.RichTextBox();
            this.richtext_room4 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // Scrollable_Events_Box
            // 
            this.Scrollable_Events_Box.AutoScroll = true;
            this.Scrollable_Events_Box.BackColor = System.Drawing.Color.White;
            this.Scrollable_Events_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Scrollable_Events_Box.Location = new System.Drawing.Point(714, 33);
            this.Scrollable_Events_Box.Margin = new System.Windows.Forms.Padding(10);
            this.Scrollable_Events_Box.Name = "Scrollable_Events_Box";
            this.Scrollable_Events_Box.Padding = new System.Windows.Forms.Padding(5);
            this.Scrollable_Events_Box.Size = new System.Drawing.Size(279, 532);
            this.Scrollable_Events_Box.TabIndex = 6;
            // 
            // PB_Back_To_Home
            // 
            this.PB_Back_To_Home.BackColor = System.Drawing.Color.Transparent;
            this.PB_Back_To_Home.Image = global::LSRD_hmi.Properties.Resources.PB_gray_back_to_home;
            this.PB_Back_To_Home.Location = new System.Drawing.Point(22, 12);
            this.PB_Back_To_Home.MaximumSize = new System.Drawing.Size(124, 80);
            this.PB_Back_To_Home.MinimumSize = new System.Drawing.Size(124, 80);
            this.PB_Back_To_Home.Name = "PB_Back_To_Home";
            this.PB_Back_To_Home.Size = new System.Drawing.Size(124, 80);
            this.PB_Back_To_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Back_To_Home.TabIndex = 12;
            this.PB_Back_To_Home.TabStop = false;
            this.PB_Back_To_Home.Click += new System.EventHandler(this.PB_Back_To_Home_Click);
            // 
            // richtext_room1
            // 
            this.richtext_room1.BackColor = System.Drawing.Color.White;
            this.richtext_room1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtext_room1.Location = new System.Drawing.Point(183, 114);
            this.richtext_room1.Name = "richtext_room1";
            this.richtext_room1.ReadOnly = true;
            this.richtext_room1.Size = new System.Drawing.Size(221, 211);
            this.richtext_room1.TabIndex = 13;
            this.richtext_room1.Text = "";
            // 
            // label_doorman_title
            // 
            this.label_doorman_title.AutoSize = true;
            this.label_doorman_title.BackColor = System.Drawing.Color.White;
            this.label_doorman_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_doorman_title.Location = new System.Drawing.Point(265, 33);
            this.label_doorman_title.Name = "label_doorman_title";
            this.label_doorman_title.Size = new System.Drawing.Size(287, 42);
            this.label_doorman_title.TabIndex = 17;
            this.label_doorman_title.Text = "Doorman Mode";
            // 
            // richtext_room2
            // 
            this.richtext_room2.BackColor = System.Drawing.Color.White;
            this.richtext_room2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtext_room2.Location = new System.Drawing.Point(434, 114);
            this.richtext_room2.Name = "richtext_room2";
            this.richtext_room2.ReadOnly = true;
            this.richtext_room2.Size = new System.Drawing.Size(221, 211);
            this.richtext_room2.TabIndex = 18;
            this.richtext_room2.Text = "";
            // 
            // richtext_room3
            // 
            this.richtext_room3.BackColor = System.Drawing.Color.White;
            this.richtext_room3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtext_room3.Location = new System.Drawing.Point(183, 353);
            this.richtext_room3.Name = "richtext_room3";
            this.richtext_room3.ReadOnly = true;
            this.richtext_room3.Size = new System.Drawing.Size(221, 211);
            this.richtext_room3.TabIndex = 19;
            this.richtext_room3.Text = "";
            // 
            // richtext_room4
            // 
            this.richtext_room4.BackColor = System.Drawing.Color.White;
            this.richtext_room4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtext_room4.Location = new System.Drawing.Point(434, 353);
            this.richtext_room4.Name = "richtext_room4";
            this.richtext_room4.ReadOnly = true;
            this.richtext_room4.Size = new System.Drawing.Size(221, 211);
            this.richtext_room4.TabIndex = 20;
            this.richtext_room4.Text = "";
            // 
            // Form_doorman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LSRD_hmi.Properties.Resources.doorman_bkg_blueish2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.richtext_room4);
            this.Controls.Add(this.richtext_room3);
            this.Controls.Add(this.richtext_room2);
            this.Controls.Add(this.label_doorman_title);
            this.Controls.Add(this.richtext_room1);
            this.Controls.Add(this.PB_Back_To_Home);
            this.Controls.Add(this.Scrollable_Events_Box);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form_doorman";
            this.Text = "Form_doorman";
            this.Load += new System.EventHandler(this.Form_doorman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel Scrollable_Events_Box;
        private System.Windows.Forms.PictureBox PB_Back_To_Home;
        private System.Windows.Forms.RichTextBox richtext_room1;
        private System.Windows.Forms.Label label_doorman_title;
        private System.Windows.Forms.RichTextBox richtext_room2;
        private System.Windows.Forms.RichTextBox richtext_room3;
        private System.Windows.Forms.RichTextBox richtext_room4;
    }
}
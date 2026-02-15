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
            this.PB_doorman_mode = new System.Windows.Forms.Button();
            this.timer_Modbus_Com = new System.Windows.Forms.Timer(this.components);
            this.PB_Draw_Fish1 = new System.Windows.Forms.Button();
            this.PB_Draw_Square = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.test_textbox = new System.Windows.Forms.Label();
            this.PB_drawing_mode = new System.Windows.Forms.Button();
            this.PB_Quit_Program = new System.Windows.Forms.Button();
            this.PB_scavenger_mode = new System.Windows.Forms.Button();
            this.PB_staff_controls = new System.Windows.Forms.Button();
            this.Picture_LSRD_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_LSRD_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_doorman_mode
            // 
            this.PB_doorman_mode.BackColor = System.Drawing.Color.Gainsboro;
            this.PB_doorman_mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_doorman_mode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PB_doorman_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PB_doorman_mode.Location = new System.Drawing.Point(134, 397);
            this.PB_doorman_mode.Margin = new System.Windows.Forms.Padding(4);
            this.PB_doorman_mode.Name = "PB_doorman_mode";
            this.PB_doorman_mode.Size = new System.Drawing.Size(189, 92);
            this.PB_doorman_mode.TabIndex = 0;
            this.PB_doorman_mode.Text = "Doorman\r\nMode";
            this.PB_doorman_mode.UseVisualStyleBackColor = false;
            this.PB_doorman_mode.Click += new System.EventHandler(this.PB_doorman_mode_Click);
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
            this.PB_Draw_Fish1.Location = new System.Drawing.Point(107, 96);
            this.PB_Draw_Fish1.Margin = new System.Windows.Forms.Padding(4);
            this.PB_Draw_Fish1.Name = "PB_Draw_Fish1";
            this.PB_Draw_Fish1.Size = new System.Drawing.Size(133, 34);
            this.PB_Draw_Fish1.TabIndex = 2;
            this.PB_Draw_Fish1.Text = "Draw Fish One";
            this.PB_Draw_Fish1.UseVisualStyleBackColor = false;
            this.PB_Draw_Fish1.Click += new System.EventHandler(this.PB_Draw_Fish1_Click);
            // 
            // PB_Draw_Square
            // 
            this.PB_Draw_Square.BackColor = System.Drawing.Color.LightGray;
            this.PB_Draw_Square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Draw_Square.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PB_Draw_Square.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PB_Draw_Square.Location = new System.Drawing.Point(107, 138);
            this.PB_Draw_Square.Margin = new System.Windows.Forms.Padding(4);
            this.PB_Draw_Square.Name = "PB_Draw_Square";
            this.PB_Draw_Square.Size = new System.Drawing.Size(133, 34);
            this.PB_Draw_Square.TabIndex = 3;
            this.PB_Draw_Square.Text = "Draw Square";
            this.PB_Draw_Square.UseVisualStyleBackColor = false;
            this.PB_Draw_Square.Click += new System.EventHandler(this.PB_Draw_Square_Click);
            // 
            // test_textbox
            // 
            this.test_textbox.AutoSize = true;
            this.test_textbox.Location = new System.Drawing.Point(42, 30);
            this.test_textbox.Name = "test_textbox";
            this.test_textbox.Size = new System.Drawing.Size(44, 16);
            this.test_textbox.TabIndex = 4;
            this.test_textbox.Text = "label1";
            this.test_textbox.Visible = false;
            // 
            // PB_drawing_mode
            // 
            this.PB_drawing_mode.BackColor = System.Drawing.Color.Gainsboro;
            this.PB_drawing_mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_drawing_mode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PB_drawing_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PB_drawing_mode.Location = new System.Drawing.Point(364, 397);
            this.PB_drawing_mode.Margin = new System.Windows.Forms.Padding(4);
            this.PB_drawing_mode.Name = "PB_drawing_mode";
            this.PB_drawing_mode.Size = new System.Drawing.Size(189, 92);
            this.PB_drawing_mode.TabIndex = 5;
            this.PB_drawing_mode.Text = "Fish Drawing\r\nDemo";
            this.PB_drawing_mode.UseVisualStyleBackColor = false;
            this.PB_drawing_mode.Click += new System.EventHandler(this.PB_drawing_mode_Click);
            // 
            // PB_Quit_Program
            // 
            this.PB_Quit_Program.BackColor = System.Drawing.Color.Gainsboro;
            this.PB_Quit_Program.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Quit_Program.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PB_Quit_Program.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PB_Quit_Program.Location = new System.Drawing.Point(107, 30);
            this.PB_Quit_Program.Margin = new System.Windows.Forms.Padding(4);
            this.PB_Quit_Program.Name = "PB_Quit_Program";
            this.PB_Quit_Program.Size = new System.Drawing.Size(133, 58);
            this.PB_Quit_Program.TabIndex = 6;
            this.PB_Quit_Program.Text = "Quit program\r\n(debug only)";
            this.PB_Quit_Program.UseVisualStyleBackColor = false;
            this.PB_Quit_Program.Click += new System.EventHandler(this.PB_Quit_Program_Click);
            // 
            // PB_scavenger_mode
            // 
            this.PB_scavenger_mode.BackColor = System.Drawing.Color.Gainsboro;
            this.PB_scavenger_mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_scavenger_mode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PB_scavenger_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PB_scavenger_mode.Location = new System.Drawing.Point(590, 397);
            this.PB_scavenger_mode.Margin = new System.Windows.Forms.Padding(4);
            this.PB_scavenger_mode.Name = "PB_scavenger_mode";
            this.PB_scavenger_mode.Size = new System.Drawing.Size(189, 92);
            this.PB_scavenger_mode.TabIndex = 7;
            this.PB_scavenger_mode.Text = "Scavenger hunt";
            this.PB_scavenger_mode.UseVisualStyleBackColor = false;
            // 
            // PB_staff_controls
            // 
            this.PB_staff_controls.BackColor = System.Drawing.Color.Gainsboro;
            this.PB_staff_controls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_staff_controls.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PB_staff_controls.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PB_staff_controls.Location = new System.Drawing.Point(792, 13);
            this.PB_staff_controls.Margin = new System.Windows.Forms.Padding(4);
            this.PB_staff_controls.Name = "PB_staff_controls";
            this.PB_staff_controls.Size = new System.Drawing.Size(189, 92);
            this.PB_staff_controls.TabIndex = 8;
            this.PB_staff_controls.Text = "Staff Controls";
            this.PB_staff_controls.UseVisualStyleBackColor = false;
            // 
            // Picture_LSRD_Logo
            // 
            this.Picture_LSRD_Logo.BackColor = System.Drawing.Color.Transparent;
            this.Picture_LSRD_Logo.Image = global::LSRD_hmi.Properties.Resources.LogoBright_transparent;
            this.Picture_LSRD_Logo.Location = new System.Drawing.Point(605, 38);
            this.Picture_LSRD_Logo.Name = "Picture_LSRD_Logo";
            this.Picture_LSRD_Logo.Size = new System.Drawing.Size(220, 196);
            this.Picture_LSRD_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_LSRD_Logo.TabIndex = 9;
            this.Picture_LSRD_Logo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LSRD_hmi.Properties.Resources.slideshow_texture_dark_blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.PB_staff_controls);
            this.Controls.Add(this.PB_scavenger_mode);
            this.Controls.Add(this.PB_Quit_Program);
            this.Controls.Add(this.PB_drawing_mode);
            this.Controls.Add(this.test_textbox);
            this.Controls.Add(this.PB_Draw_Square);
            this.Controls.Add(this.PB_Draw_Fish1);
            this.Controls.Add(this.PB_doorman_mode);
            this.Controls.Add(this.Picture_LSRD_Logo);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_LSRD_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PB_doorman_mode;
        private System.Windows.Forms.Timer timer_Modbus_Com;
        private System.Windows.Forms.Button PB_Draw_Fish1;
        private System.Windows.Forms.Button PB_Draw_Square;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label test_textbox;
        private System.Windows.Forms.Button PB_drawing_mode;
        private System.Windows.Forms.Button PB_Quit_Program;
        private System.Windows.Forms.Button PB_scavenger_mode;
        private System.Windows.Forms.Button PB_staff_controls;
        private System.Windows.Forms.PictureBox Picture_LSRD_Logo;
    }
}


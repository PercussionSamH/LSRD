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
            this.PB_wave = new System.Windows.Forms.Button();
            this.PB_Draw_Fish1 = new System.Windows.Forms.Button();
            this.PB_Draw_Square = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.test_textbox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PB_doorman_mode
            // 
            this.PB_doorman_mode.BackColor = System.Drawing.Color.Gainsboro;
            this.PB_doorman_mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_doorman_mode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PB_doorman_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PB_doorman_mode.Location = new System.Drawing.Point(58, 26);
            this.PB_doorman_mode.Margin = new System.Windows.Forms.Padding(4);
            this.PB_doorman_mode.Name = "PB_doorman_mode";
            this.PB_doorman_mode.Size = new System.Drawing.Size(189, 92);
            this.PB_doorman_mode.TabIndex = 0;
            this.PB_doorman_mode.Text = "Doorman\r\nMode";
            this.PB_doorman_mode.UseVisualStyleBackColor = false;
            this.PB_doorman_mode.Visible = false;
            // 
            // timer_Modbus_Com
            // 
            this.timer_Modbus_Com.Tick += new System.EventHandler(this.timer_Modbus_Com_Tick);
            // 
            // PB_wave
            // 
            this.PB_wave.Location = new System.Drawing.Point(58, 126);
            this.PB_wave.Margin = new System.Windows.Forms.Padding(4);
            this.PB_wave.Name = "PB_wave";
            this.PB_wave.Size = new System.Drawing.Size(189, 108);
            this.PB_wave.TabIndex = 1;
            this.PB_wave.Text = "Wave";
            this.PB_wave.UseVisualStyleBackColor = true;
            this.PB_wave.Visible = false;
            this.PB_wave.Click += new System.EventHandler(this.PB_wave_Click);
            // 
            // PB_Draw_Fish1
            // 
            this.PB_Draw_Fish1.BackColor = System.Drawing.Color.Silver;
            this.PB_Draw_Fish1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Draw_Fish1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PB_Draw_Fish1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PB_Draw_Fish1.Location = new System.Drawing.Point(489, 373);
            this.PB_Draw_Fish1.Margin = new System.Windows.Forms.Padding(4);
            this.PB_Draw_Fish1.Name = "PB_Draw_Fish1";
            this.PB_Draw_Fish1.Size = new System.Drawing.Size(189, 92);
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
            this.PB_Draw_Square.Location = new System.Drawing.Point(726, 373);
            this.PB_Draw_Square.Margin = new System.Windows.Forms.Padding(4);
            this.PB_Draw_Square.Name = "PB_Draw_Square";
            this.PB_Draw_Square.Size = new System.Drawing.Size(189, 92);
            this.PB_Draw_Square.TabIndex = 3;
            this.PB_Draw_Square.Text = "Draw Square";
            this.PB_Draw_Square.UseVisualStyleBackColor = false;
            this.PB_Draw_Square.Click += new System.EventHandler(this.PB_Draw_Square_Click);
            // 
            // test_textbox
            // 
            this.test_textbox.AutoSize = true;
            this.test_textbox.Location = new System.Drawing.Point(254, 68);
            this.test_textbox.Name = "test_textbox";
            this.test_textbox.Size = new System.Drawing.Size(44, 16);
            this.test_textbox.TabIndex = 4;
            this.test_textbox.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LSRD_hmi.Properties.Resources.slideshow_texture_dark_blue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.test_textbox);
            this.Controls.Add(this.PB_Draw_Square);
            this.Controls.Add(this.PB_Draw_Fish1);
            this.Controls.Add(this.PB_doorman_mode);
            this.Controls.Add(this.PB_wave);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PB_doorman_mode;
        private System.Windows.Forms.Timer timer_Modbus_Com;
        private System.Windows.Forms.Button PB_wave;
        private System.Windows.Forms.Button PB_Draw_Fish1;
        private System.Windows.Forms.Button PB_Draw_Square;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label test_textbox;
    }
}


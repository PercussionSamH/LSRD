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
            this.PB_wave = new System.Windows.Forms.Button();
            this.timer_Modbus_Com = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PB_doorman_mode
            // 
            this.PB_doorman_mode.Location = new System.Drawing.Point(256, 266);
            this.PB_doorman_mode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PB_doorman_mode.Name = "PB_doorman_mode";
            this.PB_doorman_mode.Size = new System.Drawing.Size(228, 108);
            this.PB_doorman_mode.TabIndex = 0;
            this.PB_doorman_mode.Text = "Doorman Mode";
            this.PB_doorman_mode.UseVisualStyleBackColor = true;
            // 
            // PB_wave
            // 
            this.PB_wave.Location = new System.Drawing.Point(583, 266);
            this.PB_wave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PB_wave.Name = "PB_wave";
            this.PB_wave.Size = new System.Drawing.Size(228, 108);
            this.PB_wave.TabIndex = 1;
            this.PB_wave.Text = "Wave";
            this.PB_wave.UseVisualStyleBackColor = true;
            this.PB_wave.Click += new System.EventHandler(this.PB_wave_Click);
            // 
            // timer_Modbus_Com
            // 
            this.timer_Modbus_Com.Tick += new System.EventHandler(this.timer_Modbus_Com_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PB_wave);
            this.Controls.Add(this.PB_doorman_mode);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PB_doorman_mode;
        private System.Windows.Forms.Button PB_wave;
        private System.Windows.Forms.Timer timer_Modbus_Com;
    }
}


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
            this.PB_doorman_mode = new System.Windows.Forms.Button();
            this.PB_wave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PB_doorman_mode
            // 
            this.PB_doorman_mode.Location = new System.Drawing.Point(192, 216);
            this.PB_doorman_mode.Name = "PB_doorman_mode";
            this.PB_doorman_mode.Size = new System.Drawing.Size(171, 88);
            this.PB_doorman_mode.TabIndex = 0;
            this.PB_doorman_mode.Text = "Doorman Mode";
            this.PB_doorman_mode.UseVisualStyleBackColor = true;
            // 
            // PB_wave
            // 
            this.PB_wave.Location = new System.Drawing.Point(437, 216);
            this.PB_wave.Name = "PB_wave";
            this.PB_wave.Size = new System.Drawing.Size(171, 88);
            this.PB_wave.TabIndex = 1;
            this.PB_wave.Text = "Wave";
            this.PB_wave.UseVisualStyleBackColor = true;
            this.PB_wave.Click += new System.EventHandler(this.PB_wave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PB_wave);
            this.Controls.Add(this.PB_doorman_mode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PB_doorman_mode;
        private System.Windows.Forms.Button PB_wave;
    }
}


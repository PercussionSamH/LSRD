namespace LSRD_hmi
{
    partial class Form_Settings
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
            this.PB_Back_To_Home = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Back_To_Home
            // 
            this.PB_Back_To_Home.BackColor = System.Drawing.Color.Transparent;
            this.PB_Back_To_Home.Image = global::LSRD_hmi.Properties.Resources.PB_gray_back_to_home2;
            this.PB_Back_To_Home.Location = new System.Drawing.Point(27, 30);
            this.PB_Back_To_Home.MaximumSize = new System.Drawing.Size(124, 80);
            this.PB_Back_To_Home.MinimumSize = new System.Drawing.Size(124, 80);
            this.PB_Back_To_Home.Name = "PB_Back_To_Home";
            this.PB_Back_To_Home.Size = new System.Drawing.Size(124, 80);
            this.PB_Back_To_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Back_To_Home.TabIndex = 12;
            this.PB_Back_To_Home.TabStop = false;
            this.PB_Back_To_Home.Click += new System.EventHandler(this.PB_Back_To_Home_Click);
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.PB_Back_To_Home);
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form_Settings";
            this.Text = "Form_Settings";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Back_To_Home;
    }
}
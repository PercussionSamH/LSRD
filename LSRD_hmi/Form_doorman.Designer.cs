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
            this.PB_Goto_Screen_Main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PB_Goto_Screen_Main
            // 
            this.PB_Goto_Screen_Main.BackColor = System.Drawing.Color.Gainsboro;
            this.PB_Goto_Screen_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Goto_Screen_Main.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PB_Goto_Screen_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PB_Goto_Screen_Main.Location = new System.Drawing.Point(42, 33);
            this.PB_Goto_Screen_Main.Margin = new System.Windows.Forms.Padding(4);
            this.PB_Goto_Screen_Main.Name = "PB_Goto_Screen_Main";
            this.PB_Goto_Screen_Main.Size = new System.Drawing.Size(158, 68);
            this.PB_Goto_Screen_Main.TabIndex = 2;
            this.PB_Goto_Screen_Main.Text = "Back";
            this.PB_Goto_Screen_Main.UseVisualStyleBackColor = false;
            this.PB_Goto_Screen_Main.Click += new System.EventHandler(this.PB_Goto_Screen_Main_Click);
            // 
            // Form_doorman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.PB_Goto_Screen_Main);
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form_doorman";
            this.Text = "Form_doorman";
            this.Load += new System.EventHandler(this.Form_doorman_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PB_Goto_Screen_Main;
    }
}
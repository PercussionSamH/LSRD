namespace LSRD_hmi.Room_popups
{
    partial class Form_door_discovery_lab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_door_discovery_lab));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PB_confirm_pass = new System.Windows.Forms.PictureBox();
            this.PB_Back_To_Home = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_confirm_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(40, 72);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(300, 151);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = " • Classroom (course number?)\n • Conference Room";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 80);
            this.label1.TabIndex = 20;
            this.label1.Text = "Discovery Lab";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_confirm_pass
            // 
            this.PB_confirm_pass.BackColor = System.Drawing.Color.Transparent;
            this.PB_confirm_pass.Image = ((System.Drawing.Image)(resources.GetObject("PB_confirm_pass.Image")));
            this.PB_confirm_pass.Location = new System.Drawing.Point(213, 239);
            this.PB_confirm_pass.Margin = new System.Windows.Forms.Padding(2);
            this.PB_confirm_pass.MaximumSize = new System.Drawing.Size(127, 63);
            this.PB_confirm_pass.MinimumSize = new System.Drawing.Size(98, 49);
            this.PB_confirm_pass.Name = "PB_confirm_pass";
            this.PB_confirm_pass.Size = new System.Drawing.Size(127, 63);
            this.PB_confirm_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_confirm_pass.TabIndex = 19;
            this.PB_confirm_pass.TabStop = false;
            // 
            // PB_Back_To_Home
            // 
            this.PB_Back_To_Home.BackColor = System.Drawing.Color.Transparent;
            this.PB_Back_To_Home.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PB_Back_To_Home.Image = ((System.Drawing.Image)(resources.GetObject("PB_Back_To_Home.Image")));
            this.PB_Back_To_Home.Location = new System.Drawing.Point(40, 239);
            this.PB_Back_To_Home.Margin = new System.Windows.Forms.Padding(2);
            this.PB_Back_To_Home.Name = "PB_Back_To_Home";
            this.PB_Back_To_Home.Size = new System.Drawing.Size(127, 63);
            this.PB_Back_To_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Back_To_Home.TabIndex = 18;
            this.PB_Back_To_Home.TabStop = false;
            this.PB_Back_To_Home.Click += new System.EventHandler(this.PB_Back_To_Home_Click);
            // 
            // Form_door_discovery_lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 326);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB_confirm_pass);
            this.Controls.Add(this.PB_Back_To_Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_door_discovery_lab";
            this.Text = "Form_door_discovery_lab";
            ((System.ComponentModel.ISupportInitialize)(this.PB_confirm_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PB_confirm_pass;
        private System.Windows.Forms.PictureBox PB_Back_To_Home;
    }
}
namespace LSRD_hmi.Room_popups
{
    partial class Form_area_up_class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_area_up_class));
            this.PB_confirm_pass = new System.Windows.Forms.PictureBox();
            this.PB_Back_To_Home = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_confirm_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_confirm_pass
            // 
            this.PB_confirm_pass.BackColor = System.Drawing.Color.Transparent;
            this.PB_confirm_pass.Image = ((System.Drawing.Image)(resources.GetObject("PB_confirm_pass.Image")));
            this.PB_confirm_pass.Location = new System.Drawing.Point(351, 326);
            this.PB_confirm_pass.MaximumSize = new System.Drawing.Size(169, 78);
            this.PB_confirm_pass.MinimumSize = new System.Drawing.Size(130, 60);
            this.PB_confirm_pass.Name = "PB_confirm_pass";
            this.PB_confirm_pass.Size = new System.Drawing.Size(169, 78);
            this.PB_confirm_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_confirm_pass.TabIndex = 15;
            this.PB_confirm_pass.TabStop = false;
            // 
            // PB_Back_To_Home
            // 
            this.PB_Back_To_Home.BackColor = System.Drawing.Color.Transparent;
            this.PB_Back_To_Home.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PB_Back_To_Home.Image = ((System.Drawing.Image)(resources.GetObject("PB_Back_To_Home.Image")));
            this.PB_Back_To_Home.Location = new System.Drawing.Point(75, 326);
            this.PB_Back_To_Home.MaximumSize = new System.Drawing.Size(169, 78);
            this.PB_Back_To_Home.MinimumSize = new System.Drawing.Size(130, 60);
            this.PB_Back_To_Home.Name = "PB_Back_To_Home";
            this.PB_Back_To_Home.Size = new System.Drawing.Size(169, 78);
            this.PB_Back_To_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Back_To_Home.TabIndex = 14;
            this.PB_Back_To_Home.TabStop = false;
            this.PB_Back_To_Home.Click += new System.EventHandler(this.PB_Back_To_Home_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 51);
            this.label1.MaximumSize = new System.Drawing.Size(445, 98);
            this.label1.MinimumSize = new System.Drawing.Size(445, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 98);
            this.label1.TabIndex = 16;
            this.label1.Text = "Upstairs Classroom\r\n(need name)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(75, 152);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(445, 135);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "This room is used for:\n- Classes\n- Example 1";
            // 
            // Form_area_up_class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB_confirm_pass);
            this.Controls.Add(this.PB_Back_To_Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_area_up_class";
            this.Text = "Form_area_upstairs_classroom";
            ((System.ComponentModel.ISupportInitialize)(this.PB_confirm_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_confirm_pass;
        private System.Windows.Forms.PictureBox PB_Back_To_Home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
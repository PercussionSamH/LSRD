namespace LSRD_hmi
{
    partial class Form_Pass_popup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pass_popup));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_entry_pass = new System.Windows.Forms.TextBox();
            this.text_wrong_pass = new System.Windows.Forms.Label();
            this.PB_confirm_pass = new System.Windows.Forms.PictureBox();
            this.PB_Back_To_Home = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PB_confirm_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter password to access\r\n staff settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // text_entry_pass
            // 
            this.text_entry_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_entry_pass.Location = new System.Drawing.Point(210, 110);
            this.text_entry_pass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_entry_pass.MaxLength = 6;
            this.text_entry_pass.Name = "text_entry_pass";
            this.text_entry_pass.PasswordChar = '*';
            this.text_entry_pass.Size = new System.Drawing.Size(140, 26);
            this.text_entry_pass.TabIndex = 2;
            this.text_entry_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_Pass_popup_KeyPress);
            // 
            // text_wrong_pass
            // 
            this.text_wrong_pass.AutoSize = true;
            this.text_wrong_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_wrong_pass.ForeColor = System.Drawing.Color.Red;
            this.text_wrong_pass.Location = new System.Drawing.Point(151, 157);
            this.text_wrong_pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text_wrong_pass.Name = "text_wrong_pass";
            this.text_wrong_pass.Size = new System.Drawing.Size(205, 17);
            this.text_wrong_pass.TabIndex = 14;
            this.text_wrong_pass.Text = "Password is incorrect, try again";
            this.text_wrong_pass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.text_wrong_pass.Visible = false;
            // 
            // PB_confirm_pass
            // 
            this.PB_confirm_pass.BackColor = System.Drawing.Color.Transparent;
            this.PB_confirm_pass.Image = ((System.Drawing.Image)(resources.GetObject("PB_confirm_pass.Image")));
            this.PB_confirm_pass.Location = new System.Drawing.Point(246, 200);
            this.PB_confirm_pass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PB_confirm_pass.MaximumSize = new System.Drawing.Size(130, 60);
            this.PB_confirm_pass.MinimumSize = new System.Drawing.Size(130, 60);
            this.PB_confirm_pass.Name = "PB_confirm_pass";
            this.PB_confirm_pass.Size = new System.Drawing.Size(130, 60);
            this.PB_confirm_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_confirm_pass.TabIndex = 13;
            this.PB_confirm_pass.TabStop = false;
            this.PB_confirm_pass.Click += new System.EventHandler(this.PB_confirm_pass_Click);
            // 
            // PB_Back_To_Home
            // 
            this.PB_Back_To_Home.BackColor = System.Drawing.Color.Transparent;
            this.PB_Back_To_Home.Image = ((System.Drawing.Image)(resources.GetObject("PB_Back_To_Home.Image")));
            this.PB_Back_To_Home.Location = new System.Drawing.Point(71, 200);
            this.PB_Back_To_Home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PB_Back_To_Home.MaximumSize = new System.Drawing.Size(130, 60);
            this.PB_Back_To_Home.MinimumSize = new System.Drawing.Size(130, 60);
            this.PB_Back_To_Home.Name = "PB_Back_To_Home";
            this.PB_Back_To_Home.Size = new System.Drawing.Size(130, 60);
            this.PB_Back_To_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Back_To_Home.TabIndex = 12;
            this.PB_Back_To_Home.TabStop = false;
            this.PB_Back_To_Home.Click += new System.EventHandler(this.PB_Back_To_Home_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.text_wrong_pass);
            this.panel1.Controls.Add(this.PB_confirm_pass);
            this.panel1.Controls.Add(this.PB_Back_To_Home);
            this.panel1.Controls.Add(this.text_entry_pass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 300);
            this.panel1.TabIndex = 15;
            // 
            // Form_Pass_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 300);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form_Pass_popup";
            this.ShowIcon = false;
            this.Text = "Settings Popup";
            ((System.ComponentModel.ISupportInitialize)(this.PB_confirm_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back_To_Home)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_entry_pass;
        private System.Windows.Forms.PictureBox PB_Back_To_Home;
        private System.Windows.Forms.PictureBox PB_confirm_pass;
        private System.Windows.Forms.Label text_wrong_pass;
        private System.Windows.Forms.Panel panel1;
    }
}
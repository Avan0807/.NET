namespace QLPhongTro
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            txtUsername = new TextBox();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            btnLogin = new Button();
            textPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(210, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(185, 159);
            label3.Name = "label3";
            label3.Size = new Size(142, 54);
            label3.TabIndex = 15;
            label3.Text = "Login";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(56, 251);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.ForeColor = SystemColors.GradientActiveCaption;
            panel1.Location = new Point(56, 293);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 2);
            panel1.TabIndex = 19;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ControlLightLight;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(98, 233);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(371, 54);
            txtUsername.TabIndex = 23;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.padlock;
            pictureBox3.Location = new Point(56, 331);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.ForeColor = SystemColors.GradientActiveCaption;
            panel2.Location = new Point(56, 373);
            panel2.Name = "panel2";
            panel2.Size = new Size(413, 2);
            panel2.TabIndex = 19;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.HotTrack;
            btnLogin.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnLogin.ForeColor = SystemColors.HighlightText;
            btnLogin.Location = new Point(56, 438);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(413, 39);
            btnLogin.TabIndex = 25;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // textPassword
            // 
            textPassword.BackColor = SystemColors.ControlLightLight;
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Cursor = Cursors.IBeam;
            textPassword.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            textPassword.Location = new Point(98, 313);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(371, 54);
            textPassword.TabIndex = 23;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(525, 558);
            Controls.Add(btnLogin);
            Controls.Add(textPassword);
            Controls.Add(panel2);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel1;
        private TextBox txtUsername;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button btnLogin;
        private TextBox textPassword;
    }
}

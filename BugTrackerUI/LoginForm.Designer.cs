namespace SupportDeskApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.helpDeskPicture = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.LoginRegisterTab = new System.Windows.Forms.TabControl();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.registerTab = new System.Windows.Forms.TabPage();
            this.usernamePicture = new System.Windows.Forms.PictureBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordPicture = new System.Windows.Forms.PictureBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.passwordRegisterTextbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.usernameRegisterTextbox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.emailRegisterTextbox = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.helpDeskPicture)).BeginInit();
            this.LoginRegisterTab.SuspendLayout();
            this.loginTab.SuspendLayout();
            this.registerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePicture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // helpDeskPicture
            // 
            this.helpDeskPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.helpDeskPicture.Image = ((System.Drawing.Image)(resources.GetObject("helpDeskPicture.Image")));
            this.helpDeskPicture.Location = new System.Drawing.Point(137, 78);
            this.helpDeskPicture.Name = "helpDeskPicture";
            this.helpDeskPicture.Size = new System.Drawing.Size(85, 85);
            this.helpDeskPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.helpDeskPicture.TabIndex = 0;
            this.helpDeskPicture.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(102, 39);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(154, 30);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Support Desk";
            // 
            // LoginRegisterTab
            // 
            this.LoginRegisterTab.Controls.Add(this.loginTab);
            this.LoginRegisterTab.Controls.Add(this.registerTab);
            this.LoginRegisterTab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginRegisterTab.HotTrack = true;
            this.LoginRegisterTab.Location = new System.Drawing.Point(0, 189);
            this.LoginRegisterTab.Name = "LoginRegisterTab";
            this.LoginRegisterTab.SelectedIndex = 0;
            this.LoginRegisterTab.Size = new System.Drawing.Size(358, 307);
            this.LoginRegisterTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.LoginRegisterTab.TabIndex = 2;
            // 
            // loginTab
            // 
            this.loginTab.Controls.Add(this.loginButton);
            this.loginTab.Controls.Add(this.panel5);
            this.loginTab.Controls.Add(this.passwordTextbox);
            this.loginTab.Controls.Add(this.passwordPicture);
            this.loginTab.Controls.Add(this.panel1);
            this.loginTab.Controls.Add(this.usernameTextBox);
            this.loginTab.Controls.Add(this.usernamePicture);
            this.loginTab.Location = new System.Drawing.Point(4, 22);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginTab.Size = new System.Drawing.Size(350, 281);
            this.loginTab.TabIndex = 0;
            this.loginTab.Text = "Login";
            this.loginTab.UseVisualStyleBackColor = true;
           
            // 
            // registerTab
            // 
            this.registerTab.Controls.Add(this.panel11);
            this.registerTab.Controls.Add(this.emailRegisterTextbox);
            this.registerTab.Controls.Add(this.pictureBox3);
            this.registerTab.Controls.Add(this.registerButton);
            this.registerTab.Controls.Add(this.panel6);
            this.registerTab.Controls.Add(this.passwordRegisterTextbox);
            this.registerTab.Controls.Add(this.pictureBox1);
            this.registerTab.Controls.Add(this.panel7);
            this.registerTab.Controls.Add(this.usernameRegisterTextbox);
            this.registerTab.Controls.Add(this.pictureBox2);
            this.registerTab.Location = new System.Drawing.Point(4, 22);
            this.registerTab.Name = "registerTab";
            this.registerTab.Padding = new System.Windows.Forms.Padding(3);
            this.registerTab.Size = new System.Drawing.Size(350, 281);
            this.registerTab.TabIndex = 1;
            this.registerTab.Text = "Register";
            this.registerTab.UseVisualStyleBackColor = true;
            // 
            // usernamePicture
            // 
            this.usernamePicture.Image = ((System.Drawing.Image)(resources.GetObject("usernamePicture.Image")));
            this.usernamePicture.Location = new System.Drawing.Point(32, 53);
            this.usernamePicture.Name = "usernamePicture";
            this.usernamePicture.Size = new System.Drawing.Size(33, 34);
            this.usernamePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usernamePicture.TabIndex = 0;
            this.usernamePicture.TabStop = false;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Arial", 16F);
            this.usernameTextBox.Location = new System.Drawing.Point(71, 61);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(216, 25);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(32, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 2);
            this.panel1.TabIndex = 2;
            // 
            // passwordPicture
            // 
            this.passwordPicture.Image = ((System.Drawing.Image)(resources.GetObject("passwordPicture.Image")));
            this.passwordPicture.Location = new System.Drawing.Point(32, 134);
            this.passwordPicture.Name = "passwordPicture";
            this.passwordPicture.Size = new System.Drawing.Size(33, 34);
            this.passwordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordPicture.TabIndex = 3;
            this.passwordPicture.TabStop = false;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextbox.Font = new System.Drawing.Font("Arial", 16F);
            this.passwordTextbox.Location = new System.Drawing.Point(71, 143);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(216, 25);
            this.passwordTextbox.TabIndex = 4;
            this.passwordTextbox.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 2);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 2);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(0, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 2);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel5.Location = new System.Drawing.Point(32, 173);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(271, 2);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel6.Location = new System.Drawing.Point(30, 137);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(271, 2);
            this.panel6.TabIndex = 11;
            // 
            // passwordRegisterTextbox
            // 
            this.passwordRegisterTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordRegisterTextbox.Font = new System.Drawing.Font("Arial", 16F);
            this.passwordRegisterTextbox.Location = new System.Drawing.Point(69, 112);
            this.passwordRegisterTextbox.Name = "passwordRegisterTextbox";
            this.passwordRegisterTextbox.Size = new System.Drawing.Size(216, 25);
            this.passwordRegisterTextbox.TabIndex = 10;
            this.passwordRegisterTextbox.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Location = new System.Drawing.Point(30, 76);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(271, 2);
            this.panel7.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(271, 2);
            this.panel8.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(0, 21);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(271, 2);
            this.panel9.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(0, 21);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(271, 2);
            this.panel10.TabIndex = 3;
            // 
            // usernameRegisterTextbox
            // 
            this.usernameRegisterTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameRegisterTextbox.Font = new System.Drawing.Font("Arial", 16F);
            this.usernameRegisterTextbox.Location = new System.Drawing.Point(69, 51);
            this.usernameRegisterTextbox.Name = "usernameRegisterTextbox";
            this.usernameRegisterTextbox.Size = new System.Drawing.Size(216, 25);
            this.usernameRegisterTextbox.TabIndex = 7;
            this.usernameRegisterTextbox.Text = "Username";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(118, 206);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(115, 49);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Location = new System.Drawing.Point(103, 219);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(115, 49);
            this.registerButton.TabIndex = 12;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Location = new System.Drawing.Point(30, 198);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(271, 2);
            this.panel11.TabIndex = 15;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(271, 2);
            this.panel12.TabIndex = 4;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Black;
            this.panel13.Location = new System.Drawing.Point(0, 21);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(271, 2);
            this.panel13.TabIndex = 3;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Black;
            this.panel14.Location = new System.Drawing.Point(0, 21);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(271, 2);
            this.panel14.TabIndex = 3;
            // 
            // emailRegisterTextbox
            // 
            this.emailRegisterTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailRegisterTextbox.Font = new System.Drawing.Font("Arial", 16F);
            this.emailRegisterTextbox.Location = new System.Drawing.Point(69, 172);
            this.emailRegisterTextbox.Name = "emailRegisterTextbox";
            this.emailRegisterTextbox.Size = new System.Drawing.Size(216, 25);
            this.emailRegisterTextbox.TabIndex = 14;
            this.emailRegisterTextbox.Text = "Email Address";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(30, 158);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 496);
            this.Controls.Add(this.LoginRegisterTab);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.helpDeskPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.helpDeskPicture)).EndInit();
            this.LoginRegisterTab.ResumeLayout(false);
            this.loginTab.ResumeLayout(false);
            this.loginTab.PerformLayout();
            this.registerTab.ResumeLayout(false);
            this.registerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox helpDeskPicture;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TabControl LoginRegisterTab;
        private System.Windows.Forms.TabPage loginTab;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.PictureBox passwordPicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.PictureBox usernamePicture;
        private System.Windows.Forms.TabPage registerTab;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox emailRegisterTextbox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox passwordRegisterTextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox usernameRegisterTextbox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
namespace SupportDeskApp
{
    partial class CreateNewProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewProjectForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.helpDeskPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.projectTitleTextBox = new System.Windows.Forms.TextBox();
            this.adminCombo = new System.Windows.Forms.ComboBox();
            this.currentAdminsListbox = new System.Windows.Forms.ListBox();
            this.selectAdminButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.currentUsers = new System.Windows.Forms.ListBox();
            this.selectUserCombo = new System.Windows.Forms.ComboBox();
            this.createProjectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.helpDeskPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(131, 22);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(154, 30);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Support Desk";
            // 
            // helpDeskPicture
            // 
            this.helpDeskPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.helpDeskPicture.Image = ((System.Drawing.Image)(resources.GetObject("helpDeskPicture.Image")));
            this.helpDeskPicture.Location = new System.Drawing.Point(166, 61);
            this.helpDeskPicture.Name = "helpDeskPicture";
            this.helpDeskPicture.Size = new System.Drawing.Size(85, 85);
            this.helpDeskPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.helpDeskPicture.TabIndex = 2;
            this.helpDeskPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(119, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Create a Project";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(75, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 2);
            this.panel1.TabIndex = 8;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 2);
            this.panel2.TabIndex = 3;
            // 
            // projectTitleTextBox
            // 
            this.projectTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectTitleTextBox.Font = new System.Drawing.Font("Arial", 16F);
            this.projectTitleTextBox.Location = new System.Drawing.Point(75, 207);
            this.projectTitleTextBox.Name = "projectTitleTextBox";
            this.projectTitleTextBox.Size = new System.Drawing.Size(271, 25);
            this.projectTitleTextBox.TabIndex = 7;
            this.projectTitleTextBox.Text = "Project Title";
            // 
            // adminCombo
            // 
            this.adminCombo.FormattingEnabled = true;
            this.adminCombo.Location = new System.Drawing.Point(27, 259);
            this.adminCombo.Name = "adminCombo";
            this.adminCombo.Size = new System.Drawing.Size(171, 21);
            this.adminCombo.TabIndex = 9;
            this.adminCombo.Text = "Select Admins";
            // 
            // currentAdminsListbox
            // 
            this.currentAdminsListbox.FormattingEnabled = true;
            this.currentAdminsListbox.Location = new System.Drawing.Point(223, 259);
            this.currentAdminsListbox.Name = "currentAdminsListbox";
            this.currentAdminsListbox.Size = new System.Drawing.Size(170, 108);
            this.currentAdminsListbox.TabIndex = 10;
            // 
            // selectAdminButton
            // 
            this.selectAdminButton.BackColor = System.Drawing.Color.Transparent;
            this.selectAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectAdminButton.Location = new System.Drawing.Point(50, 300);
            this.selectAdminButton.Name = "selectAdminButton";
            this.selectAdminButton.Size = new System.Drawing.Size(115, 49);
            this.selectAdminButton.TabIndex = 11;
            this.selectAdminButton.Text = "Add";
            this.selectAdminButton.UseVisualStyleBackColor = false;
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.Transparent;
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.Location = new System.Drawing.Point(50, 414);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(115, 49);
            this.addUserButton.TabIndex = 14;
            this.addUserButton.Text = "Add";
            this.addUserButton.UseVisualStyleBackColor = false;
            // 
            // currentUsers
            // 
            this.currentUsers.FormattingEnabled = true;
            this.currentUsers.Location = new System.Drawing.Point(223, 373);
            this.currentUsers.Name = "currentUsers";
            this.currentUsers.Size = new System.Drawing.Size(170, 108);
            this.currentUsers.TabIndex = 13;
            // 
            // selectUserCombo
            // 
            this.selectUserCombo.FormattingEnabled = true;
            this.selectUserCombo.Location = new System.Drawing.Point(27, 373);
            this.selectUserCombo.Name = "selectUserCombo";
            this.selectUserCombo.Size = new System.Drawing.Size(171, 21);
            this.selectUserCombo.TabIndex = 12;
            this.selectUserCombo.Text = "Select Users";
            // 
            // createProjectButton
            // 
            this.createProjectButton.BackColor = System.Drawing.Color.Transparent;
            this.createProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createProjectButton.Location = new System.Drawing.Point(151, 487);
            this.createProjectButton.Name = "createProjectButton";
            this.createProjectButton.Size = new System.Drawing.Size(115, 49);
            this.createProjectButton.TabIndex = 15;
            this.createProjectButton.Text = "Create Project";
            this.createProjectButton.UseVisualStyleBackColor = false;
            // 
            // CreateNewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 548);
            this.Controls.Add(this.createProjectButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.currentUsers);
            this.Controls.Add(this.selectUserCombo);
            this.Controls.Add(this.selectAdminButton);
            this.Controls.Add(this.currentAdminsListbox);
            this.Controls.Add(this.adminCombo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.projectTitleTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.helpDeskPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateNewProjectForm";
            this.Text = "CreateNewProject";
            ((System.ComponentModel.ISupportInitialize)(this.helpDeskPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox helpDeskPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox projectTitleTextBox;
        private System.Windows.Forms.ComboBox adminCombo;
        private System.Windows.Forms.ListBox currentAdminsListbox;
        private System.Windows.Forms.Button selectAdminButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.ListBox currentUsers;
        private System.Windows.Forms.ComboBox selectUserCombo;
        private System.Windows.Forms.Button createProjectButton;
    }
}
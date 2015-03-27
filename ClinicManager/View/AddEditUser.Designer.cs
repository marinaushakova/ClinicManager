namespace ClinicManager.View
{
    partial class AddEditUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.usrnameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.newPasswordLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // usrnameTxtBox
            // 
            this.usrnameTxtBox.Location = new System.Drawing.Point(128, 53);
            this.usrnameTxtBox.Name = "usrnameTxtBox";
            this.usrnameTxtBox.Size = new System.Drawing.Size(206, 21);
            this.usrnameTxtBox.TabIndex = 1;
            this.usrnameTxtBox.Tag = "Username";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(51, 95);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(71, 16);
            this.passwordLbl.TabIndex = 5;
            this.passwordLbl.Text = "Password:";
            this.passwordLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(128, 92);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(206, 21);
            this.passwordTxtBox.TabIndex = 2;
            this.passwordTxtBox.Tag = "Password";
            this.passwordTxtBox.UseSystemPasswordChar = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(302, 180);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(203, 180);
            this.okBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.errorLbl.Location = new System.Drawing.Point(0, 0);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(389, 16);
            this.errorLbl.TabIndex = 6;
            this.errorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newPasswordLbl
            // 
            this.newPasswordLbl.AutoSize = true;
            this.newPasswordLbl.Location = new System.Drawing.Point(21, 95);
            this.newPasswordLbl.Name = "newPasswordLbl";
            this.newPasswordLbl.Size = new System.Drawing.Size(101, 16);
            this.newPasswordLbl.TabIndex = 7;
            this.newPasswordLbl.Text = "New Password:";
            this.newPasswordLbl.Visible = false;
            // 
            // AddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(389, 215);
            this.Controls.Add(this.newPasswordLbl);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usrnameTxtBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddEditUser";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.AddEditUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usrnameTxtBox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Label newPasswordLbl;
    }
}
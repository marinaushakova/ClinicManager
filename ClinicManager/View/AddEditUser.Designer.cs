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
            this.personTxtBox = new System.Windows.Forms.TextBox();
            this.personLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usrnameTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmationTxtBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personTxtBox
            // 
            this.personTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.personTxtBox.Enabled = false;
            this.personTxtBox.Location = new System.Drawing.Point(162, 26);
            this.personTxtBox.Name = "personTxtBox";
            this.personTxtBox.Size = new System.Drawing.Size(206, 21);
            this.personTxtBox.TabIndex = 50;
            // 
            // personLbl
            // 
            this.personLbl.AutoSize = true;
            this.personLbl.Location = new System.Drawing.Point(105, 29);
            this.personLbl.Name = "personLbl";
            this.personLbl.Size = new System.Drawing.Size(54, 16);
            this.personLbl.TabIndex = 1;
            this.personLbl.Text = "Person:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // usrnameTxtBox
            // 
            this.usrnameTxtBox.Location = new System.Drawing.Point(162, 79);
            this.usrnameTxtBox.Name = "usrnameTxtBox";
            this.usrnameTxtBox.Size = new System.Drawing.Size(206, 21);
            this.usrnameTxtBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(162, 106);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(206, 21);
            this.passwordTxtBox.TabIndex = 2;
            this.passwordTxtBox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password Confirmation:";
            // 
            // confirmationTxtBox
            // 
            this.confirmationTxtBox.Location = new System.Drawing.Point(162, 135);
            this.confirmationTxtBox.Name = "confirmationTxtBox";
            this.confirmationTxtBox.Size = new System.Drawing.Size(206, 21);
            this.confirmationTxtBox.TabIndex = 3;
            this.confirmationTxtBox.UseSystemPasswordChar = true;
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
            // 
            // AddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 215);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confirmationTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usrnameTxtBox);
            this.Controls.Add(this.personLbl);
            this.Controls.Add(this.personTxtBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddEditUser";
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox personTxtBox;
        private System.Windows.Forms.Label personLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usrnameTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmationTxtBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
    }
}
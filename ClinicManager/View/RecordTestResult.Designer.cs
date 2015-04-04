namespace ClinicManager.View
{
    partial class RecordTestResult
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
            this.rbtnPositive = new System.Windows.Forms.RadioButton();
            this.rbtnNegative = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datDateTested = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // rbtnPositive
            // 
            this.rbtnPositive.AutoSize = true;
            this.rbtnPositive.Checked = true;
            this.rbtnPositive.Location = new System.Drawing.Point(76, 76);
            this.rbtnPositive.Name = "rbtnPositive";
            this.rbtnPositive.Size = new System.Drawing.Size(74, 20);
            this.rbtnPositive.TabIndex = 0;
            this.rbtnPositive.TabStop = true;
            this.rbtnPositive.Text = "Positive";
            this.rbtnPositive.UseVisualStyleBackColor = true;
            // 
            // rbtnNegative
            // 
            this.rbtnNegative.AutoSize = true;
            this.rbtnNegative.Location = new System.Drawing.Point(199, 76);
            this.rbtnNegative.Name = "rbtnNegative";
            this.rbtnNegative.Size = new System.Drawing.Size(81, 20);
            this.rbtnNegative.TabIndex = 1;
            this.rbtnNegative.Text = "Negative";
            this.rbtnNegative.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(183, 124);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 30);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(264, 124);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date Tested:";
            // 
            // datDateTested
            // 
            this.datDateTested.Location = new System.Drawing.Point(116, 27);
            this.datDateTested.Name = "datDateTested";
            this.datDateTested.Size = new System.Drawing.Size(223, 21);
            this.datDateTested.TabIndex = 5;
            // 
            // RecordTestResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 174);
            this.Controls.Add(this.datDateTested);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rbtnNegative);
            this.Controls.Add(this.rbtnPositive);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RecordTestResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Record Test Result";
            this.Load += new System.EventHandler(this.RecordTestResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnPositive;
        private System.Windows.Forms.RadioButton rbtnNegative;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datDateTested;
    }
}
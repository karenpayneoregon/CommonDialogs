namespace WindowsFormsDialogsSamples
{
    partial class Form1
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
            this.cmdStandardQuestionDialog = new System.Windows.Forms.Button();
            this.cmdInformationDialog = new System.Windows.Forms.Button();
            this.cmdMessageDialog = new System.Windows.Forms.Button();
            this.cmdExceptionDialog = new System.Windows.Forms.Button();
            this.cmdApplicationExceptionDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdStandardQuestionDialog
            // 
            this.cmdStandardQuestionDialog.Location = new System.Drawing.Point(12, 12);
            this.cmdStandardQuestionDialog.Name = "cmdStandardQuestionDialog";
            this.cmdStandardQuestionDialog.Size = new System.Drawing.Size(194, 23);
            this.cmdStandardQuestionDialog.TabIndex = 0;
            this.cmdStandardQuestionDialog.Text = "Standard question dialog";
            this.cmdStandardQuestionDialog.UseVisualStyleBackColor = true;
            this.cmdStandardQuestionDialog.Click += new System.EventHandler(this.cmdStandardQuestionDialog_Click);
            // 
            // cmdInformationDialog
            // 
            this.cmdInformationDialog.Location = new System.Drawing.Point(12, 41);
            this.cmdInformationDialog.Name = "cmdInformationDialog";
            this.cmdInformationDialog.Size = new System.Drawing.Size(194, 23);
            this.cmdInformationDialog.TabIndex = 1;
            this.cmdInformationDialog.Text = "Information dialog";
            this.cmdInformationDialog.UseVisualStyleBackColor = true;
            this.cmdInformationDialog.Click += new System.EventHandler(this.cmdInformationDialog_Click);
            // 
            // cmdMessageDialog
            // 
            this.cmdMessageDialog.Location = new System.Drawing.Point(12, 70);
            this.cmdMessageDialog.Name = "cmdMessageDialog";
            this.cmdMessageDialog.Size = new System.Drawing.Size(194, 23);
            this.cmdMessageDialog.TabIndex = 2;
            this.cmdMessageDialog.Text = "MessageBox/Alert";
            this.cmdMessageDialog.UseVisualStyleBackColor = true;
            this.cmdMessageDialog.Click += new System.EventHandler(this.cmdMessageDialog_Click);
            // 
            // cmdExceptionDialog
            // 
            this.cmdExceptionDialog.Location = new System.Drawing.Point(12, 99);
            this.cmdExceptionDialog.Name = "cmdExceptionDialog";
            this.cmdExceptionDialog.Size = new System.Drawing.Size(194, 23);
            this.cmdExceptionDialog.TabIndex = 3;
            this.cmdExceptionDialog.Text = "Exception dialog";
            this.cmdExceptionDialog.UseVisualStyleBackColor = true;
            this.cmdExceptionDialog.Click += new System.EventHandler(this.cmdExceptionDialog_Click);
            // 
            // cmdApplicationExceptionDialog
            // 
            this.cmdApplicationExceptionDialog.Location = new System.Drawing.Point(12, 125);
            this.cmdApplicationExceptionDialog.Name = "cmdApplicationExceptionDialog";
            this.cmdApplicationExceptionDialog.Size = new System.Drawing.Size(194, 23);
            this.cmdApplicationExceptionDialog.TabIndex = 4;
            this.cmdApplicationExceptionDialog.Text = "Application Exception dialog";
            this.cmdApplicationExceptionDialog.UseVisualStyleBackColor = true;
            this.cmdApplicationExceptionDialog.Click += new System.EventHandler(this.cmdApplicationExceptionDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 160);
            this.Controls.Add(this.cmdApplicationExceptionDialog);
            this.Controls.Add(this.cmdExceptionDialog);
            this.Controls.Add(this.cmdMessageDialog);
            this.Controls.Add(this.cmdInformationDialog);
            this.Controls.Add(this.cmdStandardQuestionDialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog code sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdStandardQuestionDialog;
        private System.Windows.Forms.Button cmdInformationDialog;
        private System.Windows.Forms.Button cmdMessageDialog;
        private System.Windows.Forms.Button cmdExceptionDialog;
        private System.Windows.Forms.Button cmdApplicationExceptionDialog;
    }
}


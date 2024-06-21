namespace SlidelyFormApp
{
    partial class MainForm
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
            this.btnViewSubmissions = new System.Windows.Forms.Button();
            this.btnCreateNewSubmission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewSubmissions
            // 
            this.btnViewSubmissions.Location = new System.Drawing.Point(34, 31);
            this.btnViewSubmissions.Name = "btnViewSubmissions";
            this.btnViewSubmissions.Size = new System.Drawing.Size(130, 58);
            this.btnViewSubmissions.TabIndex = 0;
            this.btnViewSubmissions.Text = "View Submissions";
            this.btnViewSubmissions.UseVisualStyleBackColor = true;
            // 
            // btnCreateNewSubmission
            // 
            this.btnCreateNewSubmission.Location = new System.Drawing.Point(426, 31);
            this.btnCreateNewSubmission.Name = "btnCreateNewSubmission";
            this.btnCreateNewSubmission.Size = new System.Drawing.Size(134, 57);
            this.btnCreateNewSubmission.TabIndex = 1;
            this.btnCreateNewSubmission.Text = "Create New Submission";
            this.btnCreateNewSubmission.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 321);
            this.Controls.Add(this.btnCreateNewSubmission);
            this.Controls.Add(this.btnViewSubmissions);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewSubmissions;
        private System.Windows.Forms.Button btnCreateNewSubmission;
    }
}


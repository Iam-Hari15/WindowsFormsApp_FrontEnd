using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace SlidelyFormApp
{
    public partial class CreateSubmissionForm : Form
    {
        private Timer stopwatchTimer;
        private TimeSpan elapsedTime;

        public CreateSubmissionForm()
        {
            InitializeComponent();

            // Ensure the form receives key events
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(CreateSubmissionForm_KeyDown);

            stopwatchTimer = new Timer();
            stopwatchTimer.Interval = 1000;  // 1 second interval
            stopwatchTimer.Tick += StopwatchTimer_Tick;

            // Initialize placeholder text
            SetPlaceholderText(txtName, "Name");
            SetPlaceholderText(txtEmail, "Email");
            SetPlaceholderText(txtPhone, "Phone Number");
            SetPlaceholderText(txtGithubLink, "GitHub Repo Link");

            // Attach Enter and Leave events
            txtName.Enter += (s, e) => RemovePlaceholderText(txtName, "Name");
            txtName.Leave += (s, e) => SetPlaceholderText(txtName, "Name");

            txtEmail.Enter += (s, e) => RemovePlaceholderText(txtEmail, "Email");
            txtEmail.Leave += (s, e) => SetPlaceholderText(txtEmail, "Email");

            txtPhone.Enter += (s, e) => RemovePlaceholderText(txtPhone, "Phone Number");
            txtPhone.Leave += (s, e) => SetPlaceholderText(txtPhone, "Phone Number");

            txtGithubLink.Enter += (s, e) => RemovePlaceholderText(txtGithubLink, "GitHub Repo Link");
            txtGithubLink.Leave += (s, e) => SetPlaceholderText(txtGithubLink, "GitHub Repo Link");
        }

        private void SetPlaceholderText(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholderText(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = Color.Black;
            }
        }

        private void CreateSubmissionForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnSubmit.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.T)
            {
                btnToggleStopwatch.PerformClick();
            }
        }

        private void btnToggleStopwatch_Click(object sender, EventArgs e)
        {
            if (stopwatchTimer.Enabled)
            {
                stopwatchTimer.Stop();
            }
            else
            {
                stopwatchTimer.Start();
            }
        }

        private void StopwatchTimer_Tick(object sender, EventArgs e)
        {
            elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));
            lblStopwatch.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            var submission = new
            {
                name = txtName.Text,
                email = txtEmail.Text,
                phone = txtPhone.Text,
                github_link = txtGithubLink.Text,
                stopwatch_time = lblStopwatch.Text
            };

            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(submission);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("http://localhost:3000/submit", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Submission successful");
                }
                else
                {
                    MessageBox.Show("Submission failed");
                }
            }
        }

        private void InitializeComponent()
        {
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnToggleStopwatch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtGithubLink = new System.Windows.Forms.TextBox();
            this.lblStopwatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(150, 200);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnToggleStopwatch
            // 
            this.btnToggleStopwatch.Location = new System.Drawing.Point(150, 150);
            this.btnToggleStopwatch.Name = "btnToggleStopwatch";
            this.btnToggleStopwatch.Size = new System.Drawing.Size(100, 23);
            this.btnToggleStopwatch.TabIndex = 1;
            this.btnToggleStopwatch.Text = "Toggle Stopwatch";
            this.btnToggleStopwatch.UseVisualStyleBackColor = true;
            this.btnToggleStopwatch.Click += new System.EventHandler(this.btnToggleStopwatch_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 50);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(150, 80);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // txtGithubLink
            // 
            this.txtGithubLink.Location = new System.Drawing.Point(150, 110);
            this.txtGithubLink.Name = "txtGithubLink";
            this.txtGithubLink.Size = new System.Drawing.Size(100, 20);
            this.txtGithubLink.TabIndex = 5;
            // 
            // lblStopwatch
            // 
            this.lblStopwatch.AutoSize = true;
            this.lblStopwatch.Location = new System.Drawing.Point(150, 180);
            this.lblStopwatch.Name = "lblStopwatch";
            this.lblStopwatch.Size = new System.Drawing.Size(49, 13);
            this.lblStopwatch.TabIndex = 6;
            this.lblStopwatch.Text = "00:00:00";
            // 
            // CreateSubmissionForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblStopwatch);
            this.Controls.Add(this.txtGithubLink);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnToggleStopwatch);
            this.Controls.Add(this.btnSubmit);
            this.Name = "CreateSubmissionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnToggleStopwatch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtGithubLink;
        private System.Windows.Forms.Label lblStopwatch;
    }
}

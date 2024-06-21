using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidelyFormApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Ensure the form receives key events
            this.KeyPreview = true;

            // Attach the KeyDown event handler
            this.KeyDown += new KeyEventHandler(MainForm_KeyDown);
        }

        // KeyDown event handler method
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                btnViewSubmissions.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                btnCreateNewSubmission.PerformClick();
            }
        }

        // Method to handle View Submissions button click
        private void btnViewSubmissions_Click(object sender, EventArgs e)
        {
            ViewSubmissionsForm viewForm = new ViewSubmissionsForm();
            viewForm.Show();
        }

        // Method to handle Create New Submission button click
        private void btnCreateNewSubmission_Click(object sender, EventArgs e)
        {
            CreateSubmissionForm createForm = new CreateSubmissionForm();
            createForm.Show();
        }
    }
}

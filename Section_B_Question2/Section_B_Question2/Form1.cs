
    using System;
    using System.Windows.Forms;
    using System.Xml.Linq;

namespace Section_B_Question2
{
    public partial class Form1 : Form
    {
        // Keep a reference to the profile so we can generate the summary later
        private CitizenProfile currentProfile;
        private string validationResult = "";

        public Form1()
        {
            InitializeComponent();
            // Populate ComboBox
            cmbCitizenship.Items.AddRange(new string[] { "Citizen", "Permanent Resident", "Visitor" });
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Basic check: Ensure fields aren't empty
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtIDNumber.Text))
                {
                    lblResults.Text = "Error: Please fill in all fields.";
                    return;
                }

                // 2. Create the profile
                // This is where the error triggers if the ID is invalid
                currentProfile = new CitizenProfile(txtName.Text, txtIDNumber.Text, cmbCitizenship.Text);

                // 3. If code gets here, it worked!
                lblResults.Text = $"Valid ID. User is {currentProfile.Age} years old.";
            }
            catch (ArgumentException ex)
            {
                // This catches the "Invalid birth date" error specifically
                lblResults.Text = "Error: " + ex.Message;
            }
            catch (Exception ex)
            {
                // This catches any other unexpected errors
                lblResults.Text = "Error: Invalid ID or format.";
            }
        }
        private void btnGenerateProfile_Click(object sender, EventArgs e)
        {
            if (currentProfile == null)
            {
                MessageBox.Show("Please validate the ID first.");
                return;
            }

            // Format output summary
            string summary = $"==== DIGITAL CITIZEN SUMMARY ====\n" +
                             $"Name: {currentProfile.FullName}\n" +
                             $"ID Number: {currentProfile.IDNumber}\n" +
                             $"Age: {currentProfile.Age}\n" +
                             $"Citizenship: {currentProfile.CitizenshipStatus}\n" +
                             $"Validation: {validationResult}\n" +
                             $"Processed at: Home Affairs Digital Desk\n" +
                             $"Timestamp: {DateTime.Now:yyyy/MM/dd HH:mm:ss}";

            txtOutput.Text = summary;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblPromptID_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
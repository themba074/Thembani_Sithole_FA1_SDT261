
using System;
using System.Windows.Forms;

namespace FA1_Question_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Logic for the Add Language button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input = txtLanguageInput.Text.Trim();

            // Prevent empty input
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter a programming language.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prevent duplicate languages
            if (lstLanguages.Items.Contains(input))
            {
                MessageBox.Show("This language is already in the list.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add the language
            lstLanguages.Items.Add(input);
            txtLanguageInput.Clear();
            txtLanguageInput.Focus();
        }

        // Logic for the Remove button
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (lstLanguages.SelectedIndex != -1)
            {
                string removedLanguage = lstLanguages.SelectedItem.ToString();

                // Get the current date and time
                string timestamp = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");

                // Display the removal message
                lblStatus.Text = $"Removed '{removedLanguage}' at {timestamp}";

                // Remove the item
                lstLanguages.Items.RemoveAt(lstLanguages.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a language to remove.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
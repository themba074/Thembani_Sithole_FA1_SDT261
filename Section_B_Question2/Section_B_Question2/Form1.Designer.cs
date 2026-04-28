namespace Section_B_Question2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblPromptName = new Label();
            txtName = new TextBox();
            lblPromptID = new Label();
            txtIDNumber = new TextBox();
            lblPromptCitizen = new Label();
            cmbCitizenship = new ComboBox();
            btnValidate = new Button();
            lblResults = new Label();
            txtOutput = new TextBox();
            btnGenerate = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblPromptName
            // 
            lblPromptName.AutoSize = true;
            lblPromptName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPromptName.Location = new Point(398, 58);
            lblPromptName.Name = "lblPromptName";
            lblPromptName.Size = new Size(104, 15);
            lblPromptName.TabIndex = 0;
            lblPromptName.Text = "Enter your Name:";
            lblPromptName.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(532, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(211, 23);
            txtName.TabIndex = 1;
            // 
            // lblPromptID
            // 
            lblPromptID.AutoSize = true;
            lblPromptID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPromptID.Location = new Point(398, 115);
            lblPromptID.Name = "lblPromptID";
            lblPromptID.Size = new Size(84, 15);
            lblPromptID.TabIndex = 0;
            lblPromptID.Text = "Enter your ID:";
            lblPromptID.Click += lblPromptID_Click;
            // 
            // txtIDNumber
            // 
            txtIDNumber.Location = new Point(532, 115);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(211, 23);
            txtIDNumber.TabIndex = 2;
            // 
            // lblPromptCitizen
            // 
            lblPromptCitizen.AutoSize = true;
            lblPromptCitizen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPromptCitizen.Location = new Point(398, 172);
            lblPromptCitizen.Name = "lblPromptCitizen";
            lblPromptCitizen.Size = new Size(119, 15);
            lblPromptCitizen.TabIndex = 0;
            lblPromptCitizen.Text = "Choose your Citizen:";
            // 
            // cmbCitizenship
            // 
            cmbCitizenship.FormattingEnabled = true;
            cmbCitizenship.Location = new Point(532, 169);
            cmbCitizenship.Name = "cmbCitizenship";
            cmbCitizenship.Size = new Size(211, 23);
            cmbCitizenship.TabIndex = 3;
            // 
            // btnValidate
            // 
            btnValidate.BackColor = Color.Green;
            btnValidate.Location = new Point(605, 229);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(75, 23);
            btnValidate.TabIndex = 4;
            btnValidate.Text = "Validate ID";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(532, 287);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(38, 15);
            lblResults.TabIndex = 5;
            lblResults.Text = "label4";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(532, 305);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(259, 130);
            txtOutput.TabIndex = 6;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Green;
            btnGenerate.Location = new Point(569, 453);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(146, 23);
            btnGenerate.TabIndex = 7;
            btnGenerate.Text = "Generate profile";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerateProfile_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(387, 562);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(416, 9);
            label1.Name = "label1";
            label1.Size = new Size(385, 28);
            label1.TabIndex = 11;
            label1.Text = "Home Affairs Digital Identity Processor";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(905, 621);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnGenerate);
            Controls.Add(txtOutput);
            Controls.Add(lblResults);
            Controls.Add(btnValidate);
            Controls.Add(cmbCitizenship);
            Controls.Add(lblPromptCitizen);
            Controls.Add(txtIDNumber);
            Controls.Add(lblPromptID);
            Controls.Add(txtName);
            Controls.Add(lblPromptName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPromptName;
        private TextBox txtName;
        private Label lblPromptID;
        private TextBox txtIDNumber;
        private Label lblPromptCitizen;
        private ComboBox cmbCitizenship;
        private Button btnValidate;
        private Label lblResults;
        private TextBox txtOutput;
        private Button btnGenerate;
        private PictureBox pictureBox1;
        private Label label1;
    }
}

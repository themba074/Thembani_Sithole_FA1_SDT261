namespace FA1_Question_3
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
            components = new System.ComponentModel.Container();
            lstLanguages = new ListBox();
            txtLanguageInput = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lblStatus = new Label();
            panel1 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lstLanguages
            // 
            lstLanguages.FormattingEnabled = true;
            lstLanguages.Location = new Point(28, 39);
            lstLanguages.Name = "lstLanguages";
            lstLanguages.Size = new Size(379, 184);
            lstLanguages.TabIndex = 0;
            // 
            // txtLanguageInput
            // 
            txtLanguageInput.Location = new Point(28, 229);
            txtLanguageInput.Name = "txtLanguageInput";
            txtLanguageInput.PlaceholderText = "Enter programming language";
            txtLanguageInput.Size = new Size(379, 23);
            txtLanguageInput.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Highlight;
            btnAdd.Location = new Point(28, 258);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Language";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.Location = new Point(151, 258);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(80, 23);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(28, 314);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(19, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "    ";
            lblStatus.Click += lblStatus_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lstLanguages);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(txtLanguageInput);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(117, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 366);
            panel1.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(98, 8);
            label1.Name = "label1";
            label1.Size = new Size(296, 28);
            label1.TabIndex = 5;
            label1.Text = "My Favorite coding languages";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "My favorite coding languages";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstLanguages;
        private TextBox txtLanguageInput;
        private Button btnAdd;
        private Button btnRemove;
        private Label lblStatus;
        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
    }
}

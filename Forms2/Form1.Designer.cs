namespace AddressBookApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private Button buttonSave;
        private ListBox listBoxEntries;
        private Label labelName;
        private Label labelEmail;
        private Label labelPhone;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            buttonSave = new Button();
            listBoxEntries = new ListBox();
            labelName = new Label();
            labelEmail = new Label();
            labelPhone = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(96, 28);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(140, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(96, 66);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(140, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(96, 103);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(140, 23);
            textBoxPhone.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(96, 141);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(140, 28);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // listBoxEntries
            // 
            listBoxEntries.FormattingEnabled = true;
            listBoxEntries.ItemHeight = 15;
            listBoxEntries.Location = new Point(18, 188);
            listBoxEntries.Size = new Size(219, 94);
            listBoxEntries.TabIndex = 4;
            listBoxEntries.SelectedIndexChanged += listBoxEntries_SelectedIndexChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(18, 28);
            labelName.Name = "labelName";
            labelName.Size = new Size(42, 15);
            labelName.TabIndex = 5;
            labelName.Text = "Name:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(18, 66);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(18, 103);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(44, 15);
            labelPhone.TabIndex = 7;
            labelPhone.Text = "Phone:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 328);
            Controls.Add(labelPhone);
            Controls.Add(labelEmail);
            Controls.Add(labelName);
            Controls.Add(listBoxEntries);
            Controls.Add(buttonSave);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Name = "Form1";
            Text = "Address Book";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

namespace AddressBookApp
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
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            Name = new Label();
            Email = new Label();
            label1 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(253, 241);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(368, 31);
            txtPhone.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(253, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(368, 31);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += textBox2_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(253, 102);
            txtName.Name = "txtName";
            txtName.Size = new Size(368, 31);
            txtName.TabIndex = 2;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name.ForeColor = SystemColors.Info;
            Name.Location = new Point(253, 67);
            Name.Name = "Name";
            Name.Size = new Size(81, 32);
            Name.TabIndex = 3;
            Name.Text = "Name";
            Name.Click += Name_Click;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Email.ForeColor = SystemColors.Info;
            Email.Location = new Point(253, 137);
            Email.Name = "Email";
            Email.Size = new Size(76, 32);
            Email.TabIndex = 4;
            Email.Text = "Email";
            Email.Click += Email_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(253, 206);
            label1.Name = "label1";
            label1.Size = new Size(187, 32);
            label1.TabIndex = 5;
            label1.Text = "Phone Number";
            label1.Click += label1_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 128, 0);
            btnSave.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Transparent;
            btnSave.Location = new Point(503, 296);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 52);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(Email);
            Controls.Add(Name);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtName;
        private Label Name;
        private Label Email;
        private Label label1;
        private Button btnSave;
    }
}

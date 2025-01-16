namespace Library_Management_System.View
{
    partial class MemberView
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
            name = new ReaLTaiizor.Controls.BigTextBox();
            email = new ReaLTaiizor.Controls.BigTextBox();
            mobileNumber = new ReaLTaiizor.Controls.BigTextBox();
            chatButtonRight1 = new ReaLTaiizor.Controls.ChatButtonRight();
            SuspendLayout();
            // 
            // name
            // 
            name.BackColor = Color.Transparent;
            name.Font = new Font("Tahoma", 11F);
            name.ForeColor = Color.DimGray;
            name.Image = null;
            name.Location = new Point(270, 109);
            name.MaxLength = 32767;
            name.Multiline = false;
            name.Name = "name";
            name.ReadOnly = false;
            name.Size = new Size(293, 41);
            name.TabIndex = 5;
            name.Text = "Name";
            name.TextAlignment = HorizontalAlignment.Left;
            name.UseSystemPasswordChar = false;
            // 
            // email
            // 
            email.BackColor = Color.Transparent;
            email.Font = new Font("Tahoma", 11F);
            email.ForeColor = Color.DimGray;
            email.Image = null;
            email.Location = new Point(270, 174);
            email.MaxLength = 32767;
            email.Multiline = false;
            email.Name = "email";
            email.ReadOnly = false;
            email.Size = new Size(293, 41);
            email.TabIndex = 6;
            email.Text = "Email";
            email.TextAlignment = HorizontalAlignment.Left;
            email.UseSystemPasswordChar = false;
            // 
            // mobileNumber
            // 
            mobileNumber.BackColor = Color.Transparent;
            mobileNumber.Font = new Font("Tahoma", 11F);
            mobileNumber.ForeColor = Color.DimGray;
            mobileNumber.Image = null;
            mobileNumber.Location = new Point(270, 240);
            mobileNumber.MaxLength = 32767;
            mobileNumber.Multiline = false;
            mobileNumber.Name = "mobileNumber";
            mobileNumber.ReadOnly = false;
            mobileNumber.Size = new Size(293, 41);
            mobileNumber.TabIndex = 7;
            mobileNumber.Text = "Mobile Number";
            mobileNumber.TextAlignment = HorizontalAlignment.Left;
            mobileNumber.UseSystemPasswordChar = false;
            // 
            // chatButtonRight1
            // 
            chatButtonRight1.BackColor = Color.Transparent;
            chatButtonRight1.Font = new Font("Segoe UI", 12F);
            chatButtonRight1.ForeColor = Color.FromArgb(234, 234, 234);
            chatButtonRight1.Image = null;
            chatButtonRight1.ImageAlign = ContentAlignment.MiddleLeft;
            chatButtonRight1.InactiveColorA = Color.FromArgb(0, 176, 231);
            chatButtonRight1.InactiveColorB = Color.FromArgb(0, 152, 224);
            chatButtonRight1.Location = new Point(327, 328);
            chatButtonRight1.Name = "chatButtonRight1";
            chatButtonRight1.PressedColorA = Color.FromArgb(0, 118, 176);
            chatButtonRight1.PressedColorB = Color.FromArgb(0, 149, 222);
            chatButtonRight1.PressedContourColorA = Color.FromArgb(0, 118, 176);
            chatButtonRight1.PressedContourColorB = Color.FromArgb(0, 118, 176);
            chatButtonRight1.Size = new Size(166, 40);
            chatButtonRight1.TabIndex = 8;
            chatButtonRight1.Text = "Add Member";
            chatButtonRight1.TextAlignment = StringAlignment.Center;
            chatButtonRight1.Click += chatButtonRight1_Click;
            // 
            // MemberView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 475);
            Controls.Add(chatButtonRight1);
            Controls.Add(mobileNumber);
            Controls.Add(email);
            Controls.Add(name);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MemberView";
            Text = "MemberView";
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.BigTextBox name;
        private ReaLTaiizor.Controls.BigTextBox email;
        private ReaLTaiizor.Controls.BigTextBox mobileNumber;
        private ReaLTaiizor.Controls.ChatButtonRight chatButtonRight1;
    }
}
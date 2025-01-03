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
            name = new TextBox();
            email = new TextBox();
            mobileNumber = new TextBox();
            password = new TextBox();
            register = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.Location = new Point(225, 128);
            name.Name = "name";
            name.Size = new Size(291, 23);
            name.TabIndex = 0;
            // 
            // email
            // 
            email.Location = new Point(225, 189);
            email.Name = "email";
            email.Size = new Size(291, 23);
            email.TabIndex = 1;
            // 
            // mobileNumber
            // 
            mobileNumber.Location = new Point(225, 237);
            mobileNumber.Name = "mobileNumber";
            mobileNumber.Size = new Size(291, 23);
            mobileNumber.TabIndex = 2;
            // 
            // password
            // 
            password.Location = new Point(225, 294);
            password.Name = "password";
            password.Size = new Size(291, 23);
            password.TabIndex = 3;
            // 
            // register
            // 
            register.Location = new Point(336, 353);
            register.Name = "register";
            register.Size = new Size(75, 23);
            register.TabIndex = 4;
            register.Text = "Register";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // MemberView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 475);
            Controls.Add(register);
            Controls.Add(password);
            Controls.Add(mobileNumber);
            Controls.Add(email);
            Controls.Add(name);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MemberView";
            Text = "MemberView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private TextBox email;
        private TextBox mobileNumber;
        private TextBox password;
        private Button register;
    }
}
namespace Library_Management_System.View
{
    partial class Msg
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
            panel1 = new Panel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            password = new ReaLTaiizor.Controls.BigTextBox();
            button1 = new ReaLTaiizor.Controls.Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Location = new Point(-2, 274);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 27);
            panel1.TabIndex = 0;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(122, 65);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(195, 32);
            bigLabel1.TabIndex = 1;
            bigLabel1.Text = "Update Password";
            // 
            // password
            // 
            password.BackColor = Color.Transparent;
            password.Font = new Font("Tahoma", 11F);
            password.ForeColor = Color.DimGray;
            password.Image = null;
            password.Location = new Point(89, 127);
            password.MaxLength = 32767;
            password.Multiline = false;
            password.Name = "password";
            password.ReadOnly = false;
            password.Size = new Size(264, 41);
            password.TabIndex = 2;
            password.Text = "Password";
            password.TextAlignment = HorizontalAlignment.Left;
            password.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.FromArgb(64, 64, 64);
            button1.Cursor = Cursors.Hand;
            button1.EnteredBorderColor = Color.Black;
            button1.EnteredColor = Color.Black;
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.FromArgb(32, 34, 37);
            button1.Location = new Point(160, 199);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.Black;
            button1.PressedColor = Color.Black;
            button1.Size = new Size(120, 40);
            button1.TabIndex = 3;
            button1.Text = "Update";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += button1_Click;
            // 
            // Msg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(444, 301);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(bigLabel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Msg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Msg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigTextBox password;
        private ReaLTaiizor.Controls.Button button1;
    }
}
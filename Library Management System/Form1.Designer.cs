namespace Library_Management_System
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
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            name = new ReaLTaiizor.Controls.BigTextBox();
            password = new ReaLTaiizor.Controls.BigTextBox();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(763, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(nightControlBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 36);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(441, 553);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(441, 583);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // name
            // 
            name.BackColor = Color.Transparent;
            name.Font = new Font("Tahoma", 11F);
            name.ForeColor = Color.DimGray;
            name.Image = null;
            name.Location = new Point(502, 222);
            name.MaxLength = 32767;
            name.Multiline = false;
            name.Name = "name";
            name.ReadOnly = false;
            name.Size = new Size(317, 41);
            name.TabIndex = 3;
            name.Text = "User Name";
            name.TextAlignment = HorizontalAlignment.Left;
            name.UseSystemPasswordChar = false;
            // 
            // password
            // 
            password.BackColor = Color.Transparent;
            password.Font = new Font("Tahoma", 11F);
            password.ForeColor = Color.DimGray;
            password.Image = null;
            password.Location = new Point(502, 289);
            password.MaxLength = 32767;
            password.Multiline = false;
            password.Name = "password";
            password.ReadOnly = false;
            password.Size = new Size(317, 41);
            password.TabIndex = 4;
            password.Text = "Password";
            password.TextAlignment = HorizontalAlignment.Left;
            password.UseSystemPasswordChar = false;
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 4F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Arial", 11F);
            cyberButton1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(576, 385);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(188, 50);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 6;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "Sign In";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
            cyberButton1.Click += cyberButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 581);
            Controls.Add(cyberButton1);
            Controls.Add(password);
            Controls.Add(name);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Panel panel1;
        private Panel panel2;
        private ReaLTaiizor.Controls.BigTextBox name;
        private ReaLTaiizor.Controls.BigTextBox password;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
    }
}

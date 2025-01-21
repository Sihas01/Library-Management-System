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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            name = new ReaLTaiizor.Controls.BigTextBox();
            email = new ReaLTaiizor.Controls.BigTextBox();
            mobileNumber = new ReaLTaiizor.Controls.BigTextBox();
            chatButtonRight1 = new ReaLTaiizor.Controls.ChatButtonRight();
            poisonDataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            bigTextBox1 = new ReaLTaiizor.Controls.BigTextBox();
            button1 = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            name.BackColor = Color.Transparent;
            name.Font = new Font("Tahoma", 11F);
            name.ForeColor = Color.DimGray;
            name.Image = null;
            name.Location = new Point(45, 151);
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
            email.Location = new Point(45, 216);
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
            mobileNumber.Location = new Point(45, 282);
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
            chatButtonRight1.Location = new Point(45, 354);
            chatButtonRight1.Name = "chatButtonRight1";
            chatButtonRight1.PressedColorA = Color.FromArgb(0, 118, 176);
            chatButtonRight1.PressedColorB = Color.FromArgb(0, 149, 222);
            chatButtonRight1.PressedContourColorA = Color.FromArgb(0, 118, 176);
            chatButtonRight1.PressedContourColorB = Color.FromArgb(0, 118, 176);
            chatButtonRight1.Size = new Size(293, 40);
            chatButtonRight1.TabIndex = 8;
            chatButtonRight1.Text = "Add Member";
            chatButtonRight1.TextAlignment = StringAlignment.Center;
            chatButtonRight1.Click += chatButtonRight1_Click;
            // 
            // poisonDataGridView1
            // 
            poisonDataGridView1.AllowUserToResizeRows = false;
            poisonDataGridView1.BackgroundColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView1.BorderStyle = BorderStyle.None;
            poisonDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            poisonDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            poisonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            poisonDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            poisonDataGridView1.EnableHeadersVisualStyles = false;
            poisonDataGridView1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            poisonDataGridView1.GridColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView1.Location = new Point(369, 127);
            poisonDataGridView1.Name = "poisonDataGridView1";
            poisonDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            poisonDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            poisonDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            poisonDataGridView1.Size = new Size(455, 396);
            poisonDataGridView1.TabIndex = 9;
            // 
            // bigTextBox1
            // 
            bigTextBox1.BackColor = Color.Transparent;
            bigTextBox1.Font = new Font("Tahoma", 11F);
            bigTextBox1.ForeColor = Color.DimGray;
            bigTextBox1.Image = null;
            bigTextBox1.Location = new Point(45, 53);
            bigTextBox1.MaxLength = 32767;
            bigTextBox1.Multiline = false;
            bigTextBox1.Name = "bigTextBox1";
            bigTextBox1.ReadOnly = false;
            bigTextBox1.Size = new Size(361, 41);
            bigTextBox1.TabIndex = 10;
            bigTextBox1.Text = "bigTextBox1";
            bigTextBox1.TextAlignment = HorizontalAlignment.Left;
            bigTextBox1.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.FromArgb(32, 34, 37);
            button1.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button1.EnteredColor = Color.FromArgb(32, 34, 37);
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.FromArgb(32, 34, 37);
            button1.Location = new Point(412, 53);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button1.PressedColor = Color.FromArgb(165, 37, 37);
            button1.Size = new Size(120, 40);
            button1.TabIndex = 11;
            button1.Text = "Search";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += button1_Click;
            // 
            // MemberView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(button1);
            Controls.Add(bigTextBox1);
            Controls.Add(poisonDataGridView1);
            Controls.Add(chatButtonRight1);
            Controls.Add(mobileNumber);
            Controls.Add(email);
            Controls.Add(name);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MemberView";
            Text = "MemberView";
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.BigTextBox name;
        private ReaLTaiizor.Controls.BigTextBox email;
        private ReaLTaiizor.Controls.BigTextBox mobileNumber;
        private ReaLTaiizor.Controls.ChatButtonRight chatButtonRight1;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView1;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox1;
        private ReaLTaiizor.Controls.Button button1;
    }
}
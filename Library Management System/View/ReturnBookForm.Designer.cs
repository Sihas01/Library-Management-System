namespace Library_Management_System.View
{
    partial class ReturnBookForm
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
            hopeButton3 = new ReaLTaiizor.Controls.HopeButton();
            poisonDataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            panel1 = new Panel();
            hopeButton1 = new ReaLTaiizor.Controls.HopeButton();
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // hopeButton3
            // 
            hopeButton3.BorderColor = Color.FromArgb(220, 223, 230);
            hopeButton3.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeButton3.DangerColor = Color.FromArgb(245, 108, 108);
            hopeButton3.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeButton3.Font = new Font("Segoe UI", 12F);
            hopeButton3.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeButton3.InfoColor = Color.FromArgb(144, 147, 153);
            hopeButton3.Location = new Point(46, 605);
            hopeButton3.Margin = new Padding(3, 4, 3, 4);
            hopeButton3.Name = "hopeButton3";
            hopeButton3.PrimaryColor = Color.FromArgb(2, 39, 74);
            hopeButton3.Size = new Size(335, 53);
            hopeButton3.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeButton3.TabIndex = 24;
            hopeButton3.Text = "Return Book";
            hopeButton3.TextColor = Color.White;
            hopeButton3.WarningColor = Color.FromArgb(230, 162, 60);
            hopeButton3.Click += hopeButton3_Click;
            // 
            // poisonDataGridView1
            // 
            poisonDataGridView1.AllowUserToAddRows = false;
            poisonDataGridView1.AllowUserToDeleteRows = false;
            poisonDataGridView1.AllowUserToResizeColumns = false;
            poisonDataGridView1.AllowUserToResizeRows = false;
            poisonDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            poisonDataGridView1.BackgroundColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView1.BorderStyle = BorderStyle.None;
            poisonDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            poisonDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(12, 72, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(12, 72, 128);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            poisonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(57, 142, 222);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            poisonDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            poisonDataGridView1.EnableHeadersVisualStyles = false;
            poisonDataGridView1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            poisonDataGridView1.GridColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView1.Location = new Point(46, 88);
            poisonDataGridView1.Margin = new Padding(3, 4, 3, 4);
            poisonDataGridView1.Name = "poisonDataGridView1";
            poisonDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(12, 72, 128);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(12, 72, 128);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            poisonDataGridView1.RowHeadersWidth = 51;
            poisonDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            poisonDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            poisonDataGridView1.Size = new Size(890, 457);
            poisonDataGridView1.TabIndex = 23;
            poisonDataGridView1.CellContentClick += poisonDataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 39, 74);
            panel1.Location = new Point(-3, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1018, 39);
            panel1.TabIndex = 21;
            // 
            // hopeButton1
            // 
            hopeButton1.BorderColor = Color.FromArgb(220, 223, 230);
            hopeButton1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeButton1.DangerColor = Color.FromArgb(245, 108, 108);
            hopeButton1.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeButton1.Font = new Font("Segoe UI", 12F);
            hopeButton1.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeButton1.InfoColor = Color.FromArgb(144, 147, 153);
            hopeButton1.Location = new Point(411, 605);
            hopeButton1.Margin = new Padding(3, 4, 3, 4);
            hopeButton1.Name = "hopeButton1";
            hopeButton1.PrimaryColor = Color.FromArgb(2, 39, 74);
            hopeButton1.Size = new Size(335, 53);
            hopeButton1.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeButton1.TabIndex = 25;
            hopeButton1.Text = "Renew Book";
            hopeButton1.TextColor = Color.White;
            hopeButton1.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // ReturnBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1010, 748);
            Controls.Add(hopeButton1);
            Controls.Add(hopeButton3);
            Controls.Add(poisonDataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReturnBookForm";
            Text = "ReturnBookForm";
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeButton hopeButton3;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView1;
        private Panel panel1;
        private ReaLTaiizor.Controls.HopeButton hopeButton1;
    }
}
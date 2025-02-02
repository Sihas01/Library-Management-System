namespace Library_Management_System.View
{
    partial class ReservationForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            hopeButton3 = new ReaLTaiizor.Controls.HopeButton();
            bookList = new ReaLTaiizor.Controls.PoisonDataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)bookList).BeginInit();
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
            hopeButton3.Location = new Point(44, 426);
            hopeButton3.Name = "hopeButton3";
            hopeButton3.PrimaryColor = Color.FromArgb(2, 39, 74);
            hopeButton3.Size = new Size(293, 40);
            hopeButton3.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeButton3.TabIndex = 22;
            hopeButton3.Text = "Conform Reservation";
            hopeButton3.TextColor = Color.White;
            hopeButton3.WarningColor = Color.FromArgb(230, 162, 60);
            hopeButton3.Click += hopeButton3_Click;
            // 
            // bookList
            // 
            bookList.AllowUserToAddRows = false;
            bookList.AllowUserToDeleteRows = false;
            bookList.AllowUserToResizeColumns = false;
            bookList.AllowUserToResizeRows = false;
            bookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bookList.BackgroundColor = Color.FromArgb(255, 255, 255);
            bookList.BorderStyle = BorderStyle.None;
            bookList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            bookList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(12, 72, 128);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.Padding = new Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(12, 72, 128);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            bookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            bookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(57, 142, 222);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            bookList.DefaultCellStyle = dataGridViewCellStyle5;
            bookList.EnableHeadersVisualStyles = false;
            bookList.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            bookList.GridColor = Color.FromArgb(255, 255, 255);
            bookList.Location = new Point(44, 82);
            bookList.Name = "bookList";
            bookList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(12, 72, 128);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(12, 72, 128);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            bookList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            bookList.RowHeadersWidth = 51;
            bookList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            bookList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bookList.Size = new Size(779, 308);
            bookList.TabIndex = 21;
            bookList.CellContentClick += bookList_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 39, 74);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 29);
            panel1.TabIndex = 23;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 561);
            Controls.Add(panel1);
            Controls.Add(hopeButton3);
            Controls.Add(bookList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReservationForm";
            Text = "ReservationForm";
            ((System.ComponentModel.ISupportInitialize)bookList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeButton hopeButton3;
        private ReaLTaiizor.Controls.PoisonDataGridView bookList;
        private Panel panel1;
    }
}
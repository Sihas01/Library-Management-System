﻿namespace Library_Management_System.View
{
    partial class ReserveBookForm
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
            bookList = new ReaLTaiizor.Controls.PoisonDataGridView();
            search = new ReaLTaiizor.Controls.BigTextBox();
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
            hopeButton3.Location = new Point(40, 454);
            hopeButton3.Name = "hopeButton3";
            hopeButton3.PrimaryColor = Color.FromArgb(2, 39, 74);
            hopeButton3.Size = new Size(293, 40);
            hopeButton3.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeButton3.TabIndex = 24;
            hopeButton3.Text = "Reserve Book";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(12, 72, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(12, 72, 128);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            bookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            bookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(57, 142, 222);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            bookList.DefaultCellStyle = dataGridViewCellStyle2;
            bookList.EnableHeadersVisualStyles = false;
            bookList.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            bookList.GridColor = Color.FromArgb(255, 255, 255);
            bookList.Location = new Point(40, 123);
            bookList.Name = "bookList";
            bookList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(12, 72, 128);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(12, 72, 128);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            bookList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            bookList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            bookList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bookList.Size = new Size(779, 295);
            bookList.TabIndex = 23;
            // 
            // search
            // 
            search.BackColor = Color.Transparent;
            search.Font = new Font("Tahoma", 11F);
            search.ForeColor = Color.DimGray;
            search.Image = null;
            search.Location = new Point(40, 53);
            search.MaxLength = 32767;
            search.Multiline = false;
            search.Name = "search";
            search.ReadOnly = false;
            search.Size = new Size(779, 41);
            search.TabIndex = 22;
            search.Text = "Search";
            search.TextAlignment = HorizontalAlignment.Left;
            search.UseSystemPasswordChar = false;
            search.TextChanged += search_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 39, 74);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 29);
            panel1.TabIndex = 21;
            // 
            // ReserveBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 561);
            Controls.Add(hopeButton3);
            Controls.Add(bookList);
            Controls.Add(search);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReserveBookForm";
            Text = "ReserveBookForm";
            ((System.ComponentModel.ISupportInitialize)bookList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeButton hopeButton3;
        private ReaLTaiizor.Controls.PoisonDataGridView bookList;
        private ReaLTaiizor.Controls.BigTextBox search;
        private Panel panel1;
    }
}
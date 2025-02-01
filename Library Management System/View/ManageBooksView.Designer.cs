namespace Library_Management_System.View
{
    partial class ManageBooksView
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
            panel1 = new Panel();
            search = new ReaLTaiizor.Controls.BigTextBox();
            hopeButton3 = new ReaLTaiizor.Controls.HopeButton();
            hopeButton2 = new ReaLTaiizor.Controls.HopeButton();
            hopeButton1 = new ReaLTaiizor.Controls.HopeButton();
            bookGrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            isbn = new ReaLTaiizor.Controls.BigTextBox();
            author = new ReaLTaiizor.Controls.BigTextBox();
            title = new ReaLTaiizor.Controls.BigTextBox();
            genre = new ReaLTaiizor.Controls.BigTextBox();
            ((System.ComponentModel.ISupportInitialize)bookGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 39, 74);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 29);
            panel1.TabIndex = 15;
            // 
            // search
            // 
            search.BackColor = Color.Transparent;
            search.Font = new Font("Tahoma", 11F);
            search.ForeColor = Color.DimGray;
            search.Image = null;
            search.Location = new Point(30, 53);
            search.MaxLength = 32767;
            search.Multiline = false;
            search.Name = "search";
            search.ReadOnly = false;
            search.Size = new Size(779, 41);
            search.TabIndex = 24;
            search.Text = "Search Book By Title";
            search.TextAlignment = HorizontalAlignment.Left;
            search.UseSystemPasswordChar = false;
            search.TextChanged += search_TextChanged;
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
            hopeButton3.Location = new Point(30, 381);
            hopeButton3.Name = "hopeButton3";
            hopeButton3.PrimaryColor = Color.FromArgb(2, 39, 74);
            hopeButton3.Size = new Size(293, 40);
            hopeButton3.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeButton3.TabIndex = 23;
            hopeButton3.Text = "Add Book";
            hopeButton3.TextColor = Color.White;
            hopeButton3.WarningColor = Color.FromArgb(230, 162, 60);
            hopeButton3.Click += hopeButton3_Click;
            // 
            // hopeButton2
            // 
            hopeButton2.BorderColor = Color.FromArgb(220, 223, 230);
            hopeButton2.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeButton2.DangerColor = Color.FromArgb(245, 108, 108);
            hopeButton2.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeButton2.Font = new Font("Segoe UI", 12F);
            hopeButton2.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeButton2.InfoColor = Color.FromArgb(144, 147, 153);
            hopeButton2.Location = new Point(30, 494);
            hopeButton2.Name = "hopeButton2";
            hopeButton2.PrimaryColor = Color.FromArgb(192, 0, 0);
            hopeButton2.Size = new Size(293, 40);
            hopeButton2.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeButton2.TabIndex = 22;
            hopeButton2.Text = "Delete Book";
            hopeButton2.TextColor = Color.White;
            hopeButton2.WarningColor = Color.FromArgb(230, 162, 60);
            hopeButton2.Click += hopeButton2_Click;
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
            hopeButton1.Location = new Point(30, 438);
            hopeButton1.Name = "hopeButton1";
            hopeButton1.PrimaryColor = Color.FromArgb(2, 39, 74);
            hopeButton1.Size = new Size(293, 40);
            hopeButton1.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeButton1.TabIndex = 21;
            hopeButton1.Text = "Update Book";
            hopeButton1.TextColor = Color.White;
            hopeButton1.WarningColor = Color.FromArgb(230, 162, 60);
            hopeButton1.Click += hopeButton1_Click;
            // 
            // bookGrid
            // 
            bookGrid.AllowUserToAddRows = false;
            bookGrid.AllowUserToDeleteRows = false;
            bookGrid.AllowUserToResizeColumns = false;
            bookGrid.AllowUserToResizeRows = false;
            bookGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bookGrid.BackgroundColor = Color.FromArgb(255, 255, 255);
            bookGrid.BorderStyle = BorderStyle.None;
            bookGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            bookGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(12, 72, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(12, 72, 128);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            bookGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            bookGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(57, 142, 222);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            bookGrid.DefaultCellStyle = dataGridViewCellStyle2;
            bookGrid.EnableHeadersVisualStyles = false;
            bookGrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            bookGrid.GridColor = Color.FromArgb(255, 255, 255);
            bookGrid.Location = new Point(354, 110);
            bookGrid.Name = "bookGrid";
            bookGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(12, 72, 128);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(12, 72, 128);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            bookGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            bookGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            bookGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bookGrid.Size = new Size(455, 424);
            bookGrid.TabIndex = 20;
            // 
            // isbn
            // 
            isbn.BackColor = Color.Transparent;
            isbn.Font = new Font("Tahoma", 11F);
            isbn.ForeColor = Color.DimGray;
            isbn.Image = null;
            isbn.Location = new Point(30, 265);
            isbn.MaxLength = 32767;
            isbn.Multiline = false;
            isbn.Name = "isbn";
            isbn.ReadOnly = false;
            isbn.Size = new Size(293, 41);
            isbn.TabIndex = 19;
            isbn.Text = "ISBN";
            isbn.TextAlignment = HorizontalAlignment.Left;
            isbn.UseSystemPasswordChar = false;
            // 
            // author
            // 
            author.BackColor = Color.Transparent;
            author.Font = new Font("Tahoma", 11F);
            author.ForeColor = Color.DimGray;
            author.Image = null;
            author.Location = new Point(30, 199);
            author.MaxLength = 32767;
            author.Multiline = false;
            author.Name = "author";
            author.ReadOnly = false;
            author.Size = new Size(293, 41);
            author.TabIndex = 18;
            author.Text = "Author";
            author.TextAlignment = HorizontalAlignment.Left;
            author.UseSystemPasswordChar = false;
            // 
            // title
            // 
            title.BackColor = Color.White;
            title.Font = new Font("Tahoma", 11F);
            title.ForeColor = Color.DimGray;
            title.Image = null;
            title.Location = new Point(30, 134);
            title.MaxLength = 32767;
            title.Multiline = false;
            title.Name = "title";
            title.ReadOnly = false;
            title.Size = new Size(293, 41);
            title.TabIndex = 17;
            title.Text = "Title";
            title.TextAlignment = HorizontalAlignment.Left;
            title.UseSystemPasswordChar = false;
            // 
            // genre
            // 
            genre.BackColor = Color.Transparent;
            genre.Font = new Font("Tahoma", 11F);
            genre.ForeColor = Color.DimGray;
            genre.Image = null;
            genre.Location = new Point(30, 321);
            genre.MaxLength = 32767;
            genre.Multiline = false;
            genre.Name = "genre";
            genre.ReadOnly = false;
            genre.Size = new Size(293, 41);
            genre.TabIndex = 25;
            genre.Text = "Genre";
            genre.TextAlignment = HorizontalAlignment.Left;
            genre.UseSystemPasswordChar = false;
            // 
            // ManageBooksView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 561);
            Controls.Add(genre);
            Controls.Add(search);
            Controls.Add(hopeButton3);
            Controls.Add(hopeButton2);
            Controls.Add(hopeButton1);
            Controls.Add(bookGrid);
            Controls.Add(isbn);
            Controls.Add(author);
            Controls.Add(title);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageBooksView";
            Text = "ManageBooksView";
            ((System.ComponentModel.ISupportInitialize)bookGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.BigTextBox search;
        private ReaLTaiizor.Controls.HopeButton hopeButton3;
        private ReaLTaiizor.Controls.HopeButton hopeButton2;
        private ReaLTaiizor.Controls.HopeButton hopeButton1;
        private ReaLTaiizor.Controls.PoisonDataGridView bookGrid;
        private ReaLTaiizor.Controls.BigTextBox isbn;
        private ReaLTaiizor.Controls.BigTextBox author;
        private ReaLTaiizor.Controls.BigTextBox title;
        private ReaLTaiizor.Controls.BigTextBox genre;
    }
}
namespace Library_Management_System.View
{
    partial class MostBooks
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
            poisonDataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).BeginInit();
            SuspendLayout();
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
            poisonDataGridView1.Location = new Point(36, 36);
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
            poisonDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            poisonDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            poisonDataGridView1.Size = new Size(751, 490);
            poisonDataGridView1.TabIndex = 11;
            // 
            // MostBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 561);
            Controls.Add(poisonDataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MostBooks";
            Text = "MostBooks";
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView1;
    }
}
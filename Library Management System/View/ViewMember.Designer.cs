namespace Library_Management_System.View
{
    partial class ViewMember
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
            dataGridViewMembers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMembers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMembers
            // 
            dataGridViewMembers.BackgroundColor = Color.White;
            dataGridViewMembers.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewMembers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMembers.Location = new Point(26, 12);
            dataGridViewMembers.Name = "dataGridViewMembers";
            dataGridViewMembers.Size = new Size(552, 366);
            dataGridViewMembers.TabIndex = 1;
            // 
            // ViewMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 475);
            Controls.Add(dataGridViewMembers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewMember";
            Text = "ViewMember";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMembers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewMembers;
    }
}
using Library_Management_System.Controller;
using Library_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Library_Management_System.View
{
    public partial class ReturnBookForm : Form
    {
        private BorrowingRecord _borrowingRecord;
        private BorrowingRecordController _borrowingRecordController;
        private BindingSource _bindingSource;
        private int recordId = 0;
        public ReturnBookForm()
        {
            InitializeComponent();
            _borrowingRecordController = new BorrowingRecordController(this);
            this.Load += BorrowRecordForm_Load;
            this.poisonDataGridView1.CellClick += poisonDataGridView1_CellContentClick;
            _bindingSource = new BindingSource();
            this.Activated += ReturnBook_Activated;

        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        private void BorrowRecordForm_Load(object sender, EventArgs e)
        {
            _borrowingRecordController.Getborrowrecords();
        }
        public DataTable ConvertToDataTable(List<BorrowingRecord> records)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("recordID", typeof(int));
            dt.Columns.Add("bookID", typeof(int));
            dt.Columns.Add("memberID", typeof(int));
            dt.Columns.Add("Borrow_date", typeof(DateTime));
            dt.Columns.Add("Due_Date", typeof(DateTime));

            foreach (var record in records)
            {
                dt.Rows.Add(record.Record_id, record.BookId, record.MemberId, record.Borrow_Date, record.Due_Date);
            }
            return dt;
        }


        public void DisplayRecods(List<BorrowingRecord> recods)
        {
            DataTable dt = ConvertToDataTable(recods);
            _bindingSource.DataSource = dt;
            poisonDataGridView1.DataSource = _bindingSource;
        }

        private void poisonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = poisonDataGridView1.Rows[e.RowIndex];
                if (row.Cells["recordID"] != null)
                {
                    recordId = Convert.ToInt32(row.Cells["recordID"].Value);
                }
            }

        }

        private void hopeButton3_Click(object sender, EventArgs e)
        {
            _borrowingRecordController.ReturnBook(recordId);
            recordId = 0;
        }

        private void ReturnBook_Activated(object sender, EventArgs e)
        {
            _borrowingRecordController.Getborrowrecords();
        }
    }
}
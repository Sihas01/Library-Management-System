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
        public ReturnBookForm()
        {
            InitializeComponent();
            _borrowingRecordController = new BorrowingRecordController(this);
            this.Load += BorrowRecordForm_Load;
            this.poisonDataGridView1.CellClick += poisonDataGridView1_CellContentClick;
            _bindingSource = new BindingSource();

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

            dt.Columns.Add("bookID", typeof(int));
            dt.Columns.Add("memberID", typeof(int));
            dt.Columns.Add("Return_Date", typeof(DateTime));
            dt.Columns.Add("Borrow_date", typeof(DateTime));

            foreach (var record in records) 
            {
                dt.Rows.Add(record.BookId,record.MemberId,record.Return_Date,record.Borrow_Date);
            }
            return dt;
        }
        private void hopeButton3_Click(object sender, EventArgs e)
        {
            _borrowingRecordController.fineCal();
        }

        public void DisplayRecods(List<BorrowingRecord> recods)
        {
            //ShowMessage($"{recods.Count}");
            DataTable dt = ConvertToDataTable(recods);
            _bindingSource.DataSource = dt;
            poisonDataGridView1.DataSource = _bindingSource;
        }

        private void poisonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = poisonDataGridView1.Rows[e.RowIndex];

            //}

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Management_System.Controller;
using Library_Management_System.Model;

namespace Library_Management_System.View
{
    public partial class ReservationForm : Form
    {
        private ReserveController reseveRecord;
        private BindingSource _bindingSource;
        private int selectedID;
        private int recordId;
        public ReservationForm()
        {
            InitializeComponent();
            reseveRecord = new ReserveController(this);
            this.Load += Reservationform_Load;
            this.bookList.CellClick += bookList_CellContentClick;
            _bindingSource = new BindingSource();
        }

        private void bookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = bookList.Rows[e.RowIndex];
                selectedID = Convert.ToInt32(row.Cells["Book_id"].Value);
                recordId = Convert.ToInt32(row.Cells["Record_Id"].Value);
            }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }


        public DataTable ConvertToDataTable(List<Reserve> reserve)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Record_Id", typeof(int));
            dt.Columns.Add("Book_Id", typeof(int));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("reservationDate", typeof(string));

            foreach (var reseveRecord in reserve)
            {
                dt.Rows.Add(reseveRecord.ReservationId,reseveRecord.Book_id, reseveRecord.Status, reseveRecord.ReservationDate);
            }

            return dt;
        }

        public void DisplayRecords(List<Reserve> reserve)
        {
            DataTable dt = ConvertToDataTable(reserve);
            _bindingSource.DataSource = dt;
            bookList.DataSource = _bindingSource;

        }

        private void Reservationform_Load(object sender, EventArgs e)
        {

            reseveRecord.Getborrowrecords();
        }

        private void hopeButton3_Click(object sender, EventArgs e)
        {
            reseveRecord.ConfirmReservation(selectedID,recordId);
            selectedID = 0;
            recordId = 0;   
        }
    }
}

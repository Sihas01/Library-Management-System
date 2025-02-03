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
    public partial class FineForm : Form
    {
        private FineController _fineController;
        private BindingSource _bindingSource;

        private int selectedFineID;

        public FineForm()
        {
            InitializeComponent();
            _fineController = new FineController(this);
            this.Load += Fine_Load;
            this.poisonDataGridView1.CellClick += poisonDataGridView1_CellContentClick;
            _bindingSource = new BindingSource();
            this.Activated += FineForm_Activated;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void Fine_Load(object sender, EventArgs e)
        {

            _fineController.GetFines();


        }

        public DataTable ConvertToDataTable(List<Fine> fines)
        {
            DataTable dt = new DataTable();

            // Add columns to the DataTable (based on Member properties)
            dt.Columns.Add("Fine_ID", typeof(int));
            dt.Columns.Add("Amount", typeof(decimal));
            dt.Columns.Add("Status", typeof(string));

            // Add rows from the Member list
            foreach (var fine in fines)
            {
                dt.Rows.Add(fine.Fine_Id,fine.Amount,fine.Status);
            }

            return dt;
        }

        public void DisplayFines(List<Fine> fine)
        {
            DataTable dt = ConvertToDataTable(fine);
            _bindingSource.DataSource = dt;
            poisonDataGridView1.DataSource = _bindingSource;
        }

      

        private void poisonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = poisonDataGridView1.Rows[e.RowIndex];
                if (row.Cells["Fine_ID"] != null)
                {
                    selectedFineID = Convert.ToInt32(row.Cells["Fine_ID"].Value);
                }
            }
        }

        private void hopeButton3_Click(object sender, EventArgs e)
        {
            _fineController.UpdateFineStatus(selectedFineID);
            selectedFineID = 0;

        }

        private void FineForm_Activated(object sender, EventArgs e)
        {
            _fineController.GetFines();
        }
    }
}

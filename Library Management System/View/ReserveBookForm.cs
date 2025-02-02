using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_Management_System.View
{
    public partial class ReserveBookForm : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private object _bindingSource;

        public ReserveBookForm()
        {
            InitializeComponent();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = search.Text.Trim();
            string filterExpression = string.Format("Title LIKE '%{0}%'", searchQuery);
            _bindingSource.Filter = filterExpression;
        }

        private void hopeButton3_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=library_management_system;User ID=root;Password=mysql123";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Check if the book is already reserved
                string checkQuery = "SELECT is_available FROM Books WHERE id = @BookId";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@BookId", bookId);

                object result = checkCmd.ExecuteScalar();
                if (result != null && !(bool)result)
                {
                    MessageBox.Show("Book is already reserved and not available for reservation.");
                    return;
                }

                // Reserve the book
                string reserveQuery = "INSERT INTO Reservation (book_id, reservation_date, status) VALUES (@BookId, @Date, @Status)";
                SqlCommand reserveCmd = new SqlCommand(reserveQuery, conn);
                reserveCmd.Parameters.AddWithValue("@BookId", bookId);
                reserveCmd.Parameters.AddWithValue("@Date", DateTime.Now);
                reserveCmd.Parameters.AddWithValue("@Status", "Pending"); // Or any default status you use

                int rowsAffected = reserveCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book reserved successfully.");

                    // Optionally, update the Books table to mark the book as not available
                    string updateBookQuery = "UPDATE Books SET is_available = 0 WHERE id = @BookId";
                    SqlCommand updateBookCmd = new SqlCommand(updateBookQuery, conn);
                    updateBookCmd.Parameters.AddWithValue("@BookId", bookId);
                    updateBookCmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Failed to reserve the book.");
                }
            }

        
    }
}

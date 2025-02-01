using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Library_Management_System.db
{
    internal class Database
    {
        private MySqlConnection _connection;
        private string connectionString = "Server=localhost;Database=library_management_system;User ID=root;Password=mysql123";

        public Database()
        {
            _connection = new MySqlConnection(connectionString);
        }

        private void ExecuteQuery(string query)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                _connection.Close();
            }
        }

        public void Insert(string table,List<string> columns,List<object> values)
        {
            if (columns.Count != values.Count)
            {
                throw new ArgumentException("The number of columns and values must match");
            }

            string columnsJoined = string.Join(",", columns);
            string parameters = string.Join(",", values.ConvertAll(v =>
            {
                if (v == DBNull.Value || v == null)
                {
                    return "NULL";
                }
                else if (v is string || v is DateTime)
                {
                    return $"'{v}'";
                }
                else
                {
                    return v.ToString();
                }
            }
            ));

            string query = $"INSERT INTO {table} ({columnsJoined}) VALUES ({parameters})";
            ExecuteQuery(query);
        }

        public void Update(string table,List<string> setClauses,string condition)
        {
            string setClausesJoined = string.Join(",", setClauses);
            string query = $"UPDATE {table} SET {setClausesJoined} WHERE {condition}";
            ExecuteQuery(query);
        }

        public void Delete(string table, string condition)
        {
            string query = $"DELETE FROM {table} WHERE {condition}";
            ExecuteQuery(query);
        }

        public List<Dictionary<string, string>> Select(string table, string columns = "*", string condition = "")
        {
            string query = $"SELECT {columns} FROM {table}" + (string.IsNullOrEmpty(condition) ? "" : $" WHERE {condition}");
            return ExecuteReader(query);
        }

        private List<Dictionary<string, string>> ExecuteReader(string query)
        {
            var result = new List<Dictionary<string, string>>();

            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var row = new Dictionary<string, string>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row.Add(reader.GetName(i), reader[i].ToString());
                        }
                        result.Add(row);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }


    }
}

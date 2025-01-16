using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Model;
using MySql.Data.MySqlClient;

namespace Library_Management_System.db
{
    internal class DatabaseHelper
    {
        private string connectionString = "Server=localhost;Database=test;User ID=root;Password=mysql123";

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();

                    Console.WriteLine("Connection successful.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection failed: " + ex.Message);
                return false;
            }
        }

        public void InsertMember(Member member)
        {
            using (var connection = GetConnection()) {
                connection.Open();
                string query = "INSERT INTO members (name,email,phonenumber,password,hasChangedPassword) VALUES(@name,@email,@phonenumber,@password,0)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", member.Name);
                    command.Parameters.AddWithValue("@email", member.Email);
                    command.Parameters.AddWithValue("@phonenumber", member.PhoneNumber);
                    command.Parameters.AddWithValue("@password", member.Password);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Member ViewMember(string email)
        {
            Member member = null;

            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT id, name, email, phonenumber, password, hasChangedPassword FROM Members WHERE email = @email";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);


                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            bool hasChangedPassword = Convert.ToBoolean(reader["hasChangedPassword"]);
                            member = new Member(
                                reader["name"].ToString(),
                                reader["email"].ToString(),
                                reader["phonenumber"].ToString())
                                
                            {
                                Password = reader["password"].ToString(),
                                 HasChangedPassword = hasChangedPassword
                            };
                        }


                    }
                }
                return member;
            }
        }


        public bool UpdateMemberPassword(Member member)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE members SET password = @Password, hasChangedPassword = 1 WHERE email = @Email";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Password", member.Password); 
                    command.Parameters.AddWithValue("@Email", member.Email);

                    return command.ExecuteNonQuery() > 0; 
                }
            }
        }
    }
}

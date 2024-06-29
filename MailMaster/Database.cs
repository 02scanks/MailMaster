using MailMaster;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

public class Database
{
    string connectionString = "";

    public void PopulateUserComboBox(ComboBox users, int adminID)
    {
        string query = "SELECT name FROM clients WHERE adminIndex = @adminId";

        try
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@adminId", adminID);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString("name");
                            users.Items.Add(name);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"ERROR: {ex.Message}");
        }
    }

    public void PopulateRemoveUserList(ListView removeableUsers)
    {
        string query = "SELECT name, email FROM clients";

        try
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString("name");
                            removeableUsers.Items.Add(name);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"ERROR: {ex.Message}");
        }
    }

    public void RemoveUser(string name)
    {
        string query = "DELETE FROM clients WHERE name = @name";

        try
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show($"Deleted User {name} From System");
                    }
                    else
                    {
                        MessageBox.Show("ERROR WHEN DELETING USER");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"ERROR: {ex.Message}");
        }
    }

    public string GetClientEmail(string name)
    {
        string query = "SELECT email FROM clients WHERE name = @name";
        string email = null;

        try
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            email = reader.GetString("email");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"ERROR: {ex.Message}");
        }

        return email;
    }

    public void AddClientToDatabase(string name, string email, int adminID)
    {
        string query = "INSERT INTO clients (name, email, adminIndex) values (@name, @email, @adminIndex)";

        try
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@adminIndex", adminID);
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show($"Client: '{name}' Successfully Added!");
                    }
                    else
                    {
                        MessageBox.Show("Client Couldnt Be Added, Try Again Later");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"ERROR: {ex.Message}");
        }
    }

    private int CaptureAdminID(string name)
    {
        string query = "SELECT id FROM admins WHERE name = @name";
        int id = -1;

        try
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = reader.GetInt32("id");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"ERROR: {ex.Message}");
        }

        return id;
    }

    public string GetAdminEmail(int adminID) 
    {
        string query = "SELECT email from admins WHERE id = @id";
        string email = null;

        try
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", adminID);
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            email = reader.GetString("email");
                        }
                    }
                }
            }
        }
        catch (Exception ex) 
        {
            MessageBox.Show($"ERROR: {ex.Message}");
        }

        return email;
    }

    public string GetAdminEmailPassword(int adminID)
    {
        string query = "SELECT appPassword from admins WHERE id = @id";
        string appPassword = null;

        try
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", adminID);
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appPassword = reader.GetString("appPassword");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"ERROR: {ex.Message}");
        }

        return appPassword;
    }

    public void Login(string username, string password)
    {
        string query = "SELECT COUNT(*) FROM admins WHERE name = @name AND password = @password";

        try
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", username);
                    command.Parameters.AddWithValue("@password", password);
                    connection.Open();
                    int result = Convert.ToInt32(command.ExecuteScalar());
                    if (result > 0)
                    {
                        int id = CaptureAdminID(username);
                        main mainForm = new main(id);
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error when logging in, try again later!");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"ERROR: {ex.Message}");
        }
    }
}

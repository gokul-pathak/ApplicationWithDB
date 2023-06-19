using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ApplicationWithDB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Code to be executed on page load (if needed)
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            // Retrieve the value from the input field
            string Name = this.nameInput.Value;
            try
            {
                // Database connection string
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                // SQL query to insert data into the table
                string sqlQuery = "INSERT INTO [dbo].[Table] ([Name]) VALUES (@Name)";

                

                // Create a SqlConnection object
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        // Add parameter to the command
                        command.Parameters.AddWithValue("@Name", Name);

                        // Open the connection
                        connection.Open();

                        // Execute the command
                        command.ExecuteNonQuery();
                        Response.Write("Student name registered");  
                        // Close the connection
                        connection.Close();
                    }
                }

                // Optionally, perform any additional actions or display success message
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during database operations
                // Optionally, display error message or perform error handling
                Response.Write("Error" + ex.ToString());
            }
        }
    }
}

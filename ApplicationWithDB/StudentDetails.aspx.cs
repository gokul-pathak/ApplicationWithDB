using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationWithDB
{
    public partial class StudentDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridViewRecord();
            }
        }
        protected void GridViewRecord()
        {
            SqlCommand comm = new SqlCommand("SELECT * FROM [Students]", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            DisplayDbData.DataSource = dt;
            DisplayDbData.DataBind();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Gokul Pathak\\source\\repos\\ApplicationWithDB\\ApplicationWithDB\\App_Data\\Database2.mdf\";Integrated Security=True");

        protected void CreateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("Insert into [Students] (Name, Reg_Num) values('" + StdName.Text + "','" + int.Parse(StdReg.Text) + "')", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Successfully created');", true);
            //register a Javascript code block to be executed on client - side. In this case
            //it register a script that displays an alert message with the text "Successfully Inserted".
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true);
            GridViewRecord();
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("DELETE [Students] where Reg_Num = '" + int.Parse(StdReg.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();
            //register a Javascript code block to be executed on client - side. In this case
            //it register a script that displays an alert message with the text "Successfully Inserted".
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);
            GridViewRecord();
        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("SELECT * FROM [Students] where Reg_Num = '" + int.Parse(StdReg.Text) + "'", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            DisplayDbData.DataSource = dt;
            DisplayDbData.DataBind();
        }

        protected void GetBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("SELECT * FROM [Students] where Reg_Num = '" + int.Parse(StdReg.Text) + "'", con);
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                StdName.Text = dr.GetValue(1).ToString();
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("UPDATE [Students] set Name = '" + StdName.Text + "' where Reg_Num = '" + int.Parse(StdReg.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();
            //register a Javascript code block to be executed on client - side. In this case
            //it register a script that displays an alert message with the text "Successfully Inserted".
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            GridViewRecord();
        }

    }

}
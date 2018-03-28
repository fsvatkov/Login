using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default4 : System.Web.UI.Page
{
    SqlConnection SqlCon;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Fedor\source\repos\WebSite2\WebSite2\App_Data\Database.mdf;Integrated Security=True";
        SqlCon = new SqlConnection(constr);

        SqlCon.Open();

        SqlCommand command = new SqlCommand("INSERT INTO [userdata] (Username,Password,Email,Firstname,Lastname)VALUES(@Username,@Password,@Email,@Firstname,@Lastname)", SqlCon);

        command.Parameters.AddWithValue("Username", TextBox4.Text);
        command.Parameters.AddWithValue("Password", TextBox5.Text);
        command.Parameters.AddWithValue("Email", TextBox3.Text);
        command.Parameters.AddWithValue("Firstname", TextBox1.Text);
        command.Parameters.AddWithValue("Lastname", TextBox2.Text);

        command.ExecuteNonQuery();
        SqlCon.Close();

        Server.Transfer("Default2.aspx", true);



    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("Default.aspx", true);
    }
}
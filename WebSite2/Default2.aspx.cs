using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection SqlCon;
    bool auth;
    int id;


    protected void Page_Load(object sender, EventArgs e)
    {

    }

 




    protected void Button1_Click(object sender, EventArgs e)
    {
        string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Fedor\source\repos\WebSite2\WebSite2\App_Data\Database.mdf;Integrated Security=True";
        SqlCon = new SqlConnection(constr);

        SqlCon.Open();

        SqlDataReader Reader = null;
    
        
        
        SqlCommand command = new SqlCommand("SELECT Password,Id from [userdata] where [username] = @username", SqlCon);

        command.Parameters.AddWithValue("username", TextBox1.Text);

        Reader = command.ExecuteReader();

        try {
            while (Reader.Read()) {
                auth = string.Equals(TextBox2.Text, Reader.GetString(0));
                id = Reader.GetInt32(1);
            }
              
        }

        catch (Exception)
        { Label1.Visible = true;
            Label1.Text="ERROR"; }
        
        finally { Reader.Close(); }

        Session["Userlog"] = id;

        if (auth)
        {
            Server.Transfer("Default3.aspx", true);
            if (SqlCon != null && SqlCon.State != ConnectionState.Closed)
                SqlCon.Close();
        }
        else
            Label1.Visible = true;
            Label1.Text="Неправильный пароль";






    }
}
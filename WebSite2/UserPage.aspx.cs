using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;



public partial class Default3 : System.Web.UI.Page
{

    SqlConnection SqlCon;
    protected void Page_Load(object sender, EventArgs e)
    {

        int id = Convert.ToInt32(Session["Userlog"]);

            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Fedor\source\repos\WebSite2\WebSite2\App_Data\Database.mdf;Integrated Security=True";
        SqlCon = new SqlConnection(constr);

        SqlCon.Open();

        SqlDataReader Reader = null;



        SqlCommand command = new SqlCommand("SELECT Firstname,Lastname,Email from [userdata] where [Id] = @Id", SqlCon);

       
            command.Parameters.AddWithValue("Id", id);

            Reader = command.ExecuteReader();
        




            try
            {
                while (Reader.Read())
                {
                    Label2.Text = Reader.GetString(0);
                    Label3.Text = Reader.GetString(1);
                    Label4.Text = Reader.GetString(2);
                }

            }

            catch (Exception)
            {
                Label5.Visible = true;
                Label5.Text = "ERROR";
            }

            finally { Reader.Close(); }

        

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (SqlCon != null && SqlCon.State != ConnectionState.Closed)
            SqlCon.Close();
        
        Server.Transfer("default.aspx", true);
   
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

        if (Session["New"] != null)
        {
            Response.Redirect("User.aspx");
        }
    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(Helper.CnnVal("FinnDB"));

        conn.Open();
        string checkuser = "select count(*) from UserAccountData where UserName='" + UserNameInputText.Text + "'";
        SqlCommand comm = new SqlCommand(checkuser, conn);
        int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
        conn.Close();
        if (temp == 1)
        {
            conn.Open();
            string checkpassword = "select password from UserAccountData where UserName= '" + UserNameInputText.Text + "'";
            SqlCommand passComm = new SqlCommand(checkpassword, conn);
            string password = passComm.ExecuteScalar().ToString().Replace(" ", "");
            if (password == PasswordInputText.Text)
            {
                Session["New"] = UserNameInputText.Text;
                Response.Write("Password is correct");
                Response.Redirect("User.aspx");
            }
            else
            {
                Response.Write("Password is not correct");
            }
            conn.Close();
        }
        else
        {
            Response.Write("User Name is not correct");
        }
    }
}
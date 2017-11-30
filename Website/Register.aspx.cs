using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

        if (Session["New"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            if (IsPostBack)
            {
                SqlConnection conn = new SqlConnection(Helper.CnnVal("FinnDB"));

                conn.Open();
                string checkuser = "select count(*) from UserAccountData where UserName='" + UserNameText.Text + "'";
                SqlCommand comm = new SqlCommand(checkuser, conn);
                int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
                if (temp == 1)
                {
                    Response.Write("User Name already in use");
                }
                conn.Close();
            }
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection conn = new SqlConnection(Helper.CnnVal("FinnDB"));

            conn.Open();
            string insertQuery = "insert into UserAccountData (UserName,EMail,Country,Password) values (@username ,@email ,@country ,@password)";
            SqlCommand comm = new SqlCommand(insertQuery, conn);
            comm.Parameters.AddWithValue("@username", UserNameText.Text);
            comm.Parameters.AddWithValue("@email", EMailText.Text);
            comm.Parameters.AddWithValue("@country", CountryDropDown.SelectedItem.ToString());
            comm.Parameters.AddWithValue("@password", PasswordText.Text);

            comm.ExecuteNonQuery();
            Response.Write("Registration is succsessful!");
            Response.Redirect("User.aspx");

            conn.Close();
        }
        catch (Exception ex)
        {
            Response.Write("Error:" + ex.ToString());
        }
    }
}
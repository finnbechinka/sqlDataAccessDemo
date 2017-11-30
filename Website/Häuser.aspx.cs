using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Häuser : System.Web.UI.Page
{

    List<Haus> häuser = new List<Haus>();

    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

        if (Session["New"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            UpdateBinding();
        }
    }

    private void UpdateBinding()
    {
        HäuserFoundListBox.DataSource = häuser;
        HäuserFoundListBox.DataTextField = "FullInfo";
        HäuserFoundListBox.DataValueField = "FullInfo";
        HäuserFoundListBox.DataBind();
    }

    protected void HäuserSearchButton_Click(object sender, EventArgs e)
    {
        DataAccess db = new DataAccess();

        häuser = db.GetHäuser(BezeichnungText.Text);

        UpdateBinding();
    }

    protected void InsertRecordButton0_Click1(object sender, EventArgs e)
    {
        DataAccess db = new DataAccess();

        db.InsertHaus(bezeichnungInsText.Text, adresseInsText.Text, hausmeisterTelInsText.Text);

        bezeichnungInsText.Text = "";
        adresseInsText.Text = "";
        hausmeisterTelInsText.Text = "";
    }

    protected void UpdateButton0_Click1(object sender, EventArgs e)
    {
        if (hausIDText.Text != "")
        {
            DataAccess db = new DataAccess();

            db.UpdateHaus(hausIDText.Text, bezeichnungInsText.Text, adresseInsText.Text, hausmeisterTelInsText.Text);
        }
    }

    protected void DeleteButton0_Click(object sender, EventArgs e)
    {
        if (hausIDText.Text != "")
        {
            DataAccess db = new DataAccess();

            db.DeleteHaus(hausIDText.Text);
        }
    }

}
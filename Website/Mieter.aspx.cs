using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Mieter : System.Web.UI.Page
{

    List<cMieter> mieter = new List<cMieter>();

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
        MieterFoundListBox.DataSource = mieter;
        MieterFoundListBox.DataTextField = "FullInfoMieter";
        MieterFoundListBox.DataValueField = "FullInfoMieter";
        MieterFoundListBox.DataBind();
    }

    protected void MieterSearch_Click(object sender, EventArgs e)
    {
        DataAccess db = new DataAccess();

        mieter = db.GetMieter(NachnameText.Text);

        UpdateBinding();
    }

    protected void MieterInsertRecordButton_Click(object sender, EventArgs e)
    {
        DataAccess db = new DataAccess();

        db.InsertMieter(NachnameInsText.Text, VornameInsText.Text, TelInsText.Text, WohnungsIDInsText.Text);

        NachnameInsText.Text = "";
        VornameInsText.Text = "";
        TelInsText.Text = "";
        WohnungsIDInsText.Text = "";
    }

    protected void MieterUpdateButton_Click(object sender, EventArgs e)
    {
        if (MieterIDText.Text != "")
        {
            DataAccess db = new DataAccess();

            db.UpdateMieter(MieterIDText.Text, NachnameInsText.Text, VornameInsText.Text, TelInsText.Text, WohnungsIDInsText.Text);
        }
    }

    protected void MieterDeleteButton_Click(object sender, EventArgs e)
    {
        DataAccess db = new DataAccess();

        db.DeleteMieter(MieterIDText.Text);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Wohnungen : System.Web.UI.Page
{

    List<Wohnung> wohnungen = new List<Wohnung>();

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
        WohnungenFoundListBox.DataSource = wohnungen;
        WohnungenFoundListBox.DataTextField = "FullInfoWohnung";
        WohnungenFoundListBox.DataValueField = "FullInfoWohnung";
        WohnungenFoundListBox.DataBind();
    }

    protected void WohnSearchButton_Click(object sender, EventArgs e)
    {
        DataAccess db = new DataAccess();

        wohnungen = db.GetWohnung(WohnHausIDText.Text);

        UpdateBinding();
    }

    protected void WohnInsertButton_Click(object sender, EventArgs e)
    {
            DataAccess db = new DataAccess();

            db.InsertWohnung(WohnHausIDInsText.Text, StockwerkInsText.Text, GrößeInsText.Text);

            WohnHausIDInsText.Text = "";
            StockwerkInsText.Text = "";
            GrößeInsText.Text = "";
    }

    protected void WohnUpdateButton_Click(object sender, EventArgs e)
    {
        if (WohnWohnungsIDText.Text != "")
        {
            DataAccess db = new DataAccess();

            db.UpdateWohnung(WohnWohnungsIDText.Text, WohnHausIDInsText.Text, StockwerkInsText.Text, GrößeInsText.Text);
        }
    }

    protected void WohnDeleteButton_Click(object sender, EventArgs e)
    {
        DataAccess db = new DataAccess();

        db.DeletWohnung(WohnWohnungsIDText.Text);
    }
        
}
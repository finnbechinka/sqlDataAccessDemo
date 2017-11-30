using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dashboard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

        if (Session["New"] == null)
        {
            Response.Redirect("Login.aspx");
        }
    }

    protected void buttonMieter_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mieter.aspx");
    }

    protected void buttonWohnunegn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Wohnungen.aspx");
    }

    protected void buttonHäuser_Click(object sender, EventArgs e)
    {
        Response.Redirect("Häuser.aspx");
    }
}
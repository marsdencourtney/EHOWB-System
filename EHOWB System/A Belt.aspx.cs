using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class A_Belt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayBelts();
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

    }

    //function for ddl
    void DisplayBelts()
    {
        //class instance
        ClassLibrary.clsBeltCollection Belts = new ClassLibrary.clsBeltCollection();
        //data source
        ddlBeltName.DataSource = Belts.AllBelts;
        //set PK
        ddlBeltName.DataValueField = "BeltNo";
        //set data field
        ddlBeltName.DataTextField = "BeltName";
        //bind data
        ddlBeltName.DataBind();
    }
}
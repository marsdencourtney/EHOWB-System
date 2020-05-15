using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class ACustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //create an instance of the code
        ClassLibrary.clsCustomer ACustomer = new ClassLibrary.clsCustomer();
        //var for errors
        string Error;
        //declare vars
        string CustomerFirstName;
        string CustomerLastName;
        string CustomerEmail;
        string CustomerPostcode;
        string CustomerTelNo;
        //read inputs
        CustomerFirstName = txtCustomerFirstName.Text;
        CustomerLastName = txtCustomerLastName.Text;
        CustomerEmail = txtCustomerEmail.Text;
        CustomerPostcode = txtCustomerPostcode.Text;
        CustomerTelNo = txtCustomerTelNo.Text;
        //validate data
        Error = ACustomer.CustomerValidated(CustomerFirstName, CustomerLastName, CustomerEmail, CustomerPostcode, CustomerTelNo);
        //display error
        lblError.Text = Error;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationsPrj
{
    public partial class VTestForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void cvAge_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int age;
            if (int.TryParse(args.Value, out age) && age >= 18)
                args.IsValid = true;
            else
                args.IsValid = false;
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblMsg.Text = "Validation Successful";
                lblMsg.ForeColor = System.Drawing.Color.Green;
                ClientScript.RegisterStartupScript(
                    this.GetType(),
                    "success",
                    "alert('Validation Successful');",
                    true);
            }
            else
            {
                lblMsg.Text = "Validation Failed";
                lblMsg.ForeColor = System.Drawing.Color.Red;
                ClientScript.RegisterStartupScript(
                    this.GetType(),
                    "fail",
                    "alert('Validation Failed');",
                    true);
            }
        }
    }
}
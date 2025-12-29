using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssignmentDec25
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ddlProducts.SelectedItem.Text)
            {
                case "bag":
                    imgProduct.ImageUrl = "~/Images/bag.jpg";
                    break;

                case "headphs":
                    imgProduct.ImageUrl = "~/Images/headphs.jpg";
                    break;

                case "bottle":
                    imgProduct.ImageUrl = "~/Images/imagesBottle.jpg";
                    break;

                default:
                    imgProduct.ImageUrl = "";
                    lblPrice.Text = "";
                    break;
            }
        }

        protected void btnPrice_Click(object sender, EventArgs e)
        {
            if (ddlProducts.SelectedIndex > 0)
            {
                lblPrice.Text = "Price : ₹ " + ddlProducts.SelectedValue;
            }
            else
            {
                lblPrice.Text = "select a product";
            }
        }
    }
}
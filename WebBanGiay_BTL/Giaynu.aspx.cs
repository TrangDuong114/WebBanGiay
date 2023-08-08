using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBanGiay_BTL
{
    public partial class Giaynu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                login.InnerHtml = "<p class='user'>Xin chào " + Session["username"].ToString() + " | " + "</p>" +
                                  "<a href = 'Dangxuat.aspx'> Đăng xuất </a>";

            }
            List<Product> ProductList = (List<Product>)Application["productList"];
            List<Product> giaynu = new List<Product>();
            foreach (Product product in ProductList)
            {
                string id = product.Id;
                if (id == "2" || id == "3" || id == "7" || id == "8" || id == "9" || id == "11")
                {
                    giaynu.Add(product);
                }
            }
            giaynu1.DataSource = giaynu;
            giaynu1.DataBind();
        }
    }
}
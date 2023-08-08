using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBanGiay_BTL
{
    public partial class Giaynam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                login.InnerHtml = "<p class='user'>Xin chào " + Session["username"].ToString() + " | " + "</p>" +
                                  "<a href = 'Dangxuat.aspx'> Đăng xuất </a>";

            }
            List<Product> ProductList = (List<Product>)Application["productList"];
            List<Product> giaynam = new List<Product>();
            foreach (Product product in ProductList)
            {
                string id = product.Id;
                if (id == "1" || id == "4" || id == "5" || id == "6" || id == "10" || id == "12" )
                {
                    giaynam.Add(product);
                }
            }
            giaynam1.DataSource = giaynam;
           giaynam1.DataBind();
        }
    }
}
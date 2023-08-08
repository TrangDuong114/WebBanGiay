using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebBanGiay_BTL
{
    public class Global : System.Web.HttpApplication
    {
        
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Users"] = new List<NguoiDung>();
            List<NguoiDung> Users = (List<NguoiDung>)Application["Users"];
            //tk mặc định
            

            Application["ProductList"] = new List<Product>();
            List<Product> ProductList = new List<Product>();
            //Sản phẩm bán chạy
            ProductList.Add(new Product() { Id = "1", Images = "../images/sp1.png", Name = "Giày Fila nam", Price = "500000", Detail = "Mẫu giày được thiết kế với phong cách chunky sneaker đầy nổi bật.Phần upper được làm bằng da cao cấp mang đến sự mềm mại cho đôi chân.Lớp đệm midsole Eva siêu nhẹ giúp đôi chân dễ chịu suốt cả ngày.Đế ngoài bằng cao su đúc chống trượt tạo cảm giác linh hoạt khi di chuyển.Là mẫu giày sneaker độc đáo không thể bỏ qua trong phongcách thời trang của bạn." });
            ProductList.Add(new Product() { Id = "2", Images = "../images/sp2.png", Name = "Giày Converse nữ", Price = "750000", Detail = "Mẫu giày được thiết kế với phong cách chunky sneaker đầy nổi bật.Phần upper được làm bằng da cao cấp mang đến sự mềm mại cho đôi chân.Lớp đệm midsole Eva siêu nhẹ giúp đôi chân dễ chịu suốt cả ngày.Đế ngoài bằng cao su đúc chống trượt tạo cảm giác linh hoạt khi di chuyển.Là mẫu giày sneaker độc đáo không thể bỏ qua trong phongcách thời trang của bạn." });
            ProductList.Add(new Product() { Id = "3", Images = "../images/sp3.png", Name = "Giày Converse nữ", Price = "1500000", Detail = "Mẫu giày được thiết kế với phong cách chunky sneaker đầy nổi bật.Phần upper được làm bằng da cao cấp mang đến sự mềm mại cho đôi chân.Lớp đệm midsole Eva siêu nhẹ giúp đôi chân dễ chịu suốt cả ngày.Đế ngoài bằng cao su đúc chống trượt tạo cảm giác linh hoạt khi di chuyển.Là mẫu giày sneaker độc đáo không thể bỏ qua trong phongcách thời trang của bạn." });
            ProductList.Add(new Product() { Id = "4", Images = "../images/sp4.png", Name = "Giày Puma nam", Price = "350000", Detail = "Mẫu giày được thiết kế với phong cách chunky sneaker đầy nổi bật.Phần upper được làm bằng da cao cấp mang đến sự mềm mại cho đôi chân.Lớp đệm midsole Eva siêu nhẹ giúp đôi chân dễ chịu suốt cả ngày.Đế ngoài bằng cao su đúc chống trượt tạo cảm giác linh hoạt khi di chuyển.Là mẫu giày sneaker độc đáo không thể bỏ qua trong phongcách thời trang của bạn." });
            //
            ProductList.Add(new Product() { Id = "5", Images = "../images/sp5.png", Name = "Giày Nike nam", Price = "1500000", Detail = "Mẫu giày được thiết kế với phong cách chunky sneaker đầy nổi bật.Phần upper được làm bằng da cao cấp mang đến sự mềm mại cho đôi chân.Lớp đệm midsole Eva siêu nhẹ giúp đôi chân dễ chịu suốt cả ngày.Đế ngoài bằng cao su đúc chống trượt tạo cảm giác linh hoạt khi di chuyển.Là mẫu giày sneaker độc đáo không thể bỏ qua trong phongcách thời trang của bạn." });
            ProductList.Add(new Product() { Id = "6", Images = "../images/sp6.png", Name = "Giày Nike nam", Price = "1000000", Detail = "Mẫu giày được thiết kế với phong cách chunky sneaker đầy nổi bật.Phần upper được làm bằng da cao cấp mang đến sự mềm mại cho đôi chân.Lớp đệm midsole Eva siêu nhẹ giúp đôi chân dễ chịu suốt cả ngày.Đế ngoài bằng cao su đúc chống trượt tạo cảm giác linh hoạt khi di chuyển.Là mẫu giày sneaker độc đáo không thể bỏ qua trong phongcách thời trang của bạn." });
            ProductList.Add(new Product() { Id = "7", Images = "../images/sp7.png", Name = "Giày Nike nữ", Price = "800000", Detail = "Mẫu giày được thiết kế với phong cách chunky sneaker đầy nổi bật.Phần upper được làm bằng da cao cấp mang đến sự mềm mại cho đôi chân.Lớp đệm midsole Eva siêu nhẹ giúp đôi chân dễ chịu suốt cả ngày.Đế ngoài bằng cao su đúc chống trượt tạo cảm giác linh hoạt khi di chuyển.Là mẫu giày sneaker độc đáo không thể bỏ qua trong phongcách thời trang của bạn." });
            ProductList.Add(new Product() { Id = "8", Images = "../images/sp8.png", Name = "Giày Gucci nữ", Price = "3500000", Detail = "Mẫu giày được thiết kế với phong cách chunky sneaker đầy nổi bật.Phần upper được làm bằng da cao cấp mang đến sự mềm mại cho đôi chân.Lớp đệm midsole Eva siêu nhẹ giúp đôi chân dễ chịu suốt cả ngày.Đế ngoài bằng cao su đúc chống trượt tạo cảm giác linh hoạt khi di chuyển.Là mẫu giày sneaker độc đáo không thể bỏ qua trong phongcách thời trang của bạn." });
            //
            ProductList.Add(new Product() { Id = "9", Images = "../images/sp9.png", Name = "Giày Adidas nữ", Price = "1000000", Detail = "Mẫu giày được thiết kế với phong cách chunky sneaker đầy nổi bật.Phần upper được làm bằng da cao cấp mang đến sự mềm mại cho đôi chân.Lớp đệm midsole Eva siêu nhẹ giúp đôi chân dễ chịu suốt cả ngày.Đế ngoài bằng cao su đúc chống trượt tạo cảm giác linh hoạt khi di chuyển.Là mẫu giày sneaker độc đáo không thể bỏ qua trong phongcách thời trang của bạn." });
            ProductList.Add(new Product() { Id = "10", Images = "../images/sp10.png", Name = "Giày Adidas nam", Price = "2500000", Detail = "Mẫu giày được thiết kế với phong cách chunky sneaker đầy nổi bật.Phần upper được làm bằng da cao cấp mang đến sự mềm mại cho đôi chân.Lớp đệm midsole Eva siêu nhẹ giúp đôi chân dễ chịu suốt cả ngày.Đế ngoài bằng cao su đúc chống trượt tạo cảm giác linh hoạt khi di chuyển.Là mẫu giày sneaker độc đáo không thể bỏ qua trong phongcách thời trang của bạn." });
            ProductList.Add(new Product() { Id = "11", Images = "../images/sp11.png", Name = "Giày Vans nữ", Price = "650000", Detail = "Mẫu giày được thiết kế với phong cách chunky sneaker đầy nổi bật.Phần upper được làm bằng da cao cấp mang đến sự mềm mại cho đôi chân.Lớp đệm midsole Eva siêu nhẹ giúp đôi chân dễ chịu suốt cả ngày.Đế ngoài bằng cao su đúc chống trượt tạo cảm giác linh hoạt khi di chuyển.Là mẫu giày sneaker độc đáo không thể bỏ qua trong phongcách thời trang của bạn." });
            ProductList.Add(new Product() { Id = "12", Images = "../images/sp12.png", Name = "Giày Nike nam", Price = "550000", Detail = "Mẫu giày được thiết kế với phong cách chunky sneaker đầy nổi bật.Phần upper được làm bằng da cao cấp mang đến sự mềm mại cho đôi chân.Lớp đệm midsole Eva siêu nhẹ giúp đôi chân dễ chịu suốt cả ngày.Đế ngoài bằng cao su đúc chống trượt tạo cảm giác linh hoạt khi di chuyển.Là mẫu giày sneaker độc đáo không thể bỏ qua trong phongcách thời trang của bạn." });

            Application["ProductList"] = ProductList;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["login"] = 0;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}
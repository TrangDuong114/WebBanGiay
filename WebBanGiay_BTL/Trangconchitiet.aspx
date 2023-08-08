<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trangconchitiet.aspx.cs" Inherits="WebBanGiay_BTL.Trangconchitiet" %>

<!DOCTYPE aspx>

<aspx xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
	<meta charset="utf-8">
	<link rel="stylesheet" href="Style/Trangconchitiet.css">
	<link rel="stylesheet" href="Style/HDvsFT.css">
	<link rel="stylesheet" href="Style/Trangchu.css">
    <title>Giày</title>
</head>
<body>
	<form id="form1" runat="server">
   <div class="header">
		<div class="header_top" id="header-top">
			<p>Định Công, Hoàng Mai, Hà Nội</p>
			<div id="login" class="login" runat="server">
				<p class="user"></p>
				<a href="Dangnhap.aspx" title="Đăng nhập">Đăng nhập</a>
			</div>
		</div>
		<div class="header_mid">
			<a href="Trangchu.aspx">
				<img width="150" height="150" src="images/logo.png" title="Đồng Hồ">
			</a>
			<input type="text" name="timkiem" id="timkiem" value="" />
			<input type="submit" name="btn" id="btn" value="Tìm kiếm" />

		</div>
		<div class="header_bot" id="header-bot">
			<ul>
				<li><a href="Trangchu.aspx">Trang chủ</a></li>
				<li><a href="Gioithieu.aspx">Giới thiệu</a></li>
				<li><a href="Giaynam.aspx">Giày nam</a></li>
				<li><a href="Giaynu.aspx">Giày nữ</a></li>
				<li><a href="Lienhe.aspx">Liên hệ</a></li>
				<li><a href="Giohang.aspx">Giỏ hàng</a></li>
				<a href="javascript:void(0);" style="font-size:35px;" class="icon" onclick="responsive() ">&#9776;</a>
			</ul>
		</div>
	</div>
	<div>
	<div class="main">
		<asp:ListView ID="ListViewProductinformation" runat="server" >
			<ItemTemplate>
				<div class="anh">
					<img src="<%# Eval("Images") %>" title="ảnh giày">
				</div>

				<div class="content">
					
					<h1 class="header-content"><%# Eval("Name") %></h1>
					<hr width="20px" />
					<p style="font-size:45px;color: #C89979;   " class="header-content"><b><%# Eval("Price") %> đồng</b></p>
					<p class="header-content"><%# Eval("Detail") %>
					</p>
					<ul class="header-content">
						<li>Tình trạng: Đang còn hàng</li>
						<li>Bảo hành và đổi trả: 1 tháng</li>
					</ul>
				</ItemTemplate>
		</asp:ListView>
		<div class="submit">
			<p class="Themgio" name="Themgio" runat="server" id="Themgio" style="color:red"></p>
			<button type="submit" class="themvaogio" runat="server" ID="AddToCartButton1" onserverclick="AddToCartButton" >Thêm vào giỏ hàng</button>
		</div>
		</div>
		</div>
		<hr />
		<h2 class="h2">Sản phẩm phổ biến</h2>
	<div class="sanpham2">
			<asp:ListView ID="sanphamphobien" runat="server">
				<ItemTemplate>
					<div class="sanphamphobien">
					<a href="Trangconchitiet.aspx?id=<%# Eval("Id") %>">
						<img id="anh1" width="270" height="270" src="<%# Eval("Images") %>" title="Giày">
						<div class="sanphamphobien_gia" id="sanpham2">
							<strong id="ten1"><%# Eval("Name") %></strong>
							<p id="gia1"><%# Eval("Price") %> đồng</p>
						</div>
					</a>
					</div>
				</ItemTemplate>
			</asp:ListView>
	</div>

		<div class="footter">
			<div class="footter_top">
				<div class="Thongtinlienhe">
					<h1>Thông Tin Liên Hệ</h1>
					<p>Địa chỉ: Định Công, Hoàng Mai, Hà Nội </p>
					<p>SĐT: 1910192092</p>
					<p>Gmail: abc1234@gmail.com</p>
				</div>
				<div class="Lienket">
					<h1>Liên Kết</h1>
					<ul>
						<li><a href="gioithieu.aspx">Giới thiệu</a></li>
						<li><a href="donghonam.aspx">Đồng hồ nam</a></li>
						<li><a href="donghonu.aspx">Đồng hồ nữ</a></li>
						<li><a href="Lienhe.aspx">Liên hệ</a></li>
					</ul>
				</div>
				<div class="Lienket">
					<h1>Hỗ Trợ</h1>
					<ul>
						<li><a href="#">Hướng dẫn mua hàng</a></li>
						<li><a href="#">Hướng dẫn thanh toán</a></li>
						<li><a href="#">Chính sách bảo hành</a></li>
						<li><a href="#">Chính sách đổi trả</a></li>
						<li><a href="#">Tư vấn khách hàng</a></li>
					</ul>
				</div>
			</div>
			<div class="footter_bot">
				<div class="copyright">
					© Khoa công nghê thông tin - Đại học Mở Hà Nội
				</div>
			</div>

		</div>
		</form>
	
</body>
</aspx>

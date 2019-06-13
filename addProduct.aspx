<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addProduct.aspx.cs" Inherits="WebApplication7.addProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title></title><link rel="stylesheet" type="text/css" href="Stylesheet1.css" />

    
    <style type="text/css" id="newStyle2">

        body {
    margin: 0;
}

ul {
    list-style-type: none;
    margin: 0;
    padding: 0;
    position: fixed;
    top: 0;
    width: 100%;
    overflow: hidden;
    background-color: #ECAA36;
    height: 60px;
}

li {
    float: left;
    border-right: 1px solid #bbb;
}

    li:last-child {
        border-right: none;
    }

    li a {
        display: block;
        color: white;
        text-align: center;
        padding: 14px 16px;
        text-decoration: none;
    }

        li a:hover:not(.active) {
            background-color: #111;
        }


.active {
    background-color: #4CAF50;
}

        #form1 {
            height: 611px;
            width: 952px;
        }

    </style> 
</head>
<body class="newStyle3">

    <form id="form1" runat="server">
               <ul>
                <li><asp:LinkButton ID="LinkButton5" runat="server" Font-Bold="True" Font-Size="Large" Height="18px" Width="47px">Home</asp:LinkButton> </li>
  <li><asp:LinkButton ID="LinkButton3" runat="server" Font-Bold="True" Font-Size="Large">Brands</asp:LinkButton>
      </li>
  <li><asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="True" Font-Size="Large">Products</asp:LinkButton>
      </li>
  <li style="float:right"><asp:LinkButton ID="LinkButton4" runat="server" Font-Bold="True" Font-Size="Large">Logout</asp:LinkButton>
      </li>
                
</ul>
               <br />
               <br />
               <br />
               <br />
               <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:newPConnectionString %>" SelectCommand="SELECT [brandName] FROM [brandList]"></asp:SqlDataSource>
               <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
               <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Label ID="Label1" runat="server" Text="Add Product" Font-Bold="True"></asp:Label>
               <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Label ID="Label2" runat="server" Text="Brand Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" DataSourceID="SqlDataSource1" DataTextField="brandName" DataValueField="brandName">
               </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Label ID="Label4" runat="server" Text="Product Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
               &nbsp;
               &nbsp;&nbsp;&nbsp;
               <br />
               <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Label ID="Label3" runat="server" Text="Product ID"></asp:Label>
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Label ID="Label6" runat="server" Text="Sales Price"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Label ID="Label7" runat="server" Text="Available Quantity"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:DropDownList ID="DropDownList1" runat="server">
                   <asp:ListItem>1</asp:ListItem>
                   <asp:ListItem>2</asp:ListItem>
                   <asp:ListItem>3</asp:ListItem>
                   <asp:ListItem>4</asp:ListItem>
                   <asp:ListItem>5</asp:ListItem>
                   <asp:ListItem>10</asp:ListItem>
                   <asp:ListItem>15</asp:ListItem>
                   <asp:ListItem>20</asp:ListItem>
                   <asp:ListItem>25</asp:ListItem>
                   <asp:ListItem>30</asp:ListItem>
                   <asp:ListItem>35</asp:ListItem>
                   <asp:ListItem>40</asp:ListItem>
                   <asp:ListItem>45</asp:ListItem>
                   <asp:ListItem>50</asp:ListItem>
               </asp:DropDownList>
               <br />
               <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <br />
               <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" style="z-index: 1; left: 251px; top: 390px; position: absolute; height: 174px; width: 602px">
                   <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                   <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                   <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                   <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                   <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                   <SortedAscendingCellStyle BackColor="#FFF1D4" />
                   <SortedAscendingHeaderStyle BackColor="#B95C30" />
                   <SortedDescendingCellStyle BackColor="#F1E5CE" />
                   <SortedDescendingHeaderStyle BackColor="#93451F" />
               </asp:GridView>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editbrand.aspx.cs" Inherits="WebApplication7.editbrand" %>

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

    <form id="form1" runat="server" style="margin-left:0px; width: 989px; height: 638px;">
               <ul>
                <li><asp:LinkButton ID="LinkButton5" runat="server" Font-Bold="True" Font-Size="Large" Height="18px" Width="47px" OnClick="LinkButton5_Click">Home</asp:LinkButton> </li>
  <li><asp:LinkButton ID="LinkButton3" runat="server" Font-Bold="True" Font-Size="Large" OnClick="LinkButton3_Click">Brands</asp:LinkButton>
      </li>
  <li><asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="True" Font-Size="Large" OnClick="LinkButton2_Click">Products</asp:LinkButton>
      </li>
  <li style="float:right"><asp:LinkButton ID="LinkButton4" runat="server" Font-Bold="True" Font-Size="Large" OnClick="LinkButton4_Click" Width="55px">Logout</asp:LinkButton>
      </li>
                
</ul>
               <br />
               <br />
               <br />
               <br />
               <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Label ID="Label1" runat="server" Text="Edit Brand" Font-Bold="True"></asp:Label>
               <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Label ID="Label2" runat="server" Text="Brand Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
               <br />
               <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Label ID="Label3" runat="server" Text=" Brand ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
               <br />
               <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="update" />
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="cancel" />
               <br />
               <br />
               <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" Width="969px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Height="176px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" >
            <%-- Theme Properties --%>
            <Columns>
                <asp:TemplateField HeaderText="Brand ID">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("brandID") %>'  runat="server" />
                          </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtBrandID0" Text='<%# Eval("brandID") %>' runat="server" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtFBrandIDFooter0" Text='<%# Eval("brandID") %>' runat="server" />
                    </FooterTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Brand Name">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("brandName") %>'  runat="server" />
                          </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtBrandName0" Text='<%# Eval("brandName") %>' runat="server" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtBrandNameFooter0" Text='<%# Eval("brandName") %>' runat="server" />
                    </FooterTemplate>
                </asp:TemplateField>

                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ImageUrl="~/image/edit.png" runat="server" CommandName="Edit" ToolTip="Edit" Width="20px" Height="20px" />
                        <asp:ImageButton ImageUrl="~/image/delete.png" runat="server" CommandName="Delete" ToolTip="Delete" Width="20px" Height="20px" />
                        </ItemTemplate>
                    <EditItemTemplate>
                         <asp:ImageButton ImageUrl="~/image/save.png" runat="server" CommandName="Update" ToolTip="Update" Width="20px" Height="20px" />
                        <asp:ImageButton ImageUrl="~/image/cancel.png" runat="server" CommandName="Cancel" ToolTip="Cancel" Width="20px" Height="20px" />
                        </EditItemTemplate>
                    <FooterTemplate>
                    </FooterTemplate>
                </asp:TemplateField>
            </Columns>
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

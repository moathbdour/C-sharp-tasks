<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="test5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 633px; height: 365px">
    <form id="form1" runat="server">
       <%-- <br >
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" Height="69px" Width="118px" />
        <br >
            <asp:Label runat="server" Text="Label"></asp:Label>
        <br >--%>
       <table>
           <tr>
               <td> first     Number    : </td>
               <td> <input type="text" id="txtName" runat="server" name="Name" value="" /></td>
           </tr>
           <tr>
               <td>Secound Number:</td>
               <td> <input type="text" id="txtEmail" runat="server" value="" /></td>
           </tr>
           <tr>
               <td> <asp:Button Text="Devide Them" runat="server" OnClick="Submit" /></td>
               <td>
                   <asp:Button ID="Button1" runat="server" Text="Multiply Them" OnClick="Button1_Click" />
               </td>
                <td>
                   <asp:Button ID="Button2" runat="server" Text="Add Them" OnClick="Button2_Click" />
               </td>
                <td>
                   <asp:Button ID="Button3" runat="server" Text="Subtract Them" OnClick="Button3_Click" />
               </td>
               
               <tr>
                   <td> <asp:Label ID="Label2" runat="server" Text="The Answer is :"></asp:Label></td>
                   <td>
                       <asp:Label ID="Label1" runat="server" Text="answer"></asp:Label></td>
               </tr>
               
           </tr>
             
   
   
  
           </table>
         
    </form>
   

</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="DemoMVP.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Demo (Model-View-Presenter)</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Demo Model-View-Presenter</h2>
        <hr />

        <div>
           <table>
               <tr>
                   <th colspan="2">Calculate the area of a circle</th>
               </tr>
               <tr>
                   <td>Set the radius:</td>
                   <td>
                       <asp:TextBox ID="txtRadius" runat="server"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                 <td>Result:</td>
                 <td><asp:Label ID="lblArea" runat="server" ForeColor="red"></asp:Label></td>
               </tr>
               <tr align="right">
                   <td colspan="2">
                       <asp:Button ID="btnResultado" runat="server" Text="Value of the Area" OnClick="btnResult_Click" />
                   </td>
               </tr>
           </table>
        </div>
    </form>
</body>
</html>

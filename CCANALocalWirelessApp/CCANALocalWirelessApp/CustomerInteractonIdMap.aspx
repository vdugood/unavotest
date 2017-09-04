<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerInteractonIdMap.aspx.cs"
    Inherits="CCANALocalWirelessApp.CustomerInteractonIdMap" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblInteractionId" runat="server" Text="Interaction Id:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblInteractionIdValue" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblToNumber" runat="server" Text="To:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblToNumberValue" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMDN" runat="server" Text="Enter MDN:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMDN" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblLOA" runat="server" Text="LOA?:"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="chkLOA"  runat="server" />

                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:RequiredFieldValidator ID="reqCustomerAccount" ForeColor="Red" ControlToValidate="txtMDN" runat="server" ErrorMessage="MDN/Comments is required."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblErorMessage" runat="server" ForeColor="Red" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="right">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                        onclick="btnSubmit_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Collection.aspx.cs" Inherits="Collection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style18 {
            width: 98px;
        }
        .auto-style19 {
            width: 120px;
        }
        .auto-style20 {
            width: 152px;
        }
        .auto-style21 {
            width: 137px;
        }
        .auto-style22 {
            width: 98px;
            height: 202px;
            top: 0px;
        }
        .auto-style23 {
            width: 120px;
            height: 202px;
            top: 0px;
        }
        .auto-style24 {
            width: 152px;
            height: 202px;
            top: 0px;
        }
        .auto-style25 {
            width: 137px;
            height: 202px;
            top: 0px;
        }
        .auto-style26 {
            height: 202px;
            top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;Best Overview On Data Structure:&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <table border="1" style="padding: 0px; border: 1px solid #0000FF; width: 121%; font-family: tahoma; clip: rect(0px, auto, auto, auto); height: 613px;">
            <tr>
                <td class="auto-style18">
    
        <asp:Button ID="btn_Array" runat="server" OnClick="btn_Array_Click" Text="Array" Width="84px" />
                </td>
                <td class="auto-style19">
        <asp:Button ID="btn_ArrayList" runat="server" OnClick="btn_ArrayList_Click" Text="Array List" Width="86px" />
                </td>
                <td class="auto-style21"><asp:Button ID="btn_ArrayListObject" runat="server" OnClick="btn_ArrayListObject_Click" Text="Array List , Class" />
                </td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style21">
        <asp:Button ID="btn_HashTable" runat="server" Text="HashTable" OnClick="btn_HashTable_Click" />
                </td>
                <td>
        <asp:Button ID="btn_StackPush" runat="server" Text="Stack Push"  Width="94px" OnClick="btn_StackPush_Click"  />
                    <br />
        <asp:Button ID="btn_StackPop" runat="server" Text="Stack Pop"  Width="92px" OnClick="btn_StackPop_Click"  />
                </td>
                <td>
        <asp:Button ID="btn_Queue" runat="server" Text="Queue Enqueue" OnClick="btn_Queue_Click" />
                    <br />
        <asp:Button ID="btn_DeQueue" runat="server" Text="Queue Dequeue" OnClick="btn_DeQueue_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style22" style="border-spacing: 0px; vertical-align: top;"><br />
        <asp:ListBox ID="ListBoxArray" runat="server" Height="147px" Width="71px"></asp:ListBox>
                </td>
                <td class="auto-style23" style="border-spacing: 0px; vertical-align: top;"><br />
        <asp:ListBox ID="ListBoxArrayList" runat="server" Height="130px" Width="81px"></asp:ListBox>
    
                    <br />
    
                    <asp:Label ID="lblArrayList" runat="server"></asp:Label>
    
                </td>
                <td class="auto-style25" style="border-spacing: 0px; vertical-align: top;">
                    <asp:DropDownList ID="DropDownListArrayListObject" runat="server" Height="16px" Width="102px">
                    </asp:DropDownList>
                    <br />
                    <asp:GridView ID="GridViewArrayListObject" runat="server" Height="112px" Width="70px">
                    </asp:GridView>
                </td>
                <td class="auto-style24" style="border-spacing: 0px; vertical-align: top;">
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
&nbsp;</td>
                <td class="auto-style24" style="border-spacing: 0px; vertical-align: top;">
                    </td>
                <td class="auto-style25" style="border-spacing: 0px; vertical-align: top;">
                    <asp:DropDownList ID="DropDownListHashTable" runat="server" Height="16px" Width="126px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style26" style="border-spacing: 0px; vertical-align: top;">
        <asp:ListBox ID="ListBoxStack" runat="server" Height="152px" Width="81px"></asp:ListBox>
    
                    <br />
    
                    <asp:Label ID="lblPop" runat="server"></asp:Label>
    
                </td>
                <td class="auto-style26" style="border-spacing: 0px; vertical-align: top;">
        <asp:ListBox ID="ListBoxQueue" runat="server" Height="154px" Width="81px"></asp:ListBox>
    
                    <br />
    
                    <asp:Label ID="lblQueue" runat="server"></asp:Label>
    
                </td>
            </tr>
            <tr>
                <td class="auto-style18">
        <asp:Button ID="btn_List" runat="server" Text="List" OnClick="btn_List_Click"  />
                </td>
                <td class="auto-style19">
        <asp:Button ID="btn_IList" runat="server" Text="IList" OnClick="btn_IList_Click" style="height: 26px" />
                </td>
                <td class="auto-style21">
        <asp:Button ID="btn_IEnumerable" runat="server"  Text="IEnumerable" OnClick="btn_IEnumerable_Click" />
                </td>
                <td class="auto-style20">
        <asp:Button ID="btn_IQueryable" runat="server" Text="IQueryable" OnClick="btn_IQueryable_Click" />
                </td>
                <td class="auto-style20">
        <asp:Button ID="btn_ICollection" runat="server" Text="ICollection" OnClick="btn_ICollection_Click" />
                </td>
                <td class="auto-style21">
                    <asp:Button ID="btn_Dictionary" runat="server" Text="Dictionary" OnClick="btn_Dictionary_Click" />
                </td>
                <td>
                    Generic<br />
        <asp:Button ID="btn_StackPushGeneric" runat="server" Text="Stack Push"  Width="94px" OnClick="btn_StackPushGeneric_Click"  />
        <asp:Button ID="btn_StackPopGeneric" runat="server" Text="Stack Pop"  Width="92px" OnClick="btn_StackPopGeneric_Click"  />
                </td>
                <td>
                    Generic<br />
        <asp:Button ID="btn_QueueGeneric" runat="server" Text="Queue Enqueue" OnClick="btn_QueueGeneric_Click" />
        <asp:Button ID="btn_DeQueueGeneric" runat="server" Text="Queue Dequeue" OnClick="btn_DeQueueGeneric_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style18" style="vertical-align: top">
        <asp:ListBox ID="ListBoxListGeneric" runat="server" Height="206px" Width="81px"></asp:ListBox>
    
                    <br />
    
                    <asp:Label ID="lblList" runat="server"></asp:Label>
    
                </td>
                <td class="auto-style19" style="vertical-align: top">
                    <br />
        <asp:ListBox ID="ListBoxIListGeneric" runat="server" Height="206px" Width="81px"></asp:ListBox>
    
                    <br />
    
                    <asp:Label ID="lblIList" runat="server"></asp:Label>
    
                </td>
                <td class="auto-style21" style="vertical-align: top">
    
                    <br />
    
                    <asp:GridView ID="GridViewIEnumerable" runat="server" Height="112px" Width="70px">
                    </asp:GridView>
                    <br />
    
                    <asp:Label ID="lblIEnumerable" runat="server"></asp:Label>
    
                </td>
                <td class="auto-style20" style="vertical-align: top">
        &nbsp;<asp:GridView ID="GridViewIQueryable" runat="server" Height="112px" Width="70px">
                    </asp:GridView>
                    <br />
    
                    <asp:Label ID="lblIQueryable" runat="server"></asp:Label>
    
                </td>
                <td class="auto-style20" style="vertical-align: top">
        <asp:ListBox ID="ListBoxICollection" runat="server" Height="206px" Width="81px"></asp:ListBox>
    
                    <asp:Label ID="lblICollection" runat="server"></asp:Label>
    
                </td>
                <td class="auto-style21" style="vertical-align: top">
                    <asp:DropDownList ID="DropDownListDictionary" runat="server" Height="16px" Width="126px">
                    </asp:DropDownList>
        <asp:ListBox ID="ListBoxDictionary" runat="server" Height="181px" Width="81px"></asp:ListBox>
    
                </td>
                <td style="vertical-align: top">
        <asp:ListBox ID="ListBoxStackGeneric" runat="server" Height="194px" Width="81px"></asp:ListBox>
    
                    <asp:Label ID="lblPopGeneric" runat="server"></asp:Label>
    
                </td>
                <td style="vertical-align: top">
        <asp:ListBox ID="ListBoxQueueGeneric" runat="server" Height="190px" Width="81px"></asp:ListBox>
    
                    <asp:Label ID="lblQueueGeneric" runat="server"></asp:Label>
    
                </td>
            </tr>
        </table>
        <br />
    
    </div>
    </form>
    </body>
</html>

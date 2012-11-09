<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="WebApplication1.User" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript" src="jquery-1.2.6.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       
    <%-- <script type="text/javascript">
         $(document).ready(function () {
             $("#btnTime").mouseover(function (event) {
                 $.ajax({
                     type: "post",
                     url: "TimeService.svc/GetTime",
                     data: "{}",
                     contentType: "application/json; charset=utf-8",
                     dataType: "json",
                     success: function (msg) {
                         ConsumeService(msg);
                     },
                     error: ServiceFailed
                 });
             });
         });
         function ConsumeService(result) {
             $("#sp").html(result.d);
         }
         function ServiceFailed(result) {
             alert(result.status + ' ' + result.statusText);
         }     

  </script>--%>     

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True">
        </asp:GridView>
 
<%--<input id="btnTime" value="Server Time" type="button"  /> --%> 
 <span id="sp"></span>
    </div>
    </form>
</body>
</html>

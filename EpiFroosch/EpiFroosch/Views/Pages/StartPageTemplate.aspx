<%@ Page Language="c#" Inherits="EpiFroosch.Views.Pages.StartPageTemplate" CodeBehind="StartPageTemplate.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"     "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server">
        <title>My Page Template</title>

    </head>
    <body>
        <form id="Form1" runat="server">
            <div>
                <EPiServer:Property ID="Property1" runat="server" PropertyName="MyPage" />

            </div>

        </form>

    </body>

</html>
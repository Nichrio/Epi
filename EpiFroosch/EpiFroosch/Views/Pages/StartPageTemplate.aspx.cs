using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web;
using EPiServer.Web.WebControls;
using EPiServer.Web.PropertyControls;


namespace EpiFroosch.Views.Pages
{
    [TemplateDescriptor(Path = "~/Views/Pages/StartPageTemplate.aspx")]
    public partial class StartPageTemplate : EPiServer.TemplatePage<StartPage>
    {
        protected void Page_Load(object sender, EventArgs e)
        { }
    }
}
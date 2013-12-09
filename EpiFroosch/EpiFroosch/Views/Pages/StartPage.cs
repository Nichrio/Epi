using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.BaseLibrary;


namespace EpiFroosch.Views.Pages
{
    [ContentType(DisplayName = "MyName")]
    public class StartPage : PageData
    {
        [Display(

            Name = "My name",

            Description = "",

            GroupName = SystemTabNames.Content,

            Order = 1)]

        public virtual string MyPage { get; set; }

    
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Landrys.ThePostOak_EpiServer.Models.Pages
{
    [ContentType(
        DisplayName = "ResortPage", 
        GUID = "aa1f2ba8-884d-44b7-a1bb-71dd72c78ce0", 
        Description = "")]
    public class ResortPage : PageData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         */
    }
}
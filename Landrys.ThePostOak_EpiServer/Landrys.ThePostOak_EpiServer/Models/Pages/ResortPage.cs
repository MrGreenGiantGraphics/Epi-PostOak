using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;
using Landrys.ThePostOak_EpiServer.Models.Blocks;

namespace Landrys.ThePostOak_EpiServer.Models.Pages
{
    [ContentType(
        GroupName = Global.GroupNames.Specialized,
        DisplayName = "ResortPage", 
        GUID = "aa1f2ba8-884d-44b7-a1bb-71dd72c78ce0",
        Description = "Resort Page Template")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Home.png")]
    public class ResortPage : SitePageData
    {

        [Display(Order = 100)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ImageA { get; set; }

        [Display(Order = 150)]
        public virtual XhtmlString MainBodyContent { get; set; }

        [Display(GroupName = SystemTabNames.Content,
                 Order = 200)]
        [CultureSpecific]
        public virtual ContentArea MainContentArea { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 400)]
        public virtual LinkItemCollection ProductPageLinks { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 450)]
        public virtual LinkItemCollection CompanyInformationPageLinks { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual PageReference SearchPageLink { get; set; }
        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual PageReference ContactsPageLink { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual SiteLogotypeBlock SiteLogotype { get; set; }
        
    }
}
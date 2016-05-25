using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer;
using EPiServer.Web;

namespace Landrys.ThePostOak_EpiServer.Models.Blocks
{
    [ContentType(
        GroupName = Global.GroupNames.Specialized,
        DisplayName = "Image-Block-Template",
        GUID = "84d3ea65-1deb-461e-a8f3-734a22ca9bf0",
        Description = "Use this block to create site images")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Standard.png")]
    public class ImageBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Name = "PLace URL Here",
            Order = 10)]
        public virtual Url ImageUrl { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [UIHint(UIHint.Image)]
        [Display(
            Name = "PLace Image Here",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual ContentReference Image { get; set; }

        [CultureSpecific]
        [Editable(true)]
        [Display(
            GroupName = SystemTabNames.Content,
            Name = "ADA Alternative Name",
            Order = 30)]
        public virtual string AlternativeText { get; set; }

        [CultureSpecific]
        [Display(
           Name = "ADA Description Text",
           GroupName = SystemTabNames.Content,
           Order = 40)]
        [Editable(true)]
        [UIHint(UIHint.LongString)]
        public virtual string ImageDescription { get; set; }
    }
}
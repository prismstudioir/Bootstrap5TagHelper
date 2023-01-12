using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootstrap5TagHelper.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("BSpinner")]
    public class SpinnerTagHelper : TagHelper
    {
        public enum Colors
        {
            Primary = 0,
            Secondary = 1,
            Success = 2,
            Danger = 3,
            Warning = 4,
            Info = 5,
            Light = 6,
            Dark = 7
        }

        public enum SpinnerModes
        {
            Spinner_Border = 0,
            Spinner_Grow = 1
        }
        public string ExtraClass { get; set; }
        public string ChildExtraClass { get; set; }
        public string Text { get; set; }

        public string OtherStyle { get; set; }
        public string ChildOtherStyle { get; set; }
        public Colors SpinnerColor { get; set; }
        public SpinnerModes SpinnerMode { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.Add("class",
                SpinnerMode.ToString().ToLower().Replace("_", "-") + " text-" + SpinnerColor.ToString().ToLower() + " " + ExtraClass);
            output.Attributes.Add("role", "status");
            output.Attributes.Add("Style", OtherStyle);


            string child = $"<span class='visually-hidden {ChildExtraClass}' style='{ChildOtherStyle}'></span>";


            output.Content.SetHtmlContent(child);
        }
    }
}

using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootstrap5TagHelper.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("BProgress")]
    public class ProgressTagHelper : TagHelper
    {
        public enum Background
        {
            Bg_Primary = 0,
            Bg_Secondary = 1,
            Bg_Success = 2,
            Bg_Danger = 3,
            Bg_Warning = 4,
            Bg_Info = 5,
            Bg_Light = 6,
            Bg_Dark = 7
        }
        public string ExtraClass { get; set; }
        public string ChildExtraClass { get; set; }
        public int Value { get; set; }

        public string OtherStyle { get; set; }
        public string ChildOtherStyle { get; set; }
        public Background ProgressBackgrund { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.Add("class", @"progress "+ ExtraClass);
            output.Attributes.Add("role", "progressbar");
            output.Attributes.Add("Style", OtherStyle);


            string child = $"<div class='progress-bar {ProgressBackgrund.ToString().ToLower().Replace("_", "-")} {ChildExtraClass}' " +
                           $"style='width: {Value}%; {ChildOtherStyle}'></div>";


            output.Content.SetHtmlContent(child);
        }
    }
}

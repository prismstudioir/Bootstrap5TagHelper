using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootstrap5TagHelper.TagHelpers
{
    [HtmlTargetElement("BButton")]
    public class ButtonTagHelper : TagHelper
    {
        public string Text { get; set; }
        public enum ButtonType
        {
            Primary = 0,
            Secondary = 1,
            Success = 2,
            Danger = 3,
            Warning = 4,
            Info = 5,
            Light = 6,
            Dark = 7,
            Outline_Primary = 8,
            Outline_Secondary = 9,
            Outline_Success = 10,
            Outline_Danger = 11,
            Outline_Warning = 12,
            Outline_Info = 13,
            Outline_Light = 14,
            Outline_Dark = 15


            
        }
        public string ExtraClass { get; set; }
        public string OtherStyle { get; set; }

        public ButtonType Type { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button ";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.Add("class", "btn btn-" + Type.ToString().ToLower().Replace("_","-")+" "+ ExtraClass);
            output.Attributes.Add("Style", OtherStyle);
            output.Content.SetContent(Text);
        }
    }
}

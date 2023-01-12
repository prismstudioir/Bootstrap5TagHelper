using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Bootstrap5TagHelper.TagHelpers
{
    [HtmlTargetElement("BAlert")]
    public class AlertTagHelper : TagHelper
    {
        public string Message { get; set; }
        public enum AlertType
        {
            Primary = 0,
            Secondary = 1,
            Success = 2,
            Danger=3,
            Warning=4,
            Info=5,
            Light=6,
            Dark=7
        }
        public string ExtraClass { get; set; }
        public string Value { get; set; }
        public string ChildExtraClass { get; set; }
        public string OtherStyle { get; set; }
        public string ChildOtherStyle { get; set; }
        public AlertType Type { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.Add("class", "alert alert-" + Type.ToString().ToLower() + " " + ExtraClass);
            output.Attributes.Add("role", "alert");
            output.Attributes.Add("Style", OtherStyle);

            string child = $"<div class='progress-bar {ChildExtraClass}' style='width:{Value} {ChildOtherStyle}' ></div>";


            output.Content.SetHtmlContent(child);

            
        }
    }
}

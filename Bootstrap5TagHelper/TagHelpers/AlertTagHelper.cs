using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Bootstrap5TagHelper.TagHelpers
{

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

        public AlertType Type { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.Add("class", "alert alert-" + Type.ToString().ToLower());
            output.Attributes.Add("role", "alert");

            output.Content.SetContent(Message);
        }
    }
}

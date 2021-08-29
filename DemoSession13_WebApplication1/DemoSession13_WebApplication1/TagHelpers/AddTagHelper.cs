using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession13_WebApplication1.TagHelpers
{
    [HtmlTargetElement("add",TagStructure =TagStructure.NormalOrSelfClosing)]
    public class AddTagHelper : TagHelper
    {
        [HtmlAttributeName("number1")]
        public double Number1 { get; set; }

        [HtmlAttributeName("number2")]
        public double Number2 { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "";
            output.Content.SetHtmlContent("Add: " + (Number1+Number2));
        }
    }
}

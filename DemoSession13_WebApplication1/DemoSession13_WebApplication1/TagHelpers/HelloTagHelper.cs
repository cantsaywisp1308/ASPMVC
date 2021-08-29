using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession13_WebApplication1.TagHelpers
{
    [HtmlTargetElement("hello",TagStructure =TagStructure.NormalOrSelfClosing)]
    public class HelloTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "";
            output.Content.SetHtmlContent("Hello World");
        }
    }
}

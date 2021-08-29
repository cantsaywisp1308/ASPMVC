using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession13_WebApplication1.TagHelpers
{
    [HtmlTargetElement("hi",TagStructure =TagStructure.NormalOrSelfClosing)]
    public class HiTagHelper : TagHelper
    {
        [HtmlAttributeName("fullName")]
        public string FullName { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "";
            output.Content.SetHtmlContent("<b><i> Hi "+ FullName + "</i><b>");
        }
    }
}

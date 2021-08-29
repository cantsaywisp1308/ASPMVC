using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession12_WebApplication1.TagHelpers
{
    [HtmlTargetElement("partner",TagStructure = TagStructure.NormalOrSelfClosing)]
    public class PartnerTagHelper : TagHelper
    {
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext viewContext { get; set; }
        private IHtmlHelper htmlHelper;

        public PartnerTagHelper(IHtmlHelper _htmlHelper)
        {
            htmlHelper = _htmlHelper;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            (htmlHelper as IViewContextAware).Contextualize(viewContext);
            output.TagName = "";
            output.Content.SetHtmlContent(await htmlHelper.PartialAsync("TagHelpers/Partner/Index"));
        }
    }
}

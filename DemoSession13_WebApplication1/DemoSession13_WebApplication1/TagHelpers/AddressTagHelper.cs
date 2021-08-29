using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession13_WebApplication1.TagHelpers
{
    [HtmlTargetElement("myaddress",TagStructure =TagStructure.NormalOrSelfClosing)]
    public class AddressTagHelper : TagHelper
    {
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext viewContext { get; set; }

        private IHtmlHelper htmlHelper;

        public AddressTagHelper(IHtmlHelper _htmlHelper)
        {
            htmlHelper = _htmlHelper;
        }
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            (htmlHelper as IViewContextAware).Contextualize(viewContext);
            htmlHelper.ViewBag.Street = "Street  1";
            htmlHelper.ViewBag.Ward = "Ward 1";
            htmlHelper.ViewBag.District = "District 1";
            output.TagName = "";
            output.Content.SetHtmlContent(await htmlHelper.PartialAsync("TagHelpers/Address/Index"));
        }
    }
}

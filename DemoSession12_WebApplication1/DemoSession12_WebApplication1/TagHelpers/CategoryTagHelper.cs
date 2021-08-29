using DemoSession12_WebApplication1.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession12_WebApplication1.TagHelpers
{
    [HtmlTargetElement("categories",TagStructure =TagStructure.NormalOrSelfClosing)]
    public class CategoryTagHelper : TagHelper
    {
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext viewContext { get; set; }

        private IHtmlHelper htmlHelper;
        private CategoryService categoryService; 

        public CategoryTagHelper(IHtmlHelper _htmlHelper, CategoryService _categoryService)
        {
            htmlHelper = _htmlHelper;
            categoryService = _categoryService;
        }
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            (htmlHelper as IViewContextAware).Contextualize(viewContext);
            htmlHelper.ViewBag.categories = categoryService.FindaAll();
            output.TagName = "";
            output.Content.SetHtmlContent(await htmlHelper.PartialAsync("TagHelpers/Categories/Index"));
        }
    }
}

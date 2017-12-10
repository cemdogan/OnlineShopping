using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Northwind.MvcWebUI.TagHelpers
{
    [HtmlTargetElement("product-list-paging")]
    public class PagingTagHelper : TagHelper
    {
        [HtmlAttributeName("page-size")]
        public int PageSize { get; set; }
        [HtmlAttributeName("page-count")]
        public int PageCount { get; set; }
        [HtmlAttributeName("current-category")]
        public int CurrentCategory { get; set; }
        [HtmlAttributeName("current-page")]
        public int CurrentPage { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            StringBuilder str = new StringBuilder();
            str.Append("<ul class='pagination'>");
            for (int i = 1; i <= PageCount; i++)
            {
                str.AppendFormat("<li class='{0}'>", i == CurrentPage ? "active" : "");
                str.AppendFormat("<a href='/product/index?page={0}&category={1}'>{2}</a>", i, CurrentCategory, i);
                str.Append("</li>");
            }
            str.Append("</ul>");
            output.Content.SetHtmlContent(str.ToString());
            base.Process(context, output);
        }
    }
}

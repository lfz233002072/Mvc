﻿using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using Microsoft.AspNet.Razor.TagHelpers;

namespace ActivatorWebSite.TagHelpers
{
    [HtmlElementName("body")]
    [ContentBehavior(ContentBehavior.Prepend)]
    public class TitleTagHelper : TagHelper
    {
        [Activate]
        public IHtmlHelper HtmlHelper { get; set; }

        [Activate]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var builder = new TagBuilder("h2");
            var title = ViewContext.ViewBag.Title;
            builder.InnerHtml = HtmlHelper.Encode(title);
            output.Content = builder.ToString();
        }
    }
}
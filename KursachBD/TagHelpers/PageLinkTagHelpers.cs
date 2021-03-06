﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KursachBD.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace KursachBD.TagHelpers
{
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;
        public PageLinkTagHelper(IUrlHelperFactory helperFactory)
        {
            urlHelperFactory = helperFactory;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public PageViewModel PageModel { get; set; }
        public string PageAction { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            output.TagName = "div";

            // набор ссылок будет представлять список ul
            TagBuilder tag = new TagBuilder("ul");
            tag.AddCssClass("pagination");

            // формируем три ссылки - на текущую, предыдущую и следующую
            TagBuilder currentItem = CreateTag(PageModel.PageNumber, urlHelper);

            // создаем ссылку на предыдущую страницу, если она есть
            if (PageModel.HasPreviousPage)
            {
                TagBuilder buttonFirst = CreateTag(1, urlHelper, "В начало");
                tag.InnerHtml.AppendHtml(buttonFirst);

                TagBuilder prevItem = CreateTag(PageModel.PageNumber - 1, urlHelper);
                tag.InnerHtml.AppendHtml(prevItem);
            }

            tag.InnerHtml.AppendHtml(currentItem);
            // создаем ссылку на следующую страницу, если она есть
            if (PageModel.HasNextPage)
            {
                TagBuilder nextItem = CreateTag(PageModel.PageNumber + 1, urlHelper);
                tag.InnerHtml.AppendHtml(nextItem);

                TagBuilder lastItem = CreateTag(PageModel.TotalPages, urlHelper, "В конец");
                tag.InnerHtml.AppendHtml(lastItem);
            }
            output.Content.AppendHtml(tag);
        }

        private TagBuilder CreateTag(int pageNumber, IUrlHelper urlHelper, string content = null)
        {
            TagBuilder item = new TagBuilder("li");
            item.AddCssClass("page-item");

            TagBuilder link = new TagBuilder("a");
            link.AddCssClass("page-link");

            if (pageNumber == this.PageModel.PageNumber)
            {
                item.AddCssClass("active");
            }
            else
            {
                link.Attributes["href"] = urlHelper.Action(PageAction, new { page = pageNumber });
            }
            if (content != null)
            {
                link.InnerHtml.Append(content);
            }
            else
            {
                link.InnerHtml.Append(pageNumber.ToString());
            }

            item.InnerHtml.AppendHtml(link);
            return item;
        }
    }
}

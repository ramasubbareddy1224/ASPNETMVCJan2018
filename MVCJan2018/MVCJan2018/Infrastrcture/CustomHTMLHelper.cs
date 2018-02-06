using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCJan2018.Infrastrcture
{
    public static class CustomHTMLHelper
    {
        public static HtmlString LabelWithBold(string content)
        {
            string htmlString = String.Format("<label><strong>{0}</strong></label>", content);
            return new HtmlString(htmlString);
        }
        public static HtmlString LabelWithBoldHTML(this HtmlHelper helper, string content)
        {
            string htmlString = String.Format("<label><strong>{0}</strong></label>", content);
            return new HtmlString(htmlString);
        }

    }
}
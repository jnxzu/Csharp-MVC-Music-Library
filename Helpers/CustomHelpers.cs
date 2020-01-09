using System;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace MusicLib.Helpers
{
    public static class CustomHelpers
    {
        public static HtmlString NavLink(string target)
        {
            return new HtmlString(String.Format("<li class='nav-item'><a class='nav-link text-dark' href='/{0}'>{0}</a></li>", target));
        }

        public static HtmlString ControlGroup(string target, int id)
        {
            return new HtmlString(String.Format("<td><a href='/{0}/Edit/{1}'>Edit</a> | <a href='/{0}/Details/{1}'>Details</a> | <a href='/{0}/Delete/{1}'>Delete</a></td>", target, id));
        }
    }
}



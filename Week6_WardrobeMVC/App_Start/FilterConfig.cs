﻿using System.Web;
using System.Web.Mvc;

namespace Week6_WardrobeMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

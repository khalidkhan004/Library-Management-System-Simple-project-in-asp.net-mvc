﻿using System.Web;
using System.Web.Mvc;

namespace Library_Management_System_Simple
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

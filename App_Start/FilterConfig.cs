﻿using System.Web;
using System.Web.Mvc;

namespace Aspnet_MVC_AuthFilter_POC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ERP
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application.Lock();
            Application["online"] = 0;
            Application.UnLock();
        }
        /// <summary>
        /// 全局事件结束
        /// </summary>
        protected void Application_End()
        {

        }
        /// <summary>
        /// 单个用户事件开始
        /// </summary>
        protected void Session_Start()
        {
            Application.Lock();
            int online = (int)Application["online"];
            Application["online"] = online + 1;
            Session["LoginDate"] = DateTime.Now;
            Application.UnLock();
        }
        /// <summary>
        /// 单个用户事件结束
        /// </summary>
        protected void Session_End()
        {
            Application.Lock();
            int online = (int)Application["online"];
            Application["online"] = online - 1;
            Application.UnLock();
        }
    }
}

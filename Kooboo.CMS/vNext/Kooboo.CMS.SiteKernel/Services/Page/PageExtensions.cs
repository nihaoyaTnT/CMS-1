﻿#region License
// 
// Copyright (c) 2013, Kooboo team
// 
// Licensed under the BSD License
// See the file LICENSE.txt for details.
// 
#endregion
using Kooboo.CMS.SiteKernel.Models;
using Kooboo.Common.ObjectContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kooboo.CMS.SiteKernel.Services
{
    public static class PageExtensions
    {
        public static IPageService PageService
        {
            get
            {
                return EngineContext.Current.Resolve<IPageService>();
            }
        }

        /// <summary>
        /// 页面包含的所有View
        /// </summary>
        /// <param name="page"></param>
        /// <param name="site"></param>
        /// <returns></returns>
        public static IEnumerable<View> AllViews(this Page page, Site site)
        {
            return null;
        }

        /// <summary>
        /// 页面中所有的Data rule(包括views, layouts所使用的)
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static IEnumerable<DataRuleSetting> AllDataRules(this Page page)
        {
            return null;
        }

        /// <summary>
        /// 页面中所有的plugin（包括views,layouts所添加的）
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static IEnumerable<string> AllPlugins(this Page page)
        {
            return null;
        }

        public static bool IsStaticPage(this Page page)
        {
            return page.PageType == PageType.Static;
        }

        public static Page GetDraft(this Page page)
        {
            return null;
        }

        public static IEnumerable<Page> GetUnsyncedSubPages(this Page page, Site currentSite)
        {
            return PageService.GetUnsyncedPages(currentSite, page);
        }
    }
}

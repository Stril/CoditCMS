﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using CMS.Mvc;
    using CMS.PagesSettings.Lists;
    using CMS.ViewModels;
    using DB.Entities;
    using Libs;
    
    #line 1 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
    using CMS;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Shared/DisplayTemplates/ozi_Header.cshtml")]
    public partial class _Areas_Admin_Views_Shared_DisplayTemplates_ozi_Header_cshtml_ : CMS.Mvc.AdminViewPage<dynamic>
    {
        public _Areas_Admin_Views_Shared_DisplayTemplates_ozi_Header_cshtml_()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
Write(ViewData.TemplateInfo.FormattedModelValue);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 4 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
  
    ColSettings settings = ViewBag.ColSettings;
    var order = settings.GetOrderField();
    string desc = null;
    var curOrder = Request.QueryString["order"];
    var curDesc = Request.QueryString["desc"] != null;
    if (curOrder == order && !curDesc)
    {
        desc = "true";
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 15 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
 if (order != null)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"header-panel\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" class=\"get-click\"");

WriteLiteral(" data-order=\"");

            
            #line 18 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
                                                              Write(order);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-desc=\"");

            
            #line 18 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
                                                                                 Write(desc);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n");

            
            #line 19 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
            
            
            #line default
            #line hidden
            
            #line 19 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
             if (curOrder != order)
            {

            
            #line default
            #line hidden
WriteLiteral("                <img");

WriteLiteral(" width=\"20\"");

WriteLiteral(" src=\"/Areas/Admin/Images/Default/down_g.png\"");

WriteLiteral(" />\r\n");

            
            #line 22 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
            }
            else if (curDesc)
            {

            
            #line default
            #line hidden
WriteLiteral("                <img");

WriteLiteral(" width=\"20\"");

WriteLiteral(" src=\"/Areas/Admin/Images/Default/up.png\"");

WriteLiteral(" />\r\n");

            
            #line 26 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <img");

WriteLiteral(" width=\"20\"");

WriteLiteral(" src=\"/Areas/Admin/Images/Default/down.png\"");

WriteLiteral(" />\r\n");

            
            #line 30 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </a>\r\n    </div>\r\n");

            
            #line 33 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
}

            
            #line default
            #line hidden
            
            #line 34 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
  
    var filter = settings.GetFilterField();

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 38 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
 if (filter != null)
{
    var curValue = Request.QueryString[filter];

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"header-panel\"");

WriteLiteral(">\r\n        \r\n");

            
            #line 43 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
        
            
            #line default
            #line hidden
            
            #line 43 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
         if (curValue != null)
        {
            string d = "data-" + filter + "=''";
            

            
            #line default
            #line hidden
WriteLiteral("            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"hidden get-blur\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1296), Tuple.Create("\"", 1313)
            
            #line 47 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
, Tuple.Create(Tuple.Create("", 1304), Tuple.Create<System.Object, System.Int32>(curValue
            
            #line default
            #line hidden
, 1304), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 1314), Tuple.Create("\"", 1326)
            
            #line 47 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
, Tuple.Create(Tuple.Create("", 1319), Tuple.Create<System.Object, System.Int32>(filter
            
            #line default
            #line hidden
, 1319), false)
);

WriteAttribute("name", Tuple.Create(" name=\"", 1327), Tuple.Create("\"", 1343)
            
            #line 47 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
             , Tuple.Create(Tuple.Create("", 1334), Tuple.Create<System.Object, System.Int32>(filter
            
            #line default
            #line hidden
, 1334), false)
);

WriteLiteral("/>\r\n");

WriteLiteral("            <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-hide=\"true\"");

WriteLiteral(" data-target-show=\"");

            
            #line 48 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
                                                                        Write(filter);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">");

            
            #line 48 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
                                                                                  Write(curValue);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

WriteLiteral("            <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" class=\"get-click\"");

WriteLiteral(" ");

            
            #line 49 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
                                                      Write(Html.Raw(d));

            
            #line default
            #line hidden
WriteLiteral(">\r\n                <img");

WriteLiteral(" width=\"20\"");

WriteLiteral(" src=\"/Areas/Admin/Images/Default/filter_delete.png\"");

WriteLiteral(" />\r\n            </a>\r\n");

            
            #line 52 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"hidden get-blur\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1720), Tuple.Create("\"", 1737)
            
            #line 55 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
, Tuple.Create(Tuple.Create("", 1728), Tuple.Create<System.Object, System.Int32>(curValue
            
            #line default
            #line hidden
, 1728), false)
);

WriteAttribute("name", Tuple.Create(" name=\"", 1738), Tuple.Create("\"", 1752)
            
            #line 55 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
, Tuple.Create(Tuple.Create("", 1745), Tuple.Create<System.Object, System.Int32>(filter
            
            #line default
            #line hidden
, 1745), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 1753), Tuple.Create("\"", 1765)
            
            #line 55 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
            , Tuple.Create(Tuple.Create("", 1758), Tuple.Create<System.Object, System.Int32>(filter
            
            #line default
            #line hidden
, 1758), false)
);

WriteLiteral("/>\r\n");

WriteLiteral("            <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-target-show=\"");

            
            #line 56 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
                                                      Write(filter);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                <img");

WriteLiteral(" width=\"20\"");

WriteLiteral(" src=\"/Areas/Admin/Images/Default/filter_add.png\"");

WriteLiteral(" />\r\n            </a>\r\n");

            
            #line 59 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n");

            
            #line 61 "..\..\Areas\Admin\Views\Shared\DisplayTemplates\ozi_Header.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591

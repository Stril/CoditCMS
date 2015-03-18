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
    
    #line 3 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
    using CMS;
    
    #line default
    #line hidden
    using CMS.Mvc;
    using CMS.PagesSettings.Lists;
    using CMS.ViewModels;
    
    #line 1 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
    using DB;
    
    #line default
    #line hidden
    using DB.Entities;
    
    #line 2 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
    using Libs;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Shared/_Main.cshtml")]
    public partial class _Areas_Admin_Views_Shared__Main_cshtml : CMS.Mvc.AdminViewPage<dynamic>
    {

#line 60 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
public System.Web.WebPages.HelperResult RenderModulesTree(IEnumerable<SitemapElement> modules)
                    {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 60 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
                

#line default
#line hidden

#line 61 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
                     
                    foreach (var child in modules)
                    {
                        if (child.Childs.Count > 0)
                        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                            <li><span");

WriteLiteralTo(__razor_helper_writer, " class=\"folder\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 66 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
                       WriteTo(__razor_helper_writer, child.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n                                <ul>\r\n");

WriteLiteralTo(__razor_helper_writer, "                                    ");


#line 68 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
      WriteTo(__razor_helper_writer, RenderModulesTree(child.Childs));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                                </ul>\r\n                            </li>\r\n");


#line 71 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
                        }
                        else
                        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                            <li><a ");


#line 74 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
                                    if (child.Controller == (string)ViewContext.RouteData.Values["Controller"] && 
                                       (string.IsNullOrEmpty(child.Action) || child.Action == (string)ViewContext.RouteData.Values["action"])){

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");

WriteLiteralTo(__razor_helper_writer, "class=\"selected\"");

WriteLiteralTo(__razor_helper_writer, " ");


#line 75 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
                                                                                                                                                                              }

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " href=\"");


#line 75 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
                                                                                                                                                        WriteTo(__razor_helper_writer, Url.Action(child.Action, child.Controller));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\">");


#line 75 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
                                                                                                                                                                                                     WriteTo(__razor_helper_writer, child.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a></li>\r\n");


#line 76 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
                        }
                    }
                

#line default
#line hidden
});

#line 78 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
}
#line default
#line hidden

        public _Areas_Admin_Views_Shared__Main_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n<head>\r\n    <title>");

            
            #line 8 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
      Write(WebContext.HtmlPageTitle);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <link");

WriteLiteral(" href=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/A" +
"reas/Admin/Scripts/Default/jqueryUI/development-bundle/themes/base/jquery.ui.all" +
".css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/A" +
"reas/Admin/Styles/Default/jquery-ui-timepicker-addon.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/A" +
"reas/Admin/Styles/Default/fileuploader/fineuploader.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/A" +
"reas/Admin/Styles/Default/toastr/toastr.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/A" +
"reas/Admin/Styles/Default/toastr/toastr-responsive.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/A" +
"reas/Admin/Styles/Default/Default.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/jquery-2.1.1.min.js\"");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/jqueryUI/development-bundle/ui/minified/jquery-ui.cust" +
"om.min.js\"");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/jqueryUI/development-bundle/ui/i18n/jquery.ui.datepick" +
"er-ru.js\"");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/drag/jquery.dragsort-0.5.1.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/fileuploader/util.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/fileuploader/button.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/fileuploader/header.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/fileuploader/header.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/fileuploader/handler.base.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/fileuploader/handler.form.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/fileuploader/handler.xhr.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/fileuploader/uploader.basic.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/fileuploader/dnd.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/fileuploader/uploader.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/fileuploader/jquery-plugin.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/jqueryUI/js/jquery-ui-sliderAccess.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/jqueryUI/js/jquery-ui-timepicker-addon.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/jqueryUI/js/ui.datepicker-ru.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/jqueryUI/js/jquery-ui-timepicker-ru.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/knockout/knockout-2.2.1.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/knockout/knockout-sortable.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/toastr/toastr.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/autoNumeric.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/Default.js\"");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/Mktree.js\"");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Ckeditor/ckeditor.js\"");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/Myckconfig.js\"");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://raw.githubusercontent.com/kobyb1988/CoditCMS/master/CoditCMS/CMS/Ar" +
"eas/Admin/Scripts/Default/files-logic.js\"");

WriteLiteral("></script>\r\n</head>\r\n\r\n<body>\r\n\r\n    <table");

WriteLiteral(" id=\"logo-table\"");

WriteLiteral(">\r\n        <tr>\r\n            <td");

WriteLiteral(" id=\"logo-left\"");

WriteLiteral("><div");

WriteLiteral(" id=\"logo\"");

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 5821), Tuple.Create("\"", 5876)
            
            #line 49 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 5827), Tuple.Create<System.Object, System.Int32>(Url.Content("~/Content/Images/Default/logo.gif")
            
            #line default
            #line hidden
, 5827), false)
);

WriteLiteral(" alt=\"OziCms.cms 4.0\"");

WriteLiteral(" /><div");

WriteLiteral(" id=\"ozi-version\"");

WriteLiteral(">Версия — 4.0</div></div></td>\r\n            <td");

WriteLiteral(" id=\"logo-right\"");

WriteLiteral("><span");

WriteLiteral(" id=\"hello\"");

WriteLiteral(">Здравствуйте, ");

            
            #line 50 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
                                                          Write(Request.ServerVariables["AUTH_USER"]);

            
            #line default
            #line hidden
WriteLiteral(" <a");

WriteLiteral(" href=\"/account/logout\"");

WriteLiteral(">Выйти</a></span></td>\r\n        </tr>\r\n    </table>\r\n\r\n    <table");

WriteLiteral(" id=\"main-table\"");

WriteLiteral(">\r\n        <tr>\r\n            <td");

WriteLiteral(" id=\"main-left\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"root\"");

WriteLiteral(">Konig Labs</div>\r\n                \r\n                \r\n");

WriteLiteral("                \r\n                <ul");

WriteLiteral(" class=\"mktree\"");

WriteLiteral(" id=\"modules-ul\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 81 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
               Write(RenderModulesTree(new Sitemap(@Url.Content("~/Modules.sitemap")).SitemapList));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </ul>\r\n                \r\n                <div");

WriteLiteral(" id=\"left-menu\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Функции</div>\r\n                    <div");

WriteLiteral(" class=\"left-function\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create("  href=\"", 7686), Tuple.Create("\"", 7746)
            
            #line 86 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 7694), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Admin.Utils.ClearApplicationCache())
            
            #line default
            #line hidden
, 7694), false)
);

WriteLiteral(">Очистить кэш</a></div>\r\n                    <div");

WriteLiteral(" class=\"left-function\"");

WriteLiteral("><a");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" href=\"/\"");

WriteLiteral(">На главную</a></div>\r\n                </div>\r\n                \r\n            </td" +
">\r\n            \r\n            <td");

WriteLiteral(" id=\"main-right\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 93 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
           Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591

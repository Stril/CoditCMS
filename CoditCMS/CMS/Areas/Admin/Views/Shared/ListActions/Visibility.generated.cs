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
    
    #line 2 "..\..\Areas\Admin\Views\Shared\ListActions\Visibility.cshtml"
    using DB.Entities;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Areas\Admin\Views\Shared\ListActions\Visibility.cshtml"
    using CMS;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Shared/ListActions/Visibility.cshtml")]
    public partial class _Areas_Admin_Views_Shared_ListActions_Visibility_cshtml : CMS.Mvc.AdminViewPage<DB.Entities.IEntity>
    {
        public _Areas_Admin_Views_Shared_ListActions_Visibility_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Areas\Admin\Views\Shared\ListActions\Visibility.cshtml"
 if (((IVisibleEntity)Model).Visibility)
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" class=\"list-action\"");

WriteAttribute("href", Tuple.Create(" href=\"", 151), Tuple.Create("\"", 247)
            
            #line 7 "..\..\Areas\Admin\Views\Shared\ListActions\Visibility.cshtml"
, Tuple.Create(Tuple.Create("", 158), Tuple.Create<System.Object, System.Int32>(Url.Action(Constants.SetVisibilityAction, new {id = Model.Id, visibilityToSet = false })
            
            #line default
            #line hidden
, 158), false)
);

WriteLiteral("><img");

WriteLiteral(" src=\"/Areas/Admin/Images/Default/VisibilityOn.png\"");

WriteLiteral(" alt=\"Выключить\"");

WriteLiteral(" /></a>\r\n");

            
            #line 8 "..\..\Areas\Admin\Views\Shared\ListActions\Visibility.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" class=\"list-action\"");

WriteAttribute("href", Tuple.Create(" href=\"", 367), Tuple.Create("\"", 463)
            
            #line 11 "..\..\Areas\Admin\Views\Shared\ListActions\Visibility.cshtml"
, Tuple.Create(Tuple.Create("", 374), Tuple.Create<System.Object, System.Int32>(Url.Action(Constants.SetVisibilityAction, new { id = Model.Id, visibilityToSet = true })
            
            #line default
            #line hidden
, 374), false)
);

WriteLiteral("><img");

WriteLiteral(" src=\"/Areas/Admin/Images/Default/VisibilityOff.png\"");

WriteLiteral(" alt=\"Включить\"");

WriteLiteral(" /></a>\r\n");

            
            #line 12 "..\..\Areas\Admin\Views\Shared\ListActions\Visibility.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591

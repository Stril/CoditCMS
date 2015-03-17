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
    
    #line 1 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Object.cshtml"
    using CMS.PagesSettings;
    
    #line default
    #line hidden
    using CMS.PagesSettings.Lists;
    using CMS.ViewModels;
    using DB.Entities;
    using Libs;
    
    #line 2 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Object.cshtml"
    using CMS;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Shared/EditorTemplates/ozi_Object.cshtml")]
    public partial class _Areas_Admin_Views_Shared_EditorTemplates_ozi_Object_cshtml_ : CMS.Mvc.AdminViewPage<Object>
    {

#line 30 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Object.cshtml"
public System.Web.WebPages.HelperResult RenderTabs(Settings settings)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 31 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Object.cshtml"
 
    var index = 0;
    foreach (var tab in settings.FormSettings.Tabs)
    {
        index++;
        WebContext.CurrentTab = tab;


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <div");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 784), Tuple.Create("\"", 800)
, Tuple.Create(Tuple.Create("", 789), Tuple.Create("tab", 789), true)

#line 37 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Object.cshtml"
, Tuple.Create(Tuple.Create("", 792), Tuple.Create<System.Object, System.Int32>(index

#line default
#line hidden
, 792), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n            <table");

WriteLiteralTo(__razor_helper_writer, " class=\"form-table\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 39 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Object.cshtml"
                

#line default
#line hidden

#line 39 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Object.cshtml"
                   Html.RenderPartial("EditorTemplates/Shared/ObjectFields"); 

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            </table>\r\n        </div>\r\n");


#line 42 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Object.cshtml"
    }


#line default
#line hidden
});

#line 43 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Object.cshtml"
}
#line default
#line hidden

        public _Areas_Admin_Views_Shared_EditorTemplates_ozi_Object_cshtml_()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Object.cshtml"
  
    var settings = WebContext.GetSettings();
    var tabsCount = settings.FormSettings.Tabs.Count;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n");

            
            #line 11 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Object.cshtml"
 if (tabsCount > 1)
{
    var index = 0;

            
            #line default
            #line hidden
WriteLiteral("    ");

WriteLiteral("<div id=\"edit-form-tabs\">\r\n");

WriteLiteral("        <ul>\r\n");

            
            #line 16 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Object.cshtml"
            
            
            #line default
            #line hidden
            
            #line 16 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Object.cshtml"
             foreach (var tab in settings.FormSettings.Tabs)
            {
                index++;
                var name = tab.Name ?? string.Format("tab-{0}", index);

            
            #line default
            #line hidden
WriteLiteral("                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 462), Tuple.Create("\"", 481)
, Tuple.Create(Tuple.Create("", 469), Tuple.Create("#tab", 469), true)
            
            #line 20 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Object.cshtml"
, Tuple.Create(Tuple.Create("", 473), Tuple.Create<System.Object, System.Int32>(index
            
            #line default
            #line hidden
, 473), false)
);

WriteLiteral(">");

            
            #line 20 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Object.cshtml"
                                      Write(name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 21 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Object.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n");

            
            #line 23 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Object.cshtml"
}

            
            #line default
            #line hidden
            
            #line 24 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Object.cshtml"
Write(RenderTabs(settings));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 25 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Object.cshtml"
 if (tabsCount > 1)
{

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 28 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Object.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591

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
    
    #line 1 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    using System.Collections;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 2 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    using System.ComponentModel;
    
    #line default
    #line hidden
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
    
    #line 3 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    using CMS.Controllers;
    
    #line default
    #line hidden
    using CMS.Mvc;
    
    #line 4 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    using CMS.PagesSettings.Forms;
    
    #line default
    #line hidden
    using CMS.PagesSettings.Lists;
    using CMS.ViewModels;
    
    #line 7 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    using DateSettings = CMS.PagesSettings.Forms.DateSettings;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    using DB.Entities;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    using Libs;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    using StringSettings = CMS.PagesSettings.Forms.StringSettings;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Shared/EditorTemplates/ozi_Collection.cshtml")]
    public partial class _Areas_Admin_Views_Shared_EditorTemplates_ozi_Collection_cshtml_ : CMS.Mvc.AdminViewPage<dynamic>
    {

#line 71 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
public System.Web.WebPages.HelperResult RenderView(CollectionSettings settings)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 72 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <li>\r\n        <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " data-bind=\"{value: ItemId, attr: { name: generateName() + \'.Id\' }}\"");

WriteLiteralTo(__razor_helper_writer, "/>\r\n");


#line 75 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
        

#line default
#line hidden

#line 75 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
         foreach (var item in settings.Fields)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"collection-item\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <label>");


#line 78 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, item.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</label>\r\n");


#line 79 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                

#line default
#line hidden

#line 79 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                 if (item is CollectionSettings)
                {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                    <ul");

WriteLiteralTo(__razor_helper_writer, " data-bind=\"{foreach: { data: ");


#line 81 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                       WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ", afterRender: renderPlugins}}\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                        ");


#line 82 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, RenderView((CollectionSettings) item));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                    </ul>\r\n");


#line 84 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                    

#line default
#line hidden

#line 84 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, RenderButtons((CollectionSettings) item));


#line default
#line hidden

#line 84 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                                                             
                }
                else
                {
                    

#line default
#line hidden

#line 88 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, RenderPropertyView(item));


#line default
#line hidden

#line 88 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                                             
                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </div>\r\n");


#line 91 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <input");

WriteLiteralTo(__razor_helper_writer, " type=\"button\"");

WriteLiteralTo(__razor_helper_writer, " value=\"Удалить\"");

WriteLiteralTo(__razor_helper_writer, " data-bind=\"{click: removeItem}\"");

WriteLiteralTo(__razor_helper_writer, "/>\r\n    </li>\r\n");


#line 94 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"


#line default
#line hidden
});

#line 94 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
}
#line default
#line hidden

#line 105 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
public System.Web.WebPages.HelperResult RenderButtons(CollectionSettings settings)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 106 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"button\"");

WriteLiteralTo(__razor_helper_writer, " value=\"Добавить\"");

WriteLiteralTo(__razor_helper_writer, " data-bind=\"{click: add");


#line 107 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                                   WriteTo(__razor_helper_writer, settings.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "Item}\"");

WriteLiteralTo(__razor_helper_writer, "/>\r\n");


#line 108 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"


#line default
#line hidden
});

#line 108 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
}
#line default
#line hidden

#line 110 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
public System.Web.WebPages.HelperResult RenderInitViewModel(CollectionSettings settings, string parentElName)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 111 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
 
    foreach (var item in settings.Fields.GetOf<FieldSettings, CollectionSettings>())
    {
        // инициируем коллекции
        var elName = item.GetFullPropertyName().Replace(".", string.Empty);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, "\r\n            $.each(elem.");


#line 117 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ", function(index, elem");


#line 117 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                             WriteTo(__razor_helper_writer, elName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "){\r\n                var item");


#line 118 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, elName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " = new ");


#line 118 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
           WriteTo(__razor_helper_writer, elName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "Model(elem");


#line 118 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                              WriteTo(__razor_helper_writer, elName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ", index, elem");


#line 118 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                                                    WriteTo(__razor_helper_writer, parentElName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ".");


#line 118 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                                                                    WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ", elem");


#line 118 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                                                                                      WriteTo(__razor_helper_writer, parentElName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ");\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 119 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, RenderInitViewModel(item, elName));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                elem");


#line 120 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, parentElName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ".");


#line 120 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
       WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ".push(item");


#line 120 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                             WriteTo(__razor_helper_writer, elName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ");\r\n            });\r\n        ");

WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 123 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    }


#line default
#line hidden
});

#line 124 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
}
#line default
#line hidden

#line 126 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
public System.Web.WebPages.HelperResult RenderInitModelValues(CollectionSettings settings, IEntity model)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 127 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
 
    // тут генерируем JSON для наших объектов
    var simpleFields = settings.Fields.GetNotOf<FieldSettings, CollectionSettings>().ToList();
    var children = settings.Fields.GetOf<FieldSettings, CollectionSettings>().ToList();
    var values = (IEnumerable)TypeHelpers.GetPropertyValue(model, settings.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    ");

WriteLiteralTo(__razor_helper_writer, "[ \r\n");


#line 133 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    foreach (var item in values)
    { 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, "{");

WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 136 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
        foreach (var field in simpleFields)
        { 

#line default
#line hidden

#line 137 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, GenerateJsonField(field, item));


#line default
#line hidden

#line 137 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                                          }
        foreach (var child in children)
        {

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");

WriteLiteralTo(__razor_helper_writer, " ");


#line 139 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, child.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ": ");


#line 139 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
  WriteTo(__razor_helper_writer, RenderInitModelValues(child, (IEntity)item));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ", ");

WriteLiteralTo(__razor_helper_writer, " ");


#line 139 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                                                                                      } 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, " ItemId: ");


#line 140 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, ((IEntity)item).Id);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ", OziPropertiesPath: \'");


#line 140 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                                     WriteTo(__razor_helper_writer, settings.GetFullPropertyName());


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\'},");

WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 141 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "]\r\n");


#line 143 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"


#line default
#line hidden
});

#line 143 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
}
#line default
#line hidden

#line 145 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
public System.Web.WebPages.HelperResult GenerateJsonField(FieldSettings field, object item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 146 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
 
    var val = TypeHelpers.GetPropertyValue(item, field.Name);
    if (field is UploadFileSettings)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        ");


#line 150 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, field.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ": \'");


#line 150 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
 WriteTo(__razor_helper_writer, val == null ? string.Empty : Url.Content(((IFileEntity)val).Name));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\',");

WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 151 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    }
    else if (val != null)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        ");


#line 154 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, field.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ": \'");


#line 154 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, Html.Raw(val.ToString().Replace("'", "\\'")));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\',");

WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 155 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    }


#line default
#line hidden
});

#line 156 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
}
#line default
#line hidden

#line 158 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
public System.Web.WebPages.HelperResult RenderModel(CollectionSettings settings)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 159 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
 
    var db = ((OziController) ViewContext.Controller).DataModelContext;
    foreach (var item in settings.Fields.GetOf<FieldSettings, CollectionSettings>())
    {


#line default
#line hidden

#line 163 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, RenderModel(item));


#line default
#line hidden

#line 163 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                  
    }
    var thisModelName = settings.GetFullPropertyName().Replace(".", string.Empty);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "var ");


#line 166 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, thisModelName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "Model = function(m, index, parentCollection, parent){                           ");

WriteLiteralTo(__razor_helper_writer, @"
    var self = this;
    self.plugins = [];
    self.renderPlugins = function() {
        $(self.plugins).each(function(index, f){
            f();
        });
        self.plugins = [];
    };
    self.index = ko.observable(index);
    self.ItemId = ko.observable(m.ItemId || 0);
    self.ModelId = ");


#line 177 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, WebContext.Model != null ? WebContext.Model.Id : 0);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ";\r\n    self.parent = parent;\r\n    self.propName = \'");


#line 179 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, settings.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\';\r\n    self.parentCollection = parentCollection;\r\n\r\n");


#line 182 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    

#line default
#line hidden

#line 182 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
     foreach (var item in settings.Fields.GetNotOf<FieldSettings, CollectionSettings>())
    {

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    ");

WriteLiteralTo(__razor_helper_writer, "self.");


#line 183 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " = ko.observable(m.");


#line 183 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                      WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ");");

WriteLiteralTo(__razor_helper_writer, " ");


#line 183 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                                                                         }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 185 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    

#line default
#line hidden

#line 185 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
     foreach (var item in settings.Fields.GetOf<FieldSettings, SelectSettings>())
    {
        var type = TypeHelpers.GetPropertyType(WebContext.Model, item.GetFullPropertyName());
        var list = ((IListSource)TypeHelpers.GetEntitySet(db, type)).GetList().Cast<object>().Select<object, string>(a => string.Format("{{value: {0}, label: '{1}'}}", TypeHelpers.GetPropertyValue(a, item.OptionValue), TypeHelpers.GetPropertyValue(a, item.OptionTitle)));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, "self.available");


#line 189 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " = [");


#line 189 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
              WriteTo(__razor_helper_writer, Html.Raw(string.Join(",", list)));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "];");

WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, "self.newValue = \'\';");

WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, "$(\"body\").data(\"");


#line 191 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
 WriteTo(__razor_helper_writer, item.GetFullPropertyName().Replace(".", "_"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\", self.available");


#line 191 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                                                                 WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ");");

WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, "self.current");


#line 192 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " = ko.computed({ \r\n            read: function(){\r\n                var result = $(" +
"self.available");


#line 194 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ").filter(function(index, el){\r\n                    return el.value == self.");


#line 195 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
               WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "();\r\n                });\r\n                return (result && result.length > 0) ? " +
"result[0].label : self.newValue;\r\n            }, \r\n            write: function(v" +
"alue){\r\n                var result = $(self.available");


#line 200 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ").filter(function(index, el){\r\n                    return el.value == value;\r\n   " +
"             });\r\n                if (result && result.length > 0) {\r\n          " +
"          self.newValue = \'\';\r\n                    self.");


#line 205 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "(result[0].value);\r\n                } else {\r\n                    self.newValue =" +
" value;\r\n                    self.");


#line 208 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "(0);\r\n                }\r\n            },\r\n            owner: self});");

WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, "self.parent.plugins.push(function(){\r\n            makeAutocomplete($(\"#\" + self.g" +
"enerateId() + \"_");


#line 213 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                              WriteTo(__razor_helper_writer, item.OptionTitle);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\").get(0));\r\n        });");

WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 215 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 217 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    

#line default
#line hidden

#line 217 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
     foreach (var item in settings.Fields.GetOf<FieldSettings, UploadFileSettings>())
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, "self.parent.plugins.push(function(){\r\n            makeFileUpload(\"#\" + self.gener" +
"ateId() + \"_");


#line 220 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                          WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\");\r\n        });");

WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, "self.show");


#line 222 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "img = ko.computed(function(){\r\n            return !!self.ItemId() && !!self.Model" +
"Id && !!self.");


#line 223 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                                  WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "();\r\n        }, self);");

WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, "self.show");


#line 225 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "panel = ko.computed(function(){\r\n            return !!self.ItemId() && !!self.Mod" +
"elId;\r\n        }, self);");

WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, "self.show");


#line 228 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "text = ko.computed(function(){\r\n            return !self.ItemId() || !self.ModelI" +
"d;\r\n        }, self);");

WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 231 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 233 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    

#line default
#line hidden

#line 233 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
     foreach (var item in settings.Fields.GetOf<FieldSettings, CollectionSettings>())
    {

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    ");

WriteLiteralTo(__razor_helper_writer, "\r\n            self.");


#line 235 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " = ko.observableArray([]);\r\n            self.add");


#line 236 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "Item = function(){\r\n                self.");


#line 237 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ".push(new ");


#line 237 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
              WriteTo(__razor_helper_writer, item.GetFullPropertyName().Replace(".", string.Empty));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "Model({}, self.");


#line 237 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                                                                                     WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "().length, self.");


#line 237 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                                                                                                                 WriteTo(__razor_helper_writer, item.Name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ", self));\r\n            };\r\n         ");

WriteLiteralTo(__razor_helper_writer, " \r\n");


#line 240 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, @"        self.removeItem = function(item){
            if(confirm(""Удалить элемент?"")){
                self.parentCollection.remove(self);
                $(self.parentCollection()).each(function(i, e){
                    e.index(i);
                });
            }
        };
        self.generateName = ko.computed(function(){
            var parentName = '';
            var prefix ='';
            if (!!this.parent && !!this.parent.generateName) parentName = this.parent.generateName() + ""."";
            else prefix = 'collection_';
            return prefix + parentName + this.propName + ""["" + this.index() + ""]"";
        }, self);
        self.generateId = ko.computed(function(){
            return self.generateName().replace(/[\[\]\.]/g, ""_"");//.replace(""."", ""_"").replace(""["", ""_"").replace(""]"", ""_"");
        }, self);
    };
    ");

WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 261 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"


#line default
#line hidden
});

#line 261 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
}
#line default
#line hidden

#line 303 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
public System.Web.WebPages.HelperResult RenderPropertyView(FieldSettings settings)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 304 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
 
    Html.RenderPartial(string.Format("EditorTemplates/Collections/{0}", settings.Control), settings);

    
    //if (settings is StringSettings)
    //{
    //    @StringPropertyView((StringSettings)settings)
    //}
    //else if (settings is DateSettings)
    //{
    //    @DatePropertyView((DateSettings)settings)
    //}
    //else if (settings is TextareaSettings)
    //{
    //    @TextareaPropertyView((TextareaSettings)settings)
    //}
    //else if (settings is WysiwygSettings)
    //{
    //    @WysiwygPropertyView((WysiwygSettings)settings)
    //}
    //else if (settings is SelectSettings)
    //{
    //    @SelectPropertyView((SelectSettings)settings)
    //}
    //else if (settings is UploadFileSettings)
    //{
    //    @UploadFilePropertyView((UploadFileSettings)settings)
    //}


#line default
#line hidden
});

#line 332 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
}
#line default
#line hidden

        public _Areas_Admin_Views_Shared_EditorTemplates_ozi_Collection_cshtml_()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 10 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
  
    var settings = (CollectionSettings)WebContext.FieldSettings;
    var model = WebContext.Model;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 15 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
 if (model == null)
{

            
            #line default
            #line hidden
WriteLiteral("    <div>\r\n        Необходимо сначала сохранить объект\r\n    </div>\r\n");

            
            #line 20 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
}
else
{

    
            
            #line default
            #line hidden
            
            #line 29 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
      
    

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"knockout-root\"");

WriteAttribute("id", Tuple.Create(" id=\"", 683), Tuple.Create("\"", 708)
            
            #line 31 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
, Tuple.Create(Tuple.Create("", 688), Tuple.Create<System.Object, System.Int32>(settings.Name
            
            #line default
            #line hidden
, 688), false)
, Tuple.Create(Tuple.Create("", 704), Tuple.Create("List", 704), true)
);

WriteLiteral(" >\r\n        <ul");

WriteLiteral(" data-bind=\"{foreach: { data: elements, afterRender: renderPlugins }}\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 33 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
       Write(RenderView(settings));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </ul>\r\n");

WriteLiteral("        ");

            
            #line 35 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
   Write(RenderButtons(settings));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 37 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
    //   генерация скриптов (модели и вьюмодели, а также их инициализация)
    

            
            #line default
            #line hidden
WriteLiteral("    <script>\r\n");

            
            #line 40 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
Write(RenderModel(settings));

            
            #line default
            #line hidden
WriteLiteral("\r\nvar ");

            
            #line 41 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
Write(settings.Name);

            
            #line default
            #line hidden
WriteLiteral(@"ViewModel = function() {
    var self = this;
    self.plugins = [];
    self.renderPlugins = function() {
        $(self.plugins).each(function(index, f) {
            f();
        });
        self.plugins = [];
        //alert(""hi viewModel!"");
    };
    self.elements = ko.observableArray([]);
    self.add");

            
            #line 52 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
        Write(settings.Name);

            
            #line default
            #line hidden
WriteLiteral("Item = function() {\r\n        self.elements.push(new ");

            
            #line 53 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                           Write(settings.GetFullPropertyName().Replace(".", string.Empty));

            
            #line default
            #line hidden
WriteLiteral("Model({}, self.elements().length, self.elements, self));\r\n    };\r\n};\r\n\r\n        $" +
"(function() {\r\n            var vm = new ");

            
            #line 58 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                     Write(settings.Name);

            
            #line default
            #line hidden
WriteLiteral("ViewModel();\r\n            var elems = ");

            
            #line 59 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                   Write(RenderInitModelValues(settings, model));

            
            #line default
            #line hidden
WriteLiteral(";\r\n            $.each(elems, function(index, elem) {\r\n");

            
            #line 61 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                
            
            #line default
            #line hidden
            
            #line 61 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                   var parentElName = settings.GetFullPropertyName().Replace(".", string.Empty); 
            
            #line default
            #line hidden
WriteLiteral("\r\n                var elem");

            
            #line 62 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                    Write(parentElName);

            
            #line default
            #line hidden
WriteLiteral(" = new ");

            
            #line 62 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                                          Write(parentElName);

            
            #line default
            #line hidden
WriteLiteral("Model(elem, index, vm.elements, vm); // инициируем обычные поля\r\n");

WriteLiteral("                ");

            
            #line 63 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
           Write(RenderInitViewModel(settings, parentElName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                vm.elements.push(elem");

            
            #line 64 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                                 Write(parentElName);

            
            #line default
            #line hidden
WriteLiteral(");\r\n            });\r\n            ko.applyBindings(vm, $(\"#");

            
            #line 66 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
                                 Write(settings.Name);

            
            #line default
            #line hidden
WriteLiteral("List\").get(0));\r\n        });\r\n    </script>\r\n");

            
            #line 69 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Collection.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
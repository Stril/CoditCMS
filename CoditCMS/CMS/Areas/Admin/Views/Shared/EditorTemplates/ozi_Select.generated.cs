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
    
    #line 1 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
    using System.Collections;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 2 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
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
    
    #line 3 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
    using CMS.Controllers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
    using CMS.Helpers;
    
    #line default
    #line hidden
    using CMS.Mvc;
    
    #line 5 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
    using CMS.PagesSettings.Forms;
    
    #line default
    #line hidden
    using CMS.PagesSettings.Lists;
    using CMS.ViewModels;
    using DB.Entities;
    
    #line 9 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
    using Libs;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
    using DB.Entities;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
    using CMS;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
    using CMS.Core;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Shared/EditorTemplates/ozi_Select.cshtml")]
    public partial class _Areas_Admin_Views_Shared_EditorTemplates_ozi_Select_cshtml_ : CMS.Mvc.AdminViewPage<dynamic>
    {

#line 171 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
public System.Web.WebPages.HelperResult IsValue(string curVal, object model, string mString = null)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 172 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
 
    if (mString != null && curVal == mString)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, "selected=\"selected\"");

WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 176 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
    }
    if (model is string && curVal == (string)model)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, "selected=\"selected\"");

WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 180 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
    }
    else if (model is IEnumerable && !(model is string))
    {
        var list = ((IEnumerable)model).Cast<IEntity>();
        if (list.Any(entity => entity.Id.ToString() == curVal))
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            ");

WriteLiteralTo(__razor_helper_writer, "selected=\"selected\"");

WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 187 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
        }
    }
    else if (model != null)
    {
        var modelString = model.ToString();
        if (modelString.Equals(curVal, StringComparison.InvariantCultureIgnoreCase))
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            ");

WriteLiteralTo(__razor_helper_writer, "selected=\"selected\"");

WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 195 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
        }
    }


#line default
#line hidden
});

#line 197 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
}
#line default
#line hidden

        public _Areas_Admin_Views_Shared_EditorTemplates_ozi_Select_cshtml_()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 11 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
  
    
    /*  описание свойств:
     * 
     
   		string Data - имя ключа, по которому можно получить список элементов для селекта
		string OptionTitle - текст
		string OptionValue - ключ
		List<OptionSettings> Options - предпределённые элементы
		bool Levels - использует ли вложенность
		bool Multiple - доступен ли множественный выбор

		string TypeName - тип, с помощью которого можно получить данные
		string PropertyName - свойство, возвращающее список доступных элементов (работает только при указанном типе)
		string MethodName - метод, возвращающий список доступных элементов (работает только при указанном типе)

     * если по данным ничего не установлено, берутся значения из бд по типу
     
     * 
     *  принцип работы
     *     берём текущее значение из модели
     *     если оно не указано, смотрим, есть ли такое значение в предопределённых (PreValue должно быть выставлено в true), если да, то устанавливаем именно его
     *     
     *      получаем данные: сначала просматривается свойство Data, если оно пустое, то тип, в котором свойство или метод, через которые и получаем данные
     *      
     * 
     */


    var fieldSettings = (SelectSettings)WebContext.FieldSettings;

    var model = TypeHelpers.GetPropertyValue(WebContext.Model, fieldSettings.Name, null); // текущее значение свойства

    var modelString = model != null ? model.ToString() : "";
    if (fieldSettings.PreValue && string.IsNullOrEmpty(modelString))
    {
        modelString = Session[string.Format("prevalue_{0}_{1}", fieldSettings.Name, ViewBag.EditViewModel.FormData.GetType().Name)];
    }

    IEnumerable<object> data = null;

    if (!string.IsNullOrEmpty(fieldSettings.Data))
    {
        data = (IEnumerable<object>)WebContext.ViewData[fieldSettings.Data];
    }
    else if (!string.IsNullOrEmpty(fieldSettings.TypeName))
    {
        if (!string.IsNullOrEmpty(fieldSettings.PropertyName))
        {
            data = (IEnumerable<object>)TypeHelpers.GetPropertyValue(fieldSettings.TypeName, fieldSettings.PropertyName);
        }
        else if (!string.IsNullOrEmpty(fieldSettings.MethodName))
        {
            data = (IEnumerable<object>)TypeHelpers.ExecuteMethod(fieldSettings.TypeName, fieldSettings.MethodName);
        }
    }
    else if (!string.IsNullOrEmpty(fieldSettings.Reference))
    {
        var db = ((OziController)ViewContext.Controller).DataModelContext;
        if (db != null)
        {
            var t = TypeHelpers.GetPropertyType(WebContext.ModelType, fieldSettings.GetFullPropertyName());
            var d = TypeHelpers.GetEntitySet(db, t).Cast<IEntity>();
            
            if (typeof(ISortableEntity).IsAssignableFrom(t))
            {
                d = d.OrderBy(entity => ((ISortableEntity)entity).Sort);
            }

            if (fieldSettings.Levels)
            {
                d = PlainTree.GetTree(d.Cast<IPlainTreeItem>().Where(p => WebContext.Model == null || (p.GetType() != WebContext.Model.GetType() || (p.ParentId != WebContext.Model.Id || p.ParentId == null) && p.Id != WebContext.Model.Id)));
            }
            data = d.ToList();
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 89 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
 if (!fieldSettings.Editable)
{


            
            #line default
            #line hidden
WriteLiteral("    <select");

WriteAttribute("name", Tuple.Create(" name=\"", 3490), Tuple.Create("\"", 3535)
            
            #line 92 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
, Tuple.Create(Tuple.Create("", 3497), Tuple.Create<System.Object, System.Int32>(ViewData.TemplateInfo.HtmlFieldPrefix
            
            #line default
            #line hidden
, 3497), false)
);

WriteLiteral(" class=\"ozi-select\"");

WriteLiteral(" \r\n        ");

            
            #line 93 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
         if (fieldSettings.Multiple)
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

WriteLiteral("multiple=\"multiple\" style=\"width: 400px;\"");

WriteLiteral("\r\n");

            
            #line 96 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
            if (fieldSettings.Height != 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("size=\"");

            
            #line 98 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                        Write(fieldSettings.Height);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n");

            
            #line 99 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
            }
        } 

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 101 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
         if (fieldSettings.Disabled)
        {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("disabled=\"disabled\"");

WriteLiteral(" ");

            
            #line 102 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                           }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 103 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
         if (fieldSettings.Readonly)
        {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("readonly=\"readonly\"");

            
            #line 104 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                          }
            
            #line default
            #line hidden
WriteLiteral(">\r\n        \r\n");

            
            #line 106 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
        
            
            #line default
            #line hidden
            
            #line 106 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
         foreach (OptionSettings option in fieldSettings.Options)
        {
            
            #line default
            #line hidden
WriteLiteral("<option ");

            
            #line 107 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
            Write(IsValue(option.Value, model, modelString));

            
            #line default
            #line hidden
WriteLiteral(" value=\"");

            
            #line 107 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                                              Write(option.Value);

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 107 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                                                             Write(option.Title);

            
            #line default
            #line hidden
WriteLiteral("</option>");

            
            #line 107 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                                                                                        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 108 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
         if (data != null)
        {
            foreach (var option in data)
            {
                var optionValue = TypeHelpers.GetPropertyValue(option, fieldSettings.OptionValue).ToString();
                var value = TypeHelpers.GetPropertyValue(option, fieldSettings.OptionTitle);
                if (fieldSettings.Localizable && value is Guid)
                {
                    value = Lp.GetMessage((Guid) value);
                }

            
            #line default
            #line hidden
WriteLiteral("                <option ");

            
            #line 118 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                   Write(IsValue(optionValue, model, modelString));

            
            #line default
            #line hidden
WriteLiteral(" value=\"");

            
            #line 118 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                                                    Write(optionValue);

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 118 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                                                                        if (fieldSettings.Levels)
                                                                                       {
                                                                                           for (var i = 0; i < (Int32.Parse(TypeHelpers.GetPropertyValue(option, "Level").ToString()) - 1); i++)
                                                                                           {
            
            #line default
            #line hidden
WriteLiteral("&nbsp;-&nbsp;");

            
            #line 121 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                                                                                                      }
            
            #line default
            #line hidden
WriteLiteral("○&nbsp;");

WriteLiteral(" ");

            
            #line 121 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                                                                                                                            }
            
            #line default
            #line hidden
            
            #line 121 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                                                                                                                        Write(value);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 122 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
            }
        }

            
            #line default
            #line hidden
WriteLiteral("    </select>\r\n");

            
            #line 125 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
}
else
{
    string val = string.Empty;
    string label = string.Empty;
    if (model != null)
    {
        if (fieldSettings.Multiple)
        {
            label = string.Join(", ", ((IListSource) model).GetList().Cast<object>().ToList().Select<object, string>(a => (TypeHelpers.GetPropertyValue(a, fieldSettings.OptionTitle)).ToString()));
        }
        else
        {
            label = (TypeHelpers.GetPropertyValue(model, fieldSettings.OptionTitle)).ToString();
            val = (TypeHelpers.GetPropertyValue(model, fieldSettings.OptionValue)).ToString();
        }
    }

            
            #line default
            #line hidden
WriteLiteral("    <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 5861), Tuple.Create("\"", 5918)
            
            #line 142 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
, Tuple.Create(Tuple.Create("", 5868), Tuple.Create<System.Object, System.Int32>(fieldSettings.Name
            
            #line default
            #line hidden
, 5868), false)
, Tuple.Create(Tuple.Create("", 5889), Tuple.Create(".", 5889), true)
            
            #line 142 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
, Tuple.Create(Tuple.Create("", 5890), Tuple.Create<System.Object, System.Int32>(fieldSettings.OptionValue
            
            #line default
            #line hidden
, 5890), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 5919), Tuple.Create("\"", 5974)
            
            #line 142 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
        , Tuple.Create(Tuple.Create("", 5924), Tuple.Create<System.Object, System.Int32>(fieldSettings.Name
            
            #line default
            #line hidden
, 5924), false)
, Tuple.Create(Tuple.Create("", 5945), Tuple.Create("_", 5945), true)
            
            #line 142 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                              , Tuple.Create(Tuple.Create("", 5946), Tuple.Create<System.Object, System.Int32>(fieldSettings.OptionValue
            
            #line default
            #line hidden
, 5946), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 5975), Tuple.Create("\"", 5987)
            
            #line 142 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                                                  , Tuple.Create(Tuple.Create("", 5983), Tuple.Create<System.Object, System.Int32>(val
            
            #line default
            #line hidden
, 5983), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("    <input");

WriteAttribute("value", Tuple.Create(" value=\"", 6003), Tuple.Create("\"", 6017)
            
            #line 143 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
, Tuple.Create(Tuple.Create("", 6011), Tuple.Create<System.Object, System.Int32>(label
            
            #line default
            #line hidden
, 6011), false)
);

WriteLiteral(" class=\"autocomplete ozi-string\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" ");

            
            #line 143 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                                                 Write(Html.Raw(ByCondition(fieldSettings.Multiple, "multiple='true'")));

            
            #line default
            #line hidden
WriteLiteral(" data-hiddenid=\"");

            
            #line 143 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                                                                                                                                   Write(fieldSettings.Name);

            
            #line default
            #line hidden
WriteLiteral("_");

            
            #line 143 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                                                                                                                                                         Write(fieldSettings.OptionValue);

            
            #line default
            #line hidden
WriteLiteral("\" data-sourcename=\"");

            
            #line 143 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                                                                                                                                                                                                        Write(fieldSettings.Name);

            
            #line default
            #line hidden
WriteLiteral("\" name=\"");

            
            #line 143 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                                                                                                                                                                                                                                     Write(fieldSettings.Name);

            
            #line default
            #line hidden
WriteLiteral(".");

            
            #line 143 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                                                                                                                                                                                                                                                           Write(fieldSettings.OptionTitle);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n");

WriteLiteral("    <script>\r\n        var d;\r\n        try {\r\n            d = $(\"body\").data(\"");

            
            #line 147 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                            Write(fieldSettings.Name);

            
            #line default
            #line hidden
WriteLiteral("\");\r\n        } catch(e) {\r\n            \r\n        }\r\n        if (!d) {\r\n          " +
"      d = [\r\n");

            
            #line 153 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 153 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                     foreach (var option in data)
                    {
                        var optionValue = TypeHelpers.GetPropertyValue(option, fieldSettings.OptionValue).ToString();
                        var value = TypeHelpers.GetPropertyValue(option, fieldSettings.OptionTitle);

            
            #line default
            #line hidden
WriteLiteral("                        ");

WriteLiteral("{ value: \'");

            
            #line 157 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                   Write(optionValue);

            
            #line default
            #line hidden
WriteLiteral("\', label : \'");

            
            #line 157 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                                                       if (fieldSettings.Levels){for (var i = 0; i < (Int32.Parse(TypeHelpers.GetPropertyValue(option, "Level").ToString()) - 1); i++){
            
            #line default
            #line hidden
WriteLiteral("&nbsp;-&nbsp;");

            
            #line 157 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                                                                                                                                                                                                                 }
            
            #line default
            #line hidden
WriteLiteral("○&nbsp;");

            
            #line 157 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                                                                                                                                                                                                                                      }
            
            #line default
            #line hidden
            
            #line 157 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                                                                                                                                                                                                                                                        Write(value);

            
            #line default
            #line hidden
WriteLiteral("\'},");

WriteLiteral("\r\n");

            
            #line 158 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                ];\r\n                $(\"body\").data(\"");

            
            #line 160 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
                            Write(fieldSettings.Name);

            
            #line default
            #line hidden
WriteLiteral("\", d);\r\n            }\r\n    </script>\r\n");

            
            #line 163 "..\..\Areas\Admin\Views\Shared\EditorTemplates\ozi_Select.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n");

        }
    }
}
#pragma warning restore 1591

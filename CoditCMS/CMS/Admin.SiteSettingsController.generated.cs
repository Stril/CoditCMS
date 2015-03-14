// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace MedIn.Web.Areas.Admin.Controllers
{
    public partial class SiteSettingsController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SiteSettingsController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected SiteSettingsController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult SetLanguage()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SetLanguage);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SiteSettingsController Actions { get { return MVC.Admin.SiteSettings; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Admin";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "SiteSettings";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "SiteSettings";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Emails = "Emails";
            public readonly string Logs = "Logs";
            public readonly string General = "General";
            public readonly string SetLanguage = "SetLanguage";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Emails = "Emails";
            public const string Logs = "Logs";
            public const string General = "General";
            public const string SetLanguage = "SetLanguage";
        }


        static readonly ActionParamsClass_Emails s_params_Emails = new ActionParamsClass_Emails();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Emails EmailsParams { get { return s_params_Emails; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Emails
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_General s_params_General = new ActionParamsClass_General();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_General GeneralParams { get { return s_params_General; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_General
        {
            public readonly string values = "values";
        }
        static readonly ActionParamsClass_SetLanguage s_params_SetLanguage = new ActionParamsClass_SetLanguage();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SetLanguage SetLanguageParams { get { return s_params_SetLanguage; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SetLanguage
        {
            public readonly string l = "l";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string Emails = "Emails";
                public readonly string General = "General";
                public readonly string Logs = "Logs";
            }
            public readonly string Emails = "~/Areas/Admin/Views/SiteSettings/Emails.cshtml";
            public readonly string General = "~/Areas/Admin/Views/SiteSettings/General.cshtml";
            public readonly string Logs = "~/Areas/Admin/Views/SiteSettings/Logs.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_SiteSettingsController : MedIn.Web.Areas.Admin.Controllers.SiteSettingsController
    {
        public T4MVC_SiteSettingsController() : base(Dummy.Instance) { }

        [NonAction]
        partial void EmailsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Emails()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Emails);
            EmailsOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void EmailsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Net.Configuration.SmtpSection model);

        [NonAction]
        public override System.Web.Mvc.ActionResult Emails(System.Net.Configuration.SmtpSection model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Emails);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            EmailsOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void LogsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Logs()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Logs);
            LogsOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GeneralOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult General()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.General);
            GeneralOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GeneralOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Web.Mvc.FormCollection values);

        [NonAction]
        public override System.Web.Mvc.ActionResult General(System.Web.Mvc.FormCollection values)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.General);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "values", values);
            GeneralOverride(callInfo, values);
            return callInfo;
        }

        [NonAction]
        partial void SetLanguageOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string l);

        [NonAction]
        public override System.Web.Mvc.ActionResult SetLanguage(string l)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SetLanguage);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "l", l);
            SetLanguageOverride(callInfo, l);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108

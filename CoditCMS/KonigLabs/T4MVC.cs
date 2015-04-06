﻿// <auto-generated />
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

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    public static KonigLabs.Controllers.AccountController Account = new KonigLabs.Controllers.T4MVC_AccountController();
    public static CMS.Areas.Admin.Controllers.ArticleController Article = new CMS.Areas.Admin.Controllers.T4MVC_ArticleController();
    public static CMS.Areas.Admin.Controllers.CategoryController Category = new CMS.Areas.Admin.Controllers.T4MVC_CategoryController();
    public static CMS.Areas.Admin.Controllers.ClientController Client = new CMS.Areas.Admin.Controllers.T4MVC_ClientController();
    public static CMS.Areas.Admin.Controllers.ContactController Contact = new CMS.Areas.Admin.Controllers.T4MVC_ContactController();
    public static CMS.Areas.Admin.Controllers.CrewController Crew = new CMS.Areas.Admin.Controllers.T4MVC_CrewController();
    public static KonigLabs.Controllers.DefaultController Default = new KonigLabs.Controllers.T4MVC_DefaultController();
    public static KonigLabs.Controllers.HomeController Home = new KonigLabs.Controllers.T4MVC_HomeController();
    public static KonigLabs.Controllers.ManageController Manage = new KonigLabs.Controllers.T4MVC_ManageController();
    public static CMS.Areas.Admin.Controllers.ProjectController Project = new CMS.Areas.Admin.Controllers.T4MVC_ProjectController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_CMS_ViewModels_FineUploaderResult : CMS.ViewModels.FineUploaderResult, IT4MVCActionResult
{
    public T4MVC_CMS_ViewModels_FineUploaderResult(string area, string controller, string action, string protocol = null): base(default(bool), null, null, null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string _references_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/_references.min.js") ? Url("_references.min.js") : Url("_references.js");
        public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
        public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
        public static readonly string jquery_1_10_2_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.10.2.intellisense.min.js") ? Url("jquery-1.10.2.intellisense.min.js") : Url("jquery-1.10.2.intellisense.js");
        public static readonly string jquery_1_10_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.10.2.min.js") ? Url("jquery-1.10.2.min.js") : Url("jquery-1.10.2.js");
        public static readonly string jquery_1_10_2_min_js = Url("jquery-1.10.2.min.js");
        public static readonly string jquery_1_10_2_min_map = Url("jquery-1.10.2.min.map");
        public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
        public static readonly string modernizr_2_6_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/modernizr-2.6.2.min.js") ? Url("modernizr-2.6.2.min.js") : Url("modernizr-2.6.2.js");
        public static readonly string respond_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/respond.min.js") ? Url("respond.min.js") : Url("respond.js");
        public static readonly string respond_min_js = Url("respond.min.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.css") ? Url("bootstrap.min.css") : Url("bootstrap.css");
             
        public static readonly string bootstrap_min_css = Url("bootstrap.min.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Media {
            private const string URLPATH = "~/Content/Media";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string _1_1__jpg = Url("1(1).jpg");
            public static readonly string _1_jpg = Url("1.jpg");
            public static readonly string _2_1__jpg = Url("2(1).jpg");
            public static readonly string _2_jpg = Url("2.jpg");
            public static readonly string _3_1__jpg = Url("3(1).jpg");
            public static readonly string _3_jpg = Url("3.jpg");
            public static readonly string _4_1__jpg = Url("4(1).jpg");
            public static readonly string _4_jpg = Url("4.jpg");
            public static readonly string _5_jpg = Url("5.jpg");
            public static readonly string _6_jpg = Url("6.jpg");
            public static readonly string _7_jpg = Url("7.jpg");
            public static readonly string _71ikiLcMrGYIGyvMYn7ZsljFfaS4wGaxf80_aqUxjBw_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/71ikiLcMrGYIGyvMYn7ZsljFfaS4wGaxf80-aqUxjBw.min.js") ? Url("71ikiLcMrGYIGyvMYn7ZsljFfaS4wGaxf80-aqUxjBw.min.js") : Url("71ikiLcMrGYIGyvMYn7ZsljFfaS4wGaxf80-aqUxjBw.js");
            public static readonly string _8_jpg = Url("8.jpg");
            public static readonly string a1_jpg = Url("a1.jpg");
            public static readonly string a2_jpg = Url("a2.jpg");
            public static readonly string a3_jpg = Url("a3.jpg");
            public static readonly string a4_jpg = Url("a4.jpg");
            public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
            public static readonly string cb_scout2_png = Url("cb_scout2.png");
            public static readonly string charts_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/charts.min.js") ? Url("charts.min.js") : Url("charts.js");
            public static readonly string common_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/common.min.js") ? Url("common.min.js") : Url("common.js");
            public static readonly string controls_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/controls.min.js") ? Url("controls.min.js") : Url("controls.js");
            public static readonly string count_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/count.min.js") ? Url("count.min.js") : Url("count.js");
            public static readonly string css = Url("css");
            public static readonly string css_1_ = Url("css(1)");
            public static readonly string cubeportfolio_min_css = Url("cubeportfolio.min.css");
            public static readonly string custom_modernizr_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/custom.modernizr.min.js") ? Url("custom.modernizr.min.js") : Url("custom.modernizr.js");
            public static readonly string face_logo_png = Url("face_logo.png");
            public static readonly string geocoder_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/geocoder.min.js") ? Url("geocoder.min.js") : Url("geocoder.js");
            public static readonly string gmap3_min_js = Url("gmap3.min.js");
            public static readonly string google_white2_png = Url("google_white2.png");
            public static readonly string html5player_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/html5player.min.js") ? Url("html5player.min.js") : Url("html5player.js");
            public static readonly string imgs8_png = Url("imgs8.png");
            public static readonly string jquery_appear_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.appear.min.js") ? Url("jquery.appear.min.js") : Url("jquery.appear.js");
            public static readonly string jquery_cubeportfolio_min_js = Url("jquery.cubeportfolio.min.js");
            public static readonly string jquery_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.min.js") ? Url("jquery.min.js") : Url("jquery.js");
            public static readonly string js = Url("js");
            public static readonly string logo_png = Url("logo.png");
            public static readonly string logo1_png = Url("logo1.png");
            public static readonly string logo2_png = Url("logo2.png");
            public static readonly string logo3_png = Url("logo3.png");
            public static readonly string logo4_png = Url("logo4.png");
            public static readonly string logo5_png = Url("logo5.png");
            public static readonly string logo6_png = Url("logo6.png");
            public static readonly string logo7_png = Url("logo7.png");
            public static readonly string logo8_png = Url("logo8.png");
            public static readonly string main_1__js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/main(1).min.js") ? Url("main(1).min.js") : Url("main(1).js");
            public static readonly string main_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/main.min.js") ? Url("main.min.js") : Url("main.js");
            public static readonly string map_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/map.min.js") ? Url("map.min.js") : Url("map.js");
            public static readonly string mapcnt6_png = Url("mapcnt6.png");
            public static readonly string marker_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/marker.min.js") ? Url("marker.min.js") : Url("marker.js");
            public static readonly string onion_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/onion.min.js") ? Url("onion.min.js") : Url("onion.js");
            public static readonly string owl_carousel_min_js = Url("owl.carousel.min.js");
            public static readonly string parallax_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/parallax.min.js") ? Url("parallax.min.js") : Url("parallax.js");
            public static readonly string player_api = Url("player_api");
            public static readonly string PnwNOtG06Dg_html = Url("PnwNOtG06Dg.html");
            public static readonly string QuotaService_RecordEvent = Url("QuotaService.RecordEvent");
            public static readonly string retina_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/retina.min.js") ? Url("retina.min.js") : Url("retina.js");
            public static readonly string royal_preloader_min_js = Url("royal_preloader.min.js");
            public static readonly string scripts_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/scripts.min.js") ? Url("scripts.min.js") : Url("scripts.js");
            public static readonly string smooth_scroll_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/smooth-scroll.min.js") ? Url("smooth-scroll.min.js") : Url("smooth-scroll.js");
            public static readonly string stats_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/stats.min.js") ? Url("stats.min.js") : Url("stats.js");
            public static readonly string util_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/util.min.js") ? Url("util.min.js") : Url("util.js");
            public static readonly string ViewportInfoService_GetViewportInfo = Url("ViewportInfoService.GetViewportInfo");
            public static readonly string vt = Url("vt");
            public static readonly string vt_1_ = Url("vt(1)");
            public static readonly string vt_10_ = Url("vt(10)");
            public static readonly string vt_11_ = Url("vt(11)");
            public static readonly string vt_12_ = Url("vt(12)");
            public static readonly string vt_13_ = Url("vt(13)");
            public static readonly string vt_14_ = Url("vt(14)");
            public static readonly string vt_15_ = Url("vt(15)");
            public static readonly string vt_16_ = Url("vt(16)");
            public static readonly string vt_17_ = Url("vt(17)");
            public static readonly string vt_18_ = Url("vt(18)");
            public static readonly string vt_19_ = Url("vt(19)");
            public static readonly string vt_2_ = Url("vt(2)");
            public static readonly string vt_20_ = Url("vt(20)");
            public static readonly string vt_21_ = Url("vt(21)");
            public static readonly string vt_22_ = Url("vt(22)");
            public static readonly string vt_23_ = Url("vt(23)");
            public static readonly string vt_24_ = Url("vt(24)");
            public static readonly string vt_25_ = Url("vt(25)");
            public static readonly string vt_3_ = Url("vt(3)");
            public static readonly string vt_4_ = Url("vt(4)");
            public static readonly string vt_5_ = Url("vt(5)");
            public static readonly string vt_6_ = Url("vt(6)");
            public static readonly string vt_7_ = Url("vt(7)");
            public static readonly string vt_8_ = Url("vt(8)");
            public static readonly string vt_9_ = Url("vt(9)");
            public static readonly string wow_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/wow.min.js") ? Url("wow.min.js") : Url("wow.js");
            public static readonly string www_embed_player_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/www-embed-player.min.js") ? Url("www-embed-player.min.js") : Url("www-embed-player.js");
            public static readonly string www_widgetapi_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/www-widgetapi.min.js") ? Url("www-widgetapi.min.js") : Url("www-widgetapi.js");
            public static readonly string YTPlayer_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/YTPlayer.min.js") ? Url("YTPlayer.min.js") : Url("YTPlayer.js");
        }
    
        public static readonly string Site_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Site.min.css") ? Url("Site.min.css") : Url("Site.css");
             
    }

    
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        public static partial class Scripts 
        {
            public static class Assets
            {
                public const string _references_js = "~/Scripts/_references.js"; 
                public const string bootstrap_js = "~/Scripts/bootstrap.js"; 
                public const string bootstrap_min_js = "~/Scripts/bootstrap.min.js"; 
                public const string jquery_1_10_2_intellisense_js = "~/Scripts/jquery-1.10.2.intellisense.js"; 
                public const string jquery_1_10_2_js = "~/Scripts/jquery-1.10.2.js"; 
                public const string jquery_1_10_2_min_js = "~/Scripts/jquery-1.10.2.min.js"; 
                public const string jquery_validate_js = "~/Scripts/jquery.validate.js"; 
                public const string jquery_validate_min_js = "~/Scripts/jquery.validate.min.js"; 
                public const string jquery_validate_unobtrusive_js = "~/Scripts/jquery.validate.unobtrusive.js"; 
                public const string jquery_validate_unobtrusive_min_js = "~/Scripts/jquery.validate.unobtrusive.min.js"; 
                public const string modernizr_2_6_2_js = "~/Scripts/modernizr-2.6.2.js"; 
                public const string respond_js = "~/Scripts/respond.js"; 
                public const string respond_min_js = "~/Scripts/respond.min.js"; 
            }
        }
        public static partial class Content 
        {
            public static partial class Media 
            {
                public static class Assets
                {
                    public const string _71ikiLcMrGYIGyvMYn7ZsljFfaS4wGaxf80_aqUxjBw_js = "~/Content/Media/71ikiLcMrGYIGyvMYn7ZsljFfaS4wGaxf80-aqUxjBw.js"; 
                    public const string bootstrap_min_js = "~/Content/Media/bootstrap.min.js"; 
                    public const string charts_js = "~/Content/Media/charts.js"; 
                    public const string common_js = "~/Content/Media/common.js"; 
                    public const string controls_js = "~/Content/Media/controls.js"; 
                    public const string count_js = "~/Content/Media/count.js"; 
                    public const string cubeportfolio_min_css = "~/Content/Media/cubeportfolio.min.css";
                    public const string custom_modernizr_js = "~/Content/Media/custom.modernizr.js"; 
                    public const string geocoder_js = "~/Content/Media/geocoder.js"; 
                    public const string gmap3_min_js = "~/Content/Media/gmap3.min.js"; 
                    public const string html5player_js = "~/Content/Media/html5player.js"; 
                    public const string jquery_appear_js = "~/Content/Media/jquery.appear.js"; 
                    public const string jquery_cubeportfolio_min_js = "~/Content/Media/jquery.cubeportfolio.min.js"; 
                    public const string jquery_js = "~/Content/Media/jquery.js"; 
                    public const string main_1__js = "~/Content/Media/main(1).js"; 
                    public const string main_js = "~/Content/Media/main.js"; 
                    public const string map_js = "~/Content/Media/map.js"; 
                    public const string marker_js = "~/Content/Media/marker.js"; 
                    public const string onion_js = "~/Content/Media/onion.js"; 
                    public const string owl_carousel_min_js = "~/Content/Media/owl.carousel.min.js"; 
                    public const string parallax_js = "~/Content/Media/parallax.js"; 
                    public const string retina_js = "~/Content/Media/retina.js"; 
                    public const string royal_preloader_min_js = "~/Content/Media/royal_preloader.min.js"; 
                    public const string scripts_js = "~/Content/Media/scripts.js"; 
                    public const string smooth_scroll_js = "~/Content/Media/smooth-scroll.js"; 
                    public const string stats_js = "~/Content/Media/stats.js"; 
                    public const string util_js = "~/Content/Media/util.js"; 
                    public const string wow_js = "~/Content/Media/wow.js"; 
                    public const string www_embed_player_js = "~/Content/Media/www-embed-player.js"; 
                    public const string www_widgetapi_js = "~/Content/Media/www-widgetapi.js"; 
                    public const string YTPlayer_js = "~/Content/Media/YTPlayer.js"; 
                }
            }
            public static class Assets
            {
                public const string bootstrap_css = "~/Content/bootstrap.css";
                public const string bootstrap_min_css = "~/Content/bootstrap.min.css";
                public const string Site_css = "~/Content/Site.css";
            }
        }
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108



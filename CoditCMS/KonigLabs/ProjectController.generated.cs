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
namespace CMS.Areas.Admin.Controllers
{
    public partial class ProjectController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ProjectController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected ProjectController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult UploadFileCollectionItem()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UploadFileCollectionItem);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Index()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Details()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Details);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Edit()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Delete()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Delete);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult SetVisibility()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SetVisibility);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult SortList()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SortList);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual CMS.ViewModels.FineUploaderResult UploadFile()
        {
            return new T4MVC_CMS_ViewModels_FineUploaderResult(Area, Name, ActionNames.UploadFile);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult DeleteFile()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteFile);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult SaveOrder()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SaveOrder);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult SaveFileData()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SaveFileData);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult SetLanguage()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SetLanguage);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ProjectController Actions { get { return MVC.Project; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Project";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Project";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string UploadFileCollectionItem = "UploadFileCollectionItem";
            public readonly string Index = "Index";
            public readonly string Details = "Details";
            public readonly string Create = "Create";
            public readonly string Edit = "Edit";
            public readonly string Delete = "Delete";
            public readonly string SetVisibility = "SetVisibility";
            public readonly string SortList = "SortList";
            public readonly string UploadFile = "UploadFile";
            public readonly string DeleteFile = "DeleteFile";
            public readonly string SaveOrder = "SaveOrder";
            public readonly string SaveFileData = "SaveFileData";
            public readonly string SetLanguage = "SetLanguage";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string UploadFileCollectionItem = "UploadFileCollectionItem";
            public const string Index = "Index";
            public const string Details = "Details";
            public const string Create = "Create";
            public const string Edit = "Edit";
            public const string Delete = "Delete";
            public const string SetVisibility = "SetVisibility";
            public const string SortList = "SortList";
            public const string UploadFile = "UploadFile";
            public const string DeleteFile = "DeleteFile";
            public const string SaveOrder = "SaveOrder";
            public const string SaveFileData = "SaveFileData";
            public const string SetLanguage = "SetLanguage";
        }


        static readonly ActionParamsClass_UploadFileCollectionItem s_params_UploadFileCollectionItem = new ActionParamsClass_UploadFileCollectionItem();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UploadFileCollectionItem UploadFileCollectionItemParams { get { return s_params_UploadFileCollectionItem; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UploadFileCollectionItem
        {
            public readonly string upload = "upload";
            public readonly string id = "id";
            public readonly string propName = "propName";
            public readonly string parentId = "parentId";
        }
        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string page = "page";
            public readonly string order = "order";
            public readonly string desc = "desc";
        }
        static readonly ActionParamsClass_Details s_params_Details = new ActionParamsClass_Details();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Details DetailsParams { get { return s_params_Details; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Details
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_Edit s_params_Edit = new ActionParamsClass_Edit();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Edit EditParams { get { return s_params_Edit; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Edit
        {
            public readonly string id = "id";
            public readonly string collection = "collection";
            public readonly string entity = "entity";
            public readonly string editViewName = "editViewName";
        }
        static readonly ActionParamsClass_Delete s_params_Delete = new ActionParamsClass_Delete();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Delete DeleteParams { get { return s_params_Delete; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Delete
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_Create s_params_Create = new ActionParamsClass_Create();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Create CreateParams { get { return s_params_Create; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Create
        {
            public readonly string collection = "collection";
        }
        static readonly ActionParamsClass_SetVisibility s_params_SetVisibility = new ActionParamsClass_SetVisibility();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SetVisibility SetVisibilityParams { get { return s_params_SetVisibility; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SetVisibility
        {
            public readonly string id = "id";
            public readonly string visibilityToSet = "visibilityToSet";
        }
        static readonly ActionParamsClass_SortList s_params_SortList = new ActionParamsClass_SortList();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SortList SortListParams { get { return s_params_SortList; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SortList
        {
            public readonly string page = "page";
            public readonly string collection = "collection";
        }
        static readonly ActionParamsClass_UploadFile s_params_UploadFile = new ActionParamsClass_UploadFile();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UploadFile UploadFileParams { get { return s_params_UploadFile; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UploadFile
        {
            public readonly string upload = "upload";
            public readonly string id = "id";
            public readonly string propName = "propName";
        }
        static readonly ActionParamsClass_DeleteFile s_params_DeleteFile = new ActionParamsClass_DeleteFile();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DeleteFile DeleteFileParams { get { return s_params_DeleteFile; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DeleteFile
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_SaveOrder s_params_SaveOrder = new ActionParamsClass_SaveOrder();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SaveOrder SaveOrderParams { get { return s_params_SaveOrder; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SaveOrder
        {
            public readonly string model = "model";
            public readonly string objId = "objId";
            public readonly string propName = "propName";
        }
        static readonly ActionParamsClass_SaveFileData s_params_SaveFileData = new ActionParamsClass_SaveFileData();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SaveFileData SaveFileDataParams { get { return s_params_SaveFileData; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SaveFileData
        {
            public readonly string model = "model";
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
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_ProjectController : CMS.Areas.Admin.Controllers.ProjectController
    {
        public T4MVC_ProjectController() : base(Dummy.Instance) { }

        [NonAction]
        partial void UploadFileCollectionItemOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, CMS.ViewModels.FineUpload upload, int id, string propName, int parentId);

        [NonAction]
        public override System.Web.Mvc.ActionResult UploadFileCollectionItem(CMS.ViewModels.FineUpload upload, int id, string propName, int parentId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UploadFileCollectionItem);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "upload", upload);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "propName", propName);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "parentId", parentId);
            UploadFileCollectionItemOverride(callInfo, upload, id, propName, parentId);
            return callInfo;
        }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? page, string order, string desc);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index(int? page, string order, string desc)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "page", page);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "order", order);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "desc", desc);
            IndexOverride(callInfo, page, order, desc);
            return callInfo;
        }

        [NonAction]
        partial void DetailsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Details(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Details);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            DetailsOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void CreateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Create()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
            CreateOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Edit(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            EditOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void DeleteOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Delete(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Delete);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            DeleteOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void CreateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Web.Mvc.FormCollection collection);

        [NonAction]
        public override System.Web.Mvc.ActionResult Create(System.Web.Mvc.FormCollection collection)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "collection", collection);
            CreateOverride(callInfo, collection);
            return callInfo;
        }

        [NonAction]
        partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, System.Web.Mvc.FormCollection collection);

        [NonAction]
        public override System.Web.Mvc.ActionResult Edit(int id, System.Web.Mvc.FormCollection collection)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "collection", collection);
            EditOverride(callInfo, id, collection);
            return callInfo;
        }

        [NonAction]
        partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, KonigLabs.Models.Project entity, System.Web.Mvc.FormCollection collection, string editViewName);

        [NonAction]
        public override System.Web.Mvc.ActionResult Edit(KonigLabs.Models.Project entity, System.Web.Mvc.FormCollection collection, string editViewName)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "entity", entity);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "collection", collection);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "editViewName", editViewName);
            EditOverride(callInfo, entity, collection, editViewName);
            return callInfo;
        }

        [NonAction]
        partial void SetVisibilityOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, bool visibilityToSet);

        [NonAction]
        public override System.Web.Mvc.ActionResult SetVisibility(int id, bool visibilityToSet)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SetVisibility);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "visibilityToSet", visibilityToSet);
            SetVisibilityOverride(callInfo, id, visibilityToSet);
            return callInfo;
        }

        [NonAction]
        partial void SortListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? page, System.Web.Mvc.FormCollection collection);

        [NonAction]
        public override System.Web.Mvc.ActionResult SortList(int? page, System.Web.Mvc.FormCollection collection)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SortList);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "page", page);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "collection", collection);
            SortListOverride(callInfo, page, collection);
            return callInfo;
        }

        [NonAction]
        partial void UploadFileOverride(T4MVC_CMS_ViewModels_FineUploaderResult callInfo, CMS.ViewModels.FineUpload upload, int id, string propName);

        [NonAction]
        public override CMS.ViewModels.FineUploaderResult UploadFile(CMS.ViewModels.FineUpload upload, int id, string propName)
        {
            var callInfo = new T4MVC_CMS_ViewModels_FineUploaderResult(Area, Name, ActionNames.UploadFile);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "upload", upload);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "propName", propName);
            UploadFileOverride(callInfo, upload, id, propName);
            return callInfo;
        }

        [NonAction]
        partial void DeleteFileOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DB.Entities.Mocks.CustomFileEntity model);

        [NonAction]
        public override System.Web.Mvc.ActionResult DeleteFile(DB.Entities.Mocks.CustomFileEntity model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteFile);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            DeleteFileOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void SaveOrderOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string model, int objId, string propName);

        [NonAction]
        public override System.Web.Mvc.ActionResult SaveOrder(string model, int objId, string propName)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SaveOrder);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "objId", objId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "propName", propName);
            SaveOrderOverride(callInfo, model, objId, propName);
            return callInfo;
        }

        [NonAction]
        partial void SaveFileDataOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DB.Entities.Mocks.CustomFileEntity model);

        [NonAction]
        public override System.Web.Mvc.ActionResult SaveFileData(DB.Entities.Mocks.CustomFileEntity model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SaveFileData);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            SaveFileDataOverride(callInfo, model);
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

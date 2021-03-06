﻿@using $rootnamespace$
@using DB.Entities
@using Libs
@model ListViewModel

@{
    ViewBag.HtmlPageTitle = "CoditCms.cms — список объектов";
    var roles = Roles.GetRolesForUser(User.Identity.Name);
    Func<string, bool> allowed = role => string.IsNullOrEmpty(role) || roles.Contains(role);
}

<script type="text/javascript">
    _sorlListActionUrl = '@Url.Action(Constants.SortListAction)';
</script>
<script type="text/ecmascript" src="@Url.Content("~/Areas/Admin/Scripts/Default/List.js")"></script>

<div class="global-actions">
    @foreach (GlobalActionSettings globalAction in Model.Settings.ListSettings.GlobalActions)
    {
        if (!string.IsNullOrEmpty(globalAction.Control))
        {
            Html.RenderPartial("GlobalActions/" + globalAction.Control, new ViewDataDictionary(Model) {{"Settings", Model.Settings}, {"globalActionSettings", globalAction}});
        }
        else
        {
            @Html.ActionLink(globalAction.Text, globalAction.Action, null, new { @class="global-action"})
        }
    }
</div>

@using (Html.BeginForm(null, null, FormMethod.Post, new { id = "list-form" }))
{
    <input type="hidden" name="page" value="@Request["page"]" />
    <table class="list-table">
        <colgroup>
            <col @Html.Raw("width=\"24\"") />
            @OutputCollection(Model.Settings.ListSettings.Cols.Where(s => allowed(s.RoleName)).Select(col => string.Format("<col {0} />", col.Width > 0 ? string.Format("width={0}", col.Width) : string.Empty)))
            @OutputCollection(Model.Settings.ListSettings.ListActions.Select(settings => "<col width=\"24\" />"))
        </colgroup>
        <tr>
            <th>№</th>
            @OutputCollection(Model.Settings.ListSettings.Cols.Where(settings => settings != null && allowed(settings.RoleName)).Select(settings =>
                                {
                                    var value = settings.HeaderValue();
                                    return string.Join(string.Empty, "<th>", Html.DisplayFor(model => value, settings.HeaderControl, new { ColSettings = settings, Model.Settings }), "</th>");
                                }))

            @foreach (var listAction in Model.Settings.ListSettings.ListActions.Where(settings => settings != null))
            {
                if (listAction.Control == "sort")
                {
                    <th><input id="sort-button" type="button" value="Применить" /></th>
                }
                else
                {
                    <th>&nbsp;</th>
                }
            }
        </tr>
        @{
            var number = 0;
            var hasEdit = Model.Settings.ListSettings.ListActions.Any(a => a.Control == "edit");
        }

        @foreach (IEntity row in Model.ListData)
        {
            var action = Html.Raw(hasEdit ? string.Format("target=\"{0}\"", Url.Action(Constants.EditView, new { id = row.Id })) : string.Empty);
            var selectedRow = (bool)TypeHelpers.GetPropertyValue(row, Model.Settings.ListSettings.SelectRowProperty, false);
            <tr @Html.ByCondition(selectedRow, "class=\"selected\"")>

                <td class="number">@(++number + (Model.FilterParameters.StartPosition))</td>
                @foreach (var col in Model.Settings.ListSettings.Cols.Where(s => allowed(s.RoleName)))
                {
                    <td @action>
                        @Indents(row, col)
                        @{
                            var propValue = TypeHelpers.GetPropertyValue(row, col.Name);
                            if (col.Localizable)
                            {
                                var key = (Guid?)propValue;
                                propValue = Lp.GetMessage(key);
                            }
                        }
                        @Html.DisplayFor(model => propValue, col.Control, new { ColSettings = col, Row = row })
                    </td>
                }


                @foreach (var listAction in Model.Settings.ListSettings.ListActions)
                {
                    <td class="list-action">
                        @{Html.RenderPartial("ListActions/" + listAction.Control, row, new ViewDataDictionary { { "Settings", Model.Settings }, { "listActionSettings", listAction }, { "listViewModel", Model } });}
                    </td>    
                }
            </tr>
        }

        @if (Model.FilterParameters.ItemsCount == 0)
        {
            var colspan = Model.Settings.ListSettings.Cols.Count() + Model.Settings.ListSettings.ListActions.Count();
            <tr>
                <td colspan="@(colspan + 1)">Список пуст</td>
            </tr>
        }
    </table>
}
@if (Model.FilterParameters.HasPager())
{
    var count = Model.FilterParameters.GetPagesCount();
    <div id="pager">
        Страница:
		@for (var i = 1; i <= count; i++)
  {
      if (Model.FilterParameters.Page == i)
      {
            <span>@i</span>
      }
      else
      {
            <a class="list-action" href="@Request.Url.SetParameter("page", i.ToString())">@i</a>
      }
  }

    </div>
}

@helper Indents(IEntity row, ColSettings col)
{
    if (!col.Levels)
    {
        return;
    }
    <span class="list-levels">
        @for (var i = 1; i < ((IPlainTreeItem)row).Level; i++)
        {
            <span class="list-level"></span>
        }
    </span>

    if (((IPlainTreeItem)row).HasChilds)
    {<span class="list-parent"></span>}
    else
    {<span class="list-child"></span>}
}

@helper OutputCollection(IEnumerable<string> collection)
{
    foreach (var item in collection)
    {
    @Html.Raw(item)
    }
}
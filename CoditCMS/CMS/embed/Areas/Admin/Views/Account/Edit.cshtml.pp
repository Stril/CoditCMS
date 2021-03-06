﻿@using $rootnamespace$
@model $rootnamespace$.Areas.Admin.ViewModels.Accounts.EditModel

@{
	ViewBag.CoditPageTitle = "Edit";
    Layout = "~/Areas/Admin/Views/Shared/_Main.cshtml";
}
<form action="@Url.Action("Edit", new { providerUserKey = Model.ProviderUserKey })" id="edit-form" method="post">

<input type="hidden" name="ProviderUserKey" value="@Model.ProviderUserKey" />
    
    <table class="form-table">
        <tr><th>@Model.UserName</th></tr>
    </table>
    
    <div class="form-save-button">
        <input type="submit" name="_save" value="Сохранить" /> <input type="submit" name="_apply" value="Применить" /> <span class="form-back-link"><span class="arrow">&larr;</span><a href="@Url.Action("Index")">Назад к списку</a></span>
    </div>

    @Html.ValidationSummary(true)

    <table class="form-table"  id="edit-user">
        <tr>
            <td class="form-table-label">
                Имя пользователя
            </td>
            <td class="form-table-data">
                @Model.UserName
            </td>
        </tr>

        <tr>
            <td class="form-table-label">
                Эл. почта
            </td>
            <td class="form-table-data">
                @Html.EditorFor(m=>m.Email)
                <div>@Html.ValidationMessageFor(m => m.Email)</div>
            </td>
        </tr>
        
        @if (!Model.Unlock)
        {
            <tr>
                <td class="form-table-label">
                    Разблокировать пользователя
                </td>
                <td class="form-table-data">
                    @Html.EditorFor(m => m.Unlock)
                </td>
            </tr>
        }
        <tr>
            <td class="form-table-label">
                Почта подтверждена
            </td>
            <td class="form-table-data">
                @Html.EditorFor(m=>m.IsApproved)
            </td>
        </tr>

        <tr>
            <td class="form-table-label">
                Роль
            </td>
            <td class="form-table-data">
                @if(Roles.GetRolesForUser(Model.UserName).Contains("SuperAdmin"))
                {
                    @:SuperAdmin
                    @Html.Hidden("UserRoles", "SuperAdmin")
                }
                else
                {
                    @Html.ListBox("UserRoles", Model.RolesSelectList)
                }
            </td>
        </tr>

        <tr>
            <td class="form-table-label">
                Сменить пароль
            </td>
            <td class="form-table-data">
                <div class="label">Введите старый пароль</div>
                <div>@Html.EditorFor(m => m.OldPassword)</div>
                <div style="margin-bottom:10px;">@Html.ValidationMessageFor(m => m.OldPassword)</div>

                <div class="label">Введите новый пароль</div>
                <div>@Html.EditorFor(m => m.NewPassword)</div>
                <div>@Html.ValidationMessageFor(m=>m.NewPassword)</div>
                
                <div class="label">Введите новый пароль повторно</div>
                <div>@Html.EditorFor(m => m.NewPasswordConfirm)</div>
                <div>@Html.ValidationMessageFor(m => m.NewPasswordConfirm)</div>
                <div>@Html.ValidationMessage("PasswordsSync")</div>
            </td>
        </tr>
    </table>
    
    <div class="form-save-button">
        <input type="submit" name="_save" value="Сохранить" /> <input type="submit" name="_apply" value="Применить" id="_apply" />
    </div>
</form>


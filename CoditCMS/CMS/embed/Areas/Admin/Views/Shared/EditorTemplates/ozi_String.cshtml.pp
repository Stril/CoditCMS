﻿@using $rootnamespace$
@{
    var value = ViewData.TemplateInfo.FormattedModelValue;
    if (WebContext.FieldSettings.Localizable && Model != null)
    {
        value = Lp.GetMessage((Guid)Model);
    }
}
<input type="text" name="@ViewData.TemplateInfo.HtmlFieldPrefix" value="@value" class="ozi-string" @if (WebContext.FieldSettings.Disabled) { <text>disabled="disabled"</text> } @if (WebContext.FieldSettings.Readonly) { <text>readonly="readonly"</text> }/>

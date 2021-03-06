﻿@using CMS.Models;

@{
    var model = (ReferralField)WebContext.Model ?? new ReferralField();
}
<div id="fields">
    <div data-bind="if: type()!='multicheckbox' && type()!='select'">
        нет дополнительных настроек
    </div>
    <div data-bind="if: type()=='multicheckbox' || type()=='select'">
        <table>
            <tr>
                <td>
                    <label>Список элементов:</label>
                    <div data-bind="foreach: items">
                        <div>
                            <input type="hidden" data-bind="{value: id, attr: {name: 'AvailableValues[' + $index() + '].Id'}}" />
                            <input type="hidden" data-bind="{value: $index(), attr: {name: 'AvailableValues[' + $index() + '].Index'}}" />
                            <input type="text" data-bind="{value: value, attr: {name: 'AvailableValues[' + $index() + '].Value'}}" />
                        </div>
                    </div>
                </td>
                <td>
                    <label>Цены:</label>
                    <div data-bind="foreach:items">
                        <div>
                            <input data-a-sep=" " data-a-dec="," data-alt-dec="." type="text" data-bind="{price: true, value:price,attr: {name: 'AvailableValues[' + $index() + '].Price'}}" />
                            <a href="javascript:void(0)" data-bind="{click: $parent.deleteItem}">
                                <img src="/Areas/Admin/Images/Default/delete.png" alt="Удалить" />
                            </a>
                        </div>
                    </div>
                </td>
            </tr>
        </table>

        <input type="button" value="Добавить элемент" data-bind="{click: addItem}" />
    </div>
</div>




<script>
    var ValueViewModel = function (id,val,price) {
        var self = this;
        self.id = ko.observable(id);
        self.value = ko.observable(val);
        self.price = ko.observable(price);
    };
    var ViewModel = function (model) {
        var self = this;
        self.type = ko.observable(model.type);
        self.title = ko.observable(model.title);
        self.items = ko.observableArray(model.items);
        self.addItem = function () {
            self.items.push(new ValueViewModel('0',''));
        };
        self.deleteItem = function (item) {
            self.items.remove(item);
        };
    };
    ko.bindingHandlers.price = {
        init: function(element, valueAccessor, allBindingsAccessor) {
            $(element).autoNumeric('init');
        }
    };

    $(function () {

        var model = {
            type: '@(model.Type)',
            title: '@(model.Title)',
            items: [@Html.Raw(string.Join(", ", model.AvailableValues.Select(value => string.Format("new ValueViewModel('{0}','{1}', '{2}')", value.Id, value.Value, value.Price ?? 0))))]
        };

        var vm = new ViewModel(model);

        ko.applyBindings(vm, $("#fields").get(0));

        $("form").on('change', "select[name=Type]", function () {
            var val = $(this).val();
            vm.type(val);
            checkPriceEditable(val);
        });
        checkPriceEditable(model.type);
    });
    checkPriceEditable = function(type) {
        //if (type != 'multicheckbox' && type != 'select')
        //{
        //    $('#price-disclaimer').remove();
        //    $('input[name=Price]').removeAttr("readonly");
        //    $('input[name=Price]').removeAttr("disable");
        //} else {
        //    var pricaeInput = $('input[name=Price]');
        //    pricaeInput.attr("readonly", "readonly");
        //    pricaeInput.attr("disable", "disable");
        //    pricaeInput.parent().append("<div id=\"price-disclaimer\"><p>Нельзя добавить цену в элемент с множественным выбором или выбором из списка</p></div>");
        //}
    };
</script>


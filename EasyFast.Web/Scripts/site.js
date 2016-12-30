/*全局变量部分开始*/
var url = window.location.href;
/*全局变量部分结束*/



/*****EasyUI自定义扩展开始*****/
//解决EasyUI.DataGrid卡顿问题
var fast_autoSizeColumn = $.fn.datagrid.methods['autoSizeColumn'];
$.extend($.fn.treegrid.methods, {
    autoSizeColumn: function (jq, field) {
        $.each(jq, function () {
            var opts = $(this).treegrid('options');
            if (!opts.skipAutoSizeColumns) {
                var tg_jq = $(this);
                if (field) fast_autoSizeColumn(tg_jq, field);
                else fast_autoSizeColumn(tg_jq);
            }
        });
    }
});

Date.prototype.format = function (fmt) { //author: meizz
    var o = {
        "m+": this.getMonth() + 1, //月份
        "d+": this.getDate(), //日
        "H+": this.getHours(), //小时
        "M+": this.getMinutes(), //分
        "s+": this.getSeconds(), //秒
        "q+": Math.floor((this.getMonth() + 3) / 3), //季度
        "S": this.getMilliseconds() //毫秒
    };
    if (/(y+)/.test(fmt)) fmt = fmt.replace(RegExp.$1, (this.getFullYear() + "").substr(4 - RegExp.$1.length));
    for (var k in o)
        if (new RegExp("(" + k + ")").test(fmt)) fmt = fmt.replace(RegExp.$1, (RegExp.$1.length === 1) ? (o[k]) : (("00" + o[k]).substr(("" + o[k]).length)));
    return fmt;
}
var EasyUI = {
    //EasyUI用DataGrid用日期格式化
    TimeFormatter: function (value, rec, index) {
        if (value === undefined) {
            return "";
        }
        /*json格式时间转js时间格式*/
        value = value.substr(1, value.length - 2);
        var obj = eval('(' + "{Date: new " + value + "}" + ')');
        var dateValue = obj["Date"];
        if (dateValue.getFullYear() < 1900) {
            return "";
        }
        var val = dateValue.format("yyyy-mm-dd HH:MM");
        return val.substr(11, 5);
    },
    DateTimeFormatter: function (value, rec, index) {
        if (value === undefined) {
            return "";
        }
        /*json格式时间转js时间格式*/
        value = value.substr(1, value.length - 2);
        var obj = eval('(' + "{Date: new " + value + "}" + ')');
        var dateValue = obj["Date"];
        if (dateValue.getFullYear() < 1900) {
            return "";
        }

        return dateValue.format("yyyy-mm-dd HH:MM");
    },

    //EasyUI用DataGrid用日期格式化
    DateFormatter: function (value, rec, index) {
        if (value === undefined) {
            return "";
        }
        /*json格式时间转js时间格式*/
        value = value.substr(1, value.length - 2);
        var obj = eval('(' + "{Date: new " + value + "}" + ')');
        var dateValue = obj["Date"];
        if (dateValue.getFullYear() < 1900) {
            return "";
        }

        return dateValue.format("yyyy-mm-dd");
    },
};
/*****EasyUI自定义扩展结束*****/


/*****EasyUI专用方法开始*****/
//获取指定ID的DataGrid中的选中行,返回ID数组.
function GetDataGridChecked(domId) {
    if (domId === null || domId === undefined) {
        domId = "easyui-datagrid";
    }
    var ss = [];
    var rows = $('#' + domId).datagrid('getSelections');
    for (var i = 0; i < rows.length; i++) {
        var row = rows[i];
        ss.push(row.id);
    }
    return ss;
}

//判断DataGrid是否选了单行,本代码依赖于sweetAlert
function CheckDataGridIsSingleRow(id) {
    var isOK = true;
    if (id === undefined || id === "" || id.length !== 1) {
        isOK = false;
        sweetAlert("发生了一个错误。", "只能选择一行数据进行操作!", "error");
    }
    return isOK;
}

//判断DataGrid是否至少选择了一行,本代码依赖于sweetAlert
function CheckDataGridHasSelectedRow(id) {
    var isOK = true;
    if (id === undefined || id === "" || id.length < 1) {
        isOK = false;
        sweetAlert("发生了一个错误。", "请至少选择一行数据进行操作!", "error");
    }
    return isOK;
}

//刷新DataGrid
function ReLoadDataGrid(domId) {
    if (domId === null || domId === undefined) {
        domId = "easyui-datagrid";
    }
    $('#' + domId).datagrid('reload');

}
/*****EasyUI专用方法结束*****/



/*****关闭弹窗，并提示操作结果开始*****/
//使用toastr插件进行操作结果提示
function TipResultFromToastr(text, type) {
    toastr.options = {
        "closeButton": true,
        "debug": false,
        "progressBar": true,
        "positionClass": "toast-top-center",
        "onclick": null,
        "showDuration": "400",
        "hideDuration": "1000",
        "timeOut": "1000",
        "extendedTimeOut": "1500",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    };
    switch (type) {
        default:
            break;
        case "success":
            toastr.success("操作成功:" + text + "!");
            break;
        case "error":
            toastr.error("操作失败:" + text + "!");
            break;
        case "info":
            toastr.info("提示:" + text + "!");
            break;
        case "warning":
            toastr.warning("警告:" + text + "!");
            break;
    }
}

//关闭Layer弹出的Iframe并进行相应提示
function CloseAllWindosFromLayer(text, type, domId) {
    TipResultFromToastr(text, type);
    layer.closeAll();
    $('#' + domId).datagrid('unselectAll');//EasyUI-1.5选中任意行时，reload存在bug，会默认全选，此代码用于取消选中行，进行兼容处理
    ReLoadDataGrid(domId);
}
/*****关闭弹窗，并提示操作结果结束*****/






/*****弹窗页面专用JS开始*****/
//关闭弹窗并提示操作结果，在Iframe页面直接调用
function iframeResult() {
    var reg = new RegExp("/Update/\\d+");
    if (reg.test(url)) {
        parent.CloseAllWindosFromLayer("修改成功", "success", "easyui-datagrid");
    } else {
        parent.CloseAllWindosFromLayer("添加成功", "success", "easyui-datagrid");
    }
}
/*****弹窗页面专用JS结束*****/
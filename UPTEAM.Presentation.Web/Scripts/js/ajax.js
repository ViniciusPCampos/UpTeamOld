function requisicaoAjax(type, datatype, url, json) {
    var dados;
    $.ajax({
        type: type,
        url: url,
        data: JSON.parse(json),
        datatype: datatype,
        async: false,
        success: function (data) {
            dados = data;
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            debugger;
        }
    });
    return dados;
}

function requisicaoAjaxAsync(type, datatype, url, json, success) {
    var dados;
    $.ajax({
        type: type,
        url: url,
        data: JSON.parse(json),
        datatype: datatype,
        async: true,
        success: function (data) {
            success(data);
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            debugger;
        }
    });
}

function preencherDadosDDL(component, json, jsonId, jsonText, placeholderText, searchBox, limparCampo) {
    component.empty();
    var hide = searchBox == false ? Infinity : 0;

    var dados = $.map(json, function (obj) {
        obj.id = obj.id || obj[jsonId];
        obj.text = obj.text || obj[jsonText];
        return obj;
    });
    component.append($("<option></option>").val(""));
    component.select2({
        language: "pt",
        data: dados,
        allowClear: limparCampo,
        minimumResultsForSearch: hide,
        placeholder: placeholderText
    });
}
function inserirErrosForm(data) {
    $(".msg-erro-validacao").text("");
    if (data.length > 0) {
        $.map(data, function (value, key) {
            var id = value.chave;
            var string = "#validacao-" + id;
            $(string).text(value.valor);           
        });
        return false;
    }
    return true;
}
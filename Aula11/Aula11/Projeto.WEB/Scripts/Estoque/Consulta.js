function consultarEstoques() {    
    $.ajax({
        type: "GET",
        url: "/Estoque/ConsultarEstoques",
        data: {},
        success: function (lista) {
            var conteudo = "";
            $.each(lista, function (i, v) {
                conteudo += "<tr>";
                conteudo += "<td>" + v.IdEstoque + "</td>";
                conteudo += "<td>" + v.Nome + "</td>";
                conteudo += "<td>" + v.Descricao + "</td>";
                conteudo += "<td>" + v.Tipo + "</td>";
                conteudo += "<td>";
                conteudo += "<button onclick='obterEstoque(" + v.IdEstoque + ")' type='button' data-target='#janelaExclusao' data-toggle='modal' class='btn btn-danger btn-sm'>Excluir</button>";
                conteudo += "&nbsp;";
                conteudo += "<button onclick='obterEstoque(" + v.IdEstoque + ")' type='button' data-target='#janelaEdicao' data-toggle='modal' class='btn btn-primary btn-sm'>Atualizar</button>";
                conteudo += "</td>";
                conteudo += "</tr>";
            });
            $("#tabela tbody").html(conteudo);
            $("#quantidade").html(lista.length);
        },
        error: function (e) {
            $("#mensagem").html("Erro: " + e.status);
        }
    });
}

function obterEstoque(idEstoque) {
    $.ajax({
        type: "GET",
        url: "/Estoque/ConsultarEstoquePorId",
        data: "idEstoque=" + idEstoque,
        success: function (model) {
            $("#idestoque_exclusao").html(model.IdEstoque);
            $("#nome_exclusao").html(model.Nome);
            $("#tipo_exclusao").html(model.Tipo);
            $("#descricao_exclusao").html(model.Descricao);

            $("#idestoque").val(model.IdEstoque);
            $("#nome").val(model.Nome);
            $("#tipo").val(model.IdTipo);
            $("#descricao").val(model.Descricao);
        },
        error: function (e) {
            $("#mensagem").html("Erro: " + e.status);
        }
    });
}

function excluirEstoque() {
    $.ajax({
        type: "POST",
        url: "/Estoque/ExcluirEstoque",
        data: "idEstoque=" + + $("#idestoque_exclusao").html(),
        success: function (msg) {
            $("#mensagem").html(msg);    
            $("#janelaExclusao").modal('hide');
            consultarEstoques();
        },
        error: function (e) {
            $("#mensagem").html("Erro: " + e.status);
        }
    });
}

function atualizarEstoque() {
    var estoque = {
        IdEstoque : $("#idestoque").val(),
        Nome : $("#nome").val(),
        Descricao : $("#descricao").val(),
        Tipo : $("#tipo").val()
    };
    $.ajax({
        type: "POST",
        url: "/Estoque/AtualizarEstoque",
        data: estoque,
        success: function (msg) {
            $("#mensagem").html(msg);
            $("#janelaEdicao").modal('hide');
            consultarEstoques();
        },
        error: function (e) {
            $("#mensagem").html("Erro: " + e.status);
        }
    });
}

$(document).ready(function () {
    consultarEstoques();

    $("#btnexclusao").on("click", function () {
        excluirEstoque();
        
    });

    $("#btnatualizacao").on("click", function () {
        atualizarEstoque();
        
    });
});


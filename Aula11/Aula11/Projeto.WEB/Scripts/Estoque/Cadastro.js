function cadastrarEstoque() {
        
    var model = {
        Nome: $("#nome").val(),
        Descricao: $("#descricao").val(),
        Tipo: $("#tipo").val()
    };

    $.ajax({
        type: "POST",
        url: "/Estoque/CadastrarEstoque",
        data: model,
        success: function (msg) {
            $("#mensagem").html(msg);

            $("#nome").val("");
            $("#descricao").val("");
            $("#tipo").val("");
        },
        error: function (e) {
            $("#mensagem").html("Erro: " + e.status);
        }
    });
}

$(document).ready(function () {
    $("#btncadastro").click(function () {
        CadastrarEstoque();
    });
});
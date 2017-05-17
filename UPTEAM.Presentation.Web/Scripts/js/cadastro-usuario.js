$(document).ready(function () {
});
function Usuario() {
    var self = this;
    self.Nome = $('#Nome').val();
    self.Login = $('#Login').val();
    self.Senha = $('#Senha').val();
    return self;
}
$('#btnAlterarSenha').on('click', function () {
    $('#divModalCadastrarUsuario').html('');
    var json = { login: usuarioLogado };

    requisicaoAjaxAsync('GET', 'html', urlbase + 'autenticacao/ModalAlteracaoUsuario', JSON.stringify(json),
        function (dados) {
            $('#divModalAlterarUsuario').html(dados);
            $('#modalAlterarUsuario').modal('show');
        });
});
function SalvarUsuario() {
    var usuario = new Usuario();
    usuario.IdUsuario = $('#IdUsuario').val();
    var json = { usuario: usuario };

    requisicaoAjaxAsync('POST', 'json', urlbase + 'autenticacao/ValidarEdicaoUsuario', JSON.stringify(json),
        function (dados) {
            if (inserirErrosForm(dados.erros))
                AlterarUsuario(dados.src);
                
        });
};
$('#btnAbrirCadastroUsuario').on('click', function () {
    $('#divModalAlterarUsuario').html('');
    requisicaoAjaxAsync('GET', 'html', urlbase + 'autenticacao/ModalCadastroUsuario', null,
        function (dados) {
            $('#divModalCadastrarUsuario').html(dados);
            $('#modalCadastroUsuario').modal('show');
        });
});
function CadastrarUsuario() {
    var usuario = new Usuario();
    var json = { usuario: usuario };
    requisicaoAjaxAsync('POST', 'json', urlbase + 'autenticacao/ValidarCadastroUsuario', JSON.stringify(json),
        function (dados) {
            if (inserirErrosForm(dados.erros))
                InserirUsuario(dados.src);
        });
};
function InserirUsuario(usuario){
    var json = { usuario: usuario };
    requisicaoAjaxAsync('POST', 'json', urlbase + 'autenticacao/CadastrarUsuario', JSON.stringify(json),
       function (dados) {
           if (dados.sucesso) {
               $.each(dados.msgs, function (i, val) {
                   toastr["success"](val);
               })              
           } else {
               $.each(dados.erros, function (i, val) {
                   toastr["error"](val.valor[0])
               })
           }
           $('#modalCadastroUsuario').modal('hide');
       });
}
function AlterarUsuario(usuario) {
    var json = { usuario: usuario };
    requisicaoAjaxAsync('POST', 'json', urlbase + 'autenticacao/AlterarUsuario', JSON.stringify(json),
       function (dados) {
           if (dados.sucesso) {
               $.each(dados.msgs, function (i, val) {
                   toastr["success"](val);
               })
           } else {
               $.each(dados.erros, function (i, val) {
                   toastr["error"](val.valor[0])
               })
           }
           $('.nomeUsuarioLayout').text(dados.src.nome);
           $('#modalAlterarUsuario').modal('hide');
       });
}
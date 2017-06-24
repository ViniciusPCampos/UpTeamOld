(function () {
    angular.module('starter.services')
        .factory('mensagensEquipeService', function ($http, config) {
            var _obterMensagensEquipe = function (id) {
                return $http.get(config.baseUrl + "/equipe/" + id + "/mensagem");
            };
            
            _enviarMensagem = function(mensagem) {
                console.log(mensagem);
                var req = {
                    method: 'POST',
                    url: config.baseUrl + "/mensagem",
                    crossDomain: true,
                    data: (mensagem)
                }

                $http(req)
                    .success(function (response) {
                        console.log("Mensagem Enviada!!");
                    }).error(function (err) {
                        console.log("Erro");
                    });
            }
            
            return {
                obterMensagensEquipe: _obterMensagensEquipe,
                enviarMensagem: _enviarMensagem
            };
        });
})()
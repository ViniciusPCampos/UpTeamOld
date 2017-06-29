(function () {
    angular.module('starter.services')
        .factory('mensagensEquipeService', function ($http, $q, config) {
            var _obterMensagensEquipe = function (id) {
                return $http.get(config.baseUrl + "/equipe/" + id + "/mensagem");
            };
            
            _enviarMensagem = function (mensagem) {
                var deferred = $q.defer();
                var req = {
                    method: 'POST',
                    url: config.baseUrl + "/mensagem",
                    crossDomain: true,
                    data: (mensagem)
                }

                $http(req)
                    .success(function (response) {
                        deferred.resolve(response);
                    }).error(function (err) {
                    });

                return deferred.promise;
            }
            
            return {
                obterMensagensEquipe: _obterMensagensEquipe,
                enviarMensagem: _enviarMensagem
            };
        });
})()
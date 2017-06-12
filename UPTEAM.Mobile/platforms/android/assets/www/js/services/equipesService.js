(function () {
    angular.module('starter.services')


        .factory('equipesService', function ($http, config) {

            var _obterEquipe = function (nome) {
                return $http.get(config.baseUrl + "/equipe?nome=" + nome);
            };

            return {
                obterEquipe: _obterEquipe
            };
        });



})()
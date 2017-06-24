(function () {
    angular.module('starter.services')

        .factory('projetoService', function ($http, config) {

            var _obterProjetos = function () {
                return $http.get(config.baseUrl + "/projetos");
            };

            return {
                obterProjetos: _obterProjetos
            };
        });
})()
(function () {
    angular.module('starter.services')
        .factory('projetosEquipeService', function ($http, config) {
            var _obterProjetosEquipe = function (id) {
                return $http.get(config.baseUrl + "/equipe/" + id + "/projeto");
            };

            return {
                obterProjetosEquipe: _obterProjetosEquipe
            };
        });
})()
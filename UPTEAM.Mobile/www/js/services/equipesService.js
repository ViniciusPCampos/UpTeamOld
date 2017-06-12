(function () {
    angular.module('starter.services')


        .factory('equipesService', function ($http, config) {

            var _obterEquipes = function () {
                return $http.get(config.baseUrl + "/equipes");
            };

            return {
                obterEquipes: _obterEquipes
            };
        });



})()
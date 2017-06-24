(function () {
    angular.module('starter.services')
        .factory('marcosService', function ($http, config) {
            var _obterMarcos = function (id) {
                return $http.get(config.baseUrl + "/projeto/" + id + "/marco");
            };

            return {
                obterMarcos: _obterMarcos
            };
        });
})()
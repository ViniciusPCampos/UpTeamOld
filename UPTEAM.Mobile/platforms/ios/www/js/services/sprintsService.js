(function () {
    angular.module('starter.services')
        .factory('sprintsService', function ($http, config) {
            var _obterSprints = function (id) {
                return $http.get(config.baseUrl + "/projeto/" + id + "/sprint");
            };

            return {
                obterSprints: _obterSprints
            };
        });
})()
(function () {
    angular.module('starter.services')

        .factory('dashboardService', function ($http, config) {

            var _obterDashboard = function () {
                return $http.get(config.baseUrl + "/dashboard");
            };

            return {
                obterDashboard: _obterDashboard
            };
        });
})()
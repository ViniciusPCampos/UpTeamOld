(function () {
    angular.module('starter.controllers')

        .controller('DashboardCtrl', function ($scope, dashboardService) {
            $scope.dashboard = {};

            dashboardService.obterDashboard().success(function (data) {
                console.log(data.src);
                $scope.dashboard = data.src;
            });

        })
})()
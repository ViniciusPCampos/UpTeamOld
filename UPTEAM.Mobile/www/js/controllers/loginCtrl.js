(function () {
    angular.module('starter.controllers')

        .controller('LoginCtrl', function ($scope, $location, $state, authService) {
            $scope.loginData = {};

            $scope.doLogin = function () {

                authService.login($scope.loginData).then(function (response) {
                    $state.go('app.dashboard');
                }, function (error) {
                    alert("Failed.Please try again.");
                })
            };
        })
})()
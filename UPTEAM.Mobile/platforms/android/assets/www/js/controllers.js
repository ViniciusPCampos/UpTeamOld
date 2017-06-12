(function () {
    angular.module('starter.controllers')

    .controller('AppCtrl', function ($scope, $ionicModal, $timeout) {


        // Perform the login action when the user submits the login form
    })

    .controller('EquipesCtrl', function ($scope, equipesService) {
        $scope.equipes = [];

        equipesService.obterEquipes().success(function (data) {
            $scope.equipes = data.src;
        });

    })
    .controller('DashboardCtrl', function ($scope) {
        

    })
    .controller('LoginCtrl', function ($scope, $location, $state, authService) {
        $scope.loginData = {};

        $scope.doLogin = function () {

            authService.login($scope.loginData).then(function (response) {
                console.log('ctrl');
                $state.go('app.dashboard');
            }, function (error) {
                alert("Failed.Please try again.");
            })
        };
    })
    .controller('PlaylistCtrl', function ($scope, $stateParams) {
    });
})()
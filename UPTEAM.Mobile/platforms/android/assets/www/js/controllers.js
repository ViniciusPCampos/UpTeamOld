(function () {
    angular.module('starter.controllers')

    .controller('AppCtrl', function ($scope, $ionicModal, $timeout) {


        // Perform the login action when the user submits the login form
    })

    .controller('EquipesCtrl', function ($scope, equipesService) {
        $scope.equipes = [];

        equipesService.obterEquipe('teste').success(function (data) {
            $scope.equipes = data.src;
        });

    })
    .controller('LoginCtrl', function ($scope, $location, authService) {
        $scope.loginData = {};

        $scope.doLogin = function () {
            console.log('Doing login', $scope.loginData);

            authService.login($scope.loginData).then(function (response) {
                alert("Login Successfully");
                //$window.location.href = "user.html";
            }, function () {
                alert("Failed.Please try again.");
            })
        };
    })
    .controller('PlaylistCtrl', function ($scope, $stateParams) {
    });
})()
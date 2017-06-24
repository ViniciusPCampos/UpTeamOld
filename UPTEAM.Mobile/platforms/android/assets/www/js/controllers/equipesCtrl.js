(function () {
    angular.module('starter.controllers')

        .controller('EquipesCtrl', function ($scope, equipesService) {
            $scope.equipes = [];

            equipesService.obterEquipes().success(function (data) {
                $scope.equipes = data.src;
            });

        })
})()
(function () {
    angular.module('starter.controllers')

        .controller('MarcosCtrl', function ($scope, $state, $stateParams, marcosService) {
            $scope.marcos = [];

            marcosService.obterMarcos($stateParams.projetoId).success(function (data) {
                $scope.marcos = data.src;
            });
        })
})()
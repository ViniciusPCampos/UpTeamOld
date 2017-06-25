(function () {
    angular.module('starter.controllers')

    .controller('EquipeCtrl', function ($scope, $state, $stateParams) {

        $scope.participantes = function () {
            $state.go('app.participantes', { equipeId: $stateParams.equipeId });
        };

        $scope.projetosEquipe = function () {
            $state.go('app.projetosEquipe', { equipeId: $stateParams.equipeId });
        };

        $scope.mensagensEquipe = function () {
            $state.go('app.mensagensEquipe', { equipeId: $stateParams.equipeId });
        };
    })
})()
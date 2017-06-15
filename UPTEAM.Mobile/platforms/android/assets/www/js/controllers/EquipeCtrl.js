(function () {
    angular.module('starter.controllers')

    .controller('EquipeCtrl', function ($scope, $state, $stateParams) {

        $scope.participantes = function () {
            $state.go('app.participantes', { equipeId: $stateParams.equipeId });
        };

    })
})()
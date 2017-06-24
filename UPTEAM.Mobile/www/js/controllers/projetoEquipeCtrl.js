(function () {
    angular.module('starter.controllers')

        .controller('ProjetoEquipeCtrl', function ($scope, $state, $stateParams) {
            console.log($stateParams);
            $scope.marcos = function () {
                $state.go('app.marcos', { projetoId: $stateParams.projetoId });
            };

            $scope.sprints = function () {
                $state.go('app.sprints', { projetoId: $stateParams.projetoId });
            };
        })
})()
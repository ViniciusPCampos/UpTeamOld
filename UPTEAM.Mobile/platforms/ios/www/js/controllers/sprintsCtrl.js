(function () {
    angular.module('starter.controllers')

        .controller('SprintsCtrl', function ($scope, $state, $stateParams, sprintsService) {
            $scope.sprints = [];

            sprintsService.obterSprints($stateParams.projetoId).success(function (data) {
                $scope.sprints = data.src;
            });
        })
})()
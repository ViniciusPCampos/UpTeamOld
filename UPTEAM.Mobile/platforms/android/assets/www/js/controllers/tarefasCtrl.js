(function () {
    angular.module('starter.controllers')

        .controller('TarefasCtrl', function ($scope, $state, $stateParams, tarefasService) {
            $scope.tarefas = [];

            tarefasService.obterTarefas($stateParams.sprintId).success(function (data) {
                $scope.tarefas = data.src;
            });
        })
})()
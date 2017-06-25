(function () {
    angular.module('starter.controllers')

        .controller('MinhasTarefasCtrl', function ($scope, $state, tarefasService) {
            $scope.minhasTarefas = [];

            tarefasService.obterMinhasTarefas().success(function (data) {
                console.log(data.src);
                $scope.minhasTarefas = data.src;
            });
        })
})()
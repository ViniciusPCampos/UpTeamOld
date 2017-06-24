(function () {
    angular.module('starter.controllers')

        .controller('ProjetosEquipeCtrl', function ($scope, $state, $stateParams, projetosEquipeService) {
            $scope.projetosEquipe = [];

            projetosEquipeService.obterProjetosEquipe($stateParams.equipeId).success(function (data) {
                $scope.projetosEquipe = data.src;
            });
            
        })
})()
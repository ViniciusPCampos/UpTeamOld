(function () {
    angular.module('starter.controllers')

        .controller('ProjetosCtrl', function ($scope, projetoService) {
            $scope.projetos = [];

            projetoService.obterProjetos().success(function (data) {
                $scope.projetos = data.src;
            });

        })
})()
(function () {
    angular.module('starter.controllers')

        .controller('MensagensEquipeCtrl', function ($scope, $state, $stateParams, mensagensEquipeService) {
            $scope.mensagens = [];

            $scope.mensagem = {};

            

            mensagensEquipeService.obterMensagensEquipe($stateParams.equipeId).success(function (data) {       
                $scope.mensagens = data.src;
            });
            $scope.mandarMensagem = function () {
                mensagensEquipeService.enviarMensagem($scope.mensagem);
            }
            
        })
})()
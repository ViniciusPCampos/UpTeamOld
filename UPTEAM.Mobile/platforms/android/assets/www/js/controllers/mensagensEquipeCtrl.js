(function () {
    angular.module('starter.controllers')

        .controller('MensagensEquipeCtrl', function ($scope, $state, $stateParams, mensagensEquipeService) {
            $scope.mensagens = [];

            $scope.mensagem = {};
          
            $scope.carregarMensagens = function () {
                mensagensEquipeService.obterMensagensEquipe($stateParams.equipeId).success(function (data) {
                    console.log(data.src);
                    $scope.mensagens = data.src;
                });
            }
            $scope.carregarMensagens();
            $scope.mandarMensagem = function () {
                $scope.mensagem.equipe = $stateParams.equipeId;
                mensagensEquipeService.enviarMensagem($scope.mensagem).then(function () {
                    $scope.carregarMensagens();
                })
            }
            
        })
})()
(function () {
    angular.module('starter.controllers')

    .controller('ParticipantesCtrl', function ($scope, $state, $stateParams, participantesService) {
        $scope.participantes = [];

        participantesService.obterParticipantesEquipe($stateParams.equipeId).success(function (data) {
            $scope.participantes = data.src;
        });

    })
})()
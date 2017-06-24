(function () {
    angular.module('starter.services')
        .factory('participantesService', function ($http, config) {
            var _obterParticipantesEquipe = function (id) {
                return $http.get(config.baseUrl + "/equipes/" + id + "/usuarios");
            };

            return {
                obterParticipantesEquipe: _obterParticipantesEquipe
            };
        });
})()
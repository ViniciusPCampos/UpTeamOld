(function () {
    angular.module('starter.services')
        .factory('tarefasService', function ($http, config) {
            var _obterTarefas = function (id) {
                return $http.get(config.baseUrl + "/sprint/" + id + "/tarefa");
            };

            return {
                obterTarefas: _obterTarefas
            };
        });
})()
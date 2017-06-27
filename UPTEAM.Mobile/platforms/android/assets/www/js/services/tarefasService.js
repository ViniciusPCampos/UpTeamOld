(function () {
    angular.module('starter.services')
        .factory('tarefasService', function ($http, config) {
            var _obterTarefas = function (id) {
                return $http.get(config.baseUrl + "/sprint/" + id + "/tarefa");
            };
            var _obterMinhasTarefas = function () {
                return $http.get(config.baseUrl + "/tarefas");
            };
            return {
                obterTarefas: _obterTarefas,
                obterMinhasTarefas: _obterMinhasTarefas
            };
        });
})()
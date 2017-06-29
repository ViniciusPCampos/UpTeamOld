(function () {
    angular.module('starter.services')
        .factory('usuarioService', function ($http, config) {
            var _obterPerfilUsuario = function (id) {
                return $http.get(config.baseUrl + "/usuario/perfil");
            };

            return {
                obterPerfilUsuario: _obterPerfilUsuario
            };
        });
})()
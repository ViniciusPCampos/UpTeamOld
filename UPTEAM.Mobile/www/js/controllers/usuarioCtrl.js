(function () {
    angular.module('starter.controllers')

        .controller('UsuarioCtrl', function ($scope, usuarioService) {
            $scope.perfil = {};

            usuarioService.obterPerfilUsuario().success(function (data) {
                console.log(data.src);
                $scope.perfil = data.src;
            });

        })
})()
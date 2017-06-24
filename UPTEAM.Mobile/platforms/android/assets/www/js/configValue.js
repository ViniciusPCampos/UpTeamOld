(function () {
    angular.module('starter')

    .value("config", {
        baseUrl: "http://localhost:49468/api/v1",
        baseUrlToken: "http://localhost:49468/api/security/token"
    });
})()
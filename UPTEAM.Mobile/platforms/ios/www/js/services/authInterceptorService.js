(function () {
    angular.module('starter.services')


        .factory('authInterceptorService', ['$q', '$injector', '$window', 'localStorageService', function ($q, $injector, $window, localStorageService) {

            var authInterceptorServiceFactory = {};

            authInterceptorServiceFactory.request = function (config) {

                config.headers = config.headers || {};

                var authData = localStorageService.get('authorizationData');
                if (authData) {
                    config.headers.Authorization = 'Bearer ' + authData.token;
                }

                return config;
            }

            authInterceptorServiceFactory.responseError = function (rejection) {
                if (rejection.status === 401) {
                    var authService = $injector.get('authService');
                    var authData = localStorageService.get('authorizationData');
                    //authService.logOut();

                }
                return $q.reject(rejection);
            };

            return authInterceptorServiceFactory;

        }]);



})()
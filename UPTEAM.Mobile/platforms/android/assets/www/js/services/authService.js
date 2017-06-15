(function () {
    angular.module('starter.services')


        .factory('authService', ['$http', '$httpParamSerializer', '$q', 'localStorageService', 'config', function ($http, $httpParamSerializer, $q, localStorageService, config) {
            var authServiceFactory = {};

            var _authentication = {
                isAuth: false,
                userName: ""
            };
            
            authServiceFactory.saveRegistration = function (registration) {

                //authServiceFactory.logOut();

                return $http.post('/api/account/register', registration)
            };

            authServiceFactory.login = function (loginData) {
                var deferred = $q.defer();
                console.log(loginData);
                var req = {
                    method: 'POST',
                    url: config.baseUrlToken,
                    crossDomain: true,
                    headers: {
                        'Content-Type': "application/x-www-form-urlencoded"
                    },
                    data: $httpParamSerializer({ grant_type: 'password', username: loginData.username, password: loginData.password })
                }
                console.log(req);
                $http(req)
                    .success(function (response) {
                        localStorageService.set('authorizationData', { token: response.access_token, userName: response.userName });
                        console.log('logado com sucesso!!');
                        _authentication.isAuth = true;
                        _authentication.userName = loginData.userName;
                        deferred.resolve(response);
                    }).error(function (err) {
                            deferred.reject(err);
                    });

                return deferred.promise;
            };

            authServiceFactory.logOut = function () {

                localStorageService.remove('authorizationData');

                _authentication.isAuth = false;
                _authentication.userName = "";
            };

            authServiceFactory.fillAuthData = function () {
                var authData = localStorageService.get('authorizationData');
                if (authData) {
                    _authentication.isAuth = true;
                }
                else {
                    _authentication.isAuth = false;
                }
            };

            return authServiceFactory;
        }]);



})()
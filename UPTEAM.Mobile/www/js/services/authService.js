(function () {
    angular.module('starter.services')


        .factory('authService', ['$http', '$q', 'localStorageService', 'config', function ($http, $q, localStorageService, config) {
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
                var data = "grant_type=password&username=" + loginData.username + "&password=" + loginData.password;

                var deferred = $q.defer();

                var req = {
                    method: 'POST',
                    url: config.baseUrlToken,
                    crossDomain: true,
                    headers: {
                        'Content-Type': "application/json"
                    },
                    data: { grant_type: 'password', username: loginData.username, password: loginData.password }
                }
                
                $http(req)
                    .success(function(){
                            console.log('foi');
                        }).error(function(){
                            console.log('n foi');
                        });

                //$http.post(config.baseUrlToken, data, {
                //    header: { 'Content-Type': 'application/x-www-form-urlencoded' }
                //}).success(function (response) {
                //    console.log('sim');
                //    localStorageService.set('authorizationData', { token: response.access_token, userName: response.userName });

                //    _authentication.isAuth = true;
                //    _authentication.userName = loginData.userName;

                //    deferred.resolve(response);
                //}).error(function (err) {
                //    console.log('não');
                //    //_logOut();
                //    deferred.reject(err);
                //});

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

            authServiceFactory.changePassword = function (passwordData) {

                return $http.post('/api/Manage/ChangePassword', passwordData)

            };

            return authServiceFactory;
        }]);



})()
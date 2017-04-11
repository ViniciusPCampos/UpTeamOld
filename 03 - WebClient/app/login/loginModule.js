angular.module('loginModule', [
  'loginRegisterModule',
  'loginIndexModule'
])
.config(['$stateProvider', '$urlRouterProvider',function($stateProvider, $urlRouterProvider){
  $stateProvider
  .state('login', {
    url:'/login/index',
    templateUrl: 'app/login/view/index.html',
    controller: 'loginIndexController'
  })
  .state('register',{
    url: '/login/register',
    templateUrl: 'app/login/view/register.html',
    controller:'loginRegisterModule'
  });

}]);

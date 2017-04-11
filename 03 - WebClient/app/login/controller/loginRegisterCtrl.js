angular.module('loginRegisterModule',[
  'ui.mask'
])
.controller('loginRegisterController', [
  '$scope',
  function($scope){
      $scope.msg = "teste";
  }
]);

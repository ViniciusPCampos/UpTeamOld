 angular.module("UpTeam").controller("createProjectCtrl", function($scope, login, projectAPI, team, $location){
 	$scope.PageTitle = "Project";
 	$scope.teams = team.data;
  var formatDate = function (date) {
   var day = date.getDate();
   var month = date.getMonth();
   var year = date.getFullYear();
   return year + "-" + month + "-" + day;
  }
 	$scope.addProject = function(project){
    console.log($scope.project.estimatedDeadline);
    $scope.project.estimatedDeadline = formatDate($scope.project.estimatedDeadline);
 		projectAPI.setProject(project).success(function(data){
 			swal('Parabéns!','Projeto cadastrado com Sucesso!', 'success');
 			delete $scope.project;
 			$scope.projectForm.$setPristine();
 			$location.path("/projects");
 		}).error(function(data){
 			swal('Ops!','Desculpe, não conseguimos cadastrar o seu Projeto!', 'error');
 		});
 	};
 });

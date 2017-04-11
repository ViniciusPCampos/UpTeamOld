 angular.module("UpTeam").controller("createTeamCtrl", function($scope, teamAPI, $location){
 	$scope.PageTitle = "Team";


 	$scope.addTeam = function(team){
console.log(team);
 		teamAPI.setTeam(team).success(function(data){
 			swal('Parabéns!','Team Cadastrada Com Sucesso!', 'success');
 			$location.path("/teams");
 		}).error(function(data){
 			swal('Ops!','Desculpe, não conseguimos cadastrar a sua team!', 'error');
 		});
 	};
 });

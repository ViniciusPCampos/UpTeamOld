 angular.module("UpTeam").controller("detailsProjectCtrl", function($scope, project, teams, projectAPI,$location){
 	$scope.PageTitle = "Project";
 $scope.teams = teams.data;
 var project = project.data;

  $scope.updateProject = function(project){
 		projectAPI.updateProject(project).success(function(data) {
 			swal('Ben Feitus Feitus!', 'Project Alterado Com Sucesso!', 'success');
 			$location.path("/projects");
 		}).error(function (data) {
 			swal('Oopa!', 'Desculpe, mas não conseguimos atualzar o Project!', 'error')
 		})
 	};
var formatDate = function (project) {
  console.log(project);
  project.estimatedDeadline = new Date(project.estimatedDeadline);
  console.log(project);
  	$scope.project = project;
}
formatDate(project);
  $scope.deleteProject = function (projectId) {
    swal({
      title: 'Are you sure?',
      text: "You are deleting your project!",
      type: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',
      confirmButtonText: 'Yes, delete it!'
    }).then(function() {
      projectAPI.deleteProject(projectId).success(function (data) {
        swal(
        'Deleted!',
        'Your project has been deleted.',
        'success'
        );
        $location.path("/projects");
      }).error(function (data) {
        swal(
        'Ooops!',
        'Sorry, we can\'t delete your project.',
        'error'
        );
      });

    });
  };
 });

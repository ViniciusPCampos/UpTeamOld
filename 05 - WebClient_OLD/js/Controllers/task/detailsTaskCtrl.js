 angular.module("UpTeam").controller("detailsTaskCtrl", function($scope,user, state, difficulty, project, task, taskAPI,$location){
 	$scope.PageTitle = "Task";
  $scope.users = user.data;
 	$scope.states = state.data;
 	$scope.difficulties = difficulty.data;
 	$scope.projects = project.data;
 	$scope.task = task.data;
 	$scope.updateTask = function(task){
 		taskAPI.updateTask(task).success(function(data) {
 			swal('Ben Feitus Feitus!', 'Task Alterada Com Sucesso!', 'success');
 			$location.path("/tasks/list");
 		}).error(function (data) {
 			swal('Oopa!', 'Desculpe, mas não conseguimos atualzar a Task!', 'error')
 		})
 	};

  $scope.deleteTask = function (taskId) {
    swal({
      title: 'Are you sure?',
      text: "You are deleting your task!",
      type: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',
      confirmButtonText: 'Yes, delete it!'
    }).then(function() {
      taskAPI.deleteTask(taskId).success(function (data) {
        swal(
        'Deleted!',
        'Your task has been deleted.',
        'success'
        );
        $location.path("/tasks");
      }).error(function (data) {
        swal(
        'Ooops!',
        'Sorry, we can\'t delete your task.',
        'error'
        );
      });

    });
  };
 });

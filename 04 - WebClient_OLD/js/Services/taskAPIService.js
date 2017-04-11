angular.module("UpTeam").factory ("taskAPI",function($http, config, $cookies){
	var _getTasks = function(){
		return $http.get(config.baseUrl + "task/" );
	};

	var _setTask = function(task){
		console.log($cookies.get("user"));
		return $http.post(config.baseUrl + "task/?id=&name=" + task.name
			+ "&description="  + task.description
			+ "&estimate=" + task.estimate
			+ "&difficulty=" + task.difficulty
			+ "&owner=" + task.owner
			+ "&createdBy=" + $cookies.get("user")
			+ "&state=" + task.state
			+ "&project=" + task.project
			)
	};
	var _getTask = function(id){
		return $http.get(config.baseUrl + "task/?id=" + id)
	};
	var _updateTask = function (task) {
		return $http.put(config.baseUrl + "task/?id=" + task.Id
			+ "&name=" + task.name
			+ "&description="  + task.description
			+ "&estimate=" + task.estimate
			+ "&difficulty=" + task.difficulty
			+ "&owner=" + task.owner
			+ "&state=" + task.state)
	};
	var _deleteTask = function(id){
		return $http.delete(config.baseUrl + "task/?id=" + id)
	};
	return {
		getTasks: _getTasks,
		setTask: _setTask,
		getTask: _getTask,
		updateTask: _updateTask,
		deleteTask: _deleteTask
	};
});

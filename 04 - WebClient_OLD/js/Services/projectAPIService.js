angular.module("UpTeam").factory("projectAPI", function($http, config){
	var _getProjects = function(){
		return $http.get(config.baseUrl + "Project/")
	};
	var _getProject = function(id){
		return $http.get(config.baseUrl + "Project/?id=" + id);
	};
	var _setProject = function(project){
		return $http.post(config.baseUrl + "Project/?name=" + project.name
											+ "&team=" + project.team
											+"&estimatedDeadline="+ project.estimatedDeadline
											+ "&description=" + project.description)
	};
	var _updateProject = function(project){
		return $http.put(config.baseUrl + "Project/?id="+ project.Id + "&name=" + project.name
											+ "&team=" + project.team
											+"&estimatedDeadline="+ project.estimatedDeadline
											+ "&description=" + project.description)
	};
	var _deleteProject = function(id){
		return $http.delete(config.baseUrl + "Project/?id=" + id);
	};
	return {
		getProjects: _getProjects,
		getProject: _getProject,
		setProject: _setProject,
		updateProject: _updateProject,
		deleteProject: _deleteProject
	};
});

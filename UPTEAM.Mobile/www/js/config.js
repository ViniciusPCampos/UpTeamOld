(function () {
    angular.module('starter')

        .config(function ($stateProvider, $urlRouterProvider, $httpProvider) {
            $stateProvider

                .state('app', {
                    url: '/app',
                    abstract: true,
                    templateUrl: 'templates/menu.html',
                    controller: 'AppCtrl'
                })

                .state('app.equipes', {
                    url: '/equipes',
                    views: {
                        'menuContent': {
                            templateUrl: 'templates/equipes.html',
                            controller: 'EquipesCtrl'
                        }
                    }
                })
                .state('app.equipe', {
                    url: '/equipes/:equipeId',
                    views: {
                        'menuContent': {
                            templateUrl: 'templates/equipeMenu.html',
                            controller: 'EquipeCtrl'
                        }
                    }
                })
                .state('app.participantes', {
                    url: '/participantes/:equipeId',
                    views: {
                        'menuContent': {
                            templateUrl: 'templates/participantes.html',
                            controller: 'ParticipantesCtrl'
                        }
                    }
                })

                .state('app.projetosEquipe', {
                    url: '/projetosEquipe/:equipeId',
                    views: {
                        'menuContent': {
                            templateUrl: 'templates/projetosEquipe.html',
                            controller: 'ProjetosEquipeCtrl'
                        }
                    }
                })

                .state('app.mensagensEquipe', {
                    url: '/mensagensEquipe/:equipeId',
                    views: {
                        'menuContent': {
                            templateUrl: 'templates/mensagensEquipe.html',
                            controller: 'MensagensEquipeCtrl'
                        }
                    }
                })

                .state('app.projetos', {
                    url: '/projetos',
                    views: {
                        'menuContent': {
                            templateUrl: 'templates/projetos.html',
                            controller: 'ProjetosCtrl'
                        }
                    }
                })

                .state('app.projetoMenu', {
                    url: '/projetos/:projetoId',
                    views: {
                        'menuContent': {
                            templateUrl: 'templates/projetoMenu.html',
                            controller: 'ProjetoEquipeCtrl'
                        }
                    }
                })

                .state('app.marcos', {
                    url: '/marcos/:projetoId',
                    views: {
                        'menuContent': {
                            templateUrl: 'templates/marcos.html',
                            controller: 'MarcosCtrl'
                        }
                    }
                })

                .state('app.sprints', {
                    url: '/sprints/:projetoId',
                    views: {
                        'menuContent': {
                            templateUrl: 'templates/sprints.html',
                            controller: 'SprintsCtrl'
                        }
                    }
                })

                .state('app.tarefas', {
                    url: '/tarefas/:sprintId',
                    views: {
                        'menuContent': {
                            templateUrl: 'templates/tarefas.html',
                            controller: 'TarefasCtrl'
                        }
                    }
                })

                .state('login', {
                    url: '/login',
                    templateUrl: 'templates/login.html',
                    controller: 'LoginCtrl'
                }
                )
                .state('app.dashboard', {
                    url: '/dashboard',
                    views: {
                        'menuContent': {
                            templateUrl: 'templates/dashboard.html',
                            controller: 'DashboardCtrl'
                        }
                    }
                })

                .state('app.single', {
                    url: '/playlists/:playlistId',
                    views: {
                        'menuContent': {
                            templateUrl: 'templates/playlist.html',
                            controller: 'PlaylistCtrl'
                        }
                    }
                });
            // if none of the above states are matched, use this as the fallback
            $urlRouterProvider.otherwise('/login');

            $httpProvider.interceptors.push('authInterceptorService');
        });

})()


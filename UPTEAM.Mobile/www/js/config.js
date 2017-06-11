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

        .state('login', {
            url: '/login',
            templateUrl: 'templates/login.html',
            controller: 'LoginCtrl'
            }
        )
          .state('app.playlists', {
              url: '/playlists',
              views: {
                  'menuContent': {
                      templateUrl: 'templates/playlists.html',
                      controller: 'PlaylistsCtrl'
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


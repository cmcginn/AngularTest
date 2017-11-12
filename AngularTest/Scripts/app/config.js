angular.module('myApp').config([
    '$stateProvider', '$mdIconProvider', '$urlRouterProvider', '$mdThemingProvider',
    function ($stateProvider, $mdIconProvider, $urlRouterProvider, $mdThemingProvider) {
        // theme
        $mdThemingProvider.theme('default')
            .primaryPalette('blue')
            .accentPalette('light-green')
            .foregroundPalette['1'] = 'rgb(5, 57, 72)';

        // routes
        $urlRouterProvider.otherwise('/main');
        $stateProvider.state('main',
            {
                url: '/main',
                templateUrl: '/scripts/app/views/main.html',
                controller: 'mainController'
            });
    }
]);
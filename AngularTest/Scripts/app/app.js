'use strict';

// Declare app level module which depends on views, and components
angular.module('myApp', [
        
]).config([function ($locationProvider) {
        $locationProvider.hashPrefix('!');

       // $routeProvider.otherwise({ redirectTo: '/view1' });
}]);
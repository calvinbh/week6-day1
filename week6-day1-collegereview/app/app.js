var app = angular.module('app', ['ngRoute']);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/', {
        templateUrl: '/app/Views/Home.html',
        title: 'Home Page'
    }).otherwise({
        redirectTo: '/'
    })
}]);
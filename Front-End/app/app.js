var myApp = angular.module('myApp', ['ngRoute'])

myApp.config(['$routeProvider', function($routeProvider) {
    $routeProvider.when('/fruit-vege', {
        templateUrl: 'views/home.html',
        controller: 'FruitAndVegeController'
    }).when('/employee', {
        templateUrl: 'views/employees.html',
        controller: 'EmployeesController'
    }).otherwise({
        redirectTo: '/employee'
    })
}])

myApp.controller('EmployeesController', ['$scope', '$http', function($scope, $http) {
    $scope.handleLoad = function () {
        console.log('halo')
        $http({
            method: 'GET',
            url: 'https://localhost:7177/Employee/GetEldestAndYoungestEmployees'
        }).then(function (response){
            $scope.employees = response.data
        }, function (response) {
            $scope.error = 'System error, please try again later.'
        })
    }
}])

myApp.controller('FruitAndVegeController', ['$scope', '$http', function($scope, $http) {
    var fruitsFile = '/data/fruits.text' // Replace with the path to your file
    var vegeFile = '/data/vege.text'

    $http({
        method: 'GET',
        url: fruitsFile
    }).then(function (response){
        $scope.fruits = response.data.split(" ")
    })

    $http({
        method: 'GET',
        url: vegeFile
    }).then(function (response){
        $scope.veges = response.data.split(" ")
    })
}])
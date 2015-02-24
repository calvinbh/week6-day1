app.controller('HomeController', ['$scope', '$http', function ($scope, $http) {
    $scope.colleges = [];
    $http.get("/api/College")
    .success(function (data, status) {
        for (var x in data) {
            $scope.colleges.push(data[x]);
        }
    }).error(function (data, status) {
        console.log(status);
    })
}]);
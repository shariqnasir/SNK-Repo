'use strict';
app.factory('ordersService', ['$http', function ($http) {

    var serviceBase = 'http://localhost:56133/';
    var restaurantServiceFactory = {};

    var _getOrders = function () {

        return $http.get(serviceBase + 'api/orders').then(function (results) {
            return results;
        });
    };

    restaurantServiceFactory.getOrders = _getOrders;

    return restaurantServiceFactory;

}]);
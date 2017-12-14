(function () {
    "use strict";
    var app = angular.module("learningAdminApp", []);
    app.config("configurationStates", ConfigurationStates);
    ConfigurationStates.$inject = ['$stateProvider', '$locationProvider', '$urlRouterProvider'];

    function ConfigurationStates($stateProvider, $locationProvider, $urlRouterProvider) {
        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false
        });
        $urlRouterProvider.otherwise('/admin/home');
        $stateProvider
            .state({
                name: 'home',
                url: '/admin/home',
                templateUrl: '/app/admin/Templates/adminMainDetails.html',
                title: "Home",
                controller: 'adminMainController as amCtrl'
            });

    }
})();
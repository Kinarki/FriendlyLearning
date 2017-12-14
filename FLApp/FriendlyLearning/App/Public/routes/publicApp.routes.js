(function () {
    "use strict";
    var app = angular.module("learningPublicApp", []);
    app.config("configurationStates", ConfigurationStates);
    ConfigurationStates.$inject = ['$stateProvider', '$locationProvider', '$urlRouterProvider'];

    function ConfigurationStates($stateProvider, $locationProvider, $urlRouterProvider) {
        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false
        });
        $urlRouterProvider.otherwise('/Public/home');
        $stateProvider
            .state({
                name: 'home',
                url: '/Public/home',
                templateUrl: '/App/Public/Templates/publicMainDetails.html',
                title: "Home",
                //controller: 'publicMainController as pmCtrl'
                component: "/Scripts/AngularCode/Public/Components/publicMain.component.js"
            });
    }
})();
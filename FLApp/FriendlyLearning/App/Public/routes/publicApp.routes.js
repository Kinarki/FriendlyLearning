(function () {
    "use strict";
    var app = angular.module("learningPublicApp.routes", []);
    app.config(_configurationStates);
    _configurationStates.$inject = ['$stateProvider', '$locationProvider', '$urlRouterProvider'];

    function _configurationStates($stateProvider, $locationProvider, $urlRouterProvider) {
        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false
        });
        $urlRouterProvider.otherwise('/home');
        $stateProvider
            .state({
                name: 'home',
                url: '/home',
                templateUrl: '/App/Public/Templates/publicMainDetails.html',
                title: "Home",
                controller: "publicMainController as pmCtrl"
            })
            .state({
                name: 'scraper',
                url: '/scraper',
                templateUrl: "/App/Scraper/Html/scraperDetails.html",
                title: "Scraper",
                controller: "scraperController as scrapeCtrl"
            })
            .state({
                name: 'colors',
                url: '/colors',
                templateUrl: "/App/Public/Templates/Colors/colorsDetails.html",
                title: "Colors",
                controller: "colorsController as clrCtrl"
            })
            .state({
                name: 'numbers',
                url: '/numbers',
                templateUrl: "/App/Public/Templates/Numbers/numbersDetails.html",
                title: "Numbers",
                controller: "numbersController as numCtrl"
            })
            .state({
                name: 'letters',
                url: '/letters',
                templateUrl: "/App/Public/Templates/Letters/lettersDetails.html",
                title: "Letters",
                controller: "lettersController as ltrCtrl"
            });
    }
})();
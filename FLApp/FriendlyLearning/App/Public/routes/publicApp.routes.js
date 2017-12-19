﻿(function () {
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
                component: "/Scripts/AngularCode/Public/Components/publicMain.component.js"
            })
            .state({
                name: "scraper",
                url: "Public/Scraper",
                templateUrl: "/App/Scraper/Html/scraperDetails.html",
                title: "Scraper",
                component: "/Scripts/AngularCode/Public/Components/scraper.component.js"
            });
    }
})();
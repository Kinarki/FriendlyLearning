(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .controller("scraperController", ScraperController);

    ScraperController.$inject = ["$scope", "scraperService"];

    function ScraperController($scope, ScraperService) {
        var vm = this;
        vm.$scope = $scope;
        vm.scraperService = ScraperService;
        vm.$onInit = _onInit;

        function _onInit() {
            console.log("hello from the scraper controller");
        }
    }
})();
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
        vm.getAll = _getAll;
        vm.scrapeSuccess = _scrapeSuccess;
        vm.scrapeError = _scrapeError;
        vm.imgList = [];

        function _onInit() {
            console.log("hello from the scraper controller");
            vm.getAll();
        }

        function _getAll() {
            vm.scraperService.getAll()
                .then(vm.scrapeSuccess)
                .catch(vm.scrapeError);
        }

        function _scrapeSuccess(resp) {
            console.log(resp.data.item.info);
            vm.imgList = resp.data.item.info;
            vm.imgList.splice(0, 3);
        }

        function _scrapeError(err) {
            console.log(err);
        }

    }
})();
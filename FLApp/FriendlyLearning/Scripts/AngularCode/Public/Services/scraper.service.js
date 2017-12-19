(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .factory("scraperService", ScraperService);

    ScraperService.$inject = ["$http", "$q"];

    function ScraperService($http, $q) {
        return {

        }
    }
})();
(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .factory("scraperService", ScraperService);

    ScraperService.$inject = ["$http", "$q"];

    function ScraperService($http, $q) {
        return {
            getAll: _getAll
        }

        function _getAll() {
            return $http.get("/api/scrape")
                .then(success)
                .catch(error);
        }

        function success(resp) {
            return resp;
        }

        function error(err) {
            return $q.reject(err);
        }
    }
})();
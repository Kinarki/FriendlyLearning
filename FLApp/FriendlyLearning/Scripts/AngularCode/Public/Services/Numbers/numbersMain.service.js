(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .factory("numbersMainService", NumbersMainService);

    NumbersMainService.$inject = ["$http", "$q"];

    function NumbersMainService($http, $q) {
        return {
            selectAll: _selectAll
        }

        function _selectAll() {
           return $http.get("api/numbers")
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
(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .factory("lettersMainService", LettersMainService);

    LettersMainService.$inject = ["$http", "$q"];

    function LettersMainService($http, $q) {
        return {
            selectAll: _selectAll
        }

        function _selectAll() {
            return $http.get("/api/letters")
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
(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .factory("lettersMainService", LettersMainService);

    LettersMainService.$inject = ["$http", "$q"];

    function LettersMainService($http, $q) {
        return {

        }
    }
})();
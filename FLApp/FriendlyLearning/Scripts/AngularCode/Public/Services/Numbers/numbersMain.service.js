(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .factory("numbersMainService", NumbersMainService);

    NumbersMainService.$inject = ["$http", "$q"];

    function NumbersMainService($http, $q) {
        return {

        }
    }
})();
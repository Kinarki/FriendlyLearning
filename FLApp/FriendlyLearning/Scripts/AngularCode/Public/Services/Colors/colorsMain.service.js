(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .factory("colorsMainService", ColorsMainService);

    ColorsMainService.$inject = ["$http", "$q"];

    function ColorsMainService($http, $q) {
        return {

        }
    }
})();
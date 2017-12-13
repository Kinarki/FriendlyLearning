(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .factory("publicMainService", PublicMainService);

    PublicMainService.$inject = ["$http", "$q"];

    function PublicMainService($http, $q) {
        return {

        }
    }
})();
(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .factory("picturesMainService", PicturesMainService);

    PicturesMainService.$inject = ["$http", "$q"];

    function PicturesMainService($http, $q) {
        return {

        }
    }
})();
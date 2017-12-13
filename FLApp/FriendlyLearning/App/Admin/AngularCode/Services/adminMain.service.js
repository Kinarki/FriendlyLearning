(function () {
    "use strict";
    angular
        .module("learningAdminApp")
        .factory("adminMainService", AdminMainService);

    AdminMainService.$inject = ["$http", "q"];

    function AdminMainService($http, $q) {
        return {

        }
    }
})();
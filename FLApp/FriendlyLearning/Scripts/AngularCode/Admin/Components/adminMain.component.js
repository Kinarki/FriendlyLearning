(function () {
    "use strict";
    angular
        .module("learningAdminApp")
        .component("adminMain", {
            templateUrl: "app/admin/AngularCode/Templates/adminMainDetails.html",
            controller: "adminMainController",
            bindings: {
                adminMain: "<"
            }
        });
})();
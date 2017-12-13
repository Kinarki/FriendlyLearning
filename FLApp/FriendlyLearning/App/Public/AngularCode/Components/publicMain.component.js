(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .component("publicMain", {
            templateUrl: "app/public/AngularCode/Templates/publicMainDetails.html",
            controller: "publicMainController",
            bindings: {
                mainBind: "<"
            }
        });
})();
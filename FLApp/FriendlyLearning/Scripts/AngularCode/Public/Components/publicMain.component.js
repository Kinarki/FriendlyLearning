(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .component("publicMain", {
            templateUrl: "/App/Public/Templates/publicMainDetails.html",
            controller: "publicMainController",
            bindings: {
                mainBind: "<"
            }
        });
})();
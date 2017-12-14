(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .component("numbersMain", {
            templateUrl: "/App/Public/Templates/Numbers/numbersMainDetails.html",
            controller: "numbersMainController",
            bindings: {
                numberBind: "<"
            }
        });
})();
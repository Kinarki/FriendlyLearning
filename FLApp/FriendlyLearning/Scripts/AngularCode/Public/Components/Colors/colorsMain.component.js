(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .component("colorsMain", {
            templateUrl: "/App/Public/Templates/Colors/colorsMainDetails.html",
            controller: "colorsMainController",
            bindings: {
                colorBind: "<"
            }
        });
})();
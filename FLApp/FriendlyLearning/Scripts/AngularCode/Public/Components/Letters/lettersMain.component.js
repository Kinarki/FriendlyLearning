(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .component("lettersMain", {
            templateUrl: "/App/Public/Templates/Letters/lettersMainDetails.html",
            controller: "lettersMainController",
            bindings: {
                letterBind: "<"
            }
        });
})();
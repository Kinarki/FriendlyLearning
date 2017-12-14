(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .component("picturesMain", {
            templateUrl: "/App/Public/Templates/Pictures/picturesMainDetails.html",
            controller: "picturesMainController",
            bindings: {
                pictureBind: "<"
            }
        });
})();
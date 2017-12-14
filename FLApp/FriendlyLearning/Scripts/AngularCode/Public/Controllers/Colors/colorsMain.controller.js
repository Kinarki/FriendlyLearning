(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .controller("colorsMainController", ColorsMainController);

    ColorsMainController.$inject = ["$scope", "colorsMainService"];

    function ColorsMainController($scope, ColorsMainService) {
        var vm = this;
        vm.$scope = $scope;
        vm.colorsMainService = ColorsMainService;
        vm.$onInit = _onInit;
    }
})();
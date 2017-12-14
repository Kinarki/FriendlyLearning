(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .controller("numbersMainController", NumbersMainController);

    NumbersMainController.$inject = ["$scope", "numbersMainService"];

    function NumbersMainController($scope, NumbersMainService) {
        var vm = this;
        vm.$scope = $scope;
        vm.numbersMainService = NumbersMainService;
        vm.$onInit = _onInit;
    }
})();
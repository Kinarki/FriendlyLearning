(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .controller("picturesMainController", PicturesMainController);

    PicturesMainController.$inject = ["$scope", "picturesMainService"];

    function PicturesMainController($scope, PicturesMainService) {
        var vm = this;
        vm.$scope = $scope;
        vm.picturesMainService = PicturesMainService;
        vm.$onInit = _onInit;
    }
})();
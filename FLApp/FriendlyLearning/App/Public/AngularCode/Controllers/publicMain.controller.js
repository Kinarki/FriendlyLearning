(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .controller("publicMainController", PublicMainController);

    PublicMainController.$inject = ["$scope", "publicMainService"];

    function PublicMainController($scope, PublicMainService) {
        var vm = this;
        vm.$scope = $scope;
        vm.publicMainService = PublicMainService;
        vm.$onInit = _onInit;
    }
})();
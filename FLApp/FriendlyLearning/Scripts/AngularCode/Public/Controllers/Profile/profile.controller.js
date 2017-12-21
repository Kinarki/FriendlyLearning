(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .controller("profileController", ProfileController);

    ProfileController.$inject = ["$scope", "profileService"];

    function ProfileController($scope, ProfileService) {
        var vm = this;
        vm.$scope = $scope;
        vm.profileService = ProfileService;
        vm.$onInit = _onInit;
    } 
})();
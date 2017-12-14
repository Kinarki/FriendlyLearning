(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .controller("lettersMainController", LettersMainController);

    LettersMainController.$inject = ["$scope", "lettersMainService"];

    function LettersMainController($scope, LettersMainService) {
        var vm = this;
        vm.$scope = $scope;
        vm.lettersMainService = LettersMainService;
        vm.$onInit = _onInit;
    }
})();
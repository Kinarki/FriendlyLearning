(function () {
    "use strict";
    angular
        .module("learningAdminApp")
        .controller("adminMainController", AdminMainController);

    AdminMainController.$inject = ["$scope", "adminMainService"];

    function AdminMainController($scope, AdminMainService) {
        var vm = this;
        vm.$scope = $scope;
        vm.adminMainService = AdminMainService;
        vm.$onInit = _onInit;

        function _onInit() {
            console.log("admin init inited");
        }
    }
})();
﻿(function () {
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
        vm.insertUser = _insertUser;
        vm.success = _success;
        vm.error = _error;
        vm.selectAll = _selectAll;
        vm.allSuccess = _allSuccess;
        vm.selectById = _selectById;
        vm.byIdSuccess = _byIdSuccess;
        vm.updateUser = _updateUser;
        vm.deleteUser = _deleteUser;

        function _onInit() {
            console.log("public init inited");
        }

        function _insertUser(data) {
            vm.publicMainService.InsertUser(data)
                .then(vm.success)
                .catch(vm.error);
        }

        function _success(resp) {
            console.log(resp);
        }

        function _error(err) {
            console.log(err);
        }

        function _selectAll() {
            vm.publicMainService.SelectAll()
                .then(vm.allSuccess)
                .catch(vm.Error);
        }

        function _allSuccess(resp) {
            console.log(resp);
        }

        function _selectById(id) {
            vm.publicMainService.SelectById(id)
                .then(vm.byIdSuccess)
                .catch(vm.error);
        }

        function _selectByIdSuccess(resp) {
            console.log(resp);
        }

        function _updateUser(id, data) {
            vm.publicMainService.updateUser(id, data)
                .then(vm.success)
                .catch(vm.error);
        }

        function _deleteUser(id) {
            vm.publicMainService.deleteUser(id)
                .then(vm.success)
                .catch(vm.error);
        }
    }
})();
(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .controller("publicMainController", PublicMainController);

    PublicMainController.$inject = ["$scope", "$location", "publicMainService"];

    function PublicMainController($scope, $location, PublicMainService) {
        var vm = this;
        vm.$scope = $scope;
        vm.$location = $location;
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
        vm.registerForm = _registerForm;
        vm.registerFormShow = false;
        vm.loginForm = _loginForm;
        vm.loginFormShow = false;
        vm.item = [];
        vm.checkEmail = _checkEmail;
        vm.emailSuccess = _emailSuccess;
        vm.emailTaken = false;
        vm.login = true;
        vm.picRoute = _picRoute;


        function _onInit() {
            console.log("public init inited");
        }

        function _insertUser() {
            vm.publicMainService.InsertUser(vm.item)
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

        function _byIdSuccess(resp) {
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

        function _registerForm() {
            vm.loginFormShow = false;
            vm.registerFormShow = true;
        }

        function _loginForm() {
            vm.registerFormShow = false;
            vm.loginFormShow = true;
        }

        function _checkEmail() {
            //vm.publicMainService.checkEmail(vm.item.email)
            //    .then(vm.emailSuccess).catch(vm.error);
        }

        function _emailSuccess(res) {
            if (res.data.item === 1) {
                vm.emailTaken = true;
                $scope.regForm.$setPristine();
            }
            else {
                vm.emailTaken = false;
            }
        }

        function _picRoute() {
            var absUrl = vm.$location.absUrl();
            console.log(absUrl);
            vm.$location.path("/scraper");
        }
    }
})();
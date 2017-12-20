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
        vm.selectAll = _selectAll;
        vm.success = _success;
        vm.error = _error;
        vm.numList = [];
        vm.playAudio = _playAudio;

        function _onInit() {
            console.log("numbers init");

            vm.selectAll();
        }

        function _selectAll() {
            console.log("SelectAll hit");
            vm.numbersMainService.selectAll()
                .then(vm.success)
                .catch(vm.error);
        }

        function _success(resp) {
            console.log(resp);
            for (var i = 0; i < resp.data.items.length; i++) {
                vm.numList.push(resp.data.items[i].number);
            }
        }

        function _error(err) {
            console.log(err);
        }

        function _playAudio(num) {
            var file = "/App/Sounds/audio-numbers/" + num + ".wav";
            var audio = new Audio(file);
            audio.play();
        }
    }
})();
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
        vm.selectAll = _selectAll;
        vm.success = _success;
        vm.error = _error;
        vm.letterList = [];
        vm.playAudio = _playAudio;

        function _onInit() {
            console.log("letters init");
            vm.selectAll();
        }

        function _selectAll() {
            vm.lettersMainService.selectAll()
                .then(vm.success)
                .catch(vm.error);
        }

        function _success(resp) {
            console.log(resp);
            for (var i = 0; i < resp.data.items.length; i++) {
                vm.letterList.push(resp.data.items[i].character);
            }
            console.log(vm.letterList);
        }

        function _error(err) {
            console.log(err);
        }

        function _playAudio(char) {
            var file = "/App/Sounds/audio-alphabet/" + char + ".wav"; 
            var audio = new Audio(file);
            audio.play();
        }
    }
})();
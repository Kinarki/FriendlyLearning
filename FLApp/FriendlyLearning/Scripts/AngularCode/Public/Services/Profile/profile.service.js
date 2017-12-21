(function () {
	"use strict";
	angular
		.module("learningPublicApp")
		.factory("profileService", ProfileService);

	ProfileService.$inject = ["$http", "$q"];

	function ProfileService($http, $q) {
		return {

		}

	}
})();
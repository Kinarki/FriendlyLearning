(function () {
    "use strict";
    angular
        .module("learningPublicApp")
        .factory("publicMainService", PublicMainService);

    PublicMainService.$inject = ["$http", "$q"];

    function PublicMainService($http, $q) {
        return {
            insertUser: _insertUser
            , selectAll: _selectAll
            , selectById: _selectById
            , updateUser: _updateUser
            , deleteUser: _deleteUser
        }

        function _insertUser(data) {
            return $http.post("/api/users/",
                data,
                { withCredentials: true })
                .then(success)
                .catch(error);
        }

        function _selectAll() {
            return $http.get("/api/users/all", { withCredentials: true })
                .then(success)
                .catch(error);
        }

        function _selectById(id) {
            return $http.get("api/users/" + id,
                { withCredentials: true })
                .then(success)
                .catch(error);
        }

        function _updateUser(id, data) {
            return $http.put("/api/learning/" + id,
                data,
                { withCredentials: true })
                .then(success)
                .catch(error);
        }

        function _deleteUser(id) {
            return $http.delete("/api/learning/" + id,
                { withCredentials: true })
                .then(success)
                .catch(error);
        }

        function success(resp) {
            return resp;
        }

        function error(err) {
            return $q.Reject(err);
        }
    }
})();
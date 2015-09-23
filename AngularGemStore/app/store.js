(function () {
    angular.module("store", ["store-products"])
        .controller("StoreController", ["$http", function ($http) {
            var store = this;
            store.products = [];
            $http.get("/api/Gems")
                .success(function (gems) {
                    store.setProducts(gems);
                });
            this.setProducts = function (data) {
                store.products = data;
            };
        }]);
})();
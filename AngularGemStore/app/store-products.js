﻿(function () {
    var app = angular.module("store-products", ["product-reviews"]);

    app.directive("productTitle", function () {
        return {
            restrict: "E",
            templateUrl: "templates/product-title.html"
        };
    });

    app.directive("productPanels", function () {
        return {
            restrict: "E",
            templateUrl: "templates/product-panels.html",
            controller: function () {
                this.tab = 1;

                this.selectTab = function (setTab) {
                    this.tab = setTab;
                };

                this.isSelected = function (tabNumber) {
                    return this.tab === tabNumber;
                };
            },
            controllerAs: "panel",
        };
    });
})();

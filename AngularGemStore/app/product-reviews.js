(function () {
    var app = angular.module("product-reviews", []);

    app.directive("productReviewForm", function () {
        return {
            restrict: "E",
            templateUrl: "templates/product-review-form.html",
            controller: function () {
                this.review = {};

                this.addReview = function (product) {
                    product.reviews.push(this.review);
                    this.review = {};
                };
            },
            controllerAs: "reviewController"
        }
    });
})();
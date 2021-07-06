$(document).ready(function () {
    $("#Order_DepartmentId").on("change", function () {
        $("#Order_ProductId").html("").html('<option value="0">Please select</option>'), $.ajax({
            url: "/product/get-products/" +  $("#Order_DepartmentId").val(),
            type: "GET",
            data: "",
            contentType: "application/json; charset=utf-8",
            success: function (e) {
                $.each(e, function (e, t) {
                    $("#Order_ProductId").append('<option value="' + t.productId + '">' + t.name + "</option>")
                })
            },
            error: function () {
                alert("error")
            }
        })
    });
});
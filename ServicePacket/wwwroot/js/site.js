// Write your JavaScript code.
$(document).ready(function () {
    $(".serviceBox").click(function () {
        alert($(this).attr("data-id"));
    });
});
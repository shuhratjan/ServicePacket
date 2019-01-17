// Write your JavaScript code.
$(document).ready(function () {
    var totalPrice = 0;
    $(".serviceBox").click(function () {
        if ($(this).attr("data-type") === "item") {
            if ($(this).hasClass("checked")) {
                $(this).removeClass("checked");
                $("div#receiptList div.item[data-id='" + $(this).attr("data-id") + "']").remove();
            }
            else {
                content = "<div class='item' data-id='" + $(this).attr("data-id") + "'><p>" + $(this).html() + "</p > <span> " + $(this).attr("data-price") + "</span></div>";
                $("#receiptList").append(content);
                $(this).addClass("checked");
            }
        } else {
            if ($(this).hasClass("checked")) {
                $(this).removeClass("checked");
                if ($(this).attr("data-period-id") === "2") {
                    $("div#period div.item").attr("data-period-id", "1");
                    $("div#period div.item span").html("1 месяц");
                }
            }
            else {
                if ($(this).attr("data-period-id") === "2") {
                    $(".block .serviceBox[data-period-id='1']").removeClass("checked");
                    $("div#period div.item span").html("12 месяц");
                } else {
                    $(".block .serviceBox[data-period-id='2']").removeClass("checked");
                    $("div#period div.item span").html("1 месяц");
                }
                $("div#period div.item").attr("data-period-id", $(this).attr("data-period-id"));
                $(this).addClass("checked");
            }
            
        }


        if ($("#receiptList > div").length > 1) {
            totalPrice = 0;
            $("#receiptList div").each(function (index) {
                var attr = $(this).attr('data-id');
                if (typeof attr !== typeof undefined && attr !== false) {
                    totalPrice += parseInt($(this).find('span').text(), 10);
                }
            });
            if ($("#period div.item").attr("data-period-id") === "2") {
                totalPrice = totalPrice - totalPrice * 12 / 100;
            }
            $("#totalPrice span#price").text(totalPrice + "тг");
        }
        
    });

    $("#myButton").click(function () {
        if ($("input[type='checkbox']")[0].checked && $("#receiptList > div").length > 1) {
            swal("Ваша заявка принята", "С Вами свяжутся наши менеджеры.", "success");
        } else {
            swal("Ошибка", "Не выбран услуги или нет галочки в поле соглашение", "error");
        }

    });
});
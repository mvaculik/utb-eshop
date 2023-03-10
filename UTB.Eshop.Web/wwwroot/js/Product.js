function Buy(productId, urlAction, outElementId, locale, sale) {
    $.ajax({
        type: "POST",
        url: urlAction,
        data: { productId: productId },
        dataType: "text",
        success: function (totalPrice) {

        ChangeTotalPriceInformation(outElementId, locale, totalPrice, sale);
     
            
        },
        error: function (req, status, error) {
            $(outElementId).text('Must be loggen in!');
        }
    });
}

function ChangeTotalPriceInformation(outElementId, locale, totalPrice, sale) {
    $(outElementId).text(parseFloat(totalPrice-(totalPrice*sale/100)).toLocaleString(locale,
        {
            style: "currency",
            currency: "CZK",
            minimumFractionDigits: 2,
            maximumFractionDigits: 2
        }));
}
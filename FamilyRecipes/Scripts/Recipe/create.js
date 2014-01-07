$('#addItem').click(function () {
    $.ajax({
        url: this.href,
        cache: false,
        success: function (html) {
            $('#ingredient-rows').append(html);
        }
    });
    return false;
});


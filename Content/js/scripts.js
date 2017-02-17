var invalid = /\s/;

$(function() {
    $("#word-form").submit(function(event) {
        event.preventDefault();
    })
    $("#form-submit").click(function() {
        var targetWord = $("#target-word").val();
        var longString = $("#long-string").val();
        if (invalid.test(targetWord)) {
            $("#invalid-entry-target").show();
        } else if (longString.length == 0) {
            $("#invalid-entry").show();
        } else {
            $("#word-form")[0].submit();
        }
    });
});

$("#btnSend").click(function () {

    var a = ($("#assign").val())
    var g = ($("#group").val())
    var qu = ($("#quiz").val())
    var ex = ($("#exam").val())
    var intex = ($("#intex").val())

    var output = (a * .55) + (g * .05) + (qu * .1) + (ex * .2) + (intex * .1)

    alert("Your Final Grade in IS 413 is : " + output + "%");
})
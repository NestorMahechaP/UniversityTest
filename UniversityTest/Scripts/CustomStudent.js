$('.next').click(function () {
    var container = $(this).closest('section');
    container.next('section').show();
    container.hide();
    console.log("entré")
});
$(function () {
    var PlaceHolderAddStudentElement = $('#PlaceHolderAddStudent');
    $('button[data-toggle="ajax-modal"]').click(function (event) {
  
        var url = $(this).data('url');
        console.log(url);
        $.get(url).done(function(data) {
            PlaceHolderAddStudentElement.html(data);
            PlaceHolderAddStudentElement.find('.modal').modal('show');
        })
    })

    PlaceHolderAddStudentElement.on('click', '[data-save="modal"]', function () {
        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var sendData = form.serialize();
        $.post(actionUrl, sendData).done(function (data) {
            PlaceHolderAddStudentElement.find('.modal').modal('hide');
        })
    })

    $("#btnSaveStusent").click(function () {
        window.location.href = "Student/GetAllStudent";
    })
})
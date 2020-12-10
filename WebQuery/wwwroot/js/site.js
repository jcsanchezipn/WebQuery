
$('#AnimasClass').on('change', function (e) {
    //alert("Cambie a :" + this.value);

    $.get("/Animals/Animal/?idAnimalClass=" + this.value, function (data) {
        //console.log("Respuesta a consulta WEB");
        //console.log(data);
        $('#animal').empty();
        $.each(data, function (i, item) {
            //console.log(item.value);
            //console.log(item.text);
            $('#animal').append($('<option/>', {
                value: item.value,
                text: item.text
            }));
        });
    });


})
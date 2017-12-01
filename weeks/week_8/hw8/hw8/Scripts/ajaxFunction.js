function ajaxCall(GenreID) {

    //removes previous elements from page using when new button is clicked using .empty() jquery method
    $('#tableData').empty();
    //start of the ajax
    $.ajax({
        type: "POST",
        url: "/Home/Ajax/",
        data: {id:GenreID}, 
        dataType: "json",
        success: function (data) {
            console.log(data)
            $.each(data, function (i, item) {
                $("#tableData").append("<li>" + "<strong>" + "<p> this is a test</p>" + item["Title"] + ": " + "</strong>" + item["Title"] + "</li>");  
            });
        }
    })
};
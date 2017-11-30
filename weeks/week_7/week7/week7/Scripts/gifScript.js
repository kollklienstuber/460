//currently facing issues



$("#search").click(getResults);

function getResults() {


    //first problem is
    var userQuery = document.getElementById('QueryU');

  
        $('#gifResults').empty();
  
        $.ajax({
            type: "POST",
            dataType: "json",
            data: { query },
            success: function (Giphy) {
                Giphy.data.forEach(function (gif) {
                    $('#gifResults').append(`<div <img src="${gif.images.fixed_height.url}"> </div>`);
                }
                )
            }
        });
    }
}
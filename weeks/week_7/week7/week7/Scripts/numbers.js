// Our Javascript goes here


//console.log("In numbers.js")

$("#Request").click(function () {
    var publicKey = "BK0Qij8PHomA0lnqELunbOQ8w3mjPAwm"; // Public API Key
    var limit = "10"; // Limit API to 10 gifs
    var animal = "horse";
    var queryURL = "http://api.giphy.com/v1/gifs/search?q=" + animal + "&limit=" + limit + "&api_key=" + publicKey;
    

});

function displayData(data) {
    console.log(data);
  

}

function errorOnAjax() {
    console.log("error");
}
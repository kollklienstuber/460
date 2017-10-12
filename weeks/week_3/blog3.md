
<a href="../../index.html" class="btn btn-primary btl-md" role="button">Back Home </a>

# Overview of week three



## The assignment
The assignment for this week can be found [here](http://www.wou.edu/~morses/classes/cs46x/assignments/HW3.html). The assignment for this week has me starting to learn c# and to translate a java postfix caluclator to C# which is something I did not have any previous experience with. In addition my background comes mostly from Chemeketa which uses C++ and my Java is decent but I'm less confident with it then many other Western CS students might be. Because of this I spent a bit of time quickly brushing up again with Java. 


## Steps I took and some code samples
To start learning I began by getting an overview of the language and watching [this youtube video](https://www.youtube.com/watch?v=lisiwUZJXqQ), which I found very useful and helped to give a good overview of the language. After I decided to just jump into the code with the goal of getting things up and running. I started small with trying to learn documentation comments and the goal of re creating the StackADT.java file to my StackAdt.cs file. I did this because I knew that I would need to figure out documentation comment tags and used [this link](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/recommended-tags-for-documentation-comments) for help. 

  

    <script>
    //this is the initial asks for name thing
    function askName(){
        var name = prompt("Whats your name?");
        var message = "Hello " + name + ", if you would like to view the weather click show!"
        document.getElementById('output').innerHTML = message;
    };
    
    </script>
![prompt picture](pics/prompt.PNG "JS prompt")


After I got the user input I threw it into an empty div element on the page to show to the user.


    <h3 class = "container-fluid" id="output"></h3>



Continuing on with the site, the next thing I wanted to do was play with some sort of API to make it a bit more interesting of a page. I also wanted something very simple because I didn't have much experience with API's at all. I found a weather api that uses Yahoo weather and put the code in like below into a script element and altered the code slightly to display Monmouth's weather and placed it on the page.

```  //this is for showing the weather and should be used when the no button is clicked.
reallySimpleWeather.weather({
  wunderkey: '', // leave blank for Yahoo API
    location: 'Monmouth, OR', //your location here, also works in lat/lon
    woeid: '', // "Where on Earth ID" optional alternative to location
    unit: 'f', // 'c' also works
    success: function(weather) {
      html = '<h2>'+weather.temp+'°'+weather.units.temp+'</h2>';
      html += '<ul class = "myList"><li>'+weather.city+', '+weather.region+'</li>';
      html += '<li>'+weather.currently+'</li>';
      html += '<li>'+weather.wind.direction+' '+weather.wind.speed+' '+weather.units.speed+'</li></ul>';
    document.getElementById('weather').innerHTML = html;
    },
    error: function(error) {
    document.getElementById('weather').innerHTML = '<p>'+error+'</p>';
    }
});</script>

```
![Weather picture](pics/weather.PNG "JS prompt")


The script creates a list with some data about the location that can be changed and in addition I added in jQuery to hide and show the calendar depending on if the user clicks the hide or show button. The jQuery ended up looking like the below.

```<script>
$(document).ready(function(){
    $("#hide").click(function(){
        $("#weather").hide(1000);
    });
});
$(document).ready(function(){
    $("#show").click(function(){
        $("#weather").show(500);
    });
});
</script>
```



The next thing that I wanted to do was use jQuery to add new and user dependent elements to the page. So I looked around online a bit for some tutorials on how to make jQuery add items and was able to eventually alter some code to make my list creator work.



![a list](pics/list.PNG "JS prompt")



##css

The styling for my site came mostly from test.css and I had a few elements styled inline in my main page. I also found an interesting way to style things using gradients as shown,

 ![gradient](pics/colors.PNG "JS prompt")


## Mockup

For the mock up of the site, I ended up going a much different route then originally thought. The initial mock up for the site looked like the below, 



![wireframe](pics/wireframe.PNG "JS prompt")


As you can see it is much different than the initial site being that the layout has changed in addition to the overall project itself. The wireframe for the current version ended up looking like.



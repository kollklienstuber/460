<<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>Document</title>
</head>
<body>
	


test added body
========
test


# Overview
After the end of this second week I feel much more confident with a variety of languages. I learned and gained a much better understanding of jQuery, JavaScript, Using Api's to get data to a webpage, and a large amount of different common problems that I will probably run into again in the future. 


## The assignment
The assignment for this week can be found [here](http://www.wou.edu/~morses/classes/cs46x/assignments/HW2.html) and what it was asking for was essentially to use jQuery and Javascript on a webpage and make it do something of value. Coming up with something to make that I was able to follow through with ended up being my biggest challenge for this week and in the end, I was not able to get my first idea to work out. I initially was trying to work with an API from Google that supplied a pie chart and the user was supposed to be able to input data into the pie chart and have the information change. However this didn't work out for a variety of issues that I ran into. I did still learn a large amount from it. I ended up changing ideas to a more simple shopping list. I also added in the weather for monmouth because I felt that adding it in would be something to add a bit more to the page. 


## Steps I took and some code samples
After I decided on switching over to a more simple shopping list and weather info I started by reading into jQuery and Javascript. I used W3 schools as a primary reasource and started off by trying to add a form text box form element that asked for the users name and then used JavaScript to output a brief message with the persons name to the screen. The code and an example image for this is below. 

  
'''
<script>
//this is the initial asks for name thing
function askName(){
	var name = prompt("Whats your name?");
    var message = "Hello " + name + ", if you would like to view the weather click show!"
    document.getElementById('output').innerHTML = message;
    };
    
</script>
'''

![alt text](pics/prompt.PNG "JS prompt")



</body>
</html>

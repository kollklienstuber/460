
<a href="../../index.html" class="btn btn-primary btl-md" role="button">Back Home </a>

# Overview of week Six



## Link to my code on Github
The full code for this assignment can be found [here](https://github.com/kollklienstuber/460/tree/master/weeks/week_5) and some sample images of the code are also shown below.  


## Video of [my project up and running](https://www.youtube.com/watch?v=AgZDPvlQo4E&feature=youtu.be)

## The assignment and connecting to the database
The assignment for this week can be found [here](http://www.wou.edu/~morses/classes/cs46x/assignments/HW6.html). The assignment for this week was one that gave me a large amount of trouble that came mostly from database connection issues. These issues came in a few different forms. One of the more common issues I ran into at the start was caused by the database file apparently being currently used and thus would consistently give me an error alerting me to close all open instances of the database even when I had. 
I ended up fixing this but the solution was essentially just guess and check that lasted hours. Once I fixed the issue I made sure to locally save the current project to make sure I had at least one instance of a project that was properly connected. I didn't do this first and it caused me having to backtrack once I ran into the issue again for a reason that I was never able to pinpoint to any particular cause. Part of the problem I think was the database potentially being open in another previous project that was unsuccessful in building due to similar database connection issues that was not detached. However I eventually was able to get the database connected by following the steps in [this first link](https://msdn.microsoft.com/en-us/library/mt710790.aspx) which had me run a query,


```sql
RESTORE DATABASE AdventureWorks2014_Data  
FROM DISK = 'C:\Users\kklie_000\Downloads\AdventureWorks2014.bak'  
WITH MOVE 'AdventureWorks2014_Data' TO 'C:\Users\kklie_000\Downloads\AdventureWorks2014.mdf',  
MOVE 'AdventureWorks2014_Log' TO 'C:\Users\kklie_000\Downloads\AdventureWorks2014.ldf'

```



to restore the .bak file to an mdf as well as connect it into sql server object explorer. Once I had done that I followed the steps in [this link](https://msdn.microsoft.com/en-us/library/jj200620(v=vs.113).aspx), which was also the link given to us in the week 6 instructions. After getting that part of the project finished and making sure I had at least some back up in case it went bad I was able to finally start working on the features of the project.



## Feature 1
For the first feature which was to allow a customer or a user the ability to browse through the database in such a way to model a store like system I started with creating the models. This was actually done in the previous step of connecting to the database because one of the steps was to have the models be auto generated into the project. However I did have to move them into the correct locations. In addition I installed the entity framework system through nuget package manager because I was needing this for the project.

The main page of the project starts off 


![controller](pics/cont1.PNG "Controller 1 img")


The data is pulled in through the database which is connected through the following 

![connection](pics/connection.PNG "Connection")


The main page is what shows the uses the different categories to access and the controller used to give them access is shown below,

![controller](pics/controller.PNG "controller")



and the home page/index view gives users an option to select a catagory and then a sub category based on the selected elements, navigation of the links is done through html action links and bootstrap.

![index](pics/index.PNG "index")



The Pages to show uses a single product as well as a paginated view of a list of products if applicable, (some objects didn’t have enough items to call for multiple pages) were similar to previous weeks tasks and involved HTML, bootstrap and html helper methods to post and store data,

![data](pics/data.PNG "data")

My models were pre populated into with the connection of the database using entity framework which was interesting to be able to see happen with minimal effort aside from the troubles of connecting to the database.

![models](pics/models.PNG "models")




## Part 2

For part two the users are supposed to be able to post a review to the AdventureWorks database product review table similar to the pre populated data. 

The controller for this 

![review](pics/review.PNG "review")


worked with form elements dependent on the type of data to be sent to the database and checked it to certain restraints to then if appropriate, send over to the database. 

![forms](pics/forms.PNG "forms")


![database](pics/database.PNG "database")









# _Pierres Treats_

#### By _**Justin Peters**_

#### This Browser Application will allow the user to add edit and delete Treats and if the user has an account they will be able to add, edit and delete flavors and treats

## Technologies Used

* CSHTML
* CSS
* Markdown
* Entity Framework
* C#
* dotnet
* SQL Database

## Description
### _Week 12 Code Review_
Pierre is back! He wants you to create a new application to market his sweet and savory treats. This time, he would like you to build an application with user authentication and a many-to-many relationship. Here are the features he wants in the application:

The application should have user authentication. A user should be able to log in and log out. Only logged in users should have create, update and delete functionality. All users should be able to have read functionality.
There should be a many-to-many relationship between Treats and Flavors. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include chocolate croissants, cheesecake, and so on.
A user should be able to navigate to a splash page that lists all treats and flavors. Users should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it.

## Setup/Installation Requirements

* Clone or download repository to local machine
* Run touch appsettings.json and add the following lines :

* _{ "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=[first_last];uid=root;pwd=[password];" } }_

* _Note_: _[first_last] should be replaced with your own database name and [password] should be replaced with your password. Do not include the brackets._

*Navigate to Factory directory in your Console and run dotnet ef migratations add "{insert text here}" 

* Run dotnet restore, dotnet build, and dotnet run to run web application.

## Known Bugs

* Adding a treat from the Flavor page causes and error


## License

_MIT_

Copyright(c) July 2022 (c)Justin Peters


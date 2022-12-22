# C# Travel Tickets engine

## Content:
The program is a Travel ticket search engines and User management system.

## Goal
The idea behind this project is to create a management system to manage and find the route connecting 2 places and be able to find/purchase the optimal route based on preferences.
The program starts with a login page. There are 2 different types of interfaces, if you log as admin, you will see different stuff from a normal user.
DEFAULT CREDENTIALS FOR ADMIN: username:admin password:password
DEFAULT CREDENTIALS FOR USER: username:user password:password
When logged as admin, you will get prompted to a form where you can pick what to do:
Users Management: in the user management form, you will be able to add, edit or remove Users, assigning all the related data through another form. You can also save the data to a file.txt through a button (the same file that is read when the program starts). When you create a user, username and passwords are automatically created, therefore that user could potentially login as user/admin though the login form (default rule is => username: username+userId and password: password+userId).
Routes Management: in the route management form, you will be able to add, edit or remove Routes between two cities, assigning all the related data through another form. Through another form you can also more cities, to expand the already present data (read before through a file). You can also save the data to a file.txt through a button (the same file that is read when the program starts). 
The entire program is heavily encapsulated with multiple classes.
When logged as user, you will get prompted to a form where you can interact with the core of the software:
The form starts, loads from file information about a map (European cities) and the routes between those cities, with also price, time and transportation type (trains, airplanes, bus, ferry).
In this form it is possible to pick between cities we want to travel, interact with the filters and then start a search. The results are going to be filtered based on the preferences (like price) and showed in a ListView. It is possible to find routes up to a depth of 3 routes. E.g. of possible solutions:
Helsinki -> Tallin by Ferry in 3 hours for 100€
Helsinki -> Tallinn -> Stockholm by Ferry and Airplane in 7 hours for 300€
Helsinki -> Tallinn -> Stockholm -> Copenhagen by Ferry, Airplane and Train in 12 hours for 450€
The algorithm for pathfinding works like this:

For each route i:
If i.departureCity == departureCity:
For each route j:
			If i.arrivalCity == j.departureCity:
For each route k:
					If j.arrivalCity == k.departureCity and k.arrivalCity == arrivalCity:
						Solution is [i,j,k]
*Filters are applied after finding the overall solutions (also clearing “dummy” routes)
If the user decides to buy it, a file with timestamp is generated and saved in the disk.

## Diagram
![Diagram](/UML.jpg)

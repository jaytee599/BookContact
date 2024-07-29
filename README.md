# BookContact System
A web application for managing both a bookstore and contacts. It involves creating, listing, editing, and deleting authors/books/rentals & contacts. Below are the key components and features observed:
The first part of our BookContact system. This features the use of Code-First Migrations to create our database, and WebAPI and LINQ to perform CRUD operations.

# Running this project 
- Project > BookContact Properties > Change target framework to 4.7.1 -> Change back to 4.7.2
- Make sure there is an App_Data folder in the project (Right click solution > View in File Explorer)
- Tools > Nuget Package Manager > Package Manage Console > Update-Database
- Check that the database is created using (View > SQL Server Object Explorer > MSSQLLocalDb > ..)
- Run API commands through CURL to create new contacts/books/authors

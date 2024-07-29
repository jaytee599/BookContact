# BookContact System
A web application for managing both a bookstore and contacts. It involves creating, listing, editing, and deleting authors/books/rentals & contacts. Below are the key components and features observed:
The first part of our BookContact system. This features the use of Code-First Migrations to create our database, and WebAPI and LINQ to perform CRUD operations.

# Running this project 
- Project > BookContact Properties > Change target framework to 4.7.1 -> Change back to 4.7.2
- Make sure there is an App_Data folder in the project (Right click solution > View in File Explorer)
- Tools > Nuget Package Manager > Package Manage Console > Update-Database
- Check that the database is created using (View > SQL Server Object Explorer > MSSQLLocalDb > ..)
- Run API commands through CURL to create new contacts/books/authors

Get a List of Authors curl https://localhost:44324/api/authorsdata/listauthors
Get a Single Author curl https://localhost:44324/api/authorsdata/findauthor/{id}
Get a List of Books curl https://localhost:44324/api/booksdata/listbooks
Get a Single Book curl https://localhost:44324/api/booksdata/findbook/{id}
Get a List of Rentals curl https://localhost:44324/api/rentalsdata/listrentals
Get a Single Rental curl https://localhost:44324/api/rentalsdata/findrental/{id}
Add a new Author curl https://localhost:44324/api/authorsdata/addauthor
Add a new Book curl https://localhost:44324/api/booksdata/addbook
Add a new Rental curl https://localhost:44324/api/rentalsdata/addrental
Delete an Author curl -d "" https://localhost:44324/api/authorsdata/deleteauthor/{id}
Delete a Book curl -d "" https://localhost:44324/api/booksdata/deletebook/{id}
Delete a Rental curl -d "" https://localhost:44324/api/rentalsdata/deleterental/{id}
Update an Author curl -H https://localhost:44324/api/authorsdata/updateauthor/{id}
Update a Book curl -H https://localhost:44324/api/booksdata/updatebook/{id}
Update a Rental curl -H https://localhost:44324/api/rentalsdata/updaterental/{id}

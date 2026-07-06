# Album Management
Album Management System is a web application built using C#, ASP.NET Core MVC and SQL Server. The application allows users to organise, rate and catalog their collection or wishlist of vinyl records, CDs and cassettes. Users can create, view, edit, and delete album entries while storing information such as album name, artist, genre, description, format, ownership status and personal rating.

## App Features:
- Create, view, edit, and delete album entries
- Track owned albums and wishlist items
- Rate albums on a 1–10 scale
- View all albums in a responsive table
- Display albums as cards on the home page
- View detailed information about individual albums
- Filter albums by its type (Vinyl, CD, or Cassette)

## Technologies Used:
- ASP.NET Core MVC
- C#
- Entity Framework Core
- SQL Server
- Razor Views
- Bootswatch (Bootstrap)
- HTML
- CSS

## Database
The project uses SQL Server with Entity Framework Core.

Before running the application:
1. Update the SQL Server connection string in `appsettings.json` 
2. Apply the Entity Framework Core migrations.
3. Run the application.

## Authentication
This project focuses on implementing core CRUD functionality, application architecture, and database management. It does not include authentication or authorization; therefore, no administrator or test user accounts are required to use the application.

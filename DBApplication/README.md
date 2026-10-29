# Lab 4 - Accessing SQL Server from a C# application

Files:
- DB/SPJ_DB_Lab4.sql   -> run in SSMS first (creates and fills the database)
- DBManager.cs         -> connection + ExecuteNonQuery / ExecuteScalar / ExecuteReader / CloseConnection
- Controller.cs        -> builds the SQL query strings
- Supplier.cs          -> form event handlers
- Supplier.Designer.cs -> form layout
- Program.cs           -> entry point

Run: open the folder in VS Code (needs .NET 8 SDK + C# Dev Kit), press F5 or run `dotnet run`.
The server name is set in DBManager.cs (DB_Connection_String). Change EMMA\SQLEXPRESS if your server name is different.

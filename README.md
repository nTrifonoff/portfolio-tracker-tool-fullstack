# Portfolio Tracker Tool

A web application that visualizes investments. 

The backend is built with **.NET 9 + C# + MSSQL**, and the frontend is built with **React + Vite + Redux + Highcharts**.

---

## Prerequisites
* Visual Studio / Visual Studio Code
* [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
* [Node.js 20+](https://nodejs.org/en/download/)
* [SQL Server](https://www.microsoft.com/en-us/sql-server)
* [Git](https://git-scm.com/downloads)

---

## Backend Setup (PortfolioTrackerTool.API)

1. Navigate to the backend folder and open `PortfolioTrackerTool.sln`

2. Restore NuGet packages by one of the two options:
	* Visual Studio > Solution Explorer > right click on `Solution 'PortfolioTrackerTool'` > Restore NuGet Packages
	* run `dotnet restore` in Package Manager Console or terminal in the project folder

3. Update your **connection string** in `appsettings.json` if needed:
	```json
	"ConnectionStrings": {
  	"DefaultConnection": "Server=localhost;Database=PortfolioTrackerToolDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;"
	}
	```

4. Run EF Core migrations to seed the database: 
	* Run `dotnet ef database update` in Package Manager Console
 * 
5. Run the backend:
	* By default, the API runs on: `https://localhost:5001`

---

## Frontend Setup (portfolio-tracker-tool)

1. Navigate to the frontend folder and open `portfolio-tracker-tool` with VS Code:

2. Install dependencies by running `npm install`:

3. Start the development server by running `npm run dev`:

* By default, the frontend runs on: `http://localhost:3000`
* Make sure the backend is **already running** to fetch data.

---

## Running Both Together

* Start backend first
* Then start frontend (`npm run dev`)
* Open browser at frontend URL, the dashboard should load with data.

---

## Technologies Used

**Backend:** .NET 9, C#, EF Core, MSSQL, Swagger
**Frontend:** React, Vite, Redux Toolkit, Highcharts, TailwindCSS

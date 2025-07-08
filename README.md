StudentAttendenceAPI 🎓
A simple ASP.NET Core Web API project that performs CRUD operations to manage student attendance records. This project uses Entity Framework Core with SQL Server for database interaction and is exposed via RESTful endpoints with Swagger UI for testing.

🚀 Features
✅ Add new student attendance records
📖 View all students or a single student by ID
✏️ Update student attendance data
🗑 Delete student records
📘 View and test API using Swagger UI
🔌 Connected to SQL Server using EF Core

📦 Technologies Used
ASP.NET Core 7
Entity Framework Core
SQL Server (LocalDB or SSMS)
Swagger / Swashbuckle
Visual Studio 2022

🔧 API Endpoints
Method	Endpoint	Description
GET	/api/student	Get all students
GET	/api/student/{id}	Get student by ID
POST	/api/student	Add a new student
PUT	/api/student/{id}	Update student by ID
DELETE	/api/student/{id}	Delete student by ID

⚙️ How to Run Locally
Clone the repo
git clone https://github.com/CODEBOTss/StudentAttendenceAPI.git
cd StudentAttendenceAPI
**update your appsettings.json with sql server connection string**
**apply migration**
  dotnet ef migration add initailcreate
  dotnet ef database update
dotnet run
open browser visit: https://localhost:<your-port-number>/swagger

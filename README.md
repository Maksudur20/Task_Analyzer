# Task Analyzer

Task Analyzer is a modern task management application built with ASP.NET Core MVC. It allows users to create, track, and manage their daily tasks with customizable priority levels and due dates. Authenticated users can create their own tasks, view their task history, and mark tasks as complete. The project features a clean, responsive UI, user authentication, role-based admin panel, and comprehensive task management capabilities.

---

## Features

- Create, edit, and manage personal tasks with customizable priorities (1-5)
- Set due dates for effective time management
- User registration, login, and profile management
- Authenticated users can create, edit, and delete their own tasks
- "My Tasks" section for users to view and manage their tasks
- Mark tasks as complete to track progress
- Admin panel for managing users and all tasks in the system
- Responsive Bootstrap UI for desktop and mobile devices

---

## Screenshots

Add screenshots of your project here:

![Home Page](assets/home_page%20-%20Copy.jpg)
![Trending Page](assets/trending_page%20jpg)
![Notices Page](assets/notices_page%20-%20Copy.jpg)
![Profile Page](assets/profile%20-%20Copy.jpg)
![Admin Dashboard](assets/admin_dashboard.jpg)
![Admin Route](assets/admin_route.jpg)

---

## Project Structure

```
Task_Analyzer/
├── appsettings.Development.json
├── appsettings.json
├── LICENSE.txt
├── Task_Analyzer.csproj
├── Task_Analyzer.sln
├── Program.cs
├── README.md
├── Controllers/
│   ├── AccountController.cs
│   ├── AdminController.cs
│   ├── HomeController.cs
│   └── TaskController.cs
├── Data/
│   ├── ApplicationDbContext.cs
│   └── DesignTimeDbContextFactory.cs
├── Migrations/
├── Models/
│   ├── ApplicationUser.cs
│   ├── ErrorViewModel.cs
│   └── TodoTask.cs
├── Services/
│   └── DbInitializer.cs
├── ViewModels/
│   ├── LoginViewModel.cs
│   └── RegisterViewModel.cs
├── Views/
│   ├── Account/
│   ├── Admin/
│   ├── Home/
│   ├── Shared/
│   └── Task/
└── wwwroot/
    ├── css/
    ├── images/
    └── js/
```

---

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- SQL Server (or change connection string for your DB)

### Installation

1. **Clone the repository:**

   ```bash
   git clone https://github.com/yourusername/Task_Analyzer.git
   cd Task_Analyzer
   ```

2. **Restore NuGet packages:**

   ```bash
   dotnet restore
   ```

3. **Apply database migrations:**

   ```bash
   dotnet ef database update
   ```

4. **Run the application:**

   ```bash
   dotnet run
   ```

5. **Open in browser:**

   Visit `https://localhost:5001` or `http://localhost:5053`

6. **Admin Credential:**

   ```text
   Email: admin@taskanalyzer.com
   Pass: Admin@123
   ```

---

## Usage

- Register a new account or log in with your credentials
- Create new tasks with a title, description, priority level, and due date
- View your tasks and filter by completion status
- Edit existing tasks or mark them as complete
- Delete tasks you no longer need
- Admins can access the admin panel to manage all users' tasks

---

## Contributing

Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

---

## License

This project is licensed under the MIT License.

---

## Contact

For questions or support, open an issue or contact the maintainer at [20maksudur00@gmail.com].

---

## Credits

- Built with ASP.NET Core MVC
- UI powered by Bootstrap
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

### User Interface
| Home Page | Main Dashboard |
|:---:|:---:|
| ![Home Page](assets/home.png) | ![Task Analyzer](assets/taskanalyzer.png) |
| *Landing page with welcome message* | *Main task management interface* |

### Authentication
| Login | Registration |
|:---:|:---:|
| ![Login Page](assets/login.png) | ![Register Page](assets/register.png) |
| *Secure user authentication* | *New user registration form* |

### Task Management
![Create Task](assets/createtask.png)
*Intuitive task creation with priority levels and due dates*

### Administration
| Admin Dashboard | User Management |
|:---:|:---:|
| ![Admin Panel](assets/adminpanel.png) | ![Edit User](assets/edituserfromadminpanel.png) |
| *Comprehensive admin control panel* | *User profile editing capabilities* |

### Additional
![Privacy Policy](assets/privacypolicy.png)
*GDPR-compliant privacy policy page*

### Database Structure
![Entity Relationship Diagram](assets/erdiagram.png)
*Entity-relationship diagram showing database schema*

---

## Project Structure

Task Analyzer follows the standard ASP.NET Core MVC architecture, organized into the following key components:

```
Task_Analyzer/
├── appsettings.json                  # Application configuration
├── Program.cs                        # Application entry point
├── Task_Analyzer.csproj              # Project file
├── assets/                           # README documentation images
│   ├── adminpanel.png               # Admin panel screenshot
│   ├── createtask.png               # Task creation form
│   ├── edituserfromadminpanel.png   # User editing interface
│   ├── erdiagram.png                # Database entity relation diagram
│   ├── home.png                     # Home page
│   ├── login.png                    # Login page
│   ├── privacypolicy.png            # Privacy policy page
│   ├── register.png                 # Registration page
│   └── taskanalyzer.png             # Main dashboard
├── Controllers/                      # MVC Controllers
│   ├── AccountController.cs          # User authentication
│   ├── AdminController.cs            # Admin functionality
│   ├── HomeController.cs             # Landing pages
│   └── TaskController.cs             # Task management
├── Data/                             # Database layer
│   ├── ApplicationDbContext.cs       # Entity Framework context
│   └── DesignTimeDbContextFactory.cs # Design-time DB context factory
├── Migrations/                       # Database migrations
├── Models/                           # Domain models
│   ├── ApplicationUser.cs            # Extended Identity user
│   ├── ErrorViewModel.cs             # Error handling
│   └── TodoTask.cs                   # Core task entity
├── Services/                         # Business logic services
│   └── DbInitializer.cs              # Database seeding
├── ViewModels/                       # View-specific models
│   ├── LoginViewModel.cs             # Login form model
│   └── RegisterViewModel.cs          # Registration form model
├── Views/                            # Razor views
│   ├── Account/                      # Authentication views
│   ├── Admin/                        # Admin panel views
│   ├── Home/                         # Landing page views
│   ├── Shared/                       # Layout templates
│   └── Task/                         # Task management views
└── wwwroot/                          # Static assets
    ├── css/                          # Stylesheets
    ├── js/                           # JavaScript files
    └── lib/                          # Frontend libraries
```

### Key Components:

- **Controllers**: Handle HTTP requests and user interactions
- **Models**: Define the application's data structures
- **Views**: Render the UI components and templates
- **Data**: Manages database connections and migrations
- **Services**: Contains business logic and application services
- **ViewModels**: Tailors data specifically for view consumption

---

## Database Design

The application uses Entity Framework Core with a SQL Server database. The following entity-relationship diagram illustrates the database schema and relationships between entities:

![Entity Relationship Diagram](assets/erdiagram.png)
*Database schema showing the relationships between User and Task entities*

---

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- SQL Server (or change connection string for your DB)

### Installation

1. **Clone the repository:**

   ```bash
   git clone https://github.com/Maksudur20/Task_Analyzer.git
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

For questions or support, open an issue or contact the maintainer at [20maksudur00@gmail.com](mailto:20maksudur00@gmail.com).

---

## Credits

- Built with ASP.NET Core MVC
- UI powered by Bootstrap
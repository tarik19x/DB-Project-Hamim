# Blood Bank Management System

A desktop-based Blood Bank Management System developed using C# and .NET Framework to streamline donor registration, blood request management, patient search, and donor eligibility tracking.

This project was designed to improve the efficiency of blood donation workflows by providing a centralized system for managing donor and patient information through an intuitive graphical user interface.

---

## Features

- Donor Registration System
- Blood Donor Eligibility Checking
- Patient Blood Request Management
- Search Functionality for Patients and Donors
- Update and Delete Donor Records
- User Session Management
- Dashboard Interface
- Profile Viewing System
- Login and Authentication Workflow

---

## Technologies Used

- C#
- .NET Framework
- Windows Forms (WinForms)
- Microsoft SQL Server
- Visual Studio

---

## Project Structure

```bash
Blood-Bank-Management-System/
│
├── Donor/
│   ├── Dashbord.cs
│   ├── Registration.cs
│   ├── Eligibility.cs
│   ├── SearchPaitent.cs
│   ├── PaitentRequest.cs
│   ├── Update.cs
│   ├── Delete.cs
│   ├── ViewProfile.cs
│   └── ...
│
├── packages/
├── Donorsltn.slnx
└── README.md
```

---

## System Modules

### Donor Management
Allows users to:
- Register new donors
- Update donor information
- Delete donor records
- View donor profiles

### Eligibility Checking
Evaluates whether a donor is eligible for blood donation based on predefined conditions.

### Patient Request Management
Handles patient blood requests and allows searching for suitable donors.

### Dashboard
Provides centralized navigation and access to all major functionalities of the application.

---

## Installation & Setup

### 1. Clone the Repository

```bash
git clone https://github.com/YOUR_USERNAME/YOUR_REPOSITORY.git
```

### 2. Open the Project

Open the solution file in:

- Visual Studio

```bash
Donorsltn.slnx
```

### 3. Restore NuGet Packages

Inside Visual Studio:

```text
Tools → NuGet Package Manager → Restore Packages
```

### 4. Configure Database

- Create a SQL Server database
- Update the database connection string in:

```bash
App.config
```

### 5. Build and Run

Press:

```text
F5
```

Or:

```text
Start Debugging
```

---

## Learning Outcomes

This project helped strengthen understanding of:

- Object-Oriented Programming (OOP)
- CRUD Operations
- Windows Forms Development
- Database Integration with SQL Server
- Event-Driven Programming
- UI/UX Design for Desktop Applications
- Session and State Management

---

## Future Improvements

- Role-based authentication
- Blood inventory tracking
- Email/SMS notification system
- Advanced donor matching algorithms
- Cloud database integration
- Modern UI redesign

---

## Screenshots

Add application screenshots here for better project presentation.

Example:

```markdown
![Dashboard](screenshots/dashboard.png)
```
---

## License

This project is developed for educational and learning purposes.

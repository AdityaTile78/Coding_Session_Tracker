# 📓 Coding Tracker

A clean, modular console application to **log and track your daily coding sessions**.  
Easily view your progress in a beautiful terminal UI powered by Spectre.Console.

---

## ✨ Features

✅ Log start and end times for your coding sessions  
✅ Automatically calculates session duration  
✅ View all logged sessions in a colorful table  
✅ Delete sessions by their ID  
✅ Strict validation for date & time inputs (`yyyy-MM-dd HH:mm` format)  
✅ Configuration file for database connection  
✅ Uses Dapper ORM for efficient database access  

---

## 📸 Screenshots

### 💻 Main Menu
![Main Menu](Images/outputScreeshot1.png) 


## 🛠️ Tech Stack

- **C# .NET 6**
- **SQLite** – lightweight database
- **Dapper** – ORM for data access
- **Spectre.Console** – beautiful console UI
- **ConfigurationManager** – reads `appsettings.json`

---

## 🚀 Getting Started

### 🖥 Prerequisites
- [.NET 6 SDK](https://dotnet.microsoft.com/download)
- Git

---

### 📥 Installation

1. Clone the repository
git clone https://github.com/your-username/coding-tracker.git

cd coding-tracker
Restore NuGet packages

dotnet restore
Build the project

dotnet build
Run the app

dotnet run
📝 Usage
📅 Date & Time Format
Enter all dates in the format:
yyyy-MM-dd HH:mm
(Example: 2025-07-18 10:30)

📖 Menu Options
Option	Action
1	View all coding sessions
2	Add a new coding session
3	Delete a coding session by Id
0	Exit the application

🗃️ Database
SQLite database file (codingTracker.db) is created automatically in your project directory.

📸 Screenshots
💻 Main Menu
=== Coding Tracker ===
1 - View all coding sessions
2 - Add a new coding session
3 - Delete a coding session
0 - Exit
Select an option:
📊 Session Table

╭────┬─────────────────────┬─────────────────────┬───────────╮
│ Id │     Start Time      │      End Time        │ Duration  │
├────┼─────────────────────┼─────────────────────┼───────────┤
│ 1  │ 2025-07-18 10:00    │ 2025-07-18 12:15      │ 2h 15m    │
╰────┴─────────────────────┴─────────────────────┴───────────╯
📖 License
This project is licensed under the MIT License.

🤝 Contributing
Contributions, issues, and feature requests are welcome!
Feel free to fork this repo and submit a pull request.

🙋‍♂️ Author
👤 Aditya Tile
GitHub: @AdityaTile78


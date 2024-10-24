# Visitor Management System

A basic C# console application to manage visitor information, allowing users to add, search, sign-in, sign-out, and view visit history. The data is stored in memory, and the system provides basic CRUD functionality.

## Project Overview

This application helps businesses track visitor activity, including sign-ins and sign-outs. The user can search for visitors, edit their information, and view their visit history. The system is designed to be simple and effective for small offices or shops.

## Team Members

- Kushal Dhungel (A00286174)
- Sujan Bhattarai (A00302919)
- Vrushabh Soni (A00294482)
- Sachet Shrestha (A00298291)

**Visitor Management System**

This is a simple C# console application designed to manage visitor check-ins and check-outs at an organization. The system allows adding new visitors, signing them in and out, viewing their visit history, and updating their personal information.

**Project Overview**

The Visitor Management System is a basic tool for organizations to manage visitors efficiently. Visitors can be added to the system with their contact information, and their sign-in and sign-out times can be recorded. The system also provides features for searching, editing visitor information, and viewing a visitor's visit history.

**Planned Enhancements**
SMS Notifications: Notify visitors via SMS when they are signed in or out.
Visitor Report Export: Export visitor records for backup and reporting purposes.
Features

**Add Visitor**: Allows the user to add a new visitor's personal information (name, email, phone number, etc.).
**Search Visitor**: Enables the user to search for a visitor by first name, last name, or ID. The visitor's history and details can be viewed or edited.
**Sign-In Visitor**: Records the sign-in time of a visitor.
**Sign-Out Visitor**: Records the sign-out time of a visitor and completes their visit record.
**View Visit History**: Displays the complete visit history of a specific visitor.
**Edit Visitor Information**: Allows the user to update a visitor's personal information.
Application Flow

Step 1: The user opens the application and is presented with a menu to choose an action (Add Visitor, Search Visitor, Sign-In, Sign-Out, etc.).
Step 2: Based on the selected menu option, the user performs actions such as adding a visitor, signing them in or out, or editing their details.
Step 3: The system saves visitor records and visit history for future reference.
Step 4: Users can view a specific visitor's history or edit their information before exiting the application.

**Backlog **
SMS Notifications: Implement SMS notifications for visitor sign-ins and sign-outs.
Export Visitor Data: Implement a feature to export visitor records to a CSV or other file formats.

**Console User Interfaces**

Main Menu
+------------------------------------+
|    Visitor Management System       |
| 1. Add New Visitor                 |
| 2. Search Visitor                  |
| 3. Sign-In Visitor                 |
| 4. Sign-Out Visitor                |
| 5. Exit                            |
+------------------------------------+
Add Visitor Screen
+------------------------------------+
|        Add New Visitor             |
| Please enter the following:        |
| First Name:                        |
| Last Name:                         |
| Email Address:                     |
| Phone Number:                      |
| Home Address:                      |
+------------------------------------+
Search Visitor Screen
+------------------------------------+
|        Search Visitor              |
| Enter First Name, Last Name, or ID:|
+------------------------------------+
**How to Run**

Clone or Download: Clone or download the project from the repository.
Run the Project: Open the solution in Visual Studio or any C# IDE and run the project.
Data Persistence: Visitor data is saved in memory for now, with plans to implement file-based persistence in the future.
Exiting the Application: When you exit the application, all visitor records will be reset unless a persistence method is added.

# Visitor Management System

A basic C# console application to manage visitor information, allowing users to add, search, sign-in, sign-out, and view visit history. The data is stored in memory, and the system provides basic CRUD functionality.

## Project Overview

This application helps businesses track visitor activity, including sign-ins and sign-outs. The user can search for visitors, edit their information, and view their visit history. The system is designed to be simple and effective for small offices or shops.

## Team Members

- Kushal Dhungel (A00286174)
- Sujan Bhattarai (A00302919)
- Vrushabh Soni (A00294482)
- Sachet Shrestha (A00298291)

## Features

- **Add New Visitor**: Add visitor details like name, email, phone number, and address.
- **Search Visitor**: Search by name or ID to view visitor information.
- **Sign-In/Sign-Out**: Record visitor sign-in and sign-out times.
- **View Visit History**: Show a list of all visits by a specific visitor.

## Application Flow

1. User starts the application and selects an option from the menu (Add Visitor, Search, Sign-In, Sign-Out, View History).
2. The application performs the requested operation, such as adding a new visitor or recording sign-in.
3. The user can view a visitor’s complete visit history or exit the system.

## Task Board (Agile Progress Tracker)

### Backlog

- **Visitor Validation**: Ensure visitor details are valid when adding or editing.
- **Sign-Out Logic**: Improve handling of visitors signing out without a prior sign-in.

### In Progress

- **Sign-In/Sign-Out**: Recording visitor sign-in and sign-out times. (Vrushabh)
- **Search Feature**: Searching visitors by name or ID. (Sachet)


## Console User Interfaces

### Main Menu
```plaintext
+----------------------------------+
| Visitor Management System        |
| 1. Add Visitor                   |
| 2. Search Visitor                |
| 3. Sign-In Visitor               |
| 4. Sign-Out Visitor              |
| 5. View Visit History            |
| 6. Exit                          |
+----------------------------------+

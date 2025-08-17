# Student Management System

A simple student management application built with WPF (.NET Framework 4.7.2) that demonstrates object-oriented programming concepts and Windows desktop application development.

## Overview

This project consists of two main components:
- **ConsoleApp1**: Core library containing student data models and business logic
- **WpfApp1**: WPF desktop application providing a graphical user interface

## Features

### Core Functionality
- **View All Students**: Display a complete list of all students with their details
- **Search Student by ID**: Find and display specific student information using their ID
- **Student Information Display**: Shows student name, ID, and university

### Sample Data
The application includes three pre-configured students:
- **Robert** (ID: 101) - Curtin University
- **Mia** (ID: 102) - EWU
- **Adam** (ID: 103) - Murdoch University

## Project Structure

- **ConsoleApp1/**
  - `Person.cs` - Base class with Name property
  - `Student.cs` - Student class inheriting from Person
  - `StudentList.cs` - Static data provider for students
  - `Program.cs` - Console application entry point
- **WpfApp1/**
  - `MainWindow.xaml` - UI layout definition
  - `MainWindow.xaml.cs` - UI event handlers and logic
  - `App.xaml` - Application configuration
- `README.md`

## Class Hierarchy
Person (Base Class) 
??? Properties: Name 
? ??? Student (Derived Class) 
??? Properties: Id, University 
??? Methods: ToString() override

## Requirements

- **.NET Framework 4.7.2** or higher
- **Visual Studio 2019** or later (recommended)
- **Windows OS** (for WPF support)

## Getting Started

### Running the Console Application
1. Set `ConsoleApp1` as the startup project
2. Press `F5` or click **Start**
3. View all students displayed in the console window

### Running the WPF Application
1. Set `WpfApp1` as the startup project
2. Press `F5` or click **Start**
3. Use the GUI buttons to:
   - **"Show All Students"**: Display all students in the text area
   - **"Search Student"**: Enter an ID and find specific student details

## Usage Examples

### Searching for a Student
1. Enter a student ID (101, 102, or 103) in the Student ID field
2. Click the search button
3. Student details will populate in the respective fields
4. Invalid IDs will show an error message

### Viewing All Students
1. Click the "Show All Students" button
2. All student information appears in the main text area

## Code Examples

### Student Class Usage
Student student = new Student(); 
student.Name = "John Doe"; 
student.Id = 104; 
student.University = "MIT"; 
Console.WriteLine(student.ToString());

### Accessing Student List
List<Student> students = StudentList.Students(); 
foreach (Student student in students) 
{ 
Console.WriteLine($"ID: {student.Id}, Name: {student.Name}"); 
}

## Error Handling

The application includes robust error handling for:
- **Invalid ID Format**: Non-numeric input in ID field
- **Student Not Found**: Searching for non-existent student IDs
- **Parse Exceptions**: Automatic error message display

## Technical Notes

- Uses **object-oriented inheritance** (Person ? Student)
- Implements **property accessors** for encapsulation
- Demonstrates **method overriding** with `ToString()`
- Features **exception handling** with try-catch blocks
- Utilizes **static methods** for data access

## Future Enhancements

Potential improvements could include:
- Database integration for persistent storage
- Add/Edit/Delete student functionality
- Export student data to files
- Enhanced search filters (by name, university)
- Data validation for input fields

## License

This project is for educational purposes and demonstrates basic C# and WPF concepts.


# Student Management System

## Introduction
The Student Management System is a C# project developed using Windows Forms and the .NET framework. It is designed to mainly manage student data with functionalities to create, read, update, and delete student records.

## Table of Contents
- [Program Description](#program-description)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Event-Driven Programming](#event-driven-programming)
- [Data Types](#data-types)
  - [Primitive Data Types](#primitive-data-types)
  - [Reference Data Types](#reference-data-types)
- [File Operations](#file-operations)
- [Development Environment](#development-environment)
- [Links](#links)
  
## Program Description

The application features a user-friendly interface with two main tabs: one for student operations and another for displaying information about the app. The main frame of the application consists of two rectangle panels, one at the top and one at the bottom, for performing actions and displaying details, respectively. The system is designed to be extendable, allowing for future additions such as teachers and classes while maintaining a uniform structure.

## Features
* **Two-tab Interface:** One tab for student operations and another for displaying app information.
* **Student List:** View all students in the database with a detailed preview of each student’s data.
* **Search Functionality:** Search for students by name, with notifications if a student is not found.
* **Edit and Delete:** Edit student details or delete a student record with confirmation dialogs.
* **Validation:** Comprehensive validation for input fields, ensuring data integrity.
* **Custom Events:** Notifications for changes in the database.
* **Text File Operations:** Load and save student data from/to a text file.
* **App Information:** Display a short description of the application and provide external links for additional information.

## Installation
1. Clone the repository:
   
    ```sh
    git clone https://github.com/redblindbananaz/StudentManagementSystem.git
    ```
3. Open the project in Visual Studio 2022.

## Usage
1. Run the application from Visual Studio.
2. Use the interface to manage student records:
   - Click "New Student" to add a new student.
   - Select a student from the list and click "Edit" to modify student details.
   - Select a student from the list and click "Delete" to remove a student.

## Event-Driven Programming
The application uses event-driven programming extensively. Below are some examples of event handlers used in the application:

### Notify User of changes in database:

  ```

    public partial class Form1 : Form
    {
  
  ----> Delegate for the event handler:
        public delegate void StudentListChangedEventHandler(object sender, EventArgs e);
  
  ----> Declare the event:
        public event StudentListChangedEventHandler StudentListChanged;


        //Declaration of variables here...
  
        public Form1()
        {
            InitializeComponent();
            InitailizeTextBoxes();
            InitializeStudentData();
            PopulateStudentList();

            <-- More code here-->

  ---->  Subscribe to the custom event:
            this.StudentListChanged += new StudentListChangedEventHandler(this.Form1_StudentListChanged);
        }
  

  ----> Define a method that checks if there are any subscribers to the event and then raises the event by invoking the delegate.
        protected virtual void OnStudentListChanged()
        {
            StudentListChanged?.Invoke(this, EventArgs.Empty);
        }

  ----> Event handler for the custom event:
        private void Form1_StudentListChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Student List Changed", "Info Notifications:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

  --> Example where the the event gets triggered:
  
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < dgvStudents.Rows.Count)
            {
                var selectedRow = dgvStudents.SelectedRows[0];
                int selectedId = (int)selectedRow.Cells[0].Value;
                var studentToRemove = students.FirstOrDefault(s => s.Id == selectedId);

                if (studentToRemove != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete this student: {studentToRemove.FullName}?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        students.Remove(studentToRemove);
                        PopulateStudentList();
  here                  ClearForm();
  --------------------->OnStudentListChanged();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

  ```

### Example Events:

- Button Click Events:
  
  -```btnSaveNewStudent_Click```: Handles saving a new student, validating input, and updating the database.
  -```btnEdit_Click```: Handles editing a selected student, validating input, and updating the database.

- Custom Event:
  -```StudentDataChanged```: Custom event to notify the user of changes in the database, used in save and delete operations.


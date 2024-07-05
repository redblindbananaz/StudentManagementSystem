# Student Management System

## Introduction
The Student Management System is a C# project developed using Windows Forms and the .NET framework. It is designed to mainly manage student data with functionalities to create, read, update, and delete student records.

## Table of Contents
- [Program Description](#program-description)
- [Features](#features)
- [Installation](#installation)
- [Usage and Functionalities](#usage-and-functionalities)
- [Event-Driven Programming](#event-driven-programming)
- [Data Types](#data-types)
- [Development Environment](#development-environment)
- [File Operations](#file-operations)

  
## Program Description

The application features a user-friendly interface with two main tabs: one for student operations and another for displaying information about the app. The main frame of the application consists of two rectangle panels configuration, one at the top and one at the bottom, with different layers of panels with different visiblity setup for performing actions and displaying details, respectively. The system is designed to be extendable, allowing for future additions such as teachers and classes while maintaining a uniform structure.

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

## Usage and Functionalities
1. Run the application from Visual Studio.
2. Use the interface **Tab Student**:

   
   - Search for a Student:
        - Enter a name in the search box.
        - Display search results and reset with the ```Show All``` button if needed.
        - Error message will appear if record is not found in data.
        - The use of Data grid View allows user to sort each column.
        - Pessing ```select``` button displays selected record details in the student detail group panel underneath the List.
   - Edit a Student:
        - Only when student is selected from the List that the ```Edit``` and ```Delete``` buttons appears in the detail Panel.
        - Upon ```Edit``` Press, user will be directed to a new Panel that will display input fields with selected student information display.
        - All fields get validated upon ```Save```, error message will be display and corresponding fields border changes to red with yellow focus on the input field.
        - If all errors validation are corrected, user can ```Save``` or ```cancel```
        - Upon```Save```Press, a datachange confirmation message contained  in a dialogue Box, triggered by **Custom Event** ,pops up ,and user will be redirected to Main Panel showing the student list with changes reflected.
   - Delete a Student:
        - Only when student is selected from the List that the ```Edit``` and ```Delete``` buttons appears in the detail Panel.
        - Upon ```Delete``` Press, next to the selected student details, a message Box will demand user to confirm deletion.
        - Pressing ```yes``` button, will trigger the **Custom Event**, to notify user of the changes in the database.
        - User will then be redirected to the Main panels where changes in the list are reflected. Details View resets and only shows details when a student is selected.
   - Create a Student:
      - Pressing ```New Student``` Button at the bottom will redirect user to a new Panel that will display empty input fields.
      - All fields get validated upon ```Save```, error message will be display and corresponding fields border changes to red with yellow focus on the input field.
      - CheckList box only user to select only one Item.
      - Age is checked to be numerical.
      - Upon```Save```Press, a datachange confirmation message contained  in a dialogue Box, triggered by **Custom Event** ,pops up ,and user will be redirected to Main Panel showing the student list with changes reflected.
   - Exit the application:
      - Pressing the ```EXIT``` Button will trigger Dialogue Box confirming the exit of the application.
      - Pressing ```yes``` Will close the application and ```No``` will return to the application
    
        
3. Use the interface **Tab App info**:

   - The use of multiple tabs allows the application to be extanded, so that if we want to duplicate the student interface for Teachers for example we can.
   - Tab is to diaply information about the application and the developer in different group boxes.
   - It also demonstrate the use of extrenal links
   - All Buttons have been removed form that tabs except the ```EXIT```Button.

## Event-Driven Programming
The application uses event-driven programming extensively. Below are some example of event handlers used in the application:

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
  -```StudentDataChanged```: Custom event to notify the user of changes in the database, used in ```save``` and ```delete``` operations.

## Data Types

#### Primitive Data Types:

  - ```int```: Used for the Age property in the Student class.
  - ```string```: Used for ```FirstName, LastName, Email, PhoneNumber, etc.```
    
#### Reference Data Types:
  - ```List<Student>```: Used to store and manage the list of students.
  - ```CheckedListBox, ComboBox, TextBox, Panel, etc.```: Used for various UI elements in the application.


Primitive data types, such as integers, floating-point numbers, characters, and booleans, store their values directly in memory locations allocated on the stack. They are straightforward and operate with a fixed size, making them efficient for storing simple data. On the other hand, reference data types, like objects, arrays, and strings, store references to their data in stack memory, while the actual data resides in heap memory. This distinction allows reference types to handle more complex data structures and dynamic memory allocation efficiently. 

## Development Environment

This application was developed on a Mac M1 using VMware to run Windows 11 and Visual Studio 2022. Windows Forms is not supported on Visual Studio for Mac, making the use of a virtual machine necessary. All safeguards were implemented using Git and GitHub, ensuring no direct access to the virtual hard drive outside the virtual environment.

## File Operations

An ```enrollment.txt``` file is included in this repository to test loading and saving student data. The application can work with other text files on a Windows machine.

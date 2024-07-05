# Student Management System

## Description
The Student Management System is a Windows Forms application designed to manage student records. It allows users to perform CRUD (Create, Read, Update, Delete) operations on student data.

## Table of Contents
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

## Features
- Add new student records
- Update existing student records
- Delete student records
- View the list of all students

## Installation
1. Clone the repository:
    ```sh
    git clone https://github.com/redblindbananaz/StudentManagementSystem.git
    ```
2. Open the project in Visual Studio 2022.

## Usage
1. Run the application from Visual Studio.
2. Use the interface to manage student records:
   - Click "New Student" to add a new student.
   - Select a student from the list and click "Edit" to modify student details.
   - Select a student from the list and click "Delete" to remove a student.

## Event-Driven Programming
The application uses event-driven programming extensively. Below are some examples of event handlers used in the application:

### Notify User of changes in database:


- Step 1: Declare a Delegate:
  ```
namespace StudentManagementSystem
{

    public partial class Form1 : Form
    {
        1. --> //Delegate for the event handler:
        public delegate void StudentListChangedEventHandler(object sender, EventArgs e);
        //Declare the event:
        public event StudentListChangedEventHandler StudentListChanged;

        <-- Declaration of variables here -->
        public Form1()
        {
            InitializeComponent();
            InitailizeTextBoxes();
            InitializeStudentData();
            PopulateStudentList();

            <-- More code here-->

            //Subscribe to the custom event:
            this.StudentListChanged += new StudentListChangedEventHandler(this.Form1_StudentListChanged);
        }

        // Method to raise the custom event:
        protected virtual void OnStudentListChanged()
        {
            StudentListChanged?.Invoke(this, EventArgs.Empty);
        }

        // Event handler for the custom event:
        private void Form1_StudentListChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Student List Changed", "Info Notifications:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
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
                        ClearForm();
                        OnStudentListChanged();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

  ```

csharp
Copy code
public delegate void MyCustomEventHandler(string message);
Step 2: Declare the Event
Declare an event using the delegate.

csharp
Copy code
public class EventPublisher
{
    public event MyCustomEventHandler MyCustomEvent;
}
Step 3: Define a Method to Raise the Event
Define a method that checks if there are any subscribers to the event and then raises the event by invoking the delegate.

csharp
Copy code
public class EventPublisher
{
    public event MyCustomEventHandler MyCustomEvent;

    protected virtual void OnMyCustomEvent(string message)
    {
        MyCustomEvent?.Invoke(message);
    }
}
Step 4: Subscribe to the Event
Create a class that subscribes to the event and defines the event handler method.

csharp
Copy code
public class EventSubscriber
{
    public void Subscribe(EventPublisher publisher)
    {
        publisher.MyCustomEvent += HandleCustomEvent;
    }

    private void HandleCustomEvent(string message)
    {
        Console.WriteLine("Event received: " + message);
    }
}
Step 5: Trigger the Event
Instantiate the publisher and subscriber, subscribe to the event, and trigger the event.

csharp
Copy code
class Program
{
    static void Main(string[] args)
    {
        EventPublisher publisher = new EventPublisher();
        EventSubscriber subscriber = new EventSubscriber();
        
        subscriber.Subscribe(publisher);
        
        publisher.OnMyCustomEvent("Hello, World!");
    }
}

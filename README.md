# MVCPattern

This repository demonstrates the implementation of the Model-View-Controller (MVC) design pattern using C#. The MVC pattern helps separate the concerns of an application into three main components: Model, View, and Controller, enhancing modularity and ease of maintenance.

## This repository is dedicated to my dear professor, Mrs. George Prokopakis.

## Introduction

The MVCPattern project provides a straightforward example of how to implement the MVC design pattern in C#. It separates the application's logic into three interconnected components:
1. Model: Manages the data and business logic.
2. View: Handles the presentation and user interface.
3. Controller: Acts as an intermediary between the Model and the View, handling user input and updating the Model and View accordingly.

## Components

1. **Model**: Represents the application's data and business rules.
2. **View**: Displays the data to the user and sends user commands to the Controller.
3. **Controller**: Processes user inputs, updates the Model, and refreshes the View.

## Structure

The project consists of several components:

- **Models**:
  - Defines the data structures and business logic.

- **Views**:
  - Responsible for rendering the user interface.

- **Controllers**:
  - Manages user input and interaction between the Model and View.


## Usage

To run the MVC pattern demonstration, follow these steps:

1. Clone the repository:
   ```sh
   git clone https://github.com/stevsharp/MVCPattern.git
   cd MVCPattern

class Program
{
    static void Main(string[] args)
    {
        IModel model = new StudentModel();

        IView view = new View();
    
        IStudentController studentController = new StudentController(view,model);
    
        studentController.DisplayStudents();
    
        studentController.AddStudent(new Student("Nio", "The one"));
    
        studentController.DisplayStudents();
    
        studentController.Remove(new Student("Nio", "The one"));
    
        studentController.DisplayStudents();
    }
}


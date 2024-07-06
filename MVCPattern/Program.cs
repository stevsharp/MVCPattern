// See https://aka.ms/new-console-template for more information


using MVCPattern;

try
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
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

Console.ReadLine();
namespace MVCPattern
{
    public class View : IView
    {
        public void ShowStudentAdded(Student student)
        {
            Console.WriteLine($"Student was added {student.Name} {student.LastName}");

            Console.BackgroundColor = ConsoleColor.Green;
        }

        public void ShowStudentRemoved(Student student)
        {
            Console.WriteLine($"Student was removed {student.Name} {student.LastName}");

            Console.BackgroundColor = ConsoleColor.Red;
        }

        public void ShowStudents(IEnumerable<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} {student.LastName}");
            }
        }
    }
}

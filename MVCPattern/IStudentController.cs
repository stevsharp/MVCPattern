namespace MVCPattern
{
    public interface IStudentController
    {
        void AddStudent(Student student);
        void DisplayStudents();
        void Remove(Student student);
    }
}
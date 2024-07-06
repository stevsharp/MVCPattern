namespace MVCPattern
{
    public interface IView
    {
        void ShowStudents(IEnumerable<Student> students);

        void ShowStudentAdded(Student student);

        void ShowStudentRemoved(Student student);
    }
}

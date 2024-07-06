namespace MVCPattern
{
    public class StudentModel : IModel
    {
        protected List<Student> students;

        public StudentModel() => students = [
            new ("Evelyn","Carter"),
        new ("Liam","Anderson"),
        new ("Sophia","Bennett")
        ];

        public void AddStudent(Student student)
        {
            ArgumentNullException.ThrowIfNull(student);

            students.Add(student);
        }

        public IEnumerable<Student> GetStudents()
        {
            return students;
        }

        public void RemoveStudent(Student student)
        {
            ArgumentNullException.ThrowIfNull(student);

            students.Remove(student);
        }
    }
}

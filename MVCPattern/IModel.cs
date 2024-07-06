using System.Reflection;

namespace MVCPattern;

public interface IModel
{
    IEnumerable<Student> GetStudents();

    void AddStudent(Student student);

    void RemoveStudent(Student student);
}

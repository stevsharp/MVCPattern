namespace MVCPattern
{
    public class StudentController : IStudentController
    {
        protected readonly IView _view;

        protected readonly IModel _model;

        public StudentController(IView view, IModel model)
        {
            _view = view;

            _model = model;
        }

        public void DisplayStudents()
        {
            var students = _model.GetStudents();

            _view.ShowStudents(students);
        }

        public void AddStudent(Student student)
        {
            _model.AddStudent(student);

            _view.ShowStudentAdded(student);
        }

        public void Remove(Student student)
        {
            _model.RemoveStudent(student);

            _view.ShowStudentRemoved(student);
        }
    }
}

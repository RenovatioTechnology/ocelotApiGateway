using studentService.Model;
namespace studentService.Service
{
    public class StudentRepository : List<Model.Student>, IStudentRepository
    {
        private readonly static List<Model.Student> _students = StudentsSeed();
        private static List<Student> StudentsSeed()
        {
            var result = new List<Student>()
            {
                new Student
                {
                    StudentId = 1,
                    StudentName = "Shallu J Nah",
                    StudentSchoolName = "Regis University"
                },
                new Student
                {
                    StudentId = 2,
                    StudentName = "Jefferson Nah Jr.",
                    StudentSchoolName = "FullSail University"
                },
                new Student
                {
                    StudentId = 3,
                    StudentName = "Jessica Nah",
                    StudentSchoolName = "Rutgers University"
                }
            };
            return result;
        }

        public Student Get(int id)
        {
            return _students[id];
        }
        public List<Student> GetAll()
        {
            return _students;
        }
    }
}

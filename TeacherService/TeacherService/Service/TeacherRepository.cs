using TeacherService.Model;
namespace TeacherService.Service
{
    public class TeacherRepository : List<Model.Teacher>, ITeacherRepository
    {
        private readonly static List<Model.Teacher> _teachers = TeachersSeed();
        private static List<Teacher> TeachersSeed()
        {
            var result = new List<Teacher>()
            {
                new Teacher
                {
                    TeacherId = 1,
                    TeacherName = "Sara J Star",
                    TeacherSchoolName = "Regis University"
                },
                new Teacher
                {
                    TeacherId = 2,
                    TeacherName = "Michael Steven",
                    TeacherSchoolName = "FullSail University"
                },
                new Teacher
                {
                    TeacherId = 3,
                    TeacherName = "John Smith",
                    TeacherSchoolName = "Rutgers University"
                }
            };
            return result;
        }

        public Teacher Get(int id)
        {
            return _teachers[id];
        }
        public List<Teacher> GetAll()
        {
            return _teachers;
        }
    }
}
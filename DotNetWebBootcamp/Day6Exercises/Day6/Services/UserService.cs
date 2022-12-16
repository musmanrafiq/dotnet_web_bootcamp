using Day6.Models;

namespace Day6.Services
{
    public static class StudentService
    {

        private static List<StudentModel> _students = new List<StudentModel>();

        public static List<StudentModel> GetAll()
        {
            return _students;   

        }

        public static void Add(StudentModel model)
        {
            _students.Add(model);
        }
    }
}

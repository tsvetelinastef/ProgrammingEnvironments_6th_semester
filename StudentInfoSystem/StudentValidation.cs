using UserLogin;

namespace StudentInfoSystem

{
    internal class StudentValidation
    {
        public Student GetStudentDataByUser(User user)
        {
            if (user.FacultyNumber != null)
                foreach (var student in StudentData.TestStudents)
                    //Users have a FacultyNumber
                    //Students have a FacNo
                    if (student.FacNo == user.FacultyNumber)
                        return student;
            return null;
        }
    }
}
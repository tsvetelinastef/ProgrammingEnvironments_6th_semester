
using System.Collections.Generic;

namespace StudentInfoSystem
{
    internal static class StudentData
    {
        private static List<Student> _testStudents;

        public static List<Student> TestStudents
        {
            get
            {
                setFirstStudent();
                return _testStudents;
            }
            private set { }
        }

        private static void setFirstStudent()
        {
            if (_testStudents == null)
            {
                _testStudents = new List<Student>();
                var s1 = new Student("Tsvetelina", "Tsvetanova", "Stefanova", "FKST", "KSI", "bachelor", "regular",
                    "121220181", "3", "10", "43");
                _testStudents.Add(s1);
            }
        }
    }
}
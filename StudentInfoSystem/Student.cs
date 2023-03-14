namespace StudentInfoSystem
{
    internal class Student
    {
        public Student()
        {
        }

        public Student(string nameI, string middleNameI, string lastNameI, string facultyI, string majorI, string OKSI,
            string studentStatusI, string facNoI, string courseI, string potokI, string groupI)
        {
            Name = nameI;
            MiddleName = middleNameI;
            LastName = lastNameI;
            Faculty = facultyI;
            Major = majorI;
            OKS = OKSI;
            StudentStatus = studentStatusI;
            FacNo = facNoI;
            Course = courseI;
            Potok = potokI;
            Group = groupI;
        }

        public string Name { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Faculty { get; set; }

        public string Major { get; set; }

        public string OKS { get; set; }

        public string StudentStatus { get; set; }

        public string FacultyNumber { get; set; }

        public string Course { get; set; }

        public string Potok { get; set; }

        public string Group { get; set; }
    }
}

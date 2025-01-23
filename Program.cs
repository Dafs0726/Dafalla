
using Amazon.Runtime;
using cmd;

internal class Program
{
    static void Main(string[] args)

    {


        Data data = new Data();
        List<Student> students = data.GetStudents();
        //foreach (var student in students)
        //{
        //    // console.writeline($"name: {student.name}\n");
        //    //console.writeline($"course: {student.course}\n");
        //    //console.writeline($"id: {student.id} \n");
        //    //console.writeline($"year: {student.year} \n");
        //    //console.writeline($"name: {student.name}  \ncourse: {student.course}");
        //    // Console.WriteLine($"GRADE: {student.Grades}");

            //}
            //FILTER
            List<Student> dict = students.Where(x => x.Course == "DICT").ToList();
       // List<Student> grades = students.Where(x => x.Year == 1).ToList();
        //foreach (var course in dict)
        //{
        //    Console.WriteLine($"NAME: {course.Name} - COURSE: {course.Course}");
        //}
        //COUNT
        Console.WriteLine($"The number of dict students is {dict.Count}");
         



        //ORDER
        //List<Student> orderedStudents = firstYearstudents.OrderBy(x => x.Name).OrderBy(x => x.Course).ToList();
        // foreach (var firstYear in orderedStudents)
        //{
        //     Console.WriteLine($"NAME: {firstYear.Name} {firstYear.Year} - {firstYear.Course}");
        // }


        //GROUP
        var grouped = students.GroupBy(x => x.Course);
        foreach (var firstYear in grouped)
        {
            Console.WriteLine($"COURSES: {firstYear.Key} ");
        }





        //Console.WriteLine($"Course: {student.Course}\n");
        //Console.WriteLine($"Id: {student.Id} \n");
        //Console.WriteLine($"Year: {student.Year} \n");

        ////student -- name, course, year, Subject Grades (subject, grade)

        ////instantiate

        //SubjectGrade subject1 = new SubjectGrade(); //instantiation
        //subject1.SubjectCode = "SPIC"; //dot or period access operator
        //subject1.Grade = 91;
        //subject1.IsSubjectMajor = false;

        //SubjectGrade subject2 = new SubjectGrade(); //instantiation
        //subject2.SubjectCode = "PROG3";
        //subject2.Grade = 99;
        //subject2.IsSubjectMajor = true;


        //SubjectGrade subject3 = new SubjectGrade(); //instantiation
        //subject3.SubjectCode = "DBA";
        //subject3.Grade = 89;
        //subject3.IsSubjectMajor = true;


        //SubjectGrade subject4 = new SubjectGrade(); //instantiation
        //subject4.SubjectCode = "PE";
        //subject4.Grade = 85;
        //subject4.IsSubjectMajor = false;


        //List<SubjectGrade> subjectGrades = new List<SubjectGrade>();
        //subjectGrades.Add(subject1);
        //subjectGrades.Add(subject2);
        //subjectGrades.Add(subject3);
        //subjectGrades.Add(subject4);

        //SubjectGrade subject5 = new SubjectGrade()
        //{
        //    SubjectCode = "OS",
        //    Grade = 88,
        //    IsSubjectMajor = true,
        //};

        //subjectGrades.Add(subject5);

        ////instantation while adding in a list
        //subjectGrades.Add(new SubjectGrade { SubjectCode = "INTEG", Grade = 95, IsSubjectMajor = true });

        ////foreach (var subjectGrade in subjectGrades)
        ////{
        ////    Console.WriteLine($"Subject: {subjectGrade.SubjectCode}\tGrade: {subjectGrade.Grade}\tMajor:{subjectGrade.IsSubjectMajor}");
        ////}

        //Student student1 = new Student()
        //{
        //    Name = "Armando Dafalla",
        //    Age = 19,
        //    Course = "DIT",
        //    Year = 2-1,
        //    Lrn = 108226100032,
        //    SubjectGrades = subjectGrades
        //};

        //List<Student> ditStudents = new List<Student>();
        //ditStudents.Add(student1);




        //Console.WriteLine("GRADING SHEET\n");

        //foreach (var student in ditStudents)
        //{
        //    Console.WriteLine($"\nSTUDENT NAME:\t{student.Name}");
        //    Console.WriteLine($"Course & Year:\t{student.Course} {student.Year}");
        //    Console.WriteLine("\n....SUBJECT GRADES....");

        //    foreach (var subjectGrade in student.SubjectGrades)
        //    {
        //        Console.WriteLine($"Subject: {subjectGrade.SubjectCode}\tGrade: {subjectGrade.Grade}\tMajor:{subjectGrade.IsSubjectMajor}");
        //    }
    }

}


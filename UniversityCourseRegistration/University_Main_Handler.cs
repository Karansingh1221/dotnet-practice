using System;
using System.Collections.Generic;
namespace University_Course_Registration_System
{
    public static class UniversitySystemClass{
        public static Dictionary<string,Course> AvailableCourses=new Dictionary<string,Course>();
        public static Dictionary<string,Student> Students=new Dictionary<string,Student>();
        public static List<Student> ActiveStudent=new List<Student>();
        public static void AddCourse(string code, string name, int credits, 
                    int maxCapacity = 50, List<string> prerequisites = null){
            if(AvailableCourses.ContainsKey(code)){
                throw new ArgumentException();
            }
            Course c=new Course(code,name,credits,maxCapacity,prerequisites);
            AvailableCourses.Add(code,c);
        }
        public static void AddStudent(string id, string name, string major,
                 int maxCredits = 18, List<string> completedCourses = null){
            if(Students.ContainsKey(id)){
                throw new ArgumentException();
            }
            Student s=new Student(id,name,major,maxCredits,completedCourses);
            Students.Add(id,s);
            ActiveStudent.Add(s);
        }
        public static bool RegisterStudentForCourse(string studentId, string courseCode){
            if(!Students.ContainsKey(studentId) || !AvailableCourses.ContainsKey(courseCode)){
                Console.WriteLine("Prerequisites not met");
                return false;
            }
            Student s = Students[studentId];
            Course c = AvailableCourses[courseCode];
            return true;
        }
        public static bool DropStudentFromCourse(string studentId, string courseCode){
            if(Students.ContainsKey(studentId)){
                Students[studentId].DropCourse(courseCode);
                return true;
            }
            return false;
        }
        public static void DisplayAllCourses(){
            foreach(var i in AvailableCourses.Values){
                Console.WriteLine(i.CourseCode+","+","+i.CourseName+","+i.Credits+","+
                ","+i.MaxCapacity);
            }
        }
        public static void DisplayStudentSchedule(string studentId){
            if(Students.ContainsKey(studentId)){
                Students[studentId].DisplaySchedule();
                return;
            }
            Console.WriteLine("Error");
        }
        public static void DisplaySystemSummary(){
            Console.WriteLine("Total Students: "+Students.Count);
            Console.WriteLine("Total Courses: "+AvailableCourses.Count);
            int total=0;
            foreach(var i in AvailableCourses.Values){
                total+=i.MaxCapacity;
            }
            if(AvailableCourses.Count==0){
                Console.WriteLine("Average Enrollment: 0");
                return;
            }
            Console.WriteLine("Average Enrollment: "+total/AvailableCourses.Count);
        }

    }
}
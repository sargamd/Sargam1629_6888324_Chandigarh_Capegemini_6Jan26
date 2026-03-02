namespace University_Enrollment_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "Rahul", "rahul@uni.com", "B.Tech CSE");
            Professor p1 = new Professor(101, "Dr. Sharma", "sharma@uni.com", "Maths");
            Staff st1 = new Staff(201, "Anita", "anita@uni.com", "Administration");

            Console.WriteLine("Student Profile:");
            s1.DisplayProfile();

            Console.WriteLine("\nProfessor Action:");
            p1.AssignCourse("English");
        }
    }
}

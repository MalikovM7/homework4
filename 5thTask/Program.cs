using System.Runtime.Intrinsics.Arm;

namespace _5thTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student s1 = new Student();
            s1.Name = "Malik";
            s1.Surname = "Malikov";
            s1.age = 19;
            s1.Speciality = "Computer Engineer";
            s1.GroupNo = "P419";



            Student s2 = new Student();
            s2.Name = "Ruslan";
            s2.Surname = "Jafarov";
            s2.age = 20;
            s2.Speciality = "Full Stack Developer";
            s2.GroupNo = "P419";

            Student s3 = new Student();
            s3.Name = "Mehman";
            s3.Surname = "Orujov";
            s3.age = 22;
            s3.Speciality = "Web Designer";
            s3.GroupNo = "P419";

            Student[] students = new Student[3];

            students[0] = s1;
            students[1] = s2;
            students[2] = s3;

                for (int i = 0; i < students.Length; i++)
            {
                Console.Write(students[i].Name +" "+ students[i].Surname + " " + students[i].age + " " + students[i].Speciality + " " + students[i].GroupNo);
                

                Console.WriteLine(" ");



            }






        }



        class Student
        {

            public string Name;
            public string Surname;
            public byte age;
            public string Speciality;
            public string GroupNo;

        }
    }
}
namespace Students2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] tokens = line.Split();
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string city = tokens[3];
                if (DoesStudentExist(list, firstName, lastName))
                {
                    Student student = GetStudent(list, firstName, lastName);
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = city;
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        City = city,
                    };

                    list.Add(student);
                }
                    line = Console.ReadLine();
                

            }

            string cityFilter = Console.ReadLine();
            foreach (Student student in list)
            {
                if (student.City == cityFilter)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static Student GetStudent(List<Student> list, string firstName, string lastName)
        {
            Student existingStudent = null;
            foreach (Student student in list)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }
        static bool DoesStudentExist(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }

            }
            return false;
        }


        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string City { get; set; }
        }
    }
}
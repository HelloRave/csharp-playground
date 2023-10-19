using csharp_playground;
using System.Collections;
using System.Diagnostics.Metrics;

namespace DataTypesVariables

{

    public class Program

    {

        public static void Main(string[] args)

        {
            Hashtable hashtable = new Hashtable();

            Student stud1 = new Student(1, "Maria", "Year 1");
            Student stud2 = new Student(2, "Jason", "Year 2");
            Student stud3 = new Student(3, "Clara", "Year 3");

            hashtable.Add(stud1.Id, stud1);
            hashtable.Add(stud2.Id, stud2);
            hashtable.Add(stud3.Id, stud3);

            Student storedStudent1 = (Student)hashtable[1]!; // Need to cast to type Student else type object

            Console.WriteLine($"Student ID: {storedStudent1.Id}, Name: {storedStudent1.Name}, Description: {storedStudent1.Description}");

            foreach (DictionaryEntry item in hashtable)
            {
                int id = (int)item.Key;
                Student student = (Student)item.Value!;
                Console.WriteLine("Key = {0}, Value.Id = {1}", id, student.Id);
            }

            Hashtable studentTable = new Hashtable();

            Student[] students =
            {
                new Student(1, "Maria", "Year 1"),
                new Student(2, "Jason", "Year 2"),
                new Student(3, "Clara", "Year 3"),
                new Student(3, "Nadia", "Year 3")
            };

            foreach (Student student in students) 
            {
                if (!studentTable.ContainsKey(student.Id)) 
                {
                    studentTable.Add(student.Id, student);
                    Console.WriteLine("Student with ID{0} was added", student.Id);
                }
                else
                {
                    Console.WriteLine("Student with ID{0} already exists", student.Id);
                }
            }
        }

    }

}

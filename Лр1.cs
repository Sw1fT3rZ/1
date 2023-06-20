using System;
using System.Linq;

class Program
{
    struct Student
    {
        public string LastName;
        public string Group;
        public string Gender;
        public float Time;
    }

    const int ARRAY_SIZE = 10;

    static void Main()
    {
        Student[] students = new Student[ARRAY_SIZE];

      
        students[0] = new Student { LastName = "Ivanov", Group = "Group A", Gender = "Male", Time = 12.5f };
        students[1] = new Student { LastName = "Petrov", Group = "Group B", Gender = "Male", Time = 11.2f };
        students[2] = new Student { LastName = "Sidorov", Group = "Group A", Gender = "Male", Time = 13.1f };
        students[3] = new Student { LastName = "Smirnova", Group = "Group B", Gender = "Female", Time = 14.2f };
        students[4] = new Student { LastName = "Morozov", Group = "Group A", Gender = "Male", Time = 11.9f };
        students[5] = new Student { LastName = "Kovalenko", Group = "Group C", Gender = "Female", Time = 15.7f };
        students[6] = new Student { LastName = "Stepanenko", Group = "Group B", Gender = "Male", Time = 12.8f };
        students[7] = new Student { LastName = "Fedorova", Group = "Group A", Gender = "Female", Time = 13.5f };
        students[8] = new Student { LastName = "Kozlov", Group = "Group C", Gender = "Male", Time = 14.9f };
        students[9] = new Student { LastName = "Oleksenko", Group = "Group C", Gender = "Female", Time = 15.1f };

       
        Console.Write("Введіть групу: ");
        string inputGroup = Console.ReadLine();

        
        var filteredStudents = students.Where(s => s.Group == inputGroup)
                                       .OrderBy(s => s.Time)
                                       .Take(3);

      
        Console.WriteLine($"Три найкращих результати для групи {inputGroup}:");
        foreach (var student in filteredStudents)
        {
            Console.WriteLine($"Прізвище: {student.LastName}");
            Console.WriteLine($"Група: {student.Group}");
            Console.WriteLine($"Стать: {student.Gender}");
            Console.WriteLine($"Показаний час: {student.Time}");
            Console.WriteLine();
        }
    }
}

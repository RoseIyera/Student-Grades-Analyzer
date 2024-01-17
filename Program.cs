using Student_Grades_Analyzer;
using System.Xml.Linq;

// Add list of students with names and grades
List<Student> students = new List<Student>();
students.Add(new Student { Name = "John", Subject="Math", Year=2023, Grades = new List<double> { 90, 80, 70, 60 } });
students.Add(new Student { Name = "Ali", Subject = "Math", Year = 2023, Grades = new List<double> { 100, 95, 90, 88 } });
students.Add(new Student { Name = "John", Subject = "CAT", Year = 2023, Grades = new List<double> { 90, 95, 88, 80 } });
students.Add(new Student { Name = "Jane", Subject = "Math", Year = 2023, Grades = new List<double> { 90, 80, 70, 60 } });

bool exit = false;
while (!exit)
{
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Display Students");
    Console.WriteLine("3. Filter and sort students");
    Console.WriteLine("4. Dislay class stats");
    Console.WriteLine("5. Exit");
    Console.Write("Enter your choice: 1-5 ");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            AddStudent(students);
            break;
        case "2":
            DisplayStudents(students);
            break;
        case "3":
            FilterAndSortStudents(students);
            break;
        case "4":
            DisplayClassStats(students);
            break;
        case "5":
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid choice. Please enter a valid choice.");
            break;
    }

}

// Method to add a new student
static void AddStudent(List<Student> students)
{
    Student newStudent = new Student();

    Console.Write("Enter student name: ");
    newStudent.Name = Console.ReadLine();

    Console.Write("Enter number of grades: ");
    int numGrades;
    if (int.TryParse(Console.ReadLine(), out numGrades))
    {
        newStudent.Grades = new List<double>();

        for (int i = 0; i < numGrades; i++)
        {
            Console.Write($"Enter grade {i + 1}: ");
            double grade;
            if (double.TryParse(Console.ReadLine(), out grade))
            {
                newStudent.Grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade. Please enter a valid number.");
                i--;
            }
        }

        Console.Write("Enter subject: ");
        newStudent.Subject = Console.ReadLine();

        Console.Write("Enter year: ");
        int year;
        if (int.TryParse(Console.ReadLine(), out year))
        {
            newStudent.Year = year;
        }
        else
        {
            Console.WriteLine("Invalid year. Please enter a valid number.");
        }

        students.Add(newStudent);
        Console.WriteLine("Student added successfully!");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}


// Display students
static void DisplayStudents(List<Student> students)
{
    Console.WriteLine("\nList of Students:");  
    foreach (var student in students)
    {
         Console.WriteLine($"Name: {student.Name}");
         Console.WriteLine($"Subject: {student.Subject}");
         Console.WriteLine($"Year: {student.Year}");
         Console.WriteLine($"Grades: {string.Join(", ", student.Grades)}");
         Console.WriteLine($"Average Grade: {student.AverageGrade}");
    }
         Console.WriteLine();
}
// Filter and sort students
static void FilterAndSortStudents(List<Student> students)
{
    Console.WriteLine("Enter minimum average grade for filtering (press Enter to skip): ");
    double minAverageGrade;
    bool filterByAverageGrade = double.TryParse(Console.ReadLine(), out minAverageGrade);
    
    Console.WriteLine("Sort students by(Name / AverageGrade / Subject / Year): ");
    string sortBy = Console.ReadLine();

    var query = students;

    if(filterByAverageGrade)
    {
        query = query.Where(s => s.AverageGrade >= minAverageGrade).ToList();
    }

    switch (sortBy)
    {
        case "name":
            query = query.OrderBy(s => s.Name).ToList();
            break;
        case "averageGrade":
            query = query.OrderBy(s => s.AverageGrade).ToList();
            break;
        case "subject":
            query = query.OrderBy(s => s.Subject).ToList();
            break;
        case "year":
            query = query.OrderBy(s => s.Year).ToList();
            break;
        default:
            Console.WriteLine("Invalid sort option. Students will not be sorted.");
            break;
    }
    DisplayStudents(query);
}   
// Display class stats
static void DisplayClassStats(List<Student> students)
{
    Console.WriteLine("Class Stats:");
    Console.WriteLine($"Number of students: {students.Count}");
    Console.WriteLine($"Average grade: {students.Average(s => s.AverageGrade)}");
    Console.WriteLine($"Highest grade: {students.Max(s => s.AverageGrade)}");
    Console.WriteLine($"Lowest grade: {students.Min(s => s.AverageGrade)}");
    Console.WriteLine();
}
// Exit







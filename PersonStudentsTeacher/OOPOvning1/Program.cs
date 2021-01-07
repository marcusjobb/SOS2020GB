namespace OOPOvning1
{
    using OOPOvning1.Enums;
    using OOPOvning1.Models;

    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Defines the People.
        /// </summary>
        private static readonly List<Person> People = new List<Person>();

        /// <summary>
        /// Defines the Schools.
        /// </summary>
        private static readonly List<School> Schools = new List<School>();

        /// <summary>
        /// The Main.
        /// </summary>
        internal static void Main()
        {
            // Skapa student genom Constructorn
            var student = new Student
            (
                name: "Danny Zuko",
                age: 18,
                grade: Grades.G
            );
            People.Add(student);

            // Skspar student genom constructorn
            // ersätter sedan värderna genom properties
            student = new Student(name: "Danny Zuko", age: 18, grade: Grades.G)
            {
                Name = "Sandy Olsson",
                Age = 18,
                Grade = Grades.VG
            };
            People.Add(student);

            // Skapa studenter genom en metod
            NewStudent("Peter Parker", 15, Grades.VG);
            NewStudent("Flash Thompson", 17, Grades.Superhacker);
            NewStudent("Liz Allan", 17, Grades.G);
            NewStudent("Sally Avril", 16, Grades.VG);
            NewStudent("Jessica Jones", 15, Grades.VG);

            // Skapa lärare genom metodanrop
            Newteacher("Ms. Carlyle", 37, "Midtown High School", "Queens, New York");
            Newteacher("Stanley Lieber", 42, "Midtown High School", "Queens, New York");

            //ShowAllThePeople();

            foreach (var person in People)
            {
                person.Greet();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// The ShowAllThePeople.
        /// </summary>
        private static void ShowAllThePeople()
        {
            foreach (var person in People)
            {
                Console.Write(person.Name + "(" + person.Age + ")");
                // Kolla om personen är lärare
                if (person is Teacher)
                {
                    var tmp = person as Teacher;
                    Console.WriteLine(" Jobbar på " + tmp.School.Name + ", " + tmp.School.City);
                }
                // Kolla om personen är student
                if (person is Student)
                {
                    var tmp = person as Student;
                    Console.WriteLine(" och har betyg " + tmp.Grade);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// The Newteacher.
        /// </summary>
        /// <param name="name">The name<see cref="string"/>.</param>
        /// <param name="age">The age<see cref="int"/>.</param>
        /// <param name="school">The school<see cref="string"/>.</param>
        /// <param name="city">The city<see cref="string"/>.</param>
        private static void Newteacher(string name, int age, string school, string city) => People.Add(
                new Teacher
                {
                    Name = name,
                    Age = age,
                    School = GetSchool(school, city)
                }
                );

        /// <summary>
        /// The GetSchool.
        /// </summary>
        /// <param name="school">The school<see cref="string"/>.</param>
        /// <param name="city">The city<see cref="string"/>.</param>
        /// <returns>The <see cref="School"/>.</returns>
        private static School GetSchool(string school, string city)
        {
            school = school.Trim();
            city = city.Trim();

            // Detta kan göras snabbare i Linq iofs
            foreach (var item in Schools)
            {
                if (string.Equals(item.City, city, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(item.Name, school, StringComparison.OrdinalIgnoreCase))
                {
                    return item;
                }
            }
            var newSchool = new School { City = city, Name = school };
            Schools.Add(newSchool);
            return newSchool;
        }

        /// <summary>
        /// The NewStudent.
        /// </summary>
        /// <param name="name">The name<see cref="string"/>.</param>
        /// <param name="age">The age<see cref="int"/>.</param>
        /// <param name="grade">The grade<see cref="Grades"/>.</param>
        private static void NewStudent(string name, int age, Grades grade) => People.Add(
                new Student
                {
                    Name = name,
                    Age = age,
                    Grade = grade
                }
                );
    }
}

namespace OOPOvning1.Models
{
    using OOPOvning1.Enums;

    using System;

    /// <summary>
    /// Defines the <see cref="Student" />.
    /// </summary>
    public class Student : Person
    {
        /// <summary>
        /// Gets or sets the Grade.
        /// </summary>
        public Grades Grade { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        public Student()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="name">The name<see cref="string"/>.</param>
        /// <param name="age">The age<see cref="int"/>.</param>
        /// <param name="grade">The grade<see cref="Grades"/>.</param>
        public Student(string name, int age, Grades grade) : base(name, age)
        {
            Grade = grade;
        }

        /// <summary>
        /// The Greeting.
        /// </summary>
        public override void Greet()
        {
            base.Greet();
            Console.WriteLine($"Mitt nuvarande betyg är {Grade}");
        }
    }
}

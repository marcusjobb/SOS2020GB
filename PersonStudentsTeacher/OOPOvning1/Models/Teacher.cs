namespace OOPOvning1.Models
{
    using System;

    /// <summary>
    /// Defines the <see cref="Teacher" />.
    /// </summary>
    public class Teacher : Person
    {
        /// <summary>
        /// Gets or sets the School.
        /// </summary>
        public School School { get; set; }

        /// <summary>
        /// The Greet.
        /// </summary>
        public override void Greet()
        {
            base.Greet();
            Console.WriteLine($"Jag undervisar på {School.Name} i {School.City}");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Teacher"/> class.
        /// </summary>
        public Teacher()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Teacher"/> class.
        /// </summary>
        /// <param name="name">The name<see cref="string"/>.</param>
        /// <param name="age">The age<see cref="int"/>.</param>
        /// <param name="school">The school<see cref="School"/>.</param>
        public Teacher(string name, int age, School school) : base(name, age)
        {
            School = school;
        }
    }
}

namespace OOPOvning1.Models
{
    using System;

    /// <summary>
    /// Defines the <see cref="Person" />.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Defines the name.
        /// </summary>
        private string name;

        /// <summary>
        /// Defines the age.
        /// </summary>
        private int age;

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets or sets the Age.
        /// </summary>
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="name">The name<see cref="string"/>.</param>
        /// <param name="age">The age<see cref="int"/>.</param>
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        /// <summary>
        /// The Greet.
        /// </summary>
        public virtual void Greet()
        {
            Console.WriteLine($"Hej, mitt namn är {Name} och jag är {Age} år gammal");
        }
    }
}

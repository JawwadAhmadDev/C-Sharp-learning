// ===================== 1st Problem: Solution ==================//
// School System (Student and Teacher Implementations):

// Base class
// public class Person
// {
//     public string Name { get; set; }
//     public string Address { get; set; }

//     public Person(string name, string address)
//     {
//         Name = name;
//         Address = address;
//     }
// }

// // Derived class - Student
// public class Student : Person
// {
//     public int GradeLevel { get; set; }

//     public Student(string name, string address, int gradeLevel) : base(name, address)
//     {
//         GradeLevel = gradeLevel;
//     }

//     public void Study()
//     {
//         Console.WriteLine($"{Name} is studying at grade {GradeLevel}");
//     }
// }

// // Derived class - Teacher
// public class Teacher : Person
// {
//     public string Subject { get; set; }

//     public Teacher(string name, string address, string subject) : base(name, address)
//     {
//         Subject = subject;
//     }

//     public void Teach()
//     {
//         Console.WriteLine($"{Name} teaches {Subject}");
//     }
// }








// ===================== 2nd Problem: Solution ==================//
// Zoo Animal Hierarchy:


// Base class
public class Animal
{
    public int Age { get; set; }
    public double Weight { get; set; }

    public Animal(int age, double weight)
    {
        Age = age;
        Weight = weight;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

// Derived class - Lion
public class Lion : Animal
{
    public Lion(int age, double weight) : base(age, weight) { }

    public override void MakeSound()
    {
        Console.WriteLine("Lion roars");
    }

    public void Hunt()
    {
        Console.WriteLine("Lion is hunting");
    }
}




















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










// ===================== 3rd Problem: Solution ==================//
// Company Hierarchy:

// Base class
// public class Employee
// {
//     public int ID { get; set; }
//     public string Department { get; set; }

//     public Employee(int id, string department)
//     {
//         ID = id;
//         Department = department;
//     }

//     public void Work()
//     {
//         Console.WriteLine($"Employee {ID} is working in {Department}");
//     }
// }

// // Derived class - Manager
// public class Manager : Employee
// {
//     public Manager(int id, string department) : base(id, department) { }

//     public void Manage()
//     {
//         Console.WriteLine($"Manager {ID} manages the {Department} department");
//     }
// }














// ===================== 4th Problem: Solution ==================//
// Transportation System:


// Base class
public class TransportMode
{
    public int MaxSpeed { get; set; }
    public int Capacity { get; set; }

    public TransportMode(int maxSpeed, int capacity)
    {
        MaxSpeed = maxSpeed;
        Capacity = capacity;
    }

    public void Operate()
    {
        Console.WriteLine($"Operating at speed: {MaxSpeed} with capacity: {Capacity}");
    }
}

// Derived class - Bus
public class Bus : TransportMode
{
    public Bus(int maxSpeed, int capacity) : base(maxSpeed, capacity) { }

    public void Drive()
    {
        Console.WriteLine("Bus is driving");
    }
}


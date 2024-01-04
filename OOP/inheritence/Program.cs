// ===================== 1st Problem: Solution ==================//
// School System(Student and Teacher Implementations):
// Design a base class Person with common attributes like name and address. Derive classes such as Student and Teacher from Person, adding specific properties and methods relevant to each.

// Base class
public class Person
{
    public string Name { get; set; }
    public string Address { get; set; }

    public Person(string name, string address)
    {
        Name = name;
        Address = address;
    }
}

// Derived class - Student
public class Student : Person
{
    public int GradeLevel { get; set; }

    public Student(string name, string address, int gradeLevel) : base(name, address)
    {
        GradeLevel = gradeLevel;
    }

    public void Study()
    {
        Console.WriteLine($"{Name} is studying at grade {GradeLevel}");
    }
}

// Derived class - Teacher
public class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, string address, string subject) : base(name, address)
    {
        Subject = subject;
    }

    public void Teach()
    {
        Console.WriteLine($"{Name} teaches {Subject}");
    }
}








// ===================== 2nd Problem: Solution ==================//
// Zoo Animal Hierarchy:
// Create a base class Animal with general characteristics like age and weight. Extend this class to specific animals like Lion, Elephant, and Giraffe, each with unique attributes and behaviors.

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
// Implement a base class Employee with common fields like employee ID and department. Derive different roles like Manager, Engineer, and SalesRepresentative, adding role-specific methods and properties.

// Base class
public class Employee
{
    public int ID { get; set; }
    public string Department { get; set; }

    public Employee(int id, string department)
    {
        ID = id;
        Department = department;
    }

    public void Work()
    {
        Console.WriteLine($"Employee {ID} is working in {Department}");
    }
}

// Derived class - Manager
public class Manager : Employee
{
    public Manager(int id, string department) : base(id, department) { }

    public void Manage()
    {
        Console.WriteLine($"Manager {ID} manages the {Department} department");
    }
}














// ===================== 4th Problem: Solution ==================//
// Transportation System:
// Develop a base class TransportMode with common features like maximum speed and capacity. Extend this class into specific transportation modes like Bus, Train, and Airplane, each with unique attributes.
// Create a base class ElectronicDevice with basic functionalities like powerOn() and powerOff(). Extend this class with specific products like Television, Radio, and Laptop, each having additional features and functionalities.

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













// ===================== 5th Problem: Solution ==================//
// Electronics Product Line:

// Base class
public class ElectronicDevice
{
    public virtual void PowerOn()
    {
        Console.WriteLine("Device is powered on");
    }

    public virtual void PowerOff()
    {
        Console.WriteLine("Device is powered off");
    }
}

// Derived class - Television
public class Television : ElectronicDevice
{
    public int Channel { get; set; }

    public Television()
    {
        Channel = 1; // Default channel
    }

    public void ChangeChannel(int channel)
    {
        Channel = channel;
        Console.WriteLine($"Changed to channel {Channel}");
    }

    public override void PowerOn()
    {
        base.PowerOn();
        Console.WriteLine("Television is now on");
    }

    public override void PowerOff()
    {
        base.PowerOff();
        Console.WriteLine("Television is now off");
    }
}



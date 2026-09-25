using System;

class Repository<T> where T : class
{
    public void Add(T item)
    {
        Console.WriteLine("Item added: " + item);
    }
}

class Student
{
    public string Name { get; set; }

    public Student(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}

class Program
{
    static void Main()
    {
       
        Repository<Student> studentRepository =
            new Repository<Student>();

        Student student = new Student("Rahul");

        studentRepository.Add(student);

       
    }
}

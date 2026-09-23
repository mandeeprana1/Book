Console.WriteLine("Enter your Marks");
int Marks = Convert.ToInt32(Console.ReadLine());
 if(Marks > 90)
{
    Console.WriteLine("Grade A");
}
else if (Marks > 80)
{
    Console.WriteLine("Grade B");
}
else if (Marks > 70)
{
    Console.WriteLine("Grade C");
}
else if (Marks > 60)
{
    Console.WriteLine("Grade D");
}
else
{
    Console.WriteLine("False");
}
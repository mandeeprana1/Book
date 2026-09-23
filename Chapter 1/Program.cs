try
{
    int x = 10;
    int y = 0;
    int result = x / y;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    Console.WriteLine("Execution completed.");
}
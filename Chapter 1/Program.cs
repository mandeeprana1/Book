class Mathtest
{
    public int getsquare(int x)
    {
        return x * x;
    }
   public  static int getsquare1(int x)
    {
        return x * x;
    }
}
class program
{
    static void Main(string[] args)
    {
        Mathtest m = new Mathtest();
      Console.WriteLine(m.getsquare(5));
        Console.WriteLine(Mathtest.getsquare1(6));
    }
}
using MoreCSharpFun;

public class Program
{
    private static void Main(string[] args)
    {
        /*this is going to reserve a space the size 
         of the PrintStuff class*/
        PrintStuff ps = new PrintStuff("PT");

        string name = "";

        System.Console.WriteLine("Please Enter Your Name");
        name = System.Console.ReadLine();

        /*I can use ps here because I removed
         the static keyword from the PrintStuff
        class program*/
        ps.PrintName(name);
    }
}
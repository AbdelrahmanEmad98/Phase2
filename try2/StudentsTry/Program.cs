using StudentsTry;

internal class Program
{
    private static void Main(string[] args)
    {
        Student s1 = new Student("Abdelrahmane", "Emad", "A1");
        Student s2 = new Student("Hassan", "Ali", "A2");
        Student s3 = new Student("Sarah", "Mohamed", "A2");
        
        Console.WriteLine( s1.ToString());
        Console.WriteLine( s2.ToString());
        Console.WriteLine( s3.ToString());
    }
}
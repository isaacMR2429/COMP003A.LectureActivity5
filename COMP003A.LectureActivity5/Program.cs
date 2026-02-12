namespace COMP003A.LectureActivity5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcome(); //Part A
            
            string name = "Alex";             
            int age = 20;                     // Part B
            DisplayUserInfo(name, age);        
        }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Module 5!"); //Part A
        }
        static void DisplayUserInfo(string name, int age)
        {
            Console.WriteLine($"Name: {name}, Age: {age}");  //Part B
        }

    }
}

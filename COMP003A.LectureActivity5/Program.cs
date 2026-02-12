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

            int sum = CalculateSum(7, 8);
            Console.WriteLine($"The sum is: {sum}"); //Part C

            int mainNumber = 50; //Part D

            if (true) //Part E
            {
                int blockValue = 30;
                Console.WriteLine($"Block Value: {blockValue}");
            }
            // Console.WriteLine(blockValue); // The Error message showed again. Step 11

        }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Module 5!"); //Part A
            /*Console.WriteLine(mainNumber);
             * The name mainNumber does not exist in the current context
             * Part D error message step 9
             */
        }
        static void DisplayUserInfo(string name, int age)
        {
            Console.WriteLine($"Name: {name}, Age: {age}");  //Part B 
        }
        static int CalculateSum(int a, int b)
        {
            return a + b;    //Part C
        }

    }
}

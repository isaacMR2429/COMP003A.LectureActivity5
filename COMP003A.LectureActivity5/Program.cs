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
                Console.WriteLine($"Block Value: {blockValue}"); //Step 10
            }
            // Console.WriteLine(blockValue); // The Error message showed again. Step 11

            for (int i = 0; i <3; i++) //Part F
            {
                Console.WriteLine($"Loop Counter: {i}"); //Step 12
            }
            //Console.WriteLine(i); The Error message showed again. Step 13
        }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Module 5!"); //Part A
            //Console.WriteLine(mainNumber);
            /* 
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

        /* Step G - Reflection
         * 
         * Why method variables are not accessible in main?
         *  Method variables are not accessible in main because they only exist inside that method scope, so Main can't use them.
         *
         *Why block variables do not exist outside {}
         *  Block variables do not exist outside {}, because a variable inside {} is limited to that block.
         *
         *Why scope improves program safety?
         *  Scope improves the program safety by keeping variavles contained so other parts of the program can't changed them
         */
    }
}

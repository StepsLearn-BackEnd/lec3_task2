namespace lec3_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greeting;
            char ask='y';
          
            do {
                Console.WriteLine("enter number from 1:4 ");
                greeting = Convert.ToInt16(Console.ReadLine());

                if (greeting == 1)
                {
                    Console.WriteLine(" Good Morning ");
                }

                else if (greeting == 2)
                {
                    Console.WriteLine(" Good Evening ");
                }

                else if (greeting == 3)
                {
                    Console.WriteLine(" Good Afternoon ");
                }

                else if (greeting == 4)
                {
                    Console.WriteLine(" Good Night ");
                }

                else 
                {
                    Console.WriteLine("out of rang ");
                }

                Console.WriteLine(" are you want to continue enter your replay  \n " +
                   "'y' to continue \n " +
                   "'n' to exit ");
                ask = Convert.ToChar(Console.ReadLine());
            } while (ask == 'y');

           

        }
    }
}

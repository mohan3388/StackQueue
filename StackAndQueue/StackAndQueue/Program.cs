namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {

            

            Console.WriteLine("Welcome the program");
           
            Console.WriteLine("Please Enter the Information");
            bool check = true;
            Console.WriteLine("1.To Display Stack \n 2.To Display Queue \n");

            while (check)
            {
                Console.WriteLine("Enter The Above option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Stack.InsertData();
                        break;
                    case 2:

                        Queue.InsertDataQueue();
                        break;
                    
                    default:
                        check = false;
                        break;
                }

            }

        }
    }
}
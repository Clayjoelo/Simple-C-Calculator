namespace name
{
    class program
    {
        public static void Main()
        {
            Console.WriteLine("Clayton's Calculator....\n");
            Console.WriteLine("Addition = +");
            Console.WriteLine("Subtraction = -");
            Console.WriteLine("Multiplcation = *");
            Console.WriteLine("Division = /\n");

            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string OP = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (OP == "+")
            {
                Console.WriteLine(num1 + num2);
            }else if (OP == "-")
            {
                Console.WriteLine(num1 - num2);
            }else if (OP == "*")
            {
                Console.WriteLine(num1 * num2);
            }else if (OP == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("SYNAX ERROR");
            }
        }
    }
}
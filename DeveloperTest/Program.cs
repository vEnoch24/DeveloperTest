namespace DeveloperTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1
            string name = "John Doe";
            int age = 25;
            bool isAdmin = true;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(isAdmin);

            Console.WriteLine();

            // TASK 2
            Console.Write("Input a number and press Enter: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            Console.WriteLine();

            // TASK 3
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            // TASK 4
            int[] array = new int[] { 2, 4, 6, 8, 10 };
            int sum = 0;

           
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Sum of array is: {sum}");

            foreach (int a in array)
            {
                Console.WriteLine(a);
            }

            // TASK 5
            Greet("Alice");
        }

        public static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
   
}

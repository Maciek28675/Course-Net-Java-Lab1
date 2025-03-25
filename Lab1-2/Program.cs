namespace Lab1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem p1 = new Problem(10, 2);

            Console.WriteLine(p1);
            Console.WriteLine("Enter Capacity: ");

            try
            {
                int capacity = Convert.ToInt32(Console.ReadLine());

                if (capacity < 0)
                {
                    throw new Exception("Capacity has to be greater than 0");
                }

                Result result = p1.Solve(capacity);

                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

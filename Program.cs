namespace HelloWorld
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the year");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100! == 0 || (year % 400 == 0)))
            {
                Console.WriteLine(year + "is leaf year");


            }
            else
            {
                Console.WriteLine(year + "is not leaf year");
            }

        }
    }
}































           
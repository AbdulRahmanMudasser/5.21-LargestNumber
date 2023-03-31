class LargestNumber
{
    static void Main(string[] args)
    {
        // declaring variables
        int input;
        int largestNumber = 0;
        int counter = 0;

        do
        {
            // incrementing counter
            counter++;

            // input first number
            Console.Write("Input " + counter + " Number:  ");
            input = Convert.ToInt32(Console.ReadLine());

            // checking for largest number
            if (largestNumber < input)
            {
                largestNumber = input;
            }

        } while (counter < 10);

        // displaying the largest number
        Console.WriteLine("Largest Number:  " + largestNumber);
    }
}

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //making a change for the palindrome solution
            string input = string.Empty;
            Console.WriteLine("Enter a phrase to evaluate:");
            input = Console.ReadLine();

            //clear out the spaces and punctuation
            string cleanedInput = new string(input.Where(c => char.IsLetterOrDigit(c)).ToArray()).ToLower();

            Console.WriteLine(cleanedInput);


            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();  

        }
    }
}

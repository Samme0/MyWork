namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Sam";
            int age = 18;

            SingHappyBirthday(name, age);

            Console.ReadKey();


        }
        public static void SingHappyBirthday(string birthdayBoy, int YearsOld)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + birthdayBoy);
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("You are " + YearsOld + " years old!");
            Console.WriteLine("Happy birthday to you!");

        }
    }
}



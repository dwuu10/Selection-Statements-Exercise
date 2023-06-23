namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("guess a number between 1 and 100");
            var random = new Random();
            var number = random.Next(1, 100);
            var userInput = int.Parse(Console.ReadLine());
            if (userInput > number)
            {
                Console.WriteLine("your guess is too high");
            }
            else if (userInput < number)
            {
                Console.WriteLine("your guess is too low");
            }
            else
            {
                Console.WriteLine("congratulations, you got the right number");
            }
        }
    }
}

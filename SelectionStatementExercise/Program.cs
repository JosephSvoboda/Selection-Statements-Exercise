namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //Random number guess game.

            Console.WriteLine("Select a number between 1 and 1000.");

            var r = new Random();
            int favNumber = r.Next(1, 1000);
            var userInput = int.Parse(Console.ReadLine());

            //if statement for random number.

                if (userInput < favNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine("You guessed right!");
                }

            //Exercise 2

            Console.WriteLine("What is your favorite school subject?");
            var school = Console.ReadLine();

                switch (school)
                {
                    case "history":
                        Console.WriteLine("history, mystery.");
                        break;
                    case "math":
                        Console.WriteLine("math, shmath.");
                        break;
                    case "science":
                        Console.WriteLine("science, FUN!");
                        break;
                    case "english":
                        Console.WriteLine("english, pshhhh.");
                        break;
                    case "p.e.":
                        Console.WriteLine("p.e., nah.");
                        break;
                    default:
                        Console.WriteLine("Please try again.");
                        break;
                }
        }
    }
}

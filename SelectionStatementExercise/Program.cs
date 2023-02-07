namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var FavNum = 10;
            Console.WriteLine("Guess my favorite number");
            var UserInput = int.Parse(Console.ReadLine());
            if (UserInput < FavNum)
            {
                Console.WriteLine("Too low");
            }
            if (UserInput > FavNum)
            {
                Console.WriteLine("Too high");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

        }
    }
}

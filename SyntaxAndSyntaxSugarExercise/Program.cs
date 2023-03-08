namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = int.Parse (Console.ReadLine());
          

            var userResponse = (response >= 4) ? ($"{response} is greater than or equal to {answer}") : ($"{response} is less than {answer}");

            Console.WriteLine(userResponse);


        }
    }
}

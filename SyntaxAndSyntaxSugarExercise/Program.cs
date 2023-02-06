namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Hope you are having a great Monday! Below is todays exercise");


            //int answer = 4;
            //string response;
            //if (answer < 9)
            //{
            //response = answer + " is less than nine";
            //}
            //else
            //{
            //response = answer + " is greater than or equal to nine";
            //}



            //Inferred Typing, String Interpolation, and Tenary Operator 

            Console.WriteLine("Please pick a number between 1 and 20."); 

            var answer = int.Parse(Console.ReadLine());

            var response = (answer < 9) ? $"{answer} is less than nine." : $" {answer} is greater or equal to 9.";

            Console.WriteLine(response);



            









        }


    }
}

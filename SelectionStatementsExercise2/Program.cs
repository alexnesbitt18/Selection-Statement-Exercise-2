namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello, What is your favorite school subject?");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine($"Wow, math is a super tough subject, you must be smart!");
                    break;
                case "social studies":
                    Console.WriteLine($"Amazing, what a great choice!");
                    break;
                case "science":
                    Console.WriteLine($"Fun, do you like working in a lab?");
                    break;
                case "english":
                    Console.WriteLine($"Do you have any fun writing methods you would like to share?");
                    break;
                case "gym":
                    Console.WriteLine($"Wow you must like being fit.");
                break;
                default: Console.WriteLine($"Interesting, I have never taken that subject before! {subject} sounds like a blast");
                    break;
            }
        }
    }
}
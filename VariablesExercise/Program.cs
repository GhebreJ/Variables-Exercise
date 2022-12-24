namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Jonah";
            int age = 27;
            decimal height = 6.4m;
            char initial = 'M';
            bool b = true;
            double d = 9.09;


            Console.WriteLine($"Hello, {name} you are {age} years old your middle initial is {initial}. It is {b} that you are {height}ft. The meal at Bojangels was {d}$ today");
        }
    }
}

namespace ListHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            string answer = "";
            do
            {
                Console.WriteLine("Please enter name of student");
                answer = Console.ReadLine();
                students.Add(answer);
                Console.WriteLine("Is that all students? Answer 'yes' if so, 'no' if not.");
                answer = Console.ReadLine();
            }
            while (answer != "yes");
            Console.WriteLine(students.Count);
        }
    }
}

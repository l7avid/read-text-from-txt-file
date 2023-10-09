namespace ReadFromTextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\david.reina\Documents\Personal Devs\Ruta N Udemy - C#\19 - Read From Text File\Readme.txt");

            Console.WriteLine($"The file contains the next text:\n\n{text}");
        }
    }
}
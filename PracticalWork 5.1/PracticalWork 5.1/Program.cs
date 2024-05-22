using System.Diagnostics.Tracing;

namespace PracticalWork_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            SplitText(GetText());
        }

        static string GetText()
        {

            Console.WriteLine("Введите предложение");

            string text = Console.ReadLine();

            return text;
        }

        static string[] SplitText(string text)
        {
            string[] words = text.Split(' ');

            foreach (string w in words)
            {
                Console.WriteLine(w);
            }
            return words;
        }
    }
}

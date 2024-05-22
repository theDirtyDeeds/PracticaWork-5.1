namespace PracticalWork_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string getText = Console.ReadLine();

            Reverse(getText);
        }
        static string[] SplitText(string text)
        {
            string[] words = text.Split(" ");

            foreach (string w in words)
            {
                Console.WriteLine(w);
            }
            return words;
        }

        static string Reverse(string reverseText)
        {

            for (int i = SplitText(reverseText).Length; i >= 0; i--)
            {
                Console.Write(reverseText[i]);
            }
            return reverseText;
        }
    }
}

using System.Text;

namespace Mumbling
{
    public class Accumul
    {
        public static String Accum(string s)
        {
            string[] stringsArray = new string[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                stringsArray[i] = string.Concat(char.ToUpper(s[i]).ToString(), string.Concat(stringsArray[i], new string(char.ToLower(s[i]), i)));
            }

            return string.Join('-', stringsArray);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Accumul.Accum("Caty"));
        }
    }
}
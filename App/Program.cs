using System;
using System.Text;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor " +
                "incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation" +
                " ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit " +
                "in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat " +
                "non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            Console.WriteLine("Replace words less or equals 3: ");  
            string replaceWords = ReplaceWords(lorem);
            Console.WriteLine(replaceWords);

            Console.WriteLine("\nWords in descending lenght: ");
            Print(lorem);

            Console.WriteLine("\nReplace z,c,s to upper case: ");
            string replceZCS = ReplaceZCS(lorem);
            Console.WriteLine(replceZCS);

            Console.WriteLine("\nEvery line in a paragraph: ");
            string paragraps = StringToParagraph(lorem);
            Console.WriteLine(paragraps);

            Console.WriteLine("\nReplace I to same: ");
            string replaceI = ReplaceI(lorem);
            Console.WriteLine(replaceI);

        }

        static string ReplaceI(string str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(str);
            sb.Replace("I", "same");
            return sb.ToString();
        }

        static string StringToParagraph(string str)
        {
            StringBuilder sb = new StringBuilder();
            string res = "";
            while (str != "")
            {
                int index = str.IndexOf('.');
                res = str.Substring(0, index);
                res += ".";
                sb.AppendLine(res);
                str = str.Remove(0, index+1);
            }
            return sb.ToString();
        }

        static string ReplaceZCS(string str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(str);
            sb.Replace('z', 'Z');
            sb.Replace('s', 'S');
            sb.Replace('c', 'C');
            string res = sb.ToString();
            return res;
        }

        static void Print(string str)
        {
            string[] arr = str.Split(new char[] { ' ', '.', ','});

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j].Length < arr[j + 1].Length)
                    {
                        var tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static string ReplaceWords(string str)
        {
            string newWorld = "Secret";
            string[] arr = str.Split(new char[] {' '});
            string res = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length <= 3)
                    arr[i] = newWorld;
               res += $"{arr[i]} ";
            }
            return res;
        }
    }
}

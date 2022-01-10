using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestaoNove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "ABC";

            switch (a)
            {
                case "ABC":
                case "A":
                    {
                        Console.WriteLine("A string tem ABC");
                        break;
                    }
                case "BC":
                    {
                        Console.WriteLine("A string tem BC");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("String fora do padrão");
                        break;
                    }
            }

            
        }
    }
}

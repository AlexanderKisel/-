using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Font
{
    internal class Program
    {
        static bool Prov(string Stroka)
        {
            foreach (char c in Stroka)
            {
                if (int.TryParse(c.ToString(), out var clav) || c == ' ' || c == ',' || c == '.')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {

            Console.SetWindowSize(200, 30);
            Console.SetBufferSize(200, 30);
            Console.Write("Введите любые числа от 0 до 9 (точки, запятые и пробелы являются разделителями): ");
        metka: var input = Console.ReadLine();
            if (!Prov(input))
            {
                Console.WriteLine("По-русски написано ввод от 0 до 9, а также только точки, запятые и пробел, всё, больше ничего не надо вводить, программа в стадии разработки!!!");
                goto metka;
            }
            else
            {
                var Raz = input.Length;
                var widthX = Raz * 10;
                var heightY = 6;
                var x = (Console.WindowWidth / 2) - (widthX / 2);
                var y = (Console.WindowHeight / 2) - (heightY / 2);
                Console.Clear();
                foreach (char c in input)
                {
                    switch (c)
                    {

                        case ('.'):
                            Console.SetCursorPosition(x, y);
                            string[] toch =
                              {"    ",
                               "    ",
                               "    ",
                               "    ",
                               " ██ ",
                               "    "};
                            for (int i = 0; i < toch.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(toch[i]);
                            }
                            x += 3;
                            y = (Console.WindowHeight / 2) - (heightY / 2);
                            break;
                        case (' '):
                            Console.SetCursorPosition(x, y);
                            string[] prob =
                              {"        ",
                               "        ",
                               "        ",
                               "        ",
                               "        ",
                               "        "};
                            for (int i = 0; i < prob.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(prob[i]);
                            }
                            x += 10;
                            y = (Console.WindowHeight / 2) - (heightY / 2);
                            break;
                        case (','):
                            Console.SetCursorPosition(x, y);
                            string[] zap =
                              {"    ",
                               "    ",
                               "    ",
                               "    ",
                               " ██ ",
                               " ██ "};
                            for (int i = 0; i < zap.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(zap[i]);
                            }
                            x += 3;
                            y = (Console.WindowHeight / 2) - (heightY / 2);
                            break;
                        case ('0'):
                            Console.SetCursorPosition(x, y);
                            string[] num0 =
                              {"   ██████  ",
                               " ███    ███",
                               " ███    ███",
                               " ███    ███",
                               "   ██████  ",
                               "           ",};
                            for (int i = 0; i < num0.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(num0[i]);
                            }
                            x += 11;
                            y = (Console.WindowHeight / 2) - (heightY / 2);
                            break;
                        case ('1'):
                            Console.SetCursorPosition(x, y);
                            string[] num1 =
                              {"     ██    ",
                               "   ████    ",
                               "     ██    ",
                               "     ██    ",
                               " ██████████",
                               "           ",};
                            for (int i = 0; i < num1.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(num1[i]);
                            }
                            x += 10;
                            y = (Console.WindowHeight / 2) - (heightY / 2);
                            break;
                        case ('2'):
                            Console.SetCursorPosition(x, y);
                            string[] num2 =
                              {" ████████  ",
                               " ██    ████",
                               "     ██████",
                               "   ████    ",
                               " ██████████",
                               "           ",};
                            for (int i = 0; i < num2.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(num2[i]);
                            }
                            x += 10;
                            y = (Console.WindowHeight / 2) - (heightY / 2);
                            break;
                        case ('3'):
                            Console.SetCursorPosition(x, y);
                            string[] num3 =
                              {" ████████  ",
                               " ██    ████",
                               "     ████  ",
                               " ██    ████",
                               " ████████  ",
                               "           ",};
                            for (int i = 0; i < num3.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(num3[i]);
                            }
                            x += 10;
                            y = (Console.WindowHeight / 2) - (heightY / 2);
                            break;
                        case ('4'):
                            Console.SetCursorPosition(x, y);
                            string[] num4 =
                              {"     ████  ",
                               "   ██████  ",
                               " ████  ██  ",
                               " ██████████",
                               "       ██  ",
                               "           ",};
                            for (int i = 0; i < num4.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(num4[i]);
                            }
                            x += 10;
                            y = (Console.WindowHeight / 2) - (heightY / 2);
                            break;
                        case ('5'):
                            Console.SetCursorPosition(x, y);
                            string[] num5 =
                              {" ██████████",
                               " ██        ",
                               " ██████████",
                               "       ████",
                               " ████████  ",
                               "           ",};
                            for (int i = 0; i < num5.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(num5[i]);
                            }
                            x += 10;
                            y = (Console.WindowHeight / 2) - (heightY / 2);
                            break;
                        case ('6'):
                            Console.SetCursorPosition(x, y);
                            string[] num6 =
                              {"   ██████  ",
                               " ████      ",
                               " ██████████",
                               " ████  ████",
                               "   ██████  ",
                               "           ",};
                            for (int i = 0; i < num6.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(num6[i]);
                            }
                            x += 10;
                            y = (Console.WindowHeight / 2) - (heightY / 2);
                            break;
                        case ('7'):
                            Console.SetCursorPosition(x, y);
                            string[] num7 =
                              {" ██████████ ",
                               " ██      ██ ",
                               "       ████ ",
                               "     ████   ",
                               "     ██     ",
                               "            ",};
                            for (int i = 0; i < num7.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(num7[i]);
                            }
                            x += 10;
                            y = (Console.WindowHeight / 2) - (heightY / 2);
                            break;
                        case ('8'):
                            Console.SetCursorPosition(x, y);
                            string[] num8 =
                              {"   ██████  ",
                               " ████  ████",
                               "   ██████  ",
                               " ████  ████",
                               "   ██████  ",
                               "           ",};
                            for (int i = 0; i < num8.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(num8[i]);
                            }
                            x += 11;
                            y = (Console.WindowHeight / 2) - (heightY / 2);
                            break;
                        case ('9'):
                            Console.SetCursorPosition(x, y);
                            string[] num9 =
                              {"   ██████  ",
                               " ████  ████",
                               " ██████████",
                               "       ████",
                               "   ██████  ",
                               "           ",};
                            for (int i = 0; i < num9.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(num9[i]);
                            }
                            x += 10;
                            y = (Console.WindowHeight / 2) - (heightY / 2);
                            break;
                    }
                }
                Console.ReadKey();
            }
            Console.WriteLine("\n\n\n\n\n\n\n\n");
        }
    }
}
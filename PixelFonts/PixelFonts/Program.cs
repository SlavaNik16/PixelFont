

using System;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters;

namespace PixelFonts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 0 до 9: ");
            var number = Console.ReadLine();
            bool run = int.TryParse(number, out int num);
            int[] nums = new int[10];
            Count c = new Count();
            int x = (Console.WindowWidth) / 8;
            int y = (Console.WindowHeight) / 3;
            Console.SetCursorPosition(x, y);
            c.Conv(ref nums, num);
            if (run)
            {
                while (c.i >= 0)
                {
                    Console.SetCursorPosition(x, y);
                    switch (nums[c.i])
                    {

                        case 1:                         
                            Console.Write(c.Len(1, '█'));
                            Console.SetCursorPosition(x+=2, y++);
                            for (int j = 0; j <= 6; j++,Console.SetCursorPosition(x, y++))
                            {
                                Console.WriteLine(c.Len(1, '█'));
                            }
                            Console.SetCursorPosition(x-=2, y-=2);
                            Console.WriteLine(c.Len(3, '█'));
                            c.i--;
                            x+= 8;
                            y = 10;
                            break;

                        case 2:
                            c.Dva_Tri_Sem_start(ref x, ref y);
                            Console.SetCursorPosition(x-=4,--y);
                            Console.WriteLine(c.Len(2, '█'));
                            Console.SetCursorPosition(x, ++y);
                            for (int j = 0; j < 3; j++, Console.SetCursorPosition(x, ++y))
                            {
                                Console.Write(c.Len(1, '█'));
                            }
                            Console.SetCursorPosition(x, --y);
                            Console.WriteLine(c.Len(3, '█'));

                            x += 8;
                            y = 10;
                            c.i--;
                            break;

                        case 3:
                            c.Dva_Tri_Sem_start(ref x, ref y);
                            Console.SetCursorPosition(x-=2, --y);
                            Console.WriteLine(c.Len(1, '█'));
                            Console.SetCursorPosition(x+=2,++y);
                            for (int j = 0; j < 2; j++, Console.SetCursorPosition(x, ++y))
                            {
                                Console.Write(c.Len(1, '█'));
                            }
                            Console.SetCursorPosition(x -= 4, --y);
                            Console.WriteLine(c.Len(1, '▄'));
                            Console.SetCursorPosition(x, ++y);
                            Console.WriteLine(c.Len(3, '█'));
                            x += 8;
                            y = 10;
                            c.i--;
                            break;

                        case 4:
                            for(int j = 0; j < 3; j++, Console.SetCursorPosition(x, ++y))
                            {
                                Console.WriteLine(c.Len(1, '█'));
                            }
                            Console.WriteLine(c.Len(2, '█'));
                            Console.SetCursorPosition(x+=4, y-=3);
                            for (int j = 0; j < 7; j++, Console.SetCursorPosition(x, ++y))
                            {
                                Console.Write(c.Len(1, '█'));
                            }

                            x += 4;
                            y = 10;
                            c.i--;
                            break;

                        case 5:
                            Console.Write(c.Len(2, '█'));
                            for (int j = 0; j < 3; j++, Console.SetCursorPosition(x, ++y))
                            {
                                Console.WriteLine(c.Len(1, '█'));
                            }
                            Console.WriteLine(c.Len(2, '█'));
                            Console.SetCursorPosition(x+=4, y);
                            for (int j = 0; j < 3; j++, Console.SetCursorPosition(x, ++y))
                            {
                                Console.Write(c.Len(1, '█'));
                            }
                            c.Dva_Tri_Sem_end(ref x, ref y);

                            x += 8;
                            y = 10;
                            c.i--;
                            break;

                        case 6:
                            Console.Write(c.Len(3, '█'));
                            Console.SetCursorPosition(x+=4, ++y);
                            Console.Write(c.Len(1, '▀'));
                            
                            Console.SetCursorPosition(x -= 4, --y);
                            for (int j = 0; j < 6; j++, Console.SetCursorPosition(x, ++y))
                            {
                                Console.Write(c.Len(1, '█'));
                            }
                            Console.Write(c.Len(2, '█'));
                            Console.SetCursorPosition(x += 4, y);
                            for (int j = 0; j < 3; j++, Console.SetCursorPosition(x, --y))
                            {
                                Console.Write(c.Len(1, '█'));
                            }
                            Console.SetCursorPosition(x-=2, y);
                            Console.Write(c.Len(2, '█'));
                            x += 6;
                            y = 10;
                            c.i--;
                            break;

                        case 7:
                            c.Dva_Tri_Sem_start(ref x, ref y);
                            
                            for (int j = 0; j < 3; j++, Console.SetCursorPosition(x, ++y))
                            {
                                Console.Write(c.Len(1, '█'));
                            }
                     
                            x += 4;
                            y = 10;
                            c.i--;
                            break;

                        case 8:

                            for (int j = 0; j < 6; j++, Console.SetCursorPosition(x, ++y))
                            {
                                Console.Write(c.Len(1, '█'));
                            }
                            Console.Write(c.Len(3, '█'));
                            Console.SetCursorPosition(x, y-=6);
                            Console.Write(c.Len(2, '█'));
                            Console.SetCursorPosition(x+=4, y);
                            for (int j = 0; j < 6; j++, Console.SetCursorPosition(x, ++y))
                            {
                                Console.Write(c.Len(1, '█'));
                            }
                            Console.SetCursorPosition(x -=2, y-=3);
                            Console.Write(c.Len(1, '█'));
                            x += 6;
                            y = 10;
                            c.i--;
                            break;
                        case 9:

                            for (int j = 0; j < 3; j++, Console.SetCursorPosition(x, ++y))
                            {
                                Console.Write(c.Len(1, '█'));
                            }
                            Console.Write(c.Len(2, '█'));
                            Console.SetCursorPosition(x+=2, y -= 3);
                            Console.Write(c.Len(1, '█'));
                            Console.SetCursorPosition(x+=2, y);
                            for (int j = 0; j < 6; j++, Console.SetCursorPosition(x, ++y))
                            {
                                Console.Write(c.Len(1, '█'));
                            }

                            c.Dva_Tri_Sem_end(ref x, ref y);
                            x += 8;
                            y = 10;
                            c.i--;
                            break;

                        default:
                            for(int j = 0; j < 6; j++, Console.SetCursorPosition(x, ++y))
                            {
                                Console.Write(c.Len(1, '█'));
                            }
                            Console.Write(c.Len(3, '█'));
                            Console.SetCursorPosition(x, y -= 6);
                            Console.Write(c.Len(2, '█'));
                            Console.SetCursorPosition(x += 4, y);
                            for (int j = 0; j < 6; j++, Console.SetCursorPosition(x, ++y))
                            {
                                Console.Write(c.Len(1, '█'));
                            }
                            x += 4;
                            y = 10;
                            c.i--;
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Введенно не число!");
            }
            Console.SetCursorPosition(x, y);

            Console.ReadKey();
        }
    }
}

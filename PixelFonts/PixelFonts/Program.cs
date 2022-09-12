

using System;


namespace PixelFonts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 0 до 9 со знаками разделителями(Пробел, точкой, запятой): ");
            var number = Console.ReadLine();
            int[] nums = new int[20];
            Count c = new Count();
            c.Score(ref nums, number);
            int x = (Console.WindowWidth) / 8;
            int y = (Console.WindowHeight) / 3;
            Console.SetCursorPosition(x, y);
            int q = 0;
            while (q <= c.i)
            {
                Console.SetCursorPosition(x, y);
                switch (nums[q])
                {
                    case 1:
                        Console.Write(c.Len(1, '█'));
                        Console.SetCursorPosition(x += 2, y++);
                        for (int j = 0; j <= 6; j++, Console.SetCursorPosition(x, y++))
                        {
                            Console.WriteLine(c.Len(1, '█'));
                        }
                        Console.SetCursorPosition(x -= 2, y -= 2);
                        Console.WriteLine(c.Len(3, '█'));
                        x += 8;
                        y = 10;
                        q++;
                        break;

                    case 2:
                        c.Dva_Tri_Sem_start(ref x, ref y);
                        Console.SetCursorPosition(x -= 4, --y);
                        Console.WriteLine(c.Len(2, '█'));
                        Console.SetCursorPosition(x, ++y);
                        c.drawfor(ref x, ref y);
                        Console.SetCursorPosition(x, --y);
                        Console.WriteLine(c.Len(3, '█'));
                        x += 8;
                        y = 10;
                        q++;
                        break;

                    case 3:
                        c.Dva_Tri_Sem_start(ref x, ref y);
                        Console.SetCursorPosition(x -= 2, --y);
                        Console.WriteLine(c.Len(1, '█'));
                        Console.SetCursorPosition(x += 2, ++y);
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
                        q++;
                        break;

                    case 4:
                        c.drawfor(ref x, ref y);
                        Console.WriteLine(c.Len(2, '█'));
                        Console.SetCursorPosition(x += 4, y -= 3);
                        for (int j = 0; j < 7; j++, Console.SetCursorPosition(x, ++y))
                        {
                            Console.Write(c.Len(1, '█'));
                        }
                        x += 4;
                        y = 10;
                        q++;
                        break;

                    case 5:
                        Console.Write(c.Len(2, '█'));
                        c.drawfor(ref x, ref y);
                        Console.WriteLine(c.Len(2, '█'));
                        Console.SetCursorPosition(x += 4, y);
                        c.drawfor(ref x, ref y);
                        c.Dva_Tri_Sem_end(ref x, ref y);
                        x += 8;
                        y = 10;
                        q++;
                        break;

                    case 6:
                        Console.Write(c.Len(3, '█'));
                        Console.SetCursorPosition(x += 4, ++y);
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
                        Console.SetCursorPosition(x -= 2, y);
                        Console.Write(c.Len(2, '█'));
                        x += 6;
                        y = 10;
                        q++;
                        break;

                    case 7:
                        c.Dva_Tri_Sem_start(ref x, ref y);
                        c.drawfor(ref x, ref y);
                        x += 4;
                        y = 10;
                        q++;
                        break;

                    case 8:
                        for (int j = 0; j < 6; j++, Console.SetCursorPosition(x, ++y))
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
                        Console.SetCursorPosition(x -= 2, y -= 3);
                        Console.Write(c.Len(1, '█'));
                        x += 6;
                        y = 10;
                        q++;
                        break;
                    case 9:
                        c.drawfor(ref x, ref y);
                        Console.Write(c.Len(2, '█'));
                        Console.SetCursorPosition(x += 2, y -= 3);
                        Console.Write(c.Len(1, '█'));
                        Console.SetCursorPosition(x += 2, y);
                        for (int j = 0; j < 6; j++, Console.SetCursorPosition(x, ++y))
                        {
                            Console.Write(c.Len(1, '█'));
                        }
                        c.Dva_Tri_Sem_end(ref x, ref y);
                        x += 8;
                        y = 10;
                        q++;
                        break;

                    case -1:
                        x += 4;
                        y = 10;
                        q++;
                        break;

                    case -2:
                        Console.SetCursorPosition(x, y += 6);
                        Console.Write(c.Len(1, '█'));
                        x += 4;
                        y = 10;
                        q++;
                        break;

                    case -3:
                        Console.SetCursorPosition(x, y+=6);
                        Console.Write(c.Len(1, '█'));
                        Console.SetCursorPosition(x, ++y);
                        Console.Write(c.Len(1, '█'));
                        x += 4;
                        y = 10;
                        q++;
                        break;

                    default:
                        for (int j = 0; j < 6; j++, Console.SetCursorPosition(x, ++y))
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
                        q++;
                        break;
                }
            }
            Console.SetCursorPosition(x, y);
            Console.ReadKey();
        }
    }
}

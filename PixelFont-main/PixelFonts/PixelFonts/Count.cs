using System;
using System.Collections.Generic;
namespace PixelFonts
{
     class Count
    {
        public int len;
        public int i;
        public string str;
        public int shift;
        public Count()
        {
            i = 0;
            len = 0;
            shift = 0;
        }
        public string Len(int Length, char sim)
        {
            len = Length * 2;
            str = new string(sim, len);
            return str;
        }
        public void Score(ref int[] nums, string number)
        {
            foreach (char all in number)
            {
                if (all == ' ')
                {
                    nums[i] = -1;
                    shift += 4;
                }
                else if (all == '.')
                {
                    nums[i] = -2;
                    shift += 4;
                }
                else if (all == ',')
                {
                    nums[i] = -3;
                    shift += 4;
                }
                else
                {
                    try
                    {
                        nums[i] = int.Parse(char.ToString(all));
                        shift += 5;
                    }
                    catch (FormatException)
                    {
                        Environment.Exit(0);
                    }
                }
                i++;
            }
            i--;
        }
        public void drawfor(ref int x, ref int y)
        {
            for (int j = 0; j < 3; j++, Console.SetCursorPosition(x, ++y))
            {
                Console.Write(Len(1, '█'));
            }
        }
        public void Dva_Tri_Sem_start(ref int x, ref int y)
        {
            Console.SetCursorPosition(x, ++y);
            Console.WriteLine(Len(1, '▀'));
            Console.SetCursorPosition(x, --y);
            Console.WriteLine(Len(3, '█'));
            Console.SetCursorPosition(x += 4, ++y);
            for (int j = 0; j < 3; j++, Console.SetCursorPosition(x, ++y))
            {
                Console.WriteLine(Len(1, '█'));

            }
        }
        public void Dva_Tri_Sem_end(ref int x, ref int y)
        {
            Console.SetCursorPosition(x -= 4, y);
            Console.Write(Len(3, '█'));
            Console.SetCursorPosition(x, --y);
            Console.Write(Len(1, '▄'));

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PixelFonts
{
     class Count
    {
        public int result;
        public int i;
        public int len;
        public string str; 

        public Count()
        {
            result = 0;
            i = 0;
            len = 0;
        }
       
        public void Conv(ref int[] nums, int num)
        {
            do
            {
                result = num % 10;
                nums[i] = result;
                num /= 10;
                i++;
            }
            while (num > 0);
            i--;
        }

        public string Len(int Length, char sim)
        {
            len = Length * 2;
            str = new string(sim, len);
            return str;
        }

        public void Dva_Tri_Sem_start(ref int x,ref int y)
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

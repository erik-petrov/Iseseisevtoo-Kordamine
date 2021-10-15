using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPetrov
{
    class Tasks
    {
        public static void Ex1()
        {
            Console.Write("Sisesta lause: ");
            string text = Console.ReadLine();
            //разделяем предложение по словам, поскольку между словами ставится пробел(но не после), пробелов -1
            string[] texts = text.Split(' ');
            Console.WriteLine($"Lause sisaldab: {texts.Length} sõnad ja {texts.Length-1} lüngad.");
        }

        public static void Ex2()
        {
            int[] nums = { 1, 6, 4, 3, 7, 4, 9, 9, 7, 6 };
            int len1 = 0, len2 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    len1 += 1;
                }
                else
                {
                    len2 += 1;
                }
            }
            int[] numsOdd = new int[len1];
            int[] numsEven = new int[len2];
            int k = 0, j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    numsEven[k] = nums[i];
                    k += 1;
                }
                else
                {
                    numsOdd[j] = nums[i];
                    j += 1;
                }
            }
            Array.Sort(numsOdd);
            Array.Sort(numsEven);
            foreach (var item in numsOdd)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            foreach (var item in numsEven)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        } 

        public static void Ex3()
        {
            Random rnd = new Random();
            int num = rnd.Next(10, 99999999);
            string t1 = "", t2 = "";
            Console.Write($"Teie number: {num}");
            Console.WriteLine();
            //число в массив
            int[] result = num.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            int[] temp = new int[result.Length];
            Array.Copy(result, temp, result.Length);
            Array.Reverse(temp);
            for (int i = 0; i < result.Length; i++)
            {
                t1 += result[i];
                t2 += temp[i];
            }
            if (t1 == t2)
            {
                Console.WriteLine("Sinu number on õnnelik");
            }
            else { Console.WriteLine("Sinu number ei ole õnnelik"); }
        }
        public static void ex4()
        {

        }
    }
}

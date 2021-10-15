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
            int[] nums = {1,5,4,6,45,6,546,45,64,56,456,4,564,56,4,2,45,43,45,2,64,575,67};
            List<int> numsOdd = new List<int>();
            List<int> numsEven = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    numsEven.Add(nums[i]);
                } else
                {
                    numsOdd.Add(nums[i]);
                }
            }
            int[] numsOddAr = numsOdd.ToArray();
            int[] numsEvenAr = numsEven.ToArray();
            Array.Sort(numsOddAr);
            Array.Sort(numsEvenAr);
            foreach (var item in numsOddAr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            foreach (var item in numsEvenAr)
            {
                Console.Write($"{item} ");
            }
        } 

        public static void Ex3()
        {
            Random rnd = new Random();
            int num = rnd.Next(10, 99999999);
            Console.Write($"Teie number: {num}");
            //число в массив
            int[] result = num.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            if (result.Length == 4)
            {
                Console.WriteLine("Sinu number on õnnelik");
            }
            else { Console.WriteLine("Sinu number ei ole õnnelik"); }
        }
    }
}

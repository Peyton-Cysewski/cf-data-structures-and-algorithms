using System;

namespace ArrayShift
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine($"{Math.Ceiling((decimal)4 / (decimal)2)}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int[] insertShiftArray(int[] array, int num)
        {
            int[] newArray = new int[array.Length + 1];
            for (int i = 0, j = 0; i < newArray.Length; i++, j++)
            {
                if (i == (int)Math.Ceiling((decimal)array.Length / (decimal)2))
                {
                    j--;
                    newArray[i] = num;
                }
                else
                {
                    newArray[i] = array[j];
                }
            }
            return newArray;
        }
    }
}

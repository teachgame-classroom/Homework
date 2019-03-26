using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_190325
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new int[100];

            //for(int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = (int)((i - 50) * (i - 50) * 0.02f + (i - 50));
            //    Console.Write(i + ":" + nums[i] + " ");
            //}

            //Sort(nums);

            QuestionOne(10, 35, 3);
            QuestionTwo();
            QuestionThree(46);
            QuestionThree(15);
            QuestionThree(3);
            QuestionThree(5);
            QuestionThree(38);
            int[] result = QuestionFour(20000);

            for(int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }

            Console.Read();
        }

        static void QuestionOne(int a, int b, int c)
        {
            int[] nums = new int[] { a, b, c };
            Sort(nums);
        }

        static void Sort(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int t = i + 1; t < nums.Length; t++)
                {
                    if (nums[i] > nums[t])
                    {
                        Console.WriteLine("第{0}个位置是{1}，第{2}个位置是{3}，交换位置", i, nums[i], t, nums[t]);
                        //Console.Read();
                        int temp = nums[i];
                        nums[i] = nums[t];
                        nums[t] = temp;

                        Console.WriteLine("交换完成：第{0}个位置是{1}，第{2}个位置是{3}", i, nums[i], t, nums[t]);
                        //Console.Read();
                    }
                    else
                    {
                        Console.WriteLine("第{0}个位置是{1}，第{2}个位置是{3}，不必交换", i, nums[i], t, nums[t]);
                    }
                }
            }

            Console.WriteLine("排序结果：");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }

            Console.Write('\n');
        }

        static void QuestionTwo()
        {
            int result = 0;

            for(int i = 1; i <= 100; i++)
            {
                result += i;
                Console.WriteLine(i + ":" + result);
            }
        }

        static bool QuestionThree(int num)
        {
            bool canBeDividedBy3 = false;   // “能被3整除”布尔值
            bool canBeDividedBy5 = false;   // “能被5整除”布尔值

            if(num % 3 == 0)
            {
                canBeDividedBy3 = true;
            }

            if(num % 5 == 0)
            {
                canBeDividedBy5 = true;
            }

            bool canBeDividedByBoth = canBeDividedBy3 && canBeDividedBy5;   // 逻辑与
            bool canBeDividedByAny =  canBeDividedBy3 || canBeDividedBy5;   // 逻辑或

            Console.WriteLine(num);
            Console.WriteLine("能被3整除：" + canBeDividedBy3);
            Console.WriteLine("能被5整除：" + canBeDividedBy5);
            Console.WriteLine("既能被3整除，也能被5整除：" + canBeDividedByBoth);
            Console.WriteLine("能被3或者5整除：" + canBeDividedByAny);
            return canBeDividedByBoth;
        }

        static int[] QuestionFour(int range)
        {
            if(range > 0)
            {
                List<int> result = new List<int>();
                result.Add(1);

                for (int i = 2; i < range; i++)
                {
                    bool flag = false;

                    for(int t = 2; t < i; t++)
                    {
                        if(i % t == 0)
                        {
                            flag = true;
                        }
                    }

                    if(flag == false)
                    {
                        result.Add(i);
                    }
                }

                return result.ToArray();
            }
            else
            {
                return null;
            }
        }
    }
}

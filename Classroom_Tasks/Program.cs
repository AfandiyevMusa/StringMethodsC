using System;
using System.Text;
using Internal;

namespace Classroom_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task_001

            string example1 = "Mathematics";

            if (example1.Contains("a"))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            //Task_002

            string example2 = "Hello World";
            string example3 = "Hello";
            Console.WriteLine(example2.CompareTo(example3));

            ////Task_003
            Console.WriteLine(example2.Clone());

            ////Task_004
            Console.WriteLine(example3.Insert(5, " CodeAcademy"));

            ////Task_005
            Console.WriteLine(example3.Substring(1, 3));




            ////Task_1 (10----10)

            //int a = 10;
            //int b = a;
            //Console.WriteLine(a + "----" + b);

            ////Task_2 (10----20)

            //int a = 10;
            //int b = a;
            //b = 20;
            //Console.WriteLine(a + "----" + b);

            ////Task_3 (1----1)

            //int[] arr1 = { 1, 3, 5, 7, 9 };
            //int[] arr2 = arr1;
            //Console.WriteLine(arr1[0] + " ---- " + arr2[0]);

            ////Task_4 (30 ---- 30)

            //int[] arr1 = { 1, 3, 5, 7, 9 };
            //int[] arr2 = arr1;
            //arr2[0] = 30;
            //Console.WriteLine(arr1[0] + " ---- " + arr2[0]);

            ////Task_5 (101 1)

            //int num = 1;
            //ShowNum(num);
            //Console.WriteLine(num);

            ////Task_6 (1 106 6)

            //int num = 1;
            //Console.WriteLine(num);

            //num += 5;
            //ShowNum(num);
            //Console.WriteLine(num);

            ////Task_7 (101 101)

            //int num = 1;
            //ShowNum(ref num);
            //Console.WriteLine(num);

            ////Task_8 (50 65 100)

            //int num;
            //ShowNum(out num);
            //num += 35;
            //Console.WriteLine(num);

            ////Task_9 (Murad)

            //string name1 = "Musa";
            //name1 = "Murad";
            //Console.WriteLine(name1);

            ////Task_10 (Musa Murad)

            //string name1 = "Musa";
            //string name2 = name1;
            //name2 = "Murad";
            //Console.WriteLine(name1);
            //Console.WriteLine(name2);

            ////Task_11 (Physics Math)

            //string name = "Math";
            //CheckString(name);
            //Console.WriteLine(name);

            ////Task_12 (Physics Physics)

            //string name = "Math";
            //CheckString(ref name);
            //Console.WriteLine(name);

            ////Task_13 (Physics)

            //StringBuilder str = new StringBuilder();

            //str.Append("Phys");
            //str.Append("ics");
            //Console.WriteLine(str);

            ////Task_14 (Hello World)

            //string example = "      Hello World";
            //Console.WriteLine(example.Trim());

            ////Task_15 (yes)

            //string example = "Physics";
            //Console.WriteLine(example.StartsWith("P"));

            ////Task_16 (yes)

            //string example = "Physics";
            //Console.WriteLine(example.EndsWith("s"));

            ////Task_17 (physics)

            //string example = "PHYSICS";
            //Console.WriteLine(example.ToLower());

            ////Task_18 (Yes)

            //string example = "Physics";
            //if (example.ToLower().StartsWith("p"))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            ////Task_19, Task_20, Task_21

            //string example = "Mathe matics";
            //Console.WriteLine(example.IndexOf("a"));

            //Console.WriteLine(example.LastIndexOf("a"));

            //Console.WriteLine(example.Replace("Mathematics", "Physics"));

            //Console.WriteLine(example.Remove(1));
            //Console.WriteLine(example.Remove(1, 5));

            ////var result = example.Split(" ");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////Task_22

            //string example = "Math";

            //if (string.IsNullOrEmpty(example))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            ////Task_23

            //string example2 = null;

            //if (string.IsNullOrWhiteSpace(example2))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

        }
            ////Task_5 and Task_6

            //public static void ShowNum(int num)
            //{
            //    num += 100;
            //    Console.WriteLine(num);
            //}

            ////Task_7

            //public static void ShowNum(ref int num)
            //{
            //    num += 100;
            //    Console.WriteLine(num);
            //}

            ////Task_8

            //public static void ShowNum(out int num)
            //{
            //    num = 50;
            //    num += 15;
            //    Console.WriteLine(num);
            //}

            ////Task_11 and Task_12

            //public static void CheckString(ref string str)
            //{
            //    str = "Physics";
            //    Console.WriteLine(str);
            //}
    }

}
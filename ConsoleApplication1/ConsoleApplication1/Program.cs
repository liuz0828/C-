using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;//为计时器新加项

namespace ConsoleApplication1
{
    class Program
    {

        //static string TestFunc()  //方法
        //{

        //    return "123";

        //} 

        static void Main(string[] args)
        {
            
 
//计时器
            //Stopwatch 计时器 = new Stopwatch();
            //计时器.Start();

            //string str = string.Empty;

            //for (int i = 0; i < 10000; i++)
            //{
            //    str += i.ToString();

            //}

            //StringBuilder sb = new StringBuilder();//效率提高

            //for (int i = 0; i < 10000; i++)
            //{

            //    sb.Append(i.ToString());

            //}



            //计时器.Stop();
            //Console.WriteLine(计时器.ElapsedMilliseconds);

//转义符
            //double num = 1.123456789;
            //bool isCool = true;
            //string str1 = "111\n222";
            //string str2 = "333\t444";
            //string str2 = "333\\444";
            //string str2 = "333\"444";
            //string str2 = @"\\192.9.204.8\Projects\Projects019\QZA\qzadflts\Hanger";//@忽略转义符
            //str2 = str2.ToUpper();//返回str2

            //sring str = null;

            //int? number = null;

            //var number = 1;  //隐式类型

            //int a = 1;
            //long b = 123546789;

            //a = (int)b;

            //int a;

            //checked 
            //{
            //    a = int.MaxValue;
            //    a = a + 1;
            //}


            //var str1 = Console.ReadLine();
            ////var str2 = Console.ReadLine();

            //int a1;

            ////int a1 = int.Parse(str1);

            //if (int.TryParse(str1, out a1))
            //{
            //    Console.WriteLine(a1);
            //}
            //else
            //{
            //    Console.WriteLine("解析失败");
            //}

            ////int a2 = int.Parse(str2);


            //Console.WriteLine(a1 + a2);
            //Console.WriteLine(str2);
            //Console.ReadLine();

            //int a = 10%3;    //余数

            //Console.WriteLine(a);

//自加1
            //int a = 10;
            //int b;

            //b = ++a;
            //b = a++;

            //a = a + 1;
            //a ++;
            //a += 1;

//if分支用法

            //int a = int.Parse(Console.ReadLine());

            //if (a > 10)
            //{
            //    Console.WriteLine("a大于10");
            //}
            //else
            //{
            //    if (a == 10)
            //    {
            //        Console.WriteLine("a等于10");
            //    }
            //    else
            //    {
            //        Console.WriteLine("a小于10");
            //    }



            //Console.WriteLine("a小于等于10");
            //}

//switch用法

            //int a = int.Parse(Console.ReadLine());



            //switch (a)
            //{

            //    case 1: Console.WriteLine("数字1"); break;
            //    case 2: Console.WriteLine("数字2"); break;
            //    default: Console.WriteLine("wrong number"); break;

            //}

            //string a = Console.ReadLine();

            //switch (a)
            //{

            //    case "a": Console.WriteLine("字母a"); break;
            //    case "1": Console.WriteLine("数字1"); break;
            //    default: Console.WriteLine("wrong"); break

            //}

//布尔运算 || 或  && 且

            //bool exp = 1 == 2 && 1 > 2;  //1 >= 2 || 或  && 且
            //bool exp = !(1 == 2 && 1 > 2);  // !求反


//空接合运算符
            //string fileName = null;

            //fileName = fileName ?? "default.txt";//空接合运算符

            //Console.WriteLine(fileName);

//练习
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());



            //a > b ? (a>c ? a : c) : (b>c ? b : c)

            //bool isAGreaterThanB = a > b;

            //if (isAGreaterThanB)
            //{
            //    Console.WriteLine("{0}>{1}",a,b);   //{0}占位符
            //}
            //else
            //{
            //    Console.WriteLine("{0}<={1}", a, b);
            //}


            //Console.WriteLine("最大数是{0}",a > b ? a : b); //加{0} 同时输出文字和变量值

            //Console.WriteLine("最大数是{0}",a > b ? (a > c ? a : c) : (b > c ? b : c));//三个数取最大

            //Console.WriteLine(a);
            //Console.WriteLine(b);

//以下是循环练习
            //int a1 = 1;
            //int a2 = 1;

            //int a3 = a2 + a1;
            //int a4 = a3 + a2;
            //int a5 = a4 + a3;

            //const int N = 51; //定义常量 只需修改值 

            ////int[] a = new int[N];
            //long[] a = new long[N];
            
            //a[1] = 1;
            //a[2] = 1;

//while循环写法   
         
            //int i = 3;

            //while(i !=N)
            //{
            //    a[i] = a[i - 1] + a[i - 2];
            //    i++;
            //}


            //i = 1;
            //while(i != N)
            //{

            //    Console.WriteLine(a[i]);
            //     i++;

            //}

//for循环写法

            //for (int i = 3; i != N; i++)
            //{
            //    a[i] = a[i - 1] + a[i - 2];
            //}



            //for (int i = 1; i != N; i++)
            //{

            //   Console.WriteLine(a[i]);

            //}


//foreach循环写法 和生成随机数代码

            //const int N = 50; //定义常量 只需修改值 
            
            //long[] a = new long[N];

            //var r = new Random();
            //for (int i = 0; i < N; i++)
            //{

            //    //a[i] = r.Next(1, 10);  //1~10的随机数
            //    //a[i] = r.Next()%10;     //0~9的随机数
               
            //}
          

            //foreach(long x in a)
            //{
            //    Console.WriteLine(x);
            //}

//1~49求和
            //const int N = 50; //定义常量 只需修改值 

            //long[] a = new long[N];

            //for (int i = 0; i < N; i++)
            //{
                
            //    a[i] = i;
            //}

            //long sum = 0;
            //for (int i = 0; i < N; i++)
            //{

            //    //sum = sum + a[i];
            //    sum += a[i];
            //}


            //Console.WriteLine(sum);

//输出最大值

            //const int N = 50; //定义常量 只需修改值 

            //int[] a = new int[N];

            //var r = new Random();

            //for (int i = 0; i < N; i++)
            //{

            //    a[i] = r.Next();
            //}

            //int max = a[0];
            //for (int i = 0; i < N; i++)
            //{

            //    if(a[i] > max)
            //    {
            //    max = a[i];
            //    }
            //}


            //Console.WriteLine(max);

            //Console.WriteLine();

            //foreach(long x in a)
            //{
            //    Console.WriteLine(x);
            //}

           

//查找50

            //const int N = 50; //定义常量 只需修改值 

            //int[] a = new int[N];

            //var r = new Random();

            //for (int i = 0; i < N; i++)
            //{

            //    a[i] = r.Next(1,101);
            //}

            //int num = 50;
            //for (int i = 0; i < N; i++)
            //{

            //    if (a[i] == num)
            //    {
            //        Console.WriteLine("{0}这个数字存在", num);
            //        break;
            //    }
               
            
            //}

            //Console.WriteLine();

            //foreach(long x in a)
            //{
            //    Console.WriteLine(x);
            //}

//排序

            //const int N = 20; //定义常量 只需修改值 

            //int[] a = new int[N];

            //var r = new Random();

            //for (int i = 0; i < N; i++)
            //{

            //    a[i] = r.Next(1, 11);
            //    Console.WriteLine(a[i]);
            //}

            //int temp;
            //for (int i = 0; i < N; i++)
            //{

            //    for (int j = i + 1; j < N; j++)
            //    {
            //        if (a[i] > a[j])
            //        {
            //            temp = a[j]; a[j] = a[i]; a[i] = temp;//数据替换
            //        }
            //    }


            //}

            //Console.WriteLine();

            //foreach (long x in a)
            //{
            //    Console.WriteLine(x);
            //}

//1/2+2/3....+99/100

            //const int N = 99; //定义常量 只需修改值 

            //double[] a = new double[N];

            //double sum = 0;

            //for (double i = 1; i <= 99; i++)
            //{

            //    sum += i / (i + 1);

            //}

            //for (int i = 1; i <= 99; i++)
            //{

            //    sum +=(double)i / (i + 1);//提升成double

            //}

            //Console.WriteLine(sum);

//预处理指令         
            //#region 预计算

            //double sum = 0;
            //for (double i = 1; i <= 99; i++)
            //{

            //    sum += i / (i + 1);

            //}

            //Console.WriteLine(sum);

            //#endregion


//list

            //var nums = new List<int>();
            //nums.Add(3);
            //nums.Add(2);
            //nums.Add(1);


            //Console.WriteLine(nums.Max());  //最大值

//排序    //nums.Sort();

            //foreach(var num in nums)
            //{
            //if (num !=2) continue;    //结果只有2被输出
            //if (num ==1) break;       //结果只有3 2被输出
            //Console.WriteLine(num);
            //}

//方法和参数            

            //TestFunc();

            //Console.WriteLine(TestFunc());

            Console.Read();


        }



        

    }
}

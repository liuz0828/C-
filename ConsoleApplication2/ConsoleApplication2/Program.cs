using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        //方法和参数

        //求平均值
        //static double Average(List<int> list)  //形式参数
        //{
        //    int sum = 0;
        //    foreach (var l in list)
        //    {
        //        sum += l;

        //    }

        //    return (double)sum/list.Count;
        //}
        //static void Main(string[] args)
        //{
        //    var list = new List<int>();
        //    list.Add(1);
        //    list.Add(2);
        //    list.Add(3);


        //    Console.WriteLine(Average(list));  //实际参数

        //    Console.Read();

        //}


        //传值 传引用

        //static void Swap(ref int a,ref int b)  
        //{

        //    int t;
        //    t = a; a = b; b = t;

        //}
        //static void Main(string[] args)
        //{

        //    int a = 1;
        //    int b = 2;

        //    Swap(ref a, ref b);

        //    Console.WriteLine("a={0} b={1}",a,b);  

        //    Console.Read();

        //}

        //str 传引用    基本类型加ref   list等引用类型不加ref

        //static void Add(ref string str)
        //{

        //    str += "!";


        //}
        //static void Main(string[] args)
        //{

        //    string str = "123";

        //    Add(ref str);

        //    Console.WriteLine(str);

        //    Console.Read();

        //}

 //重载


        //static void Swap(ref int a,ref int b)  
        //{

        //    int t;
        //    t = a; a = b; b = t;

        //}

        //static void Swap(ref string a, ref string b)
        //{

        //    string t;
        //    t = a; a = b; b = t;

        //}
        //static void Main(string[] args)
        //{

                                  
        //    string a = "abc";
        //    string b = "123";

        //    Swap(ref a, ref b);

        //    Console.WriteLine("a={0} b={1}", a, b);

        //    Console.Read();

        //}


//泛型 <>


        //static void Swap<T>(ref T a, ref T b)
        //{

        //    T t;
        //    t = a; a = b; b = t;

        //}

       
        //static void Main(string[] args)
        //{


        //    string a = "abc";
        //    string b = "123";

        //    Swap<string>(ref a, ref b);

        //    Console.WriteLine("a={0} b={1}", a, b);

        //    Console.Read();

        //}


//可变参数


        //static int Sum(params int[] nums)
        //{

        //    return nums.Sum();

        //}


        //static void Main(string[] args)
        //{


        //    Console.WriteLine(Sum(1,2,3,4,5));

        //    Console.Read();

        //}

 //斐波那契数列

        //static long Fib(long n)   
        //{

        //    if (n == 1 || n == 2) return 1;  //如果是void 直接return

        //    return Fib(n - 1) + Fib(n - 2);

        //}
        


        //static void Main(string[] args)
        //{

        //    for (int i = 1; i <= 10; i++)
        //    {


        //        Console.WriteLine(Fib(i));

        //    }
            

        //    Console.Read();

        //}


//统计文件数  异常

        //static long FileOrDirCount(string path,bool isDir,bool isFile,string extension="dxf")
        //{

        //    long count = 0;

        //    try
        //    {
        //        //统计file的个数
        //        if (!isFile)
        //        {
        //            var files = Directory.GetFiles(path);
        //            foreach(var file in files)
        //            {
        //                if (file.ToLower().EndsWith(extension)||string.IsNullOrEmpty(extension))
        //                {
        //                    count++;
        //                }
        //            }
        //            //count += files.Length;
                
        //        }
               

        //        //统计directory的个数
               
        //        {

        //        var dirs = Directory.GetDirectories(path);
        //        if (!isDir)
        //        {
        //        count += dirs.Length;
        //        }
        //        foreach (var dir in dirs)
        //        {

        //        count += FileOrDirCount(dir, isDir, isFile, extension);

        //        }
        //        }
        //        }
        //        catch (UnauthorizedAccessException ex)
        //        {
        //        Console.WriteLine(ex.Message);
        //        //throw;
        //        }

   

        //    return count;

        //}



        //static void Main(string[] args)
        //{


        //    Console.WriteLine("正在统计...");

        //    Console.WriteLine(FileOrDirCount("d:/temp",false,true));


        //    Console.Read();

        //}

//main

        static void Main(string[] args)
        { 
            foreach(var arg in args)
            {

            Console.WriteLine(arg);
        
            }


            Console.Read();

        }



    }
        
}

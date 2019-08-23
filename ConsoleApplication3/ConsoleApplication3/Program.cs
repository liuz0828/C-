using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class DashBorad    //仪表盘
    {
        //public static DashBorad()
        //{
        //    Sum = 10;
        //    Console.WriteLine("11111");
        //}

        public static long Sum { get; set; }  //总计数

        public static void ResetSum() { Sum = 0; }

        public DashBorad()
        {
            this.Reset();
        }
        
        public DashBorad(string name)
            :this()
        {
            if (string.IsNullOrEmpty(name))
            {
                this.Name = "unknow";
            }
            else
            {
                this.Name = name;
            }
      
        }
        
        private double Value;  //表盘读数
        private List<Compment> Compments;   //零件
        //private string _Name;  //表盘名称  字段
        public string Name { get; set; }  //属性  get set
        //{
        //    get { return _Name; }
        //    set { _Name = value; }  //上下文关键字
        //}

        public double GetValue()  //方法
        {
            return this.Value;
        }

        public void Rotate(double angle) //指针转动
        {

            Value = angle;
            Console.WriteLine("转动{0}",angle);
        }

        public void Reset()   //指针复位
        {
            Value = 0;
            Console.WriteLine("{0}表盘复位完成",this.Name);
        }
        public void ShowValue()
        {

            Console.WriteLine("当前读数{0}", Value);
        }

        public bool Save()   //将表盘读数存到数据库
        {

            DataBase db1 = new DataBase();
            return db1.Store(this);

        }

    }

    class Compment {} //零件

    class DataBase    //数据库
    {
        public bool Store(DashBorad db)
        {
            return true;
        }
       
    }

    class Program
    {
        static void Main(string[] args)
        {


            DashBorad db = new DashBorad("压力表");  //实例化
            db.Reset();
            db.Rotate(10.0);
            db.ShowValue();
            DashBorad.Sum += 20;  //类型引用
            DashBorad.ResetSum();
            

            Console.Read();

          
        }
    }
}

using System;
using System.Collections;

namespace xiaojuan
{
    interface subjects {
        uint Chinese {set; get; }
        public uint Physics  {set; get; }
        void showScore();
    }
    class xj: subjects
    {

        public uint Art{                         // 手动属性设置
            set{
                art = value;
            }
            get{
                return art;
            }
        }
        uint art;
        public uint Math{ set; get; }            // 这种方式也被称为自动属性设置
        public string Name {get;} = "Jason";     // 定义只读属性
        public string Nation {set; private get;} // 不允许其它类get, 但允许其它类set
        public uint Age { set; get; } 
        public uint Height { set; get; } 
        public uint Chinese {set; get; }
        public uint Physics  {set; get; }
        public void showScore(){
            Console.Write("math: {0}, art: {1}", Chinese, Physics);
        }
    }

    class Shapes: CollectionBase {
        public void Add(uint v)
        {
            List.Add(v);
        }

        public uint this[int ok]{
            get{
                return (uint)List[ok];
            }
            set{
                List[ok] = value;
            }
        }

        public static void showXj(){
            Console.WriteLine("showXj methond is called!");
        }

        public void showJs(){
            Console.WriteLine("showJs is called!");
        }
    }
    class Book:IComparable<Book>
    {
        //定义构造方法为图书名称和价格赋值
        public Book(string name,double price)
        {
            Name = name;
            Price = price;
        }
        //定义图书名称属性
        public string Name { get; set; }
        //定义图价格属性
        public double Price { get; set; }
        //实现比较器中比较的方法
        public int CompareTo(Book other)
        {
            return (int)(this.Price - other.Price);
        }
        //重写ToString方法，返回图书名称和价格
        public override string ToString()
        {
            return Name + ":" + Price;
        }
        //图书信息排序
        public static void BookSort(Book[] books)
        {
            Array.Sort(books);
        }
    }

}
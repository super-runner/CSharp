using System;
using xiaojuan;
using Delegate_Learn;

class Program
{
    public delegate void Mydel();                    // 声明委托类型，名为Mydel
    public delegate void BookDelegate(Book[] books); // 声明委托类型，名为BookDelegate
    public delegate void AreaDelegate(double length, double width);
    static void Main(string[] args)
    {
#if false
        xj obj = new xj();
        obj.Age = 36;
        obj.Height = 158;
        obj.Nation = "Japan";
        Console.WriteLine("Age={0},Height={1}",obj.Age, obj.Height);
#endif

#if false
        int[,] m_array = new int[2,3];

        for(int i=0; i<m_array.Length; i++)
        {
           m_array[i/3,i%3] = i;
        }

        for(int i=0; i<m_array.Length; i++)
        {
            Console.WriteLine("{0}, ", m_array[i/3,i%3]);
        }
#endif

#if false
        int[] num = {2,4,8};

        foreach (int x in num){
            Console.WriteLine(x);
        }
#endif

#if false
    Shapes shp = new Shapes();
    shp.Add(5);
    shp.Add(4);
    shp.Add(3);
    shp.Add(2);
    shp.Add(1);
    Console.WriteLine(shp[2]);
#endif

#if false 
// 装箱和拆箱实验
//在 C# 语言中数据类型分为值类型和引用类型，将值类型转换为引用类型的操作称为装箱，相应地将引用类型转换成值类型称为拆箱。

    int a=101;
    string str = a.ToString(); //装箱
    float b = float.Parse(str);//拆箱

    Console.WriteLine("a={0}, b={1}", a, b);

    int val = 100;
    object obj = val;//装箱
    Console.WriteLine("对象的值 = {0}", obj);

    int num = (int) obj;//拆箱
    Console.WriteLine("num: {0}", num);
#endif

#if false
// 第1种委托：命名方法委托

    Mydel del_a = new Mydel(Shapes.showXj); // 委托实例化, 代理类的静态方法
    del_a(); // 调用委托实例

    Mydel del_b = new Mydel(new Shapes().showJs); // 委托实例化，代理一个对象的方法
    del_b();

#endif

#if false
    BookDelegate bookDelegate = new BookDelegate(Book.BookSort);
    Book[] books = new Book[3];
    books[0] = new Book("计算机应用", 50);
    books[1] = new Book("C# 教程", 59);
    books[2] = new Book("VS2015应用", 49);
    bookDelegate(books);
    foreach(Book bk in books)
    {
        Console.WriteLine(bk);
    }
#endif

#if false
// 第2种委托：多播委托。
// 即调用委托实例时，可同时调用所代理的多个方法。可以向委托实例添加、删除方法
    DelegateLearn delObj = new DelegateLearn();
    while(true)
    {
        Console.WriteLine("A - add, R - remove, Q - quit:");
        switch(Console.ReadKey().Key)
        {
            case ConsoleKey.A:
                delObj.AddFlower();
                break;

            case ConsoleKey.R:
                delObj.RemoveFlower();
                break;

            case ConsoleKey.Q:
                return;

            default:
                delObj.showOrder();
                break;
        }

    }
#endif

#if true
// 第3种委托：匿名委托。就是实例化委托时，直接给出代码块，而不必定义方法
// 匿名委托不是为了代码重用，一般用于实现一些仅需要使用一次委托中代码的情况，并且代码比较少
    AreaDelegate areaDlg = delegate (double length, double width){
        Console.WriteLine("Rectangle Area: " + length * width);
    };
    areaDlg(3, 6);
#endif

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS;

namespace CS
{
    class Met
    {
        public int getmax(int x, int y)
        {
            int max;
            if (x > y)
                max = x;
            else
                max = y;
            return max;
        }

        public void swap(out int x, out int y)
        {
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            int temp = x;
            x = y;
            y = temp;
        }
    }

    class Box
    {
        private double length;
        private double breadth;
        private double height;

        public double getVolume()
        {
            return length * breadth * height;
        }

        public void setLength(double length)
        {
            this.length = length;
        }

        public void setBreadth(double breadth)
        {
            this.breadth = breadth;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public static Box operator +(Box a, Box b)
        {
            Box box = new Box();
            box.length = a.length + b.length;
            box.breadth = a.breadth + b.breadth;
            box.height = a.height + b.height;
            return box;
        }
    }

    struct Books
    {
        private string title;
        private string auther;
        private int prices;

        public void setInfo(string title, string auther, int prices)
        {
            this.title = title;
            this.auther = auther;
            this.prices = prices;
        }

        public void showInfo()
        {
            Console.WriteLine(title);
            Console.WriteLine(auther);
            Console.WriteLine(prices);
        }
    }

    enum nums { zero, one, two, three, four, five };


    class statictest
    {
        private static int nums = 5;
        public void plus()
        {
            nums++;
        }
        public void getInfo()
        {
            Console.WriteLine(nums);
        }
    }

    class Games
    {
        public bool muti = false;
        public int def = 0;
        private string mp = "half life";

        public void showMp()
        {
            Console.WriteLine(mp);
        }

        public virtual void setMp(string mp)
        {
            this.mp = mp;
        }
    }

    class FPS : Games, IBuy
    {
        public override void setMp(string mp)
        {
            base.setMp(mp);
        }

        public void getValue()
        {
            Console.WriteLine("to ub,steam,epic");
        }

    }

    class RTS : Games, IBuy
    {
        public void getValue()
        {
            Console.WriteLine("to steam");
        }
    }

    interface IBuy
    {

        void getValue();
    }
}
class cast
{
    static void Main(string[] args)
    {
        //double d = 6666.66;
        //int i;
        //i = (int)d;
        //Console.WriteLine(i);
        //Console.ReadKey();

        //int a = 75;
        //float b = 3.001f;
        //double d = 234.7546;
        //bool e = true;
        //int c = Convert.ToInt32(Console.ReadLine()) ;
        //string f = Console.ReadLine();

        //Console.WriteLine(a);
        //Console.WriteLine(b.ToString());
        //Console.WriteLine(d.ToString());
        //Console.WriteLine(e.ToString());
        //Console.WriteLine(c);
        //Console.WriteLine(f);
        //Console.ReadKey();

        //int []a = { 2, 6, 7, 8, 9, 6, 4, 5 };
        //for(int i = 0;i<a.Length;i++)
        //{
        //    Console.WriteLine(a[i]);
        //}
        //Console.ReadKey();

        //int a = 20;
        //if (a < 100)
        //    Console.WriteLine("a's value = {0}", a);
        //Console.ReadKey();

        //int count = 0;
        //int[] a = { 2, 6, 7, 8, 9, 6, 4, 5 };
        //foreach (int i in a)
        //{
        //    Console.WriteLine("Element{0} = {1}",count,i);
        //    count += 1;
        //}
        //Console.ReadKey();

        //int a = 10;
        //while(a<20)
        //{
        //    Console.WriteLine("a'value: {0}", a);
        //    a++;
        //    if (a == 15)
        //    {
        //        Console.WriteLine("a'value: {0}", a);
        //        break;
        //    }
        //}
        //Console.ReadKey();

        //int a = 10;
        //do
        //{
        //    if (a == 15)
        //    {
        //        a += 1;
        //        continue;
        //    }
        //    Console.WriteLine("a'value = {0}", a);
        //    a++;
        //} while (a < 20);
        //Console.ReadKey();

        //int getmax(int x, int y)
        //{
        //    int max;
        //    if (x > y)
        //        max = x;
        //    else
        //        max = y;
        //    return max;
        //}

        //int a = 5, b = 9;
        //Met n = new Met();
        //int Max = n.getmax(a, b);
        //Console.WriteLine(Max);
        //int c, d;
        //n.swap(out c,out d);
        //Console.WriteLine("c = {0},d = {1}", c, d);
        //Console.ReadKey();

        //Box box1 = new Box();
        //Box box2 = new Box();
        //Box box3 = new Box();

        //box1.setLength(3.3);
        //box1.setBreadth(3.4);
        //box1.setHeight(3.5);
        //box2.setLength(4.3);
        //box2.setBreadth(4.4);
        //box2.setHeight(4.5);
        //box3 = box1 + box2;

        //Console.WriteLine(box3.getVolume());
        //Console.ReadKey();

        //bool a = true;
        //bool b = false;
        //bool c = a||b;
        //Console.WriteLine(c);
        //Console.ReadKey();

        //string mes = "go or lie";
        //string mes1 = "go or lie";
        //int c = string.Compare(mes, mes1);
        //string con = string.Concat(mes, mes1);
        //bool kd = mes.Contains(" or");
        //string ddd = mes.Substring(1);
        //Console.ReadKey();

        //Books book1;
        //Books book2;

        //book1.title = "C Program";
        //book1.auther = "Nuha Ali";
        //book1.prices = 123;

        //book2.title = "Telecom";
        //book2.auther = "Zara Ali";
        //book2.prices = 321;


        //Books book1 = new Books();
        //book1.setInfo("C Program", "Nuha Ali", 123);

        //statictest info = new statictest();
        //info.plus();
        //info.plus();

        //FPS fPS = new FPS();
        //fPS.muti = true;
        //fPS.def = 7;
        //fPS.setMp("R6");

        //RTS rts = new RTS();
        //rts.muti = true;
        //rts.def = 8;
        //rts.setMp("IN");
        //fPS.showMp();
        //rts.showMp();
        //fPS.getValue();
        //rts.getValue();

        ///*快排*/
        //int[] a = { 5, 6, 3, 5, 98, 9, 7, 4 };

        //void QuickSort(int[] arr, int left, int right)
        //{
        //    if (left >= right)
        //        return;
        //    int low = left;
        //    int hight = right;
        //    int temp = arr[left];
        //    while (low != hight)
        //    {
        //        while (arr[hight] >= temp && hight > low)
        //            hight--;
        //        while (arr[low] <= temp && hight > low)
        //            low++;
        //        if (arr[low] > temp)
        //        {
        //            int x = arr[hight];
        //            arr[hight] = arr[low];
        //            arr[low] = x;
        //        }
        //    }
        //    arr[left] = a[low];
        //    a[low] = temp;
        //    QuickSort(arr, left, low - 1);
        //    QuickSort(arr, low + 1, right);
        //}

        //QuickSort(a, 0, 7);

        //foreach (int o in a)
        //{
        //    Console.WriteLine(o);
        //}


        Dictionary<string, int> id = new Dictionary<string, int>();
        id.Add("tom", 5515);
        id.Add("li", 7615);
        id.Add("po", 135);
        id.Add("sc", 1545);

        bool back = id.ContainsKey("ssd");

        Console.WriteLine(back);

        foreach (KeyValuePair<string, int> x in id)
        {
            Console.WriteLine(x);
        }










        Console.ReadKey();
    }
}
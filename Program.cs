using System;
namespace BaiThucHanh_1
{
    //Bai1
    class Diem
    {
        private double x, y;
        public Diem()
        {
            x = y = 0;
        }
        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Nhap()
        {
            Console.Write("Nhap x:");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y:");
            y = double.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.WriteLine("Toa do (x,y)=({0},{1})");
        }
        public double TinhDT(Diem B)
        {
            return Math.Sqrt(Math.Pow(B.x - this.x, 2) + Math.Pow(B.y - this.y, 2));
        }
    }
}
//Bai2
class Employee
{
    private int id;
    private string name;
    private int yearOfBirth;
    private double salaryLever;
    private double basicSalary;
    public int getld()
    {
        return id;
    }
    public string getname()
    {
        return name;
    }
    public int getyearOBirth()
    {
        return yearOfBirth;
    }
    public double getIncome()
    {
        return salaryLever * basicSalary;
    }
    public void display()
    {
        Console.WriteLine("Thong tin ve nguoi lao dong:");
        Console.Write("Dinh danh", id, "Ten", name, "Nam sinh", yearOfBirth, "Luong co ban", basicSalary, "Thu nhap", getIncome);
    }
}
//Bai3
class Stack
{
    private int top;
    private int[] s;
    public bool empty()
    {
        return (top == -1);
    }
    public bool full()
    {
        return (top >= s.Length);
    }
    public Stack()
    {
        s = new int[20];
        top = -1;
    }
    public void push(int x)
    {
        if (!full())
        {

            top = top + 1;
            s[top] = x;
        }
        else
            Console.WriteLine("Stack tran");
    }
    public int pop()
    {
        if (empty())
        {
            Console.Write("Stack can");
            return 0;
        }
        else
            return s[top--];
    }
}
//Bai4
class SoPhuc
{
    private double thuc, ao;
    public SoPhuc()
    {
        thuc = 0;
        ao = 0;
    }
    public SoPhuc(double thuc, double ao)
    {
        this.thuc = thuc;
        this.ao = ao;
    }
    public SoPhuc(SoPhuc t2)
    {
        this.thuc = t2.thuc;
        this.ao = t2.ao;
    }
    public void Nhap()
    {
        Console.Write("Nhap phan thuc:"); thuc = double.Parse(Console.ReadLine());
        Console.Write("Nhap phan ao:"); ao = double.Parse(Console.ReadLine());
    }
    public void Hien()
    {
        string kq = thuc + (ao > 0 ? "+" : "") + ao + "*i";
        Console.WriteLine(kq);
    }
    public static SoPhuc operator +(SoPhuc t1, SoPhuc t2)
    {
        SoPhuc tmp = new SoPhuc();
        tmp.thuc = t1.thuc + t2.thuc;
        tmp.ao = t1.ao + t2.ao;
        return tmp;
    }
    public SoPhuc Tong(SoPhuc t2)
    {
        SoPhuc tmp = new SoPhuc();
        tmp.thuc = this.thuc + t2.thuc;
        tmp.ao = this.ao + t2.ao;
        return tmp;
    }
}
//Bai5
class Matran
{
    private int sh, sc;
    private int[,] a;
    public Matran()
    {
        sh = sc = 0;
        a = new int[sh, sc];
    }
    public Matran(int sh, int sc)
    {
        this.sh = sh;
        this.sc = sc;
        a = new int[sh, sc];
    }
    public Matran(Matran t2)
    {
        this.sh = t2.sh;
        this.sc = t2.sc;
        this.a = new int[sh, sc];
        for (int i = 0; i < sh; i++)
            for (int j = 0; j < sc; j++)
                this.a[i, j] = t2.a[i, j];
    }
    public void print()
    {
        for (int i = 0; i < sh; i++)
        {
            for (int j = 0; j < sc; j++)
                Console.Write("{0}\t", a[i, j]);
            Console.WriteLine();
        }
    }
    public void Nhap()
    {
        for (int i = 0; i < sh; i++)
            for (int j = 0; j < sc; j++)
            {
                Console.Write("a[{0},{1}]=", i, j);
                a[i, j] = int.Parse(Console.ReadLine());
            }
    }
    public Matran Tong(Matran t2)
    {
        if (this.sh == t2.sh && this.sc == t2.sc)
        {
            Matran t = new Matran(this.sh, this.sc);
            for (int i = 0; i < sh; i++)
                for (int j = 0; j < sc; j++)
                    t.a[i, j] = this.a[i, j] + t2.a[i, j];
            return t;
        }
        else return null;
    }
    public Matran Hieu(Matran t2)
    {
        if (this.sh == t2.sh && this.sc == t2.sc)
        {
            Matran t1 = new Matran(this.sh, this.sc);
            for (int i = 0; i < sh; i++)
                for (int j = 0; j < sc; j++)
                    t1.a[i, j] = this.a[i, j] - t2.a[i, j];
            return t1;
        }
        else return null;
    }
}

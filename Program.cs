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

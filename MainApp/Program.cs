using Domain.Models;
using Servise.Servise;
var sts = new StudentServise();
while (true)
{
    System.Console.WriteLine();
    System.Console.WriteLine("input 1 for get students");
    System.Console.WriteLine("input 2 for add student");
    System.Console.WriteLine("input 3 for getbyid students");
    System.Console.WriteLine("input 4 for updete students");
    System.Console.WriteLine("input 5 for delete students");
    System.Console.WriteLine("input 6 for addmore students");
    System.Console.WriteLine("input 7 for exit  program");
    System.Console.WriteLine();
    int b;
    b = Convert.ToInt32(System.Console.ReadLine());
    if (b == 1)
    {
        var st = sts.GetAll();
        for (int i = 0; i < st.Count(); i++)
        {   System.Console.WriteLine();
            System.Console.Write("ID: ");
            System.Console.WriteLine(st[i].Id = i + 1);
            System.Console.Write("FirstName: ");
            System.Console.WriteLine(st[i].firstName);
            System.Console.Write("LastName: ");
            System.Console.WriteLine(st[i].lastName);
            System.Console.Write("BirthDay: ");
            System.Console.WriteLine(st[i].birthDay);
            System.Console.Write("EveregeGrande :");
            System.Console.WriteLine(st[i].Everage(st[i].Grande));
            System.Console.WriteLine("================================================");

        }
    }
    else if (b == 2)
    {
        var c = new Student();
        System.Console.Write("FirstName: ");
        c.firstName = Console.ReadLine();
        System.Console.Write("LastName: ");
        c.lastName = Console.ReadLine();
        System.Console.Write("BirthYear: ");
        int a = Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Birthmonth: ");
        int q = Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Birthday: ");
        int w = Convert.ToInt32(System.Console.ReadLine());
        c.birthDay = new DateTime(a, q, w);
        System.Console.WriteLine("Grande: ");
        c.Grande = new int[4];
        for (int i = 0; i < 4; i++)
        {
            System.Console.Write($"grande-{i + 1}: ");
            c.Grande[i] = Convert.ToInt16(Console.ReadLine());
        }

        System.Console.WriteLine(sts.Add(c));
    }
    else if (b == 3)
    { int n;
        System.Console.Write("введите ID: ");
        n = Convert.ToInt32(System.Console.ReadLine());
        sts.GetById(n);
    }
    else if (b == 4)
    {     
         int n;
        System.Console.Write("Для изменит введите ID: ");
      
        var z = new Student();
          z.Id = n = Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("FirstName: ");
        z.firstName = Console.ReadLine();
        System.Console.Write("LastName: ");
        z.lastName = Console.ReadLine();
        System.Console.Write("BirthYear: ");
        int a = Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Birthmonth: ");
        int q = Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Birthday: ");
        int w = Convert.ToInt32(System.Console.ReadLine());
        z.birthDay = new DateTime(a, q, w);
        System.Console.Write("Grande: ");
        z.Grande = new int[4];
        for (int i = 0; i < 4; i++)
        {
            System.Console.Write($"grande-{i + 1}: ");
            z.Grande[i] = Convert.ToInt16(Console.ReadLine());
        }
        sts.Update(z);
    }
    else if (b == 5)
    {
        int x;
        System.Console.Write("Для удалит дании введите ID: ");
        x = Convert.ToInt32(System.Console.ReadLine());
        sts.Remove(x);
    }
    else if (b == 6)
    {
        var lst = new List<Student>();
        int f;
        System.Console.Write("Сколко студентов вы хотите набрать: ");
        f = Convert.ToInt32(System.Console.ReadLine());
        for (int j = 0; j < f; j++)
        {   System.Console.WriteLine($"{j+1} Student: ");
            var c = new Student();
            System.Console.Write("FirstName: ");
            c.firstName = Console.ReadLine();
            System.Console.Write("LastName: ");
            c.lastName = Console.ReadLine();
            System.Console.Write("BirthYear: ");
            int a = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Birthmonth: ");
            int q = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Birthday: ");
            int w = Convert.ToInt32(System.Console.ReadLine());
            c.birthDay = new DateTime(a, q, w);
            System.Console.WriteLine("Grande: ");
            c.Grande = new int[4];
        for (int i = 0; i < 4; i++)
        {
            System.Console.Write($"grande-{i + 1}: ");
            c.Grande[i] = Convert.ToInt16(Console.ReadLine());
        }
            lst.Add(c);
        }
        sts.AddMore(lst);
    }
    else if (b == 7)
    {
        return 0;
    }

}

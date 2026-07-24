using System;
using System.Collections.Generic;

class Collection
{
    public void display()
    {
        List<string> names = new List<string>(); // Create a list

        names.Add("Mayur");
        names.Add("Vaishnavi");
        names.Add("Mohammed");
        names.Add("Aditya");

        foreach (string f in names)
        {
            Console.WriteLine(f);
        }
         ///////////
          ////
          /// /////
          /// //////
          /// 
          /// 
    List<Stud> st = new List<Stud>()
    {
    new Stud { id = 1, sname = "abc" },
    new Stud { id = 2, sname = "bob" },
    new Stud { id = 3, sname = "sam" },
    new Stud { id = 4, sname = "john" },
    };

    List<Teacher> th = new List<Teacher>()
    {
    new Teacher { tid = 101, Tname = "Mamta" },
    new Teacher { tid = 102, Tname = "Anjita" }
    };

    foreach (var stu in st)
{
    Console.WriteLine("Students : " + stu.sname);
}

foreach (var thu in th)
{
    Console.WriteLine("Teachers : " + thu.Tname);
}




    }
}
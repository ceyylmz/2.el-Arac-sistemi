using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("VİZE NOTUNUZU GİRİNİZ");
        int vize = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("FİNAL NOTUNUZU GİRİNİZ");
        int final = Convert.ToInt32(Console.ReadLine());

    }

    static void ortalama()
    {
        //todo:
    }

    static void harfnotu()
    {
       double ortalama=Convert.ToDouble(Console.ReadLine());
        string harfNotu = "";

        if (ortalama>0 && ortalama<30)
        {
            harfNotu = "FF";
        }
        else if (ortalama >=30 && ortalama <60)
        {
            harfNotu = "CC";
        }
        else if (ortalama >= 60 && ortalama < 100)
        {
            harfNotu = "AA";
        }
        
    }
}
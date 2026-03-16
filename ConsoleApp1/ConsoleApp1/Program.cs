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

    static double ortalama(int vize , int final)
    {
        double ortalama = (vize * 0.4) + (final * 0.6);

        return ortalama;
    }

    static void harfnotu()
    {
        
    }
}
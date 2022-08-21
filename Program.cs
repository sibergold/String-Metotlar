using System;
namespace hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
           string degisken="Dersimiz CSharp, Hoşgeldiniz!";
           string degisken2="CSharp";
           Console.WriteLine(degisken.Length);
           Console.WriteLine(degisken.ToUpper());
          Console.WriteLine(degisken.ToLower());
          Console.WriteLine("**** Concat ****");
          Console.WriteLine(String.Concat(degisken,"Merhaba!"));
          Console.WriteLine("**** Compare,CompareTo ****");
          Console.WriteLine(degisken.CompareTo(degisken2));
          Console.WriteLine(string.Compare(degisken,degisken2,true));
          Console.WriteLine(string.Compare(degisken,degisken2,false));
         Console.WriteLine("**** Contains ****");
         Console.WriteLine(degisken.Contains(degisken2));
         Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
         Console.WriteLine(degisken.StartsWith("Merhaba!"));
         Console.WriteLine("**** IndexOf ****");
         Console.WriteLine(degisken.IndexOf("CS"));
         Console.WriteLine(degisken.IndexOf("Zikriye"));
        Console.WriteLine(degisken.LastIndexOf("i"));
        Console.WriteLine("**** Insert ****");
        Console.WriteLine(degisken.Insert(0,"Merhaba"));
        Console.WriteLine("**** Padleft, PadLight ****");
        Console.WriteLine(degisken+degisken2.PadLeft(30));
        Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
        Console.WriteLine(degisken.PadRight(50)+degisken2);
        Console.WriteLine(degisken.PadRight(50,'_')+degisken2);
        Console.WriteLine("**** Remove ****");
        Console.WriteLine(degisken.Remove(10));
        Console.WriteLine(degisken.Remove(5,3));
        Console.WriteLine(degisken.Remove(0,1));
        Console.WriteLine("**** Replace ****");
        Console.WriteLine(degisken.Replace("CSharp","C#"));
        Console.WriteLine(degisken.Replace(" ","*"));
        Console.WriteLine("**** Split ****");
        Console.WriteLine(degisken.Split(' ')[1]);
       Console.WriteLine("**** Substring ****");
        Console.WriteLine(degisken.Substring(4));
        
        
        
        
        }  






        }











    }


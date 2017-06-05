/*
Demonstrates file opening

Sample ouput:
1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 -1
*/
using System;
using System.IO;

namespace FileIOApplication
{
   class Program
   {
      static void Main(string[] args)
      {
         FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
         for (int i = 1; i <= 20; i++)
         {
            F.WriteByte((byte)i);
         }
         
         F.Position = 0;
         for (int i = 0; i <= 20; i++)
         {
            Console.Write(F.ReadByte() + " ");
         }
         F.Close();
         Console.ReadKey();
      }
   }
}
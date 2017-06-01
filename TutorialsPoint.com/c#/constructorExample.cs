/*
Demonstrates concept of a default constructor (a constructor which does not have any parameters).

Sample Output:
Object is being created //Note how this line is displayed when a new instance of Line is created.
Length of line : 6
*/

using System;
namespace LineApplication
{
   class Line
   {
      private double length;   // Length of a line
      
      public Line()//constructor
      {
         Console.WriteLine("Object is being created");
      }

      public void setLength( double len )
      {
         length = len;
      }
      
      public double getLength()
      {
         return length;
      }

      static void Main(string[] args)
      {
         Line line = new Line();    
         
         // set line length
         line.setLength(6.0);
         Console.WriteLine("Length of line : {0}", line.getLength());
         Console.ReadKey();
      }
   }
}
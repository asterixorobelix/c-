using System;

namespace RectangleApplication
{
   class Rectangle 
   {
      // member variables
      double length;
      double width;
      
      public void Acceptdetails()//Member function
      {
         length = 4.5;    
         width = 3.5;
      }
      
      public double GetArea()//Member function
      {
         return length * width; 
      }
      
      public void Display()//member function
      {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }//End of Rectangle class
   
   class ExecuteRectangle 
   {
      static void Main() 
      //the class ExecuteRectangle contains the Main() method and instantiates the Rectangle class.
      {
         Rectangle r = new Rectangle();//creates instance of the Rectangle class
         r.Acceptdetails();
         r.Display();
         Console.ReadLine(); //The Console class in the System namespace provides a function ReadLine() for accepting input from the user and store it into a variable.
      }
   }
}//End of RectangleApplication namespace
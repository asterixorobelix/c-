/*
 * https://www.juanantonioripoll.es/practice-exercises-c-sharp/practice-exercises-c-sharp-exercise-6-2-PhotoAlbumTarea.aspx
 * Create a class "Album", in the PhotoAlbum namespace with a NumberOfPages property. 
   It should also have a public method "GetNumberOfPages", which will return the number of pages. 
   The default constructor will create an album with 16 pages. There will be an additional constructor, with which we can specify the number of pages we want in the album. 
   Create a test class "Program" which creates an album with its default constructor and one with 24 pages.

   Sample Ouput:
   The number of pages: 16
   The number of pages: 24
*/

using System;

namespace PhotoAlbum
{
    class Program
    {
        static void Main()
        {
            //Create an album with its default constructor
            Album myAlbum1 = new Album();
            Console.WriteLine("The number of pages: "+myAlbum1.GetNumberOfPages());

            //Create an album with 24 pages
            Album myAlbum2 = new Album(24);
            Console.WriteLine("The number of pages: "+myAlbum2.GetNumberOfPages());
        }
    }
}

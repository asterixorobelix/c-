using System;

namespace PhotoAlbum
{
    internal class Album
    {
        
        public int NumbOfPages
        {
            get; set;
        }

        internal Album()
        {
            NumbOfPages = 16;
        }

        internal Album(int p)
        {
            NumbOfPages = p;
        }
        internal int GetNumberOfPages()
        {
            return NumbOfPages;
        }
    }
}
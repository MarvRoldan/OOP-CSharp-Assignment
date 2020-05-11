using System;

namespace Painting
{
    class Painting
    {
        private string name;

        private string artist;

        private string medium;

        private int year;

        public string Myname
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Myartist
        {
            get
            {
                return artist;
            }
            set
            {
                artist = value;
            }
        }

        public string Mymedium
        {
            get
            {
                return medium;
            }
            set
            {
                medium = value;
            }
        }

        public int Myyear
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

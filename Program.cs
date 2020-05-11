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
            // Encapsulation 
            Painting myPainting = new Painting();
            myPainting.Myname = "Mona Lisa";
            myPainting.Myartist = "Leonardo da Vinci";
            myPainting.Mymedium = "Oil";
            myPainting.Myyear = 1506;

            Console.WriteLine("Name: " + myPainting.Myname);
            Console.WriteLine("Artist: " + myPainting.Myartist);
            Console.WriteLine("Medium: " + myPainting.Mymedium);
            Console.WriteLine("Year: " + myPainting.Myyear);
        }
    }
}

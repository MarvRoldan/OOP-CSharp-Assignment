using System;

namespace Painting
{
    class Painting
    {
        private string name;

        private string artist;

        private string medium;

        private int year;

        public virtual void isamaster() {
            Console.WriteLine("Is not a Renaissance Master");
        }

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

    class Leo : Painting 
    {
        public string artist = "Leonardo da Vinci";

        public override void isamaster()
        {
            Console.WriteLine("Is a Renaissance Master");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Encapsulation 
            Painting myPainting = new Painting();
            myPainting.Myname = "Mona Lisa";
            myPainting.Mymedium = "Oil";
            myPainting.Myyear = 1506;

            // Inheritance
            Leo newLeo = new Leo();

            Console.WriteLine("Name: " + myPainting.Myname);
            Console.WriteLine("Artist: " + newLeo.artist);
            Console.WriteLine("Medium: " + myPainting.Mymedium);
            Console.WriteLine("Year: " + myPainting.Myyear);
            newLeo.isamaster();
        }
    }
}

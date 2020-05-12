using System;

namespace Painting
{
    abstract class Painting
    {
        private string name;

        private string artist;

        private string medium;

        private int year;

        public virtual void isamaster() {
            Console.WriteLine("Is not a Renaissance Master");
        }

        public void hiddenTruth() {
            Console.WriteLine("This is a self-portrait");

        }

        public string Myname {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public string Myartist {
            get {
                return artist;
            }
            set {
                artist = value;
            }
        }

        public string Mymedium {
            get {
                return medium;
            }
            set {
                medium = value;
            }
        }

        public int Myyear {
            get {
                return year;
            }
            set {
                year = value;
            }
        }
    }

    class Leo : Painting
    {
        public string name = "Mona Lisa";
        public string artist = "Leonardo da Vinci";
        public string medium = "Oil";
        public int year = 1506;


        public override void isamaster() {
            Console.WriteLine("Is a Renaissance Master");
        }

        public void openLie() {
            Console.WriteLine("This is not a self-portrait");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Encapsulation 
            // Inheritance
            Leo newLeo = new Leo();

            Console.WriteLine("Name: " + newLeo.name);
            Console.WriteLine("Artist: " + newLeo.artist);
            Console.WriteLine("Medium: " + newLeo.medium);
            Console.WriteLine("Year: " + newLeo.year);

            // Polymorphism
            newLeo.isamaster();

            // Abstraction
            newLeo.openLie();
        }
    }
}

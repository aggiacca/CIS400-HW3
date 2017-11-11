using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Versions
{
    class Question1
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[4];

            animals[0] = new Animal();
            animals[1] = new Cow();
            animals[2] = new Pig();
            animals[3] = new Snake();

            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].talk();
            }

            //pause
            Console.ReadKey();

        }
    }

    public class Animal
    {
        private int Leg;
        public Animal()
        {
            Leg = 4;
        }
        public virtual void talk()
        {
            Console.WriteLine("Animals Can't Talk!");
        }
    }

    public class Cow : Animal
    {
        public Cow()
            : base()
        {

        }
        public override void talk()
        {
            Console.WriteLine("Moo!");
        }

    }

    public class Pig : Animal
    {
        public Pig()
            : base()
        {

        }
        public override void talk()
        {
            Console.WriteLine("Grunt!");
        }
    }

    public class Snake : Animal
    {
        public Snake()
            : base()
        {

        }

    }
}

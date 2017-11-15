using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{

    class Pianist
    {
        private string name;
        public void Pianist(string x)
        {
            name = x;
        }
        public void pianoPlay(){
            Console.WriteLine("Play a piano!");
        }
    }

    class Violinist
    {
        public void violinPlay()
        {
            Console.WriteLine("Play a violin!");
        }
    }

    class Musician
    {
        public void sing()
        {
            Console.WriteLine("Sing a song!");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

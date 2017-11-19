using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Question2
 * C#
 * Adam Giaccaglia
 */

namespace Question2
{

    class Pianist
    {
        private string name;
        public Pianist(string x)
        {
            name = x;
        }
        public void pianoPlay(){
            Console.WriteLine("Play a piano!");
        }
    }

    class Violinist: IViolinist
    {
        public void violinPlay()
        {
            Console.WriteLine("Play a violin!");
        }
    }

    interface IViolinist
    {
        void violinPlay();
    }


    class Musician: Pianist, IViolinist
    {
        
        public Musician(string nm) : base(nm){

        }
        public void sing()
        {
            Console.WriteLine("Sing a song!");
        }

        // makes having a violinist class redundant
        public void violinPlay()
        {
            Console.WriteLine("Play a violin!");
        }
    }

    /******************************************/
    //          Updated to fit C# better with some slight changes
    /******************************************/
    class Pianist2 : IInterstrument
    {
        public void plays()
        {
            Console.WriteLine("Play a piano!");
        }
    }

    class Violinist2 : IInterstrument
    {
        public void plays()
        {
            Console.WriteLine("Play a violin!");
        }
    }

    // comman attribute that all 
    public interface IInterstrument
    {
        void plays();
    } 

    class Musicianv2
    {
        // uses IInterstrument instead of separate variables for each type 
        private List<IInterstrument> interPlays;
        private string name;

        public Musicianv2(string nm){
            name = nm;
            interPlays = new List<IInterstrument>();
        }
        public void addinter(IInterstrument i){
            interPlays.Add(i);
        }

        public void sing()
        {
            Console.WriteLine("Sing a song!");
        }

        public void playAllInter()
        {
            // since we are using an interface we don't need to use specific functions for each type like in previous example
            foreach (IInterstrument i in interPlays)
            {
                i.plays();
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Musician guy = new Musician("billy");

            guy.sing();
            guy.pianoPlay();
            guy.violinPlay();
            
            Console.WriteLine("--------------------");

            Musicianv2 bob = new Musicianv2("bob");
            IInterstrument piano = new Pianist2();
            IInterstrument violin = new Violinist2();
            bob.sing();
            bob.addinter(piano);
            bob.addinter(violin);
            bob.playAllInter();

            Console.ReadKey();
        }
    }
}

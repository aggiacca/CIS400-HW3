using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Question3
 * C#
 * Adam Giaccaglia
 */

namespace Question3
{
    class Program
    {

        class Bank
        {
            private string name;
            protected internal string securityInfo;
            public Bank()
            {
                securityInfo = "High";
            }
            public void display(){
                Console.WriteLine("This is a bank!");
            }
            
        }
        class Manager
        {
            private int id;
            public void display()
            {
                Console.WriteLine("I am a manager!");
            }
            public void securityAccess(Bank x){
                Console.WriteLine("Security Information is: " + x.securityInfo);
            }
        }

        static void Main(string[] args)
        {

            Bank bank1 = new Bank();
            Manager boss = new Manager();
            boss.securityAccess(bank1);

            //pause
            Console.ReadKey();
        }
    }
}

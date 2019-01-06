using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using BE;

namespace Project01_9843_1010_dotNet5779
{
    class Program
    {
        static void Main(string[] args)
        {
            BL.IBL bl;
            bl = BL.FactoryBl.GetBL();
            /*List<Tester> t = new List<Tester>();
            t = bl.getAllTesters();*/

             structTyps.Address add = new structTyps.Address("BET HADFUS", 7, "JERUSALEM");
             /*DateTime b = new DateTime(1974, 12, 12);
             DateTime s = new DateTime(2018, 12, 1, 13, 30, 00);
             DateTime s1 = new DateTime(2018, 12, 20, 13, 00, 00);
             Tester ts = new Tester("318749843", "M", "A", 0, "0587912442", add, b, 13, 0, 56);
             Trainee tr = new Trainee("315551010", "C", "R", 0, "0525435117", add, b, 0, 0, "tvuna", "yair", 28, s);
             Test t1 = new Test(ts, tr, s1.Date, s1.Hour, add, 0);
             bl.addTester(ts);
             bl.addTrainee(tr);
             bl.addTest(t1);*/


            /*foreach (Tester t2 in bl.getAllTesters())
            {
                Console.WriteLine(t2);
            }*/
            //Tester t = bl.GetTester("123456789");

            /*DateTime r = new DateTime(1950, 3, 12);
            Tester ts = new Tester("123456789", "s", "r", 0, "1234567890", add, r, 24, 0, 30);
            bl.addTester(ts);*/
            Console.WriteLine(bl.GetTester("123456789"));
            Console.ReadKey();
           
        }
    }
}

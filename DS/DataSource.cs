using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DS
{
    public class DataSource
    {
        public static List<Tester> testerList;
        public static List<Trainee> traineeList;
        public static List<Test> testList;

        static DataSource()
        {
            testerList = new List<Tester>();
            traineeList = new List<Trainee>();
            testList = new List<Test>();

            /*structTyps.Address add = new structTyps.Address("BET HADFUS", 7, "JERUSALEM");
            DateTime b = new DateTime(1997, 12, 12);
            testerList.Add(new Tester("32123456", "M", "A", 0, "054", add, b, 15, 0, 50));
            testerList.Add(new Tester("45665475", "R", "C", 0, "054", add, b, 15, 0, 50));
            testerList.Add(new Tester("78965456", "S", "E", 0, "054", add, b, 15, 0, 50));*/

        }
    }
}

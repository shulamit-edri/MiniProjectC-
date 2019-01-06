using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BE
{
    public class Configuration
    {
        public static int minLesson = 20;
        public static int maxTesterAge = 70;
        public static int minTesterAge = 40;
        public static int minTraineeAge = 18;
        public static int timeWaitForTest = 7;
        public static long NumTest = 10000000;
        public static int digitsOfNumTest = 8;
        public static int maxTesterTests = 15;

        #region check function
        //The function checks for age correctness
        public static int checkAge(DateTime birhtday)
        {
            DateTime temp = DateTime.Now;
            DateTime tester1 = birhtday;
            TimeSpan ageInDays = temp - tester1;
            int age = ageInDays.Days / 365;
            return age;
        }

        //Cellphone check function
        public static bool CheckPhoneNumber(string str)
        {
            int a = str.Length;
            if (a > 10 || a < 10)
                return false;
            return true;
        }

        //Validation function for identity card
        public static bool checkId(string id)
        {
            int a = id.Length;
            if (a > 9 || a<8)
            {
                return false;
            }
            return true;
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tester
    {
        #region fildes and properties
        string id;
        public string Id { get => id; set => id = value; }

        string lastName;
        public string LastName { get => lastName; set => lastName = value; }

        string firstName;
        public string FirstName { get => firstName; set => firstName = value; }

        DateTime birthday;
        public DateTime Birthday { get => birthday; set => birthday = value; }

        myEnum.Gender gender;
        public myEnum.Gender Gender { get => gender; set => gender = value; }

        string phonNum;
        public string PhonNum { get => phonNum; set => phonNum = value; }

        structTyps.Address address;
        internal structTyps.Address Address { get => address; set => address = value; }

        int yearsExperience;
        public int YearsExperience { get => yearsExperience; set => yearsExperience = value; }

        myEnum.CarType testerCar;
        public myEnum.CarType TesterCar { get => testerCar; set => testerCar = value; }

        bool[,] timeWork = new bool[6, 5];
        public bool[,] TimeWork { get => timeWork; set => timeWork = value; }

        int maxDistance;
        public int MaxDistance { get => maxDistance; set => maxDistance = value; }
        #endregion

        #region ctors
        public Tester(string ID, string lN, string FN, myEnum.Gender g, string Phon, structTyps.Address add, DateTime birth,
            int YE, myEnum.CarType c, int maxD)
        {
            id = ID;
            lastName = lN;
            firstName = FN;
            gender = g;
            phonNum = Phon;
            address = add;
            birthday = birth;
            yearsExperience = YE;
            testerCar = c;
            maxDistance = maxD;

        }

        public Tester() { }

        public Tester(Tester t)
        {
            id = t.id;
            lastName = t.lastName;
            firstName = t.firstName;
            gender = t.gender;
            phonNum = t.phonNum;
            address = t.address;
            birthday = t.birthday;
            yearsExperience = t.yearsExperience;
            testerCar = t.testerCar;
            timeWork = t.timeWork;
            maxDistance = t.maxDistance;
        }
        #endregion

        #region toString
        public override string ToString()
        {
            return string.Format("Details of the tester:\n Id: {0}\n Last Name: {1}\n First Name: {2}\n Birthday: {3}\n Gender: {4}\n Phon Number: {5}\n " +
                "Address: {6}\n Years of Experience: {7}\n Car type of tester:{8}\n Weekly schedule: {9}\n Maximum distance to work: {10}",
                id, lastName, firstName, birthday, gender, phonNum, address, yearsExperience, testerCar, timeWork, maxDistance);
        }
        #endregion
    }
}

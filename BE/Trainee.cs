using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Trainee
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

        myEnum.CarType traineeCar;
        public myEnum.CarType TraineeCar { get => traineeCar; set => traineeCar = value; }

        myEnum.GearBox gearBox;
        public myEnum.GearBox GearBox { get => gearBox; set => gearBox = value; }

        string schoolName;
        public string SchoolName { get => schoolName; set => schoolName = value; }

        string teacherName;
        public string TeacherName { get => teacherName; set => teacherName = value; }

        int numLessons;
        public int NumLessons { get => numLessons; set => numLessons = value; }

        DateTime prevTestDate;
        public DateTime PrevTestDate { get => prevTestDate; set => prevTestDate = value; }

        int countTests;
        public int CountTests { get => countTests; set => countTests = value; }
        #endregion

        #region ctors
        public Trainee(string ID, string lN, string FN, myEnum.Gender g, string Phon, structTyps.Address add, DateTime birth,
            myEnum.CarType c, myEnum.GearBox GB, string SN, string TN, int NL, DateTime ptd)
        {
            id = ID;
            lastName = lN;
            firstName = FN;
            gender = g;
            phonNum = Phon;
            address = add;
            birthday = birth;
            TraineeCar = c;
            gearBox = GB;
            schoolName = SN;
            teacherName = TN;
            numLessons = NL;
            PrevTestDate = ptd;
        }

        public Trainee(Trainee tn)
        {
            id = tn.Id;
            lastName = tn.lastName;
            firstName = tn.firstName;
            gender = tn.gender;
            phonNum = tn.phonNum;
            address = tn.address;
            birthday = tn.birthday;
            TraineeCar = tn.traineeCar;
            gearBox = tn.GearBox;
            schoolName = tn.schoolName;
            teacherName = tn.TeacherName;
            numLessons = tn.numLessons;
            PrevTestDate = tn.prevTestDate;
        }

        public Trainee() { }
        #endregion

        #region toString
        public override string ToString()
        {
            return string.Format("Details of the trainee:/n Id: {0}/n Last Name: {1}/n First Name: {2}/n Birthday: {3}/n Gender: {4}/n Phon Number: {5}/n " +
              "Address: {6}/n Car type of trainee: {7}/n Type of gear box: {8}/n Name of driving school: {9}/n The name of the teacher: {10}/n The number of lessons: {11}",
              id, lastName, firstName, birthday, gender, phonNum, address, traineeCar, gearBox, schoolName, teacherName, numLessons);
        }
        #endregion
    }
}

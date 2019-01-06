using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Test
    {
        #region fields and properties
        long numTest;
        public long NumTest { get => numTest; set => numTest = value; }

        string testerId;
        public string TesterId { get => testerId; set => testerId = value; }

        string traineeId;
        public string TraineeId { get => traineeId; set => traineeId = value; }

        DateTime dateTest;
        public DateTime DateTest { get => dateTest; set => dateTest = value; }

        int timeTest;
        public int TimeTest { get => timeTest; set => timeTest = value; }

        structTyps.Address addressBegin;
        internal structTyps.Address AddressBegin { get => addressBegin; set => addressBegin = value; }

        Boolean keepDistance;
        public Boolean KeepDistance { get => keepDistance; set => keepDistance = value; }

        Boolean parkingRevers;
        public Boolean ParkingRevers { get => parkingRevers; set => parkingRevers = value; }

        Boolean lookingMirror;
        public Boolean LookingMirror { get => lookingMirror; set => lookingMirror = value; }

        Boolean useVinker;
        public Boolean UseVinker { get => useVinker; set => useVinker = value; }

        Boolean drivingRightLane;
        public Boolean DrivingRightLane { get => drivingRightLane; set => drivingRightLane = value; }

        Boolean testSpeed;
        public Boolean TestSpeed { get => testSpeed; set => testSpeed = value; }

        bool isPassed;
        public bool IsPassed { get => isPassed; set => isPassed = value; }

        string testerNote;
        public string TesterNote { get => testerNote; set => testerNote = value; }

        myEnum.CarType carLearning;
        public myEnum.CarType CarLearning { get => carLearning; set => carLearning = value; }
        #endregion

        #region ctors
        public Test(Tester tester, Trainee trainee, DateTime date, int time,
            structTyps.Address address, myEnum.CarType cl)
        {
            testerId = tester.Id;
            traineeId = trainee.Id;
            dateTest = date;
            timeTest = time;
            addressBegin = address;
            carLearning = cl;
        }

        public Test() { }

        public Test(Test ts)
        {
            NumTest = ts.numTest;
            testerId = ts.testerId;
            traineeId = ts.traineeId;
            dateTest = ts.dateTest;
            timeTest = ts.timeTest;
            addressBegin = ts.addressBegin;
            carLearning = ts.carLearning;
        }
        #endregion

        #region toString
        public override string ToString()
        {
            return string.Format("The dtails of test number {0}:/n ID tester: {1}/n ID trainee: {2}/n Dait of test: {3}/n" +
                "Time of test: {4}/n Address begin: {5}/n Keep distance: {6}/n Parking revers: {7}/n" +
                "Looking mirror: {8}/n Use vinkers: {9}/n If the trainee passed the test: {10}/n" +
                "The tester note: {11}/n", numTest, testerId, traineeId, dateTest, timeTest, addressBegin,
                keepDistance, parkingRevers, lookingMirror, useVinker, isPassed, testerNote);
        }
        #endregion
    }
}

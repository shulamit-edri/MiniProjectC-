using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public interface IBL
    {
        #region tester function
        void addTester(Tester tester);
        void removeTester(string idTester);
        void updateTester(Tester tester);
        List<Tester> getAllTesters();
        Tester GetTester(string id);
        int countTestsForTester(Tester ts);
        List<Tester> AvailableTester(DateTime date, int hour);
        bool IfTesterAvailable(DateTime date, int hour, Tester t);
        List<Tester> neerTesters(structTyps.Address add);
        Tester anotherAvailableTester();
        IEnumerable<IGrouping<BE.myEnum.CarType, Tester>> TesterGroupingByTypeCar(bool sort);
        string searchTesterToCar(Trainee trainee, List<Tester> t);
        #endregion

        #region trainee function
        void addTrainee(Trainee trainee);
        void removeTrainee(string idTrainee);
        void updateTrainee(Trainee trainee);
        List<Trainee> getAllTrainees();
        Trainee GetTrainee(string id);
        void isPassedTest(Trainee trainee);
        int numTestsOfTrainee(Trainee tr);
        IEnumerable<IGrouping<string, Trainee>> TraineeGroupingByDrivingScool(bool sort);
        IEnumerable<IGrouping<string, Trainee>> TraineeGroupingByDrivingTeacher(bool sort);
        IEnumerable<IGrouping<int, Trainee>> TraineeGroupingByNumTest(bool sort);
        #endregion

        #region test function
        void addTest(Test test);
        void removeTest(int numTest);
        void updateTestResults(Test test);
        List<Test> getAllTests();
        Test GetTest(long numTest);
        List<Test> testByCondition(Predicate<Test> func);
        List<Test> testByDate(DateTime date);
        bool checkDoubleTestInDate(Test test);
        bool prevTestStatus(Trainee trainee);
        List<Test> testByMonth(DateTime date);
        int testScore(Test test);
        bool fieldsOfTester(Test test);
        #endregion
    }
}

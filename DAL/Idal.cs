using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

namespace DAL
{
    public interface Idal
    {
        #region tester function
        void addTester(Tester tester);
        void removeTester(string idTester);
        void updateTester(Tester tester);
        List<Tester> getAllTesters();
        Tester GetTester(string id);
        #endregion

        #region trainee function
        void addTrainee(Trainee trainee);
        void removeTrainee(string idTrainee);
        void updateTrainee(Trainee trainee);
        List<Trainee> getAllTrainees();
        Trainee GetTrainee(string id);
        #endregion

        #region test function
        void addTest(Test test);
        void removeTest(long numTest);
        void updateTestResults(Test test);
        List<Test> getAllTests();
        Test GetTest(long numTest);
        #endregion
    }
}

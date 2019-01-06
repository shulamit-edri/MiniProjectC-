using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

namespace DAL
{
    public class Dal_imp:Idal
    {
        DataSource d;
        public Dal_imp()
        {
            d = new DataSource();
        }

        #region tester Function
        public void addTester(Tester tester)
        {
            foreach (Tester ts in DS.DataSource.testerList)
            {
                if (ts.Id == tester.Id)
                {
                    throw new Exception("Tester with the same id already exists");
                }
            }
            DS.DataSource.testerList.Add(tester);
        }

        public void removeTester(string idTester)
        {
            Tester tester1 = GetTester(idTester);
            if (tester1==null)
            {
                throw new Exception("Tester with the same id not found");
            }
            DS.DataSource.testerList.Remove(tester1);
        }

        public void updateTester(Tester tester)
        {
            Tester tester1 = GetTester(tester.Id);
            if (tester1==null)
            {
                throw new Exception("Tester with the same id not found");
            }
            tester1 = tester;
            removeTester(tester.Id);
            addTester(tester1);
        }

        public List<Tester> getAllTesters()
        {
            List<Tester> help = new List<Tester>();
            help = DS.DataSource.testerList;
            if (help == null)
            {
                throw new Exception("There are no testers");
            }
            return help;
        }

        public Tester GetTester(string id)
        {
            Tester tester1 = DS.DataSource.testerList.FirstOrDefault(tester => tester.Id == id);
            return tester1;
        }

        #endregion

        #region Trainee Function
        public void addTrainee(Trainee trainee)
        {
            foreach (Trainee tn in DS.DataSource.traineeList)
            {
                if (tn.Id == trainee.Id)
                {
                    throw new Exception("Trainee with the same id already exists");
                }
            }
            DS.DataSource.traineeList.Add(trainee);
        }

        public void removeTrainee(string idTrainee)
        {
            Trainee trainee1 = GetTrainee(idTrainee);
            if (trainee1 == null)
            {
                throw new Exception("Trainee with the same id not found");
            }
            DS.DataSource.traineeList.Remove(trainee1);
        }

        public void updateTrainee(Trainee trainee)
        {
            Trainee trainee1 = GetTrainee(trainee.Id);
            if (trainee1 == null)
            {
                throw new Exception("Trainee with the same id not found");
            }
            trainee1 = trainee;
            removeTrainee(trainee.Id);
            addTrainee(trainee1);
        }

        public List<Trainee> getAllTrainees()
        {
            List<Trainee> help = new List<Trainee>();
            help = DS.DataSource.traineeList;
            if (help == null)
            {
                throw new Exception("There are no trainees");
            }
            return help;
        }

        public Trainee GetTrainee(string id)
        {
            Trainee trainee1 = DS.DataSource.traineeList.FirstOrDefault(trainee => trainee.Id == id);
            return trainee1;
        }
        #endregion

        #region Test Function
        public void addTest(Test test)
        {
            foreach (Test t in DS.DataSource.testList)
            {
                if (t.NumTest == test.NumTest)
                {
                    throw new Exception("Test with the same number already exists");
                }
            }
            if (Configuration.NumTest < 99999999)
            {
                Configuration.NumTest++;
                test.NumTest = Configuration.NumTest;
            }
            DS.DataSource.testList.Add(test);
        }

        public void removeTest(long numTest)
        {
            Test test1 = GetTest(numTest);
            if (test1 == null)
            {
                throw new Exception("Test with the same number not found");
            }
            DS.DataSource.testList.Remove(test1);
        }

        public void updateTestResults(Test test)
        {
            Test test1 = GetTest(test.NumTest);
            if (test1 == null)
            {
                throw new Exception("Test with the same number not found");
            }
            test1 = test;
            removeTest(test.NumTest);
            addTest(test1);
        }

        public List<Test> getAllTests()
        {
            List<Test> help = new List<Test>();
            help = DS.DataSource.testList;
            if (help == null)
            {
                throw new Exception("There are no tests");
            }
            return help;
        }

        public Test GetTest(long number)
        {
            Test test1 = DS.DataSource.testList.FirstOrDefault(test => test.NumTest == number);
            return test1;
        }
        #endregion
    }
}

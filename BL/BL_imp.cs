using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;
using DAL;
using System.Threading;
using System.Collections.ObjectModel;

namespace BL
{
    public  class BL_imp : IBL
    {
        public void InitializeList()
        {

        }

        DAL.Idal dal;
        public BL_imp()
        {
            dal = DAL.FactoryDal.getDal();
        }

        #region tester function
        //add new tester to the list of testers
        public void addTester(Tester tester)
        {
            if (Configuration.checkAge(tester.Birthday) > Configuration.maxTesterAge)
                throw new ArgumentOutOfRangeException("Tester is too old");
            if (Configuration.checkAge(tester.Birthday) < Configuration.minTesterAge)
                throw new ArgumentOutOfRangeException("Tester is too young");
            if (!(Configuration.checkId(tester.Id)))
            {
                throw new Exception("ID card is not valid");
            }
            foreach (Tester t in dal.getAllTesters())
            {
                if (t.Id == tester.Id)
                    throw new Exception("Tester with the same id is already exist");
            }
            if (!(Configuration.CheckPhoneNumber(tester.PhonNum)))
            {
                throw new Exception("Invalid phone number");
            }
            dal.addTester(tester);
        }

        //remove tester frome the list of testers
        public void removeTester(string idTester)
        {
            foreach(Tester t in dal.getAllTesters())
            {
                if (t.Id == idTester)
                {
                    dal.removeTester(idTester);
                    return;
                }
            }
            throw new Exception("Tester with this id is not found");
        }

        //update tester that exist in the list of testers
        public void updateTester(Tester tester)
        {
            foreach(Tester t in dal.getAllTesters())
            {
                if (t.Id == tester.Id)
                {
                    dal.updateTester(tester);
                    return;
                }
            }
            throw new Exception("Tester with this id not found");
        }

        //return the list of testers
        public List<Tester> getAllTesters()
        {
            return dal.getAllTesters();
        }

        //return certain tester from the list of testers
        public Tester GetTester(string id)
        {
            foreach(Tester t in dal.getAllTesters())
            {
                if (t.Id == id)
                    return dal.GetTester(id);
            }
            throw new Exception("Tester with this id is not found");
        }

        // return number of tests for tester in week
        public int countTestsForTester(Tester ts)
        {
            int count = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 6; j++)
                {
                    if (ts.TimeWork[i, j] == true)
                        count++;
                }
            return count;

        }

        // return list of testers that available at certain date
        public List<Tester> AvailableTester(DateTime date, int hour)
        {
            if ((hour < 9) || (hour > 15))
                throw new Exception("There is no tester available in this hour");

            if (date.DayOfWeek == DayOfWeek.Friday || date.DayOfWeek == DayOfWeek.Saturday)
                throw new Exception("There is no tester available in this day");

            List<Tester> testerFree = new List<Tester>();
            var v = from Tester item in dal.getAllTesters()
                    where IfTesterAvailable(date, hour, item) == true
                    select item;
            foreach (var item in v)
                testerFree.Add(item);
            return testerFree;
        }

        // check if tester available at certain time
        public bool IfTesterAvailable(DateTime date, int hour, Tester t)
        {
            int numDay = Convert.ToInt32(date.DayOfWeek);
            int numHour = hour - 9;
            if (t.TimeWork[numDay, numHour] == true)
                return true;
            return false;
        }

        //return list of testers who live neer the trainee's address
        public List<Tester> neerTesters(structTyps.Address add)
        {
            Random r = new Random();
            int s = r.Next();
            List<Tester> dt = new List<Tester>();
            var v = from Tester item in dal.getAllTesters()
                    let a = item.MaxDistance
                    where a < s
                    select item;
            foreach (var item in v)
                dt.Add(item);
            return dt;
        }

        //return another available tester
        public Tester anotherAvailableTester()
        {
            List<Tester> ts = new List<Tester>();
            Random ran1 = new Random();
            Random ran2 = new Random();
            Random ran3 = new Random();
            Random ran4 = new Random();
            int x, y, z, w;
            DateTime newDate = new DateTime();
            while (ts == null)
            {
                x = ran1.Next(1, 28);
                y = ran2.Next(1, 12);
                z = ran3.Next(2019, 2030);
                w = ran4.Next(9, 15);
                newDate = new DateTime(z, y, x, w, 0, 0);
                ts = AvailableTester(newDate, newDate.Hour);
            }
            /*Console.WriteLine("The date you want are not free. We offer you another free date:"+newDate)
             בהמשך נרצה שהתאריך הנ"ל יופיע בחלון ואם התלמיד מעוניין בתאריך הזה לחיצה על כפתור "הוסף" תשלח
             אותו לפונקציה אדטסט ותוסיף אותו. אם התלמיד לא מעוניין לחיצה על כפתור "סגירה" תוציא אותו לגמרי מהפונקציה*/
            //במידה והתלמיד לחץ על הוסף הקטע קוד הבא שולח לפונקציה אדטסט את הטסטר עם התאריך הפנוי
            Tester tester = new Tester();
            foreach (Tester t in ts)
            {
                tester = new Tester(t);
            }
            return tester;
        }

        //return sorted list of testers by their specialty type
        public IEnumerable<IGrouping<BE.myEnum.CarType, Tester>> TesterGroupingByTypeCar(bool sort)
        {
            if (sort)
            {
                var result =
                    from Tester in dal.getAllTesters()
                    group Tester by (Tester.TesterCar) into g
                    orderby g.Key
                    select g;
                return result;
            }
            else
            {
                var result =
                      from Tester in dal.getAllTesters()
                      group Tester by (Tester.TesterCar) into g
                      select g;
                return result;
            }
        }

        // return id of tester that specializes on type car that match to the trainee
        public string searchTesterToCar(Trainee trainee, List<Tester> t)
        {
            foreach (Tester ts in t)
                if (ts.TesterCar == trainee.TraineeCar)
                    return ts.Id;
            return null;
        }
        #endregion

        #region trainee function
        //add new trainee to list of trainees
        public void addTrainee(Trainee trainee)
        {
            if (Configuration.checkAge(trainee.Birthday) < Configuration.minTraineeAge)
                throw new ArgumentOutOfRangeException("Trainee is too young");
            if (!(Configuration.CheckPhoneNumber(trainee.PhonNum)))
                throw new Exception("Invalid phone number");
            if (!(Configuration.checkId(trainee.Id)))
                throw new Exception("ID card is not valid");
            foreach (Trainee tn in dal.getAllTrainees())
            {
                if (tn.Id == trainee.Id)
                    throw new Exception("Trainee with the same id is already exist");
            }
            dal.addTrainee(trainee);
        }

        //remove trainee from the list of trainees
        public void removeTrainee(string idTrainee)
        {
            foreach (Trainee tn in dal.getAllTrainees())
            {
                if (tn.Id == idTrainee)
                    dal.removeTrainee(idTrainee);
                break;
            }
            throw new Exception("Trainee with this id is not found");
        }

        //update trainee that exist in the list of trainees
        public void updateTrainee(Trainee trainee)
        {
            foreach (Trainee tn in dal.getAllTrainees())
            {
                if (tn.Id == trainee.Id)
                    dal.updateTrainee(trainee);
                break;
            }
            throw new Exception("Trainee with this id not found");
        }

        //return the list of trainees
        public List<Trainee> getAllTrainees()
        {
            return dal.getAllTrainees();
        }

        //return certain trainee from the list of trainees
        public Trainee GetTrainee(string id)
        {
            foreach (Trainee tn in dal.getAllTrainees())
            {
                if (tn.Id == id)
                    return dal.GetTrainee(id);
            }
            throw new Exception("Trainee with this id is not found");
        }

        //update if trainee passed the test
        public void isPassedTest(Trainee trainee)
        {
            Test test = new Test();
            foreach(Test ts in dal.getAllTests())
            {
                if (ts.TraineeId == trainee.Id)
                {
                    test = ts;
                }
            }
            int a = testScore(test);
            if (a >= 90)
            {
                test.IsPassed = true;
                dal.updateTestResults(test);
            }
            else
            {
                test.IsPassed = false;
                dal.updateTestResults(test);
            }
        }

        //return number of tests that the trainee is tested
        public int numTestsOfTrainee(Trainee tr)
        {
            int count = 0;
            var v = dal.getAllTests().Where(item => item.TraineeId == tr.Id);
            foreach (var item in v)
                count++;
            return count;
        }

        //return list of trainees divided into groups by school driving
        public IEnumerable<IGrouping<string, Trainee>> TraineeGroupingByDrivingScool(bool sort)
        {
            if (sort)
            {
                var result =
                    from Trainee in dal.getAllTrainees()
                    group Trainee by (Trainee.SchoolName) into g
                    orderby g.Key
                    select g;
                return result;
            }
            else
            {
                var result =
                      from Trainee in dal.getAllTrainees()
                      group Trainee by (Trainee.SchoolName) into g
                      select g;
                return result;
            }
        }

        //return list of trainees divided into groups by tester name
        public IEnumerable<IGrouping<string, Trainee>> TraineeGroupingByDrivingTeacher(bool sort)
        {
            if (sort)
            {
                var result =
                    from Trainee in dal.getAllTrainees()
                    group Trainee by (Trainee.TeacherName) into g
                    orderby g.Key
                    select g;
                return result;
            }
            else
            {
                var result =
                      from Trainee in dal.getAllTrainees()
                      group Trainee by (Trainee.TeacherName) into g
                      select g;
                return result;
            }
        }

        //return list of trainees divided into groups by number of tests
        public IEnumerable<IGrouping<int, Trainee>> TraineeGroupingByNumTest(bool sort)
        {
            if (sort)
            {
                var result =
                    from Trainee in dal.getAllTrainees()
                    group Trainee by (Trainee.CountTests) into g
                    orderby g.Key
                    select g;
                return result;
            }
            else
            {
                var result =
                      from Trainee in dal.getAllTrainees()
                      group Trainee by (Trainee.CountTests) into g
                      select g;
                return result;
            }

        }
        #endregion

        #region test function
        //add new test to list of tests
        public void addTest(Test test)
        {
            Trainee traineeOfTest = GetTrainee(test.TraineeId);
            Tester testerOfTest = new Tester();

            //check if this test is already exist
            bool isDouble = checkDoubleTestInDate(test);
            if (isDouble == true)
                throw new Exception("You can not add the test because it already exists");

            //check if passed 7 days from the last test and if the trainee do the minimum of lessons
            if (traineeOfTest.PrevTestDate != null)
            {
                TimeSpan timeFromLastTest = test.DateTest - traineeOfTest.PrevTestDate;
                if ((timeFromLastTest.Days < 7) || (traineeOfTest.NumLessons < Configuration.minLesson))
                    throw new ArgumentOutOfRangeException("The trainee can not be tested");
            }

            //check if the trainee tested in the past in tha same test and passed it
            foreach(Test t1 in getAllTests())
            {
                if (t1.TraineeId == test.TraineeId && t1.CarLearning == test.CarLearning)
                {
                    bool r = prevTestStatus(traineeOfTest);
                    if (r == true)
                        throw new ArgumentOutOfRangeException("The trainee can not be tested because he has been tested in same test in the past and succeeded");
                }
            }

            //find list of available tester
            List<Tester> t = AvailableTester(test.DateTest, test.TimeTest);
            if (t == null)
            {
                testerOfTest = anotherAvailableTester();
                t.Add(testerOfTest);
            }

            //find tester from the list of available testers that specialize in the car type of the trainee
            string tsId = searchTesterToCar(traineeOfTest, t);
            if (tsId == null)
                throw new ArgumentOutOfRangeException("There is no appropriate tester");

            //check if the tester passed the maximum tests in week
            testerOfTest = GetTester(tsId);
            int countTests = countTestsForTester(testerOfTest);
            if (countTests >= Configuration.maxTesterTests)
                throw new Exception("you can not add this tester Because he passed the number of weekly tests");

            test.TesterId = testerOfTest.Id;

            dal.addTest(test);
        }

        //remove test from the list of tests
        public void removeTest(int numTest)
        {
            foreach (Test t in dal.getAllTests())
            {
                if (t.NumTest == numTest)
                    dal.removeTest(numTest);
                break;
            }
            throw new Exception("Test with this number is not found");
        }

        //update test that exist in the list of tests
        public void updateTestResults(Test test)
        {
            Test t = GetTest(test.NumTest);
            if (t == null)
                throw new Exception("Test with this number is not found");
            if (!(fieldsOfTester(test)))
            {
                throw new Exception("You did not fill all fields");
            }
            dal.updateTestResults(test);
        }

        //return the list of tests
        public List<Test> getAllTests()
        {
            return dal.getAllTests();
        }

        //return certain test from the list of tests
        public Test GetTest(long numTest)
        {
            foreach (Test ts in getAllTests())
            {
                if (ts.NumTest == numTest)
                    return dal.GetTest(numTest);
            }
            throw new Exception("Test with this number is not found");
        }

        //return list of tests that match a specific condition
        public List<Test> testByCondition(Predicate<Test> func)
        {
            List<Test> test = new List<Test>();
            test = dal.getAllTests().FindAll(func);
            return test;
        }

        //return list of tests that take place on specific date
        public List<Test> testByDate(DateTime date)
        {
            List<Test> testByDay = new List<Test>();
            var v = from Test item in dal.getAllTests()
                    where item.DateTest.Month == date.Month && item.DateTest.Year == date.Year && item.DateTest.Day == date.Day
                    select item;
            foreach (Test item in v)
                testByDay.Add(item);
            return testByDay;
        }

        //check if the test is exist in the list of the tests
        public bool checkDoubleTestInDate(Test test)
        {
            foreach (Test ts in DataSource.testList)
            {
                if (ts.TraineeId == test.TraineeId && ts.DateTest == test.DateTest)
                {
                    return true;
                }
            }
            return false;
        }

        //check if trainee is tested in the past on specific type car and passed it
        public bool prevTestStatus(Trainee trainee)
        {
            foreach (Test ts in dal.getAllTests())
            {
                if ((ts.TraineeId == trainee.Id) && (ts.CarLearning == trainee.TraineeCar))
                    if (ts.IsPassed == true)
                        return true;
            }
            return false;

        }

        //return list of tests that take place on specific month
        public List<Test> testByMonth(DateTime date)
        {
            List<Test> testByMonth = new List<Test>();
            var v = from Test item in dal.getAllTests()
                    where item.DateTest.Month == date.Month && item.DateTest.Year == date.Year
                    select item;
            foreach (Test item in v)
                testByMonth.Add(item);
            return testByMonth;
        }

        //return the score of test
        public int testScore(Test test)
        {
            int c = 0;
            if (test.KeepDistance == true)
                c += 25;
            if (test.LookingMirror == true)
                c += 15;
            if (test.ParkingRevers == true)
                c += 10;
            if (test.UseVinker == true)
                c += 15;
            if (test.DrivingRightLane == true)
                c += 10;
            if (test.TestSpeed == true)
                c += 25;
            return c;
        }

        //check if the tester fill all the fields 
        public bool fieldsOfTester(Test test)
        {
            int count = 0;
            if (test.KeepDistance == true || test.KeepDistance == false)
                count++;
            if (test.ParkingRevers == true || test.ParkingRevers == false)
                count++;
            if (test.LookingMirror == true || test.LookingMirror == false)
                count++;
            if (test.UseVinker == true || test.UseVinker == false)
                count++;
            if (test.DrivingRightLane == true || test.DrivingRightLane == false)
                count++;
            if (test.TestSpeed == true || test.TestSpeed == false)
                count++;
            if (test.TesterNote != null)
                count++;
            if (count == 7)
                return true;
            return false;
        }
        #endregion
    }
}

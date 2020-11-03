using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
        Job testJob1;
        Employer acme;
        Location desert;
        PositionType qa;
        CoreCompetency persistence;

        [TestInitialize]
        public void CreateTestJobAndFields()
        {
            acme = new Employer("ACME");
            desert = new Location("Desert");
            qa = new PositionType("Quality Control");
            persistence = new CoreCompetency("Persistence");

            testJob1 = new Job("Product tester", acme, desert, qa, persistence);
        }
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsTrue(job2.Id - job1.Id == 1);
            
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
           
            Assert.IsTrue(testJob1.Name == "Product tester");
            Assert.IsTrue(testJob1.EmployerName.Value == "ACME");
            Assert.IsTrue(testJob1.EmployerLocation.Value == "Desert");
            Assert.IsTrue(testJob1.JobCoreCompetency.Value == "Persistence");
            Assert.IsTrue(testJob1.JobType.Value == "Quality Control");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJob1 = new Job("Value", new Employer("test"), new Location("test"), new PositionType("test"), new CoreCompetency("test"));
            Job testJob2 = new Job("Value", new Employer("test"), new Location("test"), new PositionType("test"), new CoreCompetency("test"));
            Assert.AreNotEqual(testJob1, testJob2);
        }
        //TestJobsForEquality is not checking that the two classes are not equal 
        // but rather than the custom equality method you generated in your class works.

        [TestMethod]
        public void TestJobsToString()
        {
            
            Assert.AreEqual(testJob1.ToString().Substring(0,1), "\n"); //interesting, reads as one character.
            Assert.AreEqual(testJob1.ToString().Substring(testJob1.ToString().Length-1, 1), "\n");
            Assert.IsTrue(testJob1.ToString().Contains($"ID: "+ testJob1.Id));
            Assert.IsTrue(testJob1.ToString().Contains($"Name: " + testJob1.Name));
            Assert.IsTrue(testJob1.ToString().Contains($"Employer: " + testJob1.EmployerName.Value));
            Assert.IsTrue(testJob1.ToString().Contains($"Location: " + testJob1.EmployerLocation.Value));
            Assert.IsTrue(testJob1.ToString().Contains($"Position Type: " + testJob1.JobType.Value));
            Assert.IsTrue(testJob1.ToString().Contains($"Core Competency: " + testJob1.JobCoreCompetency.Value));


            Job jobToStringTest2 = new Job("", new Employer(""), desert, qa, persistence);
            Assert.IsTrue(jobToStringTest2.ToString().Contains($"Name: Data not avaliable"));
            Assert.IsTrue(jobToStringTest2.ToString().Contains($"Employer: Data not available"));
            

            Job jobToStringTest3 = new Job();
            Assert.AreEqual(jobToStringTest3.ToString(), "OOPS! This job does not seem to exist.");

        


        }

    }
}

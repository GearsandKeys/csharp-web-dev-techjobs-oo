using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
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
            Employer acme = new Employer("ACME");
            Location desert = new Location("Desert");
            PositionType qa = new PositionType("Quality Control");
            CoreCompetency persistence = new CoreCompetency("Persistence");

            Job constructorTest = new Job("Product tester", acme, desert, qa, persistence);
            Assert.IsTrue(constructorTest.Name == "Product tester");
            Assert.IsTrue(constructorTest.EmployerName.Value == "ACME");
            Assert.IsTrue(constructorTest.EmployerLocation.Value == "Desert");
            Assert.IsTrue(constructorTest.JobCoreCompetency.Value == "Persistence");
            Assert.IsTrue(constructorTest.JobType.Value == "Quality Control");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJob1 = new Job("Value", new Employer("test"), new Location("test"), new PositionType("test"), new CoreCompetency("test"));
            Job testJob2 = new Job("Value", new Employer("test"), new Location("test"), new PositionType("test"), new CoreCompetency("test"));
            Assert.AreNotEqual(testJob1, testJob2);
        }


    }
}

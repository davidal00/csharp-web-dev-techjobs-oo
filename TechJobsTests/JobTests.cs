using System;
using TechJobsOO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        Job job1;
        Job job2;
        Job job3;
        Job job4;

        [TestInitialize]
        public void CreateJobs()
        {
            job1 = new Job();
            job2 = new Job();
            job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        }

        [TestMethod]
        public void TestSettingJobId()
        {
            //Assert.AreEqual(job1.Id, job2.Id, 1);
            Assert.IsTrue(job1.Id != job2.Id);
            Assert.IsTrue(job2.Id - job1.Id == 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual("ACME", job3.EmployerName.Value);
            Assert.AreEqual("Desert", job3.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job3.JobType.Value);
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.Value);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {

            //Assert.AreEqual(job3.Id, job4.Id, 1);
            Assert.IsFalse(job2.Equals(job3));
            Assert.IsFalse(job3.Equals(job4));
            Assert.IsTrue(job1.Equals(job1));

        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            string testString = job3.ToString();
            char firstChar = testString[0];
            char lastChar = testString[testString.Length - 1];

            Assert.IsTrue(firstChar == lastChar);
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            string testOutput = $"\nID: {job3.Id}\nName: {job3.Name}\nEmployer: {job3.EmployerName}\nLocation: {job3.EmployerLocation}\nPosition Type: {job3.JobType}\nCore Competency: {job3.JobCoreCompetency}\n";

            Assert.AreEqual(testOutput, job3.ToString());

        }

    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
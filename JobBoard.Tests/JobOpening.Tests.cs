using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using JobBoard.Models;
namespace JobBoard.Tests
{

    [TestClass]
    public class JobOpeningTests
    {
        [TestMethod]
        public void JobOpening_Constructs_Object()
        {
            JobOpening testopening = new JobOpening("My new dad", "Fathersoft", "Be my father");
            Assert.AreEqual(testopening.Name, "My new dad");
        }
        public void JobOpening_GetSet_Object()
        {
            JobOpening testopening = new JobOpening("My new dad", "Fathersoft", "Be my father");
            testopening.Name = "President of fatherton";
            Assert.AreEqual(testopening.Name, "President of fatherton");
        }
        [TestMethod]
        public void JobOpening_AddedToInstances_Object()
        {
            JobOpening testopening = new JobOpening("My new dad", "Fathersoft", "Be my father");
            Assert.AreSame(testopening.Name, JobOpening._Instances.Find(x => x.Name.Contains("My new dad")).Name);
        }
        [TestMethod]
        public void JobOpening_ReturnsListOfInstances_Object()
        {
            JobOpening testopening = new JobOpening("My new dad", "Fathersoft", "Be my father");
            JobOpening testopening1 = new JobOpening("My new dad", "Fathersoft", "Be my father");
            JobOpening testopening2 = new JobOpening("My new dad", "Fathersoft", "Be my father");
            JobOpening testopening3 = new JobOpening("My new dad", "Fathersoft", "Be my father");
            Assert.AreEqual(JobOpening.GetAll().Count, JobOpening._Instances.Count);
        }
        [TestMethod]
        public void JobOpening_SetsID_Int()
        {
            JobOpening testopening = new JobOpening("My new dad", "Fathersoft", "Be my father");
            JobOpening testopening1 = new JobOpening("My new grandpa", "Fathersoft", "Be my father");
            JobOpening testopening2 = new JobOpening("My new dad", "Fathersoft", "Be my father");
            JobOpening testopening3 = new JobOpening("My new dad", "Fathersoft", "Be my father");
            Assert.AreEqual(testopening2.Name, JobOpening.GetOpeningByID(2).Name);
        }
    }
}
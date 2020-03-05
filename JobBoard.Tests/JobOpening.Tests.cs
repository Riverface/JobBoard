using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using JobBoard.Models;
namespace JobBoard.Tests
{

    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void Job_Constructs_Object()
        {
            Job testopening = new Job("My new dad", "Fathersoft", "Be my father");
            Assert.AreEqual(testopening.Name, "My new dad");
        }
        public void Job_GetSet_Object()
        {
            Job testopening = new Job("My new dad", "Fathersoft", "Be my father");
            testopening.Name = "President of fatherton";
            Assert.AreEqual(testopening.Name, "President of fatherton");
        }
        [TestMethod]
        public void Job_AddedToInstances_Object()
        {
            Job testopening = new Job("My new dad", "Fathersoft", "Be my father");
            Assert.AreSame(testopening.Name, Job._Instances.Find(x => x.Name.Contains("My new dad")).Name);
        }
        [TestMethod]
        public void Job_ReturnsListOfInstances_Object()
        {
            Job testopening = new Job("My new dad", "Fathersoft", "Be my father");
            Job testopening1 = new Job("My new dad", "Fathersoft", "Be my father");
            Job testopening2 = new Job("My new dad", "Fathersoft", "Be my father");
            Job testopening3 = new Job("My new dad", "Fathersoft", "Be my father");
            Assert.AreEqual(Job.GetAll().Count, Job._Instances.Count);
        }
        [TestMethod]
        public void Job_SetsID_Int()
        {
            Job testopening = new Job("My new dad", "Fathersoft", "Be my father");
            Job testopening1 = new Job("My new grandpa", "Fathersoft", "Be my father");
            Job testopening2 = new Job("My new dad", "Fathersoft", "Be my father");
            Job testopening3 = new Job("My new dad", "Fathersoft", "Be my father");
            Assert.AreEqual(testopening2.Name, Job.GetOpeningByID(2).Name);
        }
    }
}
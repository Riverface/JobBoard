using System.Collections.Generic;
namespace JobBoard.Models
{
    public class JobOpening
    {
        static public List<JobOpening> _Instances { get; set; } = new List<JobOpening>();
        public string Name { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        public int ID { get; }
        public JobOpening(string name, string company, string position)
        {
            Name = name;
            Company = company;
            Position = position;
            _Instances.Add(this);
            ID = _Instances.Count;
        }
        public static List<JobOpening> GetAll()
        {
            return _Instances;
        }
        public static JobOpening GetOpeningByID(int id)
        {
            return _Instances[id-1];
        }
        private static void ResetIDs()
        {
            _Instances = new List<JobOpening>();
        }
    }
}